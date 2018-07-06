﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Reddit.Services;

namespace Reddit.Controllers
{
    public class RedditController : Controller
    {
        public RedditService service;
        public RedditController(RedditService service)
        {
            this.service = service;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("/")]
        public IActionResult List()
        {
            return View(service.GetAllPosts());
        }
    }
}