using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparen.Data
{
    
    public class CheckingAccount : Account
    { 
        

        //set in controller
        public string AccountType {get; set;}
        public string NameGiven { get; set; }
        //get
            //{
            //    string name = "Checking";
            //    return name;
            //}
}
}
