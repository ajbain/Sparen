using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparen.Models
{
    public class CheckingAccountCreate
    {
        [Required]
        //public int AccountNumber { get; set; }
       // public string AccountType { get; set; }
        public string NameGiven { get; set; }
        public double Balance { get; set; }
    }
}
