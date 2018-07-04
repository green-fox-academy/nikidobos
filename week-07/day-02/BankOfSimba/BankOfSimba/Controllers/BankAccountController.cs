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
        public static BankViewModel viewModel = new BankViewModel();
        
        [HttpGet("")]
        public IActionResult Index()
        {
            return Redirect("/accounts");
        }

        [Route("simba")]
        public IActionResult GetAccount()
        {
            return View(viewModel.Accounts[0]);
        }

        [Route("accounts")]
        public IActionResult GetBankAccounts()
        {
            return View(viewModel);
        }

        [HttpPost("accounts")]
        public IActionResult AddCurrency(int index)
        {
            viewModel.Accounts[index].AddMoney();
            return RedirectToAction("GetBankAccounts");
        }
    }
}