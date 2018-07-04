using BankOfSimba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba.ViewModels
{
    public class BankViewModel
    {
        public List<BankAccount> Accounts { get; set; }

        public BankViewModel()
        {
            Accounts = new List<BankAccount>();
            Accounts.Add(new BankAccount("Simba", 5000, "Lion", true, true));
            Accounts.Add(new BankAccount("Nala", 3000, "Lion", false, true));
            Accounts.Add(new BankAccount("Timon", 500, "Meerkat", false, true));
            Accounts.Add(new BankAccount("Zordon", 2000, "Lion", false, false));
            Accounts.Add(new BankAccount("Mufasa", 2000, "Lion", false, true));
            Accounts.Add(new BankAccount("Zazu", 3000, "Bird", false, true));
        }
    }
}

