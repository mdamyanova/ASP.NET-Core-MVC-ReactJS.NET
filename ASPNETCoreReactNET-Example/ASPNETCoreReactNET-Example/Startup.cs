namespace ASPNETCoreReactNET_Example
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.DependencyInjection;
    using React.AspNet;
    using System;

    public class Startup
    {
        // Changed the method from void to return IServiceProvider
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddReact();

            services.AddMvc();

            return services.BuildServiceProvider();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Initialise ReactJS.NET. Must be before static files.
            app.UseReact(config =>
            {
                // If you want to use server-side rendering of React components,
                // add all the necessary JavaScript files here. This includes
                // your components as well as all of their dependencies.
                // See http://reactjs.net/ for more information. Example:
                //config
                //      .AddScript("~/Source/Components/ExampleComponent.jsx");
                  //   .AddScript("~/Source/main.js");

                // If you use an external build too (for example, Babel, Webpack,
                // Browserify or Gulp), you can improve performance by disabling
                // ReactJS.NET's version of Babel and loading the pre-transpiled
                // scripts. Example:
                config
                  .SetLoadBabel(true)
                  .AddScriptWithoutTransform("~/dist/bundle.js")
                  .AddScript("~/Source/Components/ExampleComponent.jsx");
            });

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                          name: "default",
                          template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}