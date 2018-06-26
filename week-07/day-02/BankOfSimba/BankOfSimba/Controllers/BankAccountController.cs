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
            BankAccount SimbasBankAccount = new BankAccount("Simba", 2000, "Lion");
            return View(SimbasBankAccount);
        }

        [Route("List")]
        public void GetBankAccounts()
        {
            List<BankAccount> accounts = new List<BankAccount>();
            {
                new BankAccount() { Name = "Nala", Balance = 3000, AnimalType = "Lion" };
                new BankAccount() { Name = "Timon", Balance = 5000, AnimalType = "Meerkat" };
                new BankAccount() { Name = "Mufasa", Balance = 2000, AnimalType = "Lion" };
                new BankAccount() { Name = "Zazu", Balance = 3000, AnimalType = "Bird" };
            };
        }
    }
}