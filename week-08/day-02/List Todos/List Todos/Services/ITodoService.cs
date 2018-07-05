using List_Todos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace List_Todos.Services
{
    public interface ITodoService
    {
        //CRUD
        void AddNewTodo(Todo todo);
        List<Type> GetAllTodos();
        void EditTodo(Todo todo);
        void RemoveTodo(long id);
        List<Type> GetTodoById(long id);
    }
}
