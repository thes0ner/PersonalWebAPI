using PersonalWebAPI.Application.Repositories;
using PersonalWebAPI.Domain.Entities;
using PersonalWebAPI.Domain.Entities.Common;
using PersonalWebAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalWebAPI.Persistence.Repositories.Concretes
{
    public class ContactReadRepository : ReadRepository<Contact>, IContactReadRepository
    {
        public ContactReadRepository(PersonalWebAPIDbContext context) : base(context)
        {
        }
    }
}
