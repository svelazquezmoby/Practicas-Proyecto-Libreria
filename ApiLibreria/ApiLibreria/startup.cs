using Microsoft.EntityFrameworkCore;
using Repositories;
using Repositories.Interfaces;
using Services;
using Utils.Filters;
using Services.Interfaces;
using System.Text.Json.Serialization;
using DataBase;

namespace LogisticAndInventory
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IBookService, BookService>();
            services.AddTransient<IBookRepository, BookRepository>();

            services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

            services.AddMvc(options =>
            {
                options.Filters.Add(item: new HttpExceptionFilter());
            });

            services.AddDbContext<ApilibreriaContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("DDBB"));
            });

            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
        }

        public void configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
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
