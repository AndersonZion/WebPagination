using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPagination.Data.Context;
using WebPagination.Models;

namespace WebPagination.Data.Repositories
{
    public class PhoneRepository :  IPhoneRepository
    {
        //public PhoneRepository(ApplicationDbContext appContext) : base(appContext)
        //{

        //}

        private readonly IRepositoryBase<Phone> _repositoryBase;

        public PhoneRepository(IRepositoryBase<Phone> repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }

        public async Task AddAsync(Phone entity)
        {
            await _repositoryBase.AddAsync(entity);
        }
    }
}
