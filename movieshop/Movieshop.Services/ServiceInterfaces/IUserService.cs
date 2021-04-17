namespace Movieshop.Services.ServiceInterfaces
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;


    public interface IUserService
    {
        public IQueryable<SelectListItem> GetSelectListRoles(IQueryable<IdentityRole> roles,  string? currentRoleName);
    }
}
