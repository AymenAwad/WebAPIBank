using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIBank.Data;
using WebAPIBank.Entity;
using WebAPIBank.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPIBank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KicController : ControllerBase
    {



        private readonly IKic _todo;
        private readonly ApplicationDbContext _applicationDbcontext;

        public KicController(IKic todo, ApplicationDbContext applicationDbContext)
        {
            _todo = todo;
            _applicationDbcontext = applicationDbContext;
        }
        [HttpGet("GetAccountInfoDetails")]
        public async Task<IActionResult> Accounts()
        {
            var AccountOfAccount = await _todo.GetAccountInfo();
            return Ok(AccountOfAccount);
        }

        // POST api/<KicController>
        [HttpPost]
        public async Task<IActionResult> CreateAccountInfo(Kic kic)
        {
            var x = new Kic
            {
                RegistrationNo = kic.RegistrationNo,
                PackageNo = kic.PackageNo,
                MonthNo = kic.MonthNo,
                CustName = kic.CustName,
                SubcAmount = kic.SubcAmount,
                SubcBalance = kic.SubcBalance,
                EndDate = kic.EndDate,
                SubcStatus = kic.SubcStatus,
                Installments = kic.Installments,
                OpResult = kic.OpResult,
                Decoder = kic.Decoder

            };
            _applicationDbcontext.Add(x);
            _applicationDbcontext.SaveChanges();

            return Ok(x);

        }



        //[HttpGet]
        //public async Task<IActionResult> GetAccountInfo([FromQuery] string CustName)
        //{
        //    var CarQuery = _applicationDbcontext.kics.AsQueryable();
        //    CarQuery = CarQuery.Where(x => x.CustName == "CustName");

        //    if (!String.IsNullOrWhiteSpace(CustName))
        //    {
        //        CarQuery = CarQuery.Where(x => x.CustName.Equals(CustName));

        //    }

        //    return Ok(CarQuery);

        //}

        // GET api/<KicController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

      
        // PUT api/<KicController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<KicController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
