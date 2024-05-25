using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PersonalWebAPI.Application.Repositories;
using PersonalWebAPI.Persistence.Contexts;
using PersonalWebAPI.Persistence.Repositories;
using PersonalWebAPI.Persistence.Repositories.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalWebAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<PersonalWebAPIDbContext>(options => options.UseSqlServer(Configuration.ConnectionString));

            services.AddScoped<IProjectReadRepository, ProjectReadRepository>();
            services.AddScoped<IProjectWriteRepository, ProjectWriteRepository>();

            services.AddScoped<IContactReadRepository, ContactReadRepository>();
            services.AddScoped<IContactWriteRepository, ContactWriteRepository>();

            services.AddScoped<IProjectImageReadRepository, ProjectImageReadRepository>();
            services.AddScoped<IProjectImageWriteRepository, ProjectImageWriteRepository>();
        }
    }
}
