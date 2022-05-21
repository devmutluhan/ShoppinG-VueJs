using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using BusinessLayer.Manager;
using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;

namespace Shopping.Api
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

            services.AddControllers();
            services.AddSingleton<Settings>(new Settings { ConnectionString = @"Data Source=DESKTOP-JUEFI31;Initial Catalog=Shopping;Integrated Security=True" });
            services.AddSingleton<IBasketRepository, BasketRepository>();
            services.AddSingleton<BasketManager>();
            services.AddSingleton<ICategoryRepository, CategoryRepository>();
            services.AddSingleton<CategoryManager>();
            services.AddSingleton<IProductRepository, ProductRepository>();
            services.AddSingleton<ProductManager>();
            services.AddSingleton<ICustomerRepository, CustomerRepository>();
            services.AddSingleton<CustomerManager>();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Shopping.Api", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Shopping.Api v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
