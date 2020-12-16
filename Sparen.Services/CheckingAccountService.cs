using Sparen.Data;
using Sparen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparen.Services
{
    public class CheckingAccountService
    {
        //private readonly Guid _userId;
        //public CheckingAccountService(Guid userId)
        //{
        //    _userId = userId;
        //}
        public bool CreateCheckingAccount(CheckingAccountCreate model)
        {
            var entity =
                new CheckingAccount()
                {
                    AccountNumber = GenerateAccountNumber(),
                    AccountType = "Checking",
                    Balance = model.Balance,
                    NameGiven = model.NameGiven

                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.CheckingAccounts.Add(entity);
                return ctx.SaveChanges() == 1; 
            }

        }
        public IEnumerable<CheckingAccountListItem> GetCheckingAccounts()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .CheckingAccounts
                    .Select(
                        e =>
                        new CheckingAccountListItem
                        {
                            AccountNumber = e.AccountNumber,
                            AccountType = e.AccountType,
                            Balance = e.Balance,
                            NameGiven = e.NameGiven
                        });
                return query.ToArray();
            }
        }
        public int GenerateAccountNumber()
        {
            Random randy = new Random();
            int accountNumber = randy.Next(100000000, 999999999);
            return accountNumber; 
        }
    }
}
