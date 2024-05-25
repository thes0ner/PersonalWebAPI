﻿using PersonalWebAPI.Application.Repositories;
using PersonalWebAPI.Domain.Entities;
using PersonalWebAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalWebAPI.Persistence.Repositories.Concretes
{
    public class ContactWriteRepository : WriteRepository<Contact>, IContactWriteRepository
    {
        public ContactWriteRepository(PersonalWebAPIDbContext context) : base(context)
        {
        }
    }
}
