using List_Todos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace List_Todos.Repositories
{
    public class TodoRepository
    {
        private TodoDbContext todoDbContext;
        public TodoRepository(TodoDbContext todoDbContext)
        {
            this.todoDbContext = todoDbContext;
        }

        public List<Todo> ListAllTodos()
        {
            return todoDbContext.Todos.ToList();
        }

        public void AddNewTodo(Todo todo)
        {
            todoDbContext.Todos.Add(todo);
            todoDbContext.SaveChanges();
        }
    }
}
