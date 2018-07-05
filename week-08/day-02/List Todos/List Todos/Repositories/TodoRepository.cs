using List_Todos.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace List_Todos.Repositories
{
    public class TodoRepository : IGeneralRepository<Todo>
    {
        private TodoDbContext todoDbContext;
        public TodoRepository(TodoDbContext todoDbContext)
        {
            this.todoDbContext = todoDbContext;
        }

        public Todo GetTodoById(long idToFind)
        {
            return todoDbContext.Todos.ToList().FirstOrDefault(x => x.Id.Equals(idToFind));
        }

        internal List<Todo> FindTodo(string searcher)
        {
            var searchedTodo = todoDbContext.Todos.Where(x => x.Title.ToLower().Contains(searcher.ToLower())).ToList();
            return searchedTodo;
        }

        public void Create(Todo element)
        {
            todoDbContext.Todos.Add(element);
            todoDbContext.SaveChanges();
        }

        public List<Todo> GetAllElements()
        {
            return todoDbContext.Todos.ToList();
        }

        public void Update(Todo element)
        {
            todoDbContext.Update(element);
            todoDbContext.SaveChanges();
        }

        public void Delete(Todo element)
        {
            todoDbContext.Remove(element);
            todoDbContext.SaveChanges();
        }
    }
}
