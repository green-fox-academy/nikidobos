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

        public List<Todo> AddNewTodo(Todo todo)
        {
            if (todoDbContext.Todos != null)
            {
                todoDbContext.Todos.Add(todo);
            }
            todoDbContext.SaveChanges();
            return todoDbContext.Todos.ToList();
        }

        public IEnumerable<Todo> isItActive ()
        {
            var isActive = todoDbContext.Todos.ToList()
               .Where(x => x.IsDone.Equals(true));
            return isActive;
        }
    }
}
