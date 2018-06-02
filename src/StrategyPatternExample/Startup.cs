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
            services.AddScoped<IMathOperator<Operator>, AddOperator>();
            services.AddScoped<IMathOperator<Operator>, SubtractOperator>();
            services.AddScoped<IMathOperator<Operator>, MultipleOperator>();
            services.AddScoped<IMathOperator<Operator>, DivideOperator>();
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
