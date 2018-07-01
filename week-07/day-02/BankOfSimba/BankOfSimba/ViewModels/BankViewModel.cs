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
            accounts.Add(new BankAccount("Simba", 5000, "Lion", true));
            accounts.Add(new BankAccount("Nala", 3000, "Lion", false));
            accounts.Add(new BankAccount("Timon", 500, "Meerkat", false));
            accounts.Add(new BankAccount("Mufasa", 2000, "Lion", false));
            accounts.Add(new BankAccount("Zazu", 3000, "Bird", false));
        }
    }
}
