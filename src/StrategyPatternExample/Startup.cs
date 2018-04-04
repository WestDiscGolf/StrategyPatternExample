using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace StrategyPatternExample
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddScoped<IMathStrategy, MathStrategy>();
            services.AddScoped<IMathOperator, AddOperator>();
            services.AddScoped<IMathOperator, SubtractOperator>();
            services.AddScoped<IMathOperator, MultipleOperator>();
            services.AddScoped<IMathOperator, DivideOperator>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvcWithDefaultRoute();
        }
    }
}
