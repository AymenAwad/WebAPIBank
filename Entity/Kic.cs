using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIBank.Entity
{
    public class Kic
    {
        public int id { get; set; }
        public string RegistrationNo { get; set; }
        public decimal MonthNo { get; set; }
        public string PackageNo { get; set; }
        public string CustName { get; set; }
        public decimal SubcBalance { get; set; }
        public decimal SubcAmount { get; set; }
        public DateTime EndDate { get; set; }
        public string SubcStatus { get; set; }
        public decimal Installments { get; set; }
        public string OpResult { get; set; }
        public string Decoder { get; set; }
    }
}
