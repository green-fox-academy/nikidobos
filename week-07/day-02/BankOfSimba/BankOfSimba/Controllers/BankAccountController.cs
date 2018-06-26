using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankOfSimba.Models;
using Microsoft.AspNetCore.Mvc;

namespace BankOfSimba.Controllers
{
    [Route("Bank")]
    public class BankAccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("Simba")]
        public IActionResult GetAccount()
        {
            BankAccount SimbasBankAccount = new BankAccount("Simba", 2000.ToString("0.##"), "Animal.Lion");
            return View(SimbasBankAccount);
        }

        List<BankAccount> accounts = new List<BankAccount>();
        [Route("List")]
        public IActionResult BankAccounts(BankAccount bankAccount)
        {
            accounts.Add(bankAccount);
            return View(accounts);
        }
    }
}