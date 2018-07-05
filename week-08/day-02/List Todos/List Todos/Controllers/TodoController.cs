using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using List_Todos.Models;
using List_Todos.Repositories;
using List_Todos.Services;
using Microsoft.AspNetCore.Mvc;

namespace List_Todos.Controllers
{
    [Route("/todo")]
    public class TodoController : Controller
    {
        private ITodoService todoService;

        public TodoController(ITodoService todoService)
        {
            this.todoService = todoService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("/")]
        [HttpGet("/list")]
        public IActionResult List(long id)
        {
            return View(todoService.GetTodoById(id));
        }

        [HttpGet("/add")]
        public IActionResult AddTodo()
        {
            return View();
        }

        [HttpPost("/add")]
        public IActionResult AddTodo(Todo todo)
        {
            todoService.AddNewTodo(todo);
            return Redirect("list");
        }

        [HttpGet("/{id}/delete")]
        public IActionResult DeleteTodo(long id)
        {
            todoService.RemoveTodo(id);
            return Redirect("/list");
        }

        [HttpGet("/{id}/edit")]
        public IActionResult UpdateTodo(long id)
        {
            return View(todoService.GetTodoById(id));
        }

        [HttpPost("/{id}/edit")]
        public IActionResult UpdateTodo(Todo todo)
        {
            todoService.EditTodo(todo);
            return Redirect("/list");
        }
    }
}