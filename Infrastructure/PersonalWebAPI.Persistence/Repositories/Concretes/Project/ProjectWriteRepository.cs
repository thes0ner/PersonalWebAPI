using PersonalWebAPI.Application.Repositories;
using PersonalWebAPI.Domain.Entities;
using PersonalWebAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalWebAPI.Persistence.Repositories
{
    public class ProjectWriteRepository : WriteRepository<Project>, IProjectWriteRepository
    {
        public ProjectWriteRepository(PersonalWebAPIDbContext context) : base(context)
        {
        }
    }
}
