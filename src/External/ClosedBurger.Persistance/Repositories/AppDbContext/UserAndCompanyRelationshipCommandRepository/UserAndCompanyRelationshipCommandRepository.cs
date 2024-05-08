﻿using ClosedBurger.Domain.AppEntities;
using ClosedBurger.Domain.Repositories.AppDbContext.UserAndCompanyRelationshipRepositories;
using ClosedBurger.Persistance.Repositories.GenericRepositories.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClosedBurger.Persistance.Repositories.AppDbContext.UserAndCompanyRelationshipCommandRepository
{
    public class UserAndCompanyRelationshipCommandRepository : AppCommandRepository<UserAndCompanyRelationship>, IUserAndCompanyRelationshipCommandRepository
    {
        public UserAndCompanyRelationshipCommandRepository(Persistance.Context.AppDbContext context) : base(context) { }
    }
}
