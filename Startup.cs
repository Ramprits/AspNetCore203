using System;
<<<<<<< HEAD
using AspNetcore203.Infrastructure;
using AspNetcore203.Models;
using AspNetcore203.Repository;
=======
using AspNetCore203.Infrastructure;
using AspNetCore203.Models;
using AspNetCore203.Repository;
>>>>>>> 3defbe213d772ba5b9a0af0cc4ffa129c9b010ce
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

<<<<<<< HEAD
namespace AspNetcore203 {
=======
namespace AspNetCore203 {
>>>>>>> 3defbe213d772ba5b9a0af0cc4ffa129c9b010ce
    public class Startup {
        public Startup (IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices (IServiceCollection services) {
<<<<<<< HEAD
            services.AddDbContext<AspNetcore203DbContext> (options => {
=======
            services.AddDbContext<AspNetCore203DbContext> (options => {
>>>>>>> 3defbe213d772ba5b9a0af0cc4ffa129c9b010ce
                options.UseSqlServer (Configuration.GetConnectionString ("ApplicationConnection"));
            }).AddIdentity<ApplicationUser, IdentityRole> ();

            services.AddMvc ()
                .AddJsonOptions (opt => {
                    opt.SerializerSettings.ReferenceLoopHandling =
                        ReferenceLoopHandling.Ignore;
                });
            services.AddScoped<ICampRepository, CampRepository> ();
            services.AddScoped<ICampaignaignRepository, CampaignaignRepository> ();
            services.AddScoped<IEmployeeRepository, EmployeeRepository> ();
            services.AddScoped<IDepartmentRepository, DepartmentRepository> ();
            services.AddAutoMapper ();
        }

        public void Configure (IApplicationBuilder app, IHostingEnvironment env,
            ILoggerFactory loggerFactory) {
            loggerFactory.AddConsole ();

            loggerFactory.AddDebug (LogLevel.Information);
            if (env.IsDevelopment ()) {
                app.UseDeveloperExceptionPage ();
            }
            if (env.IsDevelopment ()) {
                app.UseDeveloperExceptionPage ();
            } else {
                app.UseExceptionHandler (appBuilder => {
                    appBuilder.Run (async context => {
                        var exceptionHandlerFeature = context.Features.Get<IExceptionHandlerFeature> ();
                        if (exceptionHandlerFeature != null) {
                            var logger = loggerFactory.CreateLogger ("Global exception logger");
                            logger.LogError (500,
                                exceptionHandlerFeature.Error,
                                exceptionHandlerFeature.Error.Message);
                        }
                        context.Response.StatusCode = 500;
                        await context.Response.WriteAsync ("An unexpected fault happened. Try again later.");

                    });
                });
            }
            app.UseCors ((corsPolicyBuilder) => {
                corsPolicyBuilder.AllowAnyOrigin ();
                corsPolicyBuilder.AllowAnyMethod ();
                corsPolicyBuilder.AllowAnyHeader ();
            });
            app.UseMvc ();
        }
    }
}