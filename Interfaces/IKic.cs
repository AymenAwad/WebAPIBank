using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIBank.Entity;

namespace WebAPIBank.Interfaces
{
   public interface IKic
    {

        Task<IEnumerable<Kic>> GetAccountInfo();

        //  Task<Kic> CreateAccount(Kic kic);

        void CreateAccountInfo(Kic kic);

        Task<bool> SaveChanges();


    }
}
