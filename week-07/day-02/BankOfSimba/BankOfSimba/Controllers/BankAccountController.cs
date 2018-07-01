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
        BankViewModel viewModel = new BankViewModel();

        public IActionResult Index()
        {
            return View();
        }

        [Route("simba")]
        public IActionResult GetAccount()
        {
            return View(viewModel.accounts[0]);
        }

        [Route("accounts")]
        public IActionResult GetBankAccounts()
        {
            return View(viewModel);
        }
    }
}