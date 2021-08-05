using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.OData;
using Microsoft.AspNetCore.OData.Batch;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;
using Microsoft.EntityFrameworkCore;
using System;
using Models;

namespace NMBERAlert_System
{
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
			//services.AddRouting();

			services.AddControllersWithViews(mvcOptions => mvcOptions.EnableEndpointRouting = false);

			services.AddControllers().AddOData(
								opt => opt.AddRouteComponents("odata", GetEdmModel(), new DefaultODataBatchHandler())
										.Select()
										.Filter()
										.OrderBy()
										.Count()
										.Expand()
										.SetMaxTop(null));

			services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

			services.AddDbContext<NMBER_SystemMainDbContext>(opt =>
						opt.UseSqlServer(Configuration.GetConnectionString("NMBER_SystemMainDbContext"))); 
			//services.AddRazorPages();



			// In production, the Angular files will be served from this directory
			services.AddSpaStaticFiles(configuration =>
			{
				configuration.RootPath = "ClientApp/dist";
			});
		}


		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();
			if (!env.IsDevelopment())
			{
				app.UseSpaStaticFiles();
			}

			app.UseRouting();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute(
									name: "default",
									pattern: "{controller}/{action=Index}/{id?}");
			});

			app.UseSpa(spa =>
			{
				// To learn more about options for serving an Angular SPA from ASP.NET Core,
				// see https://go.microsoft.com/fwlink/?linkid=864501


				spa.Options.SourcePath = "ClientApp";
				if (env.IsDevelopment())
				{
					spa.UseProxyToSpaDevelopmentServer("http://localhost:4200");
				}
			});
		}
		private static IEdmModel GetEdmModel()
		{
			ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
			builder.Namespace = "Action";
			builder.EntitySet<AuthUserInformation>("AuthUserInformation");
			builder.EntitySet<UserInformation>("UserInformation");
			builder.EntitySet<NMBERAlert>("NMBERAlert");
			builder.EntitySet<UserLoginInformation>("UserLoginInformation");

			return builder.GetEdmModel();
		}
	}
}
