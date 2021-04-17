namespace Movieshop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.UI;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.HttpsPolicy;
    using Microsoft.EntityFrameworkCore;
    using Movieshop.Data;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Movieshop.Repository.RepositoryInterfaces;
    using Movieshop.Repository;
    using Movieshop.Services;
    using Movieshop.Services.ServiceInterfaces;


    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DataContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("MovieshopConnection")));
            services.AddDefaultIdentity<IdentityUser>(options =>
            options.SignIn.RequireConfirmedAccount = true)
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<DataContext>();
            services.AddControllersWithViews();
            services.AddRazorPages();


            // *** Repositories ***
           services.AddTransient<IMovieRepository, MovieRepository>();
           services.AddTransient<ICategoryRepository, CategoryRepository>();
           services.AddTransient<IGenreRepository, GenreRepository>();
           services.AddTransient<IActorRepository, ActorRepository>();
           services.AddTransient<IProducerRepository, ProducerRepository>();
           services.AddTransient<IProductionRepository, ProductionRepository>();
           services.AddTransient<IOrderRepository, OrderRepository>();
           services.AddTransient<IShoppingCardRepository, ShoppingCardRepository>();
           services.AddTransient<IWatchLatterRepository, WatchLatterRepository>();

            // *** Services ***
            services.AddTransient<IMovieService, MovieService>();
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<IGenreService, GenreService>();
            services.AddTransient<IActorService, ActorService>();
            services.AddTransient<IProducerService, ProducerService>();
            services.AddTransient<IProductionService, ProductionService>();
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<IShoppingCardService, ShoppingCardService>();
            services.AddTransient<IWatchLatterService, WatchLatterService>();
            services.AddTransient<IUserService, UserService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
