using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIBank.Data;
using WebAPIBank.Entity;
using WebAPIBank.Interfaces;

namespace WebAPIBank.Repository
{
    public class KicRepository :Kic , IKic
    {
        private readonly ApplicationDbContext _applicationDbContext;

        //private readonly ApplicationDbContext _applicationDbContext;


        public KicRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<IEnumerable<Kic>> GetAccountInfo()
        {
            return await _applicationDbContext.Set<Kic>().ToListAsync();
        }

        //public async Task<Kic> CreateAccountInfo(Kic kic)
        //{
        //  var Add = await _applicationDbContext.Set<Kic>().AddAsync(kic);
        //}

        public void CreateAccountInfo(Kic kic)
        {
            _applicationDbContext.Set<Kic>().AddAsync(kic);

        }

        public async Task<bool> SaveChanges()
        {
            return await _applicationDbContext.SaveChangesAsync() > 0;
        }

  
    }
}
