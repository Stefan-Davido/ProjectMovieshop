namespace Movieshop.Controllers
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using Movieshop.Areas.Identity;
    using Movieshop.Entities.Logger;
    using Movieshop.Services.ServiceInterfaces;
    using System.Linq;
    using System.Threading.Tasks;


    public class UserController : Controller
    {
        private UserManager<IdentityUser> _userManager;
        private RoleManager<IdentityRole> _roleManager;
        private IPasswordHasher<IdentityUser> _passwordHasher;
        private readonly ILogger<UserController> _logger;
        private readonly IUserService _userService;

        public UserController(
            UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager,
            IPasswordHasher<IdentityUser> passwordHasher,
            ILogger<UserController> logger,
            IUserService userService)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _passwordHasher = passwordHasher;
            _logger = logger;
            _userService = userService;
        }

        // GET: UserController
        public ActionResult Index()
        {
            var users = _userManager.Users;
            _logger.LogInformation(LoggerMessagesDisplay.UsersListed);

            return View(users);
        }

        // GET: UserController/Details/5
        public async Task<ActionResult> Details(string id)
        {
            IdentityUser user = await _userManager.FindByIdAsync(id);
            var roles = _roleManager.Roles;
            var userRoles = await _userManager.GetRolesAsync(user);

            var userModel = new UserModel
            {
                Id = user.Id,
                Email = user.Email,
                Name = user.UserName
            };

            var selectedRole = roles.SingleOrDefault(x => x.Name == userRoles[0]).Name;
            userModel.RoleName = selectedRole;
            return View(userModel);
        }

        // GET: UserController/Create
        public ActionResult Create()
        {
            var roles = _roleManager.Roles;
            var userModel = new UserModel();
            userModel.Roles = _userService.GetSelectListRoles(roles, null);

            return View(userModel);
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(UserModel user)
        {
            if (ModelState.IsValid)
            {
                IdentityUser appUser = new IdentityUser
                {
                    UserName = user.Name,
                    Email = user.Email,
                    EmailConfirmed = true
                };

                IdentityResult result = await _userManager.CreateAsync(appUser, user.password);
                _logger.LogInformation(LoggerMessagesDisplay.UserCreated);

                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(appUser, user.RoleName);

                    return RedirectToAction("Index");
                }
                else
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }

                    _logger.LogError(LoggerMessagesDisplay.UserNotCreatedModelStateInvalid);
                }
            }
            return View(user);
        }

        // GET: UserController/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            IdentityUser user = await _userManager.FindByIdAsync(id);
            var roles = _roleManager.Roles; // get all roles from db

            if (user != null)
            {
                // var getUserRoles = await _userManager.GetRolesAsync(user); // get every role for specific user
                var userRoles = await _userManager.GetRolesAsync(user);

                var userModel = new UserModel()
                {
                    Id = user.Id,
                    Email = user.Email,
                    Roles = _userService.GetSelectListRoles(roles, userRoles[0])
                };

                var selectedRoleId = roles.Where(x => x.Name == userRoles[0]).SingleOrDefault().Id;
                userModel.RoleId = selectedRoleId;

                return View(userModel);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(string id, string email, string password, string RoleName)
        {
            IdentityUser user = await _userManager.FindByIdAsync(id);

            if (user != null)
            {
                var userRoles = await _userManager.GetRolesAsync(user);
                var getUserOldRole = _roleManager.FindByNameAsync(userRoles[0]);

                if (!string.IsNullOrEmpty(email))
                {
                    user.Email = email;
                }
                else
                {
                    ModelState.AddModelError("", "Email cannot be empty");
                }

                if (!string.IsNullOrEmpty(password))
                {
                    user.PasswordHash = _passwordHasher.HashPassword(user, password);
                }
                else
                {
                    ModelState.AddModelError("", "Password cannot be empty");
                }

                if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password))
                {
                    IdentityResult result = await _userManager.UpdateAsync(user);
                    if (result.Succeeded)
                    {
                        await _userManager.RemoveFromRoleAsync(user, getUserOldRole.Result.Name); // remove old role
                        await _userManager.AddToRoleAsync(user, RoleName); // add new role
                        _logger.LogInformation(LoggerMessagesDisplay.UserEdited);

                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        Errors(result);
                        _logger.LogError(LoggerMessagesDisplay.UserEditErrorModelStateInvalid);
                    }
                }
            }
            else
            {
                ModelState.AddModelError("", "User Not Found");
                _logger.LogWarning(LoggerMessagesDisplay.NoUserFound);
            }

            return RedirectToAction(nameof(Index));
        }

        // GET: UserController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(string id)
        {
            IdentityUser user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                IdentityResult result = await _userManager.DeleteAsync(user);
                if (result.Succeeded)
                {
                    _logger.LogInformation(LoggerMessagesDisplay.UserDeleted);
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    Errors(result);
                    _logger.LogInformation(LoggerMessagesDisplay.UserDeletedError);
                }
            }
            else
            {
                ModelState.AddModelError("", "User Not Found");
                _logger.LogWarning(LoggerMessagesDisplay.NoUserFound);
            }

            return View(nameof(Index), _userManager.Users);
        }

        #region Helper Functions
        private void Errors(IdentityResult result)
        {
            foreach (IdentityError error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
        }
        #endregion


    }
}
