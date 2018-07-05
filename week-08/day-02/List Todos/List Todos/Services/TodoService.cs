using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using List_Todos.Models;
using List_Todos.Repositories;

namespace List_Todos.Services
{
    public class TodoService : ITodoService
    {
        private TodoRepository todorepository;
        private AssigneeRepository assigneeRepository;
        public TodoService(TodoRepository todorepository, AssigneeRepository assigneeRepository)
        {
            this.todorepository = todorepository;
            this.assigneeRepository = assigneeRepository;
        }
        public void AddNewTodo(Todo todo)
        {
            todorepository.Create(todo);
        }

        public void EditTodo(Todo todo)
        {
            todorepository.Update(todo);
        }

        public List<Todo> GetAllTodos()
        {
            return todorepository.GetAllElements();
        }

        public Todo GetTodoById(long id)
        {
            return todorepository.GetTodoById(id);
        }

        public void RemoveTodo(long id)
        {
            var toRemove = GetTodoById(id);
            todorepository.Delete(toRemove);
        }
    }
}
