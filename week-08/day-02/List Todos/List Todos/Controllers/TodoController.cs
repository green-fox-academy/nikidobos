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
        public IActionResult List(bool isDone, Todo todo)
        {
            return View(todoRepository.ListAllTodos(isDone, todo));
        }

        [HttpGet("/add")]
        public IActionResult AddTodo()
        {
            return View();
        }

        [HttpPost("/add")]
        public IActionResult AddTodo(Todo todo)
        {
            todoRepository.AddNewTodo(todo);
            return Redirect("list");
        }

        [HttpGet("/{id}/delete")]
        public IActionResult DeleteTodo(long id)
        {
            todoRepository.RemoveTodo(id);
            return Redirect("/list");
        }

        [HttpGet("/{id}/edit")]
        public IActionResult UpdateTodo(long id)
        {            
            return View(todoRepository.GetTodoById(id));
        }

        [HttpPost("/{id}/edit")]
        public IActionResult UpdateTodo(Todo todo)
        {
            todoRepository.EditTodo(todo);
            return Redirect("/list");
        }
    }
}