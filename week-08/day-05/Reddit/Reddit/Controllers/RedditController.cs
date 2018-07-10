using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Reddit.Models;
using Reddit.Services;

namespace Reddit.Controllers
{
    public class RedditController : Controller
    {
        public IRedditService service;
        public UserService userService;
        public RedditController(IRedditService service, UserService userService)
        {
            this.service = service;
            this.userService = userService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("/")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("/")]
        public IActionResult Login(User user)
        {
            userService.AddNewUser(user);
            return RedirectToAction("list");
        }

        [HttpGet("/list")]
        public IActionResult List()
        {
            return View(service.GetAllPosts());
        }

        [HttpGet("/{id}/increase")]
        public IActionResult IncreaseVote(int id)
        {
            service.IncreaseVote(id);
            return RedirectToAction("List");
        }

        [HttpGet("/{id}/decrease")]
        public IActionResult DecreaseVote(int id)
        {
            service.DecreaseVote(id);
            return RedirectToAction("List");
        }

        [HttpGet("/submit")]
        public IActionResult AddPost()
        {
            return View();
        }

        [HttpPost("/submit")]
        public IActionResult AddPost(Post post)
        {
            service.AddNewPost(post);
            return RedirectToAction("List");
        }
    }
}