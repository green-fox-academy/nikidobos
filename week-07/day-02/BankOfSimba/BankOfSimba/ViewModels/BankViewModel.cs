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
        }
    }
}
