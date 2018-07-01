using BankOfSimba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba.ViewModels
{
    public class BankViewModel
    {
        public List<BankAccount> accounts { get; set; }

        public BankViewModel()
        {
            accounts = new List<BankAccount>();
            accounts.Add(new BankAccount("Nala", 3000, "Lion"));
            accounts.Add(new BankAccount("Timon", 500, "Meerkat"));
            accounts.Add(new BankAccount("Mufasa", 2000, "Lion"));
            accounts.Add(new BankAccount("Zazu", 3000, "Bird"));
        }
    }
}
