using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using myProject.Mock;
using myProject.Repositories.Interfaces;
using myProject.Repositories.Rpositories;
using myProject.Services;
using myProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using myProject.Services.services;

namespace myProject.API
{
    public class Startup
    {
        private readonly string _myOrigin = "myOrigin";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(name: _myOrigin,
                                  policy =>
                                  {
                                      policy.AllowAnyOrigin().AllowAnyMethod();
                                  });
            });
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "myProject.API", Version = "v1" });
            });
            services.AddAutoMapper(typeof(Mapping));
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddSingleton<IContext, MockContext>();
            services.AddScoped<IClaimRepository, ClaimRepository>();
            services.AddScoped<IPermissionReporitory, PermissionRepository>();
            services.AddScoped<IClaimService, ClaimService>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IPermissionService, PermissionService>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "myProject.API v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseCors(_myOrigin);

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
