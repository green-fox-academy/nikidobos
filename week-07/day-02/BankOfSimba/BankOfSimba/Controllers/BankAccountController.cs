using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankOfSimba.Models;
using BankOfSimba.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BankOfSimba.Controllers
{
    public class BankAccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("simba")]
        public IActionResult GetAccount()
        {
            BankAccount SimbasBankAccount = new BankAccount("Simba", 2000, "Lion");
            return View(SimbasBankAccount);
        }

        [Route("accounts")]
        public IActionResult GetBankAccounts()
        {
            BankViewModel model = new BankViewModel();
            model.accounts.Add(new BankAccount("Nala", 3000, "Lion"));
            model.accounts.Add(new BankAccount("Timon", 500, "Meerkat"));
            model.accounts.Add(new BankAccount("Mufasa", 2000, "Lion"));
            model.accounts.Add(new BankAccount("Zazu", 3000, "Bird"));
            return View(model);
        }
    }
}