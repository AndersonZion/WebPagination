using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPagination.Data.Context;
using WebPagination.Models;

namespace WebPagination.Data.Repositories
{
    public class PersonRepository : RepositoryBase<Person>, IPersonRepository
    {
        public PersonRepository(ApplicationDbContext appContext) : base(appContext)
        {

        }

        
    }
}
