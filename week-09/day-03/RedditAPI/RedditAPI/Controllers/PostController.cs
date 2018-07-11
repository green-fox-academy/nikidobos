using Microsoft.AspNetCore.Mvc;
using RedditAPI.Services;

namespace RedditAPI.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private RedditService service;
        public HomeController(RedditService service)
        {
            this.service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("/posts")]
        public IActionResult List()
        {
            return Json(new
            {
                posts = service.GetAllPosts()
            });
        }
    }
}