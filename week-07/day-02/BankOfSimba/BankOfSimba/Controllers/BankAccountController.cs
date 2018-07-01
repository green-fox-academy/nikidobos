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
            BankViewModel viewModel = new BankViewModel();
            return View(viewModel);
        }
    }
}