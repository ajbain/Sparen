using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparen.Data
{
    public class Account
    {
        [Key]
        public int AccountNumber { get; set; }
        public double Balance { get; set; }
    }
}
