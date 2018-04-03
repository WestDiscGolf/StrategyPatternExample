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
            services.AddScoped<AddOperator>();
            services.AddScoped<SubtractOperator>();
            services.AddScoped<MultipleOperator>();
            services.AddScoped<DivideOperator>();
            services.AddScoped<IMathStrategyFactory, MathStrategyFactory>();
            services.AddScoped<IMathOperator[]>(provider =>
            {
                var factory = (IMathStrategyFactory)provider.GetService(typeof(IMathStrategyFactory));
                return factory.Create();
            });
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
