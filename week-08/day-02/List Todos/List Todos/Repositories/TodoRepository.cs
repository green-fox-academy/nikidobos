using List_Todos.Models;
using System;
using System.Collections;
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

        public List<Todo> ListAllTodos(bool isDone, Todo todo)
        {
            if (!todo.IsDone)
            {
                todoDbContext.Todos.ToList();
            }
            return todoDbContext.Todos.ToList();
        }

        public List<Todo> AddNewTodo(Todo todo)
        {
            todoDbContext.Todos.Add(todo);
            todoDbContext.SaveChanges();
            return todoDbContext.Todos.ToList();
        }

        public void RemoveTodo(long idToRemove)
        {
            var removable = todoDbContext.Todos.ToList().FirstOrDefault(x => x.Id.Equals(idToRemove));
            if (removable != null)
            {
                todoDbContext.Remove(removable);
            }
            todoDbContext.SaveChanges();
        }
    }
}
