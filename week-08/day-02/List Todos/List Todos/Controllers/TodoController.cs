using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using List_Todos.Models;
using List_Todos.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace List_Todos.Controllers
{
    [Route("/todo")]
    public class TodoController : Controller
    {
        private TodoRepository todoRepository;
        public TodoController(TodoRepository todoRepository)
        {
            this.todoRepository = todoRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("/")]
        [HttpGet("/list")]
        public IActionResult List(Todo todo)
        {
            return View(todoRepository.ListAllTodos());
        }
    }
}