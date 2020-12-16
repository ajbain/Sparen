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
        
        //column key setting , manually setting key MVC


        //come back and get-set methods, put the random number generator in AcctCreate controller
        [Key]
        public int AccountNumber { get; set; }
        //{
        //    get
        //    {
        //        Random randy = new Random();
        //        int acctNum =randy.Next(100000000, 999999999);
        //        return acctNum;
        //    }
        //}
        public double Balance { get; set; }
    }
}
