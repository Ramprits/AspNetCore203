using System;
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
using AspNet_core_203.Infrastructure;
using AspNet_core_203.Models;
using AspNet_core_203.Repository;
using Newtonsoft.Json;

namespace AspNet_core_203 {
    public class Startup {
        public Startup (IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices (IServiceCollection services) {
            services.AddDbContext<AspNet_core_203DbContext> (options => {
                options.UseSqlServer (Configuration.GetConnectionString ("ApplicationConnection"));
            }).AddIdentity<ApplicationUser, IdentityRole> ();

            services.AddMvc ()
                .AddJsonOptions (opt => {
                    opt.SerializerSettings.ReferenceLoopHandling =
                        ReferenceLoopHandling.Ignore;
                });
            services.AddScoped<ICampRepository, CampRepository> ();
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