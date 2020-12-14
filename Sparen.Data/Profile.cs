using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparen.Data
{
    public class Profile

    {
        [Key]
        public int ProfileId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]

        [Phone]
        public string MobilePhone { get; set; }

        //list of Checking Accounts
        //List of Savings Accounts

    }
}
