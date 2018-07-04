﻿using List_Todos.Models;
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
            var removable = GetTodoById(idToRemove);
            if (removable != null)
            {
                todoDbContext.Remove(removable);
                todoDbContext.SaveChanges();
            }
        }

        public void EditTodo(long idToEdit, Todo todo)
        {
            var toEdit = GetTodoById(idToEdit);
            if (toEdit != null)
            {
                toEdit.Title = todo.Title;
                toEdit.IsUrgent = todo.IsUrgent;
                toEdit.IsDone = todo.IsDone;
                todoDbContext.SaveChanges();
            }
        }

        public Todo GetTodoById(long idToFind)
        {
            var selectedTodoById = todoDbContext.Todos.ToList().FirstOrDefault(x => x.Id.Equals(idToFind));
            return selectedTodoById;
        }
    }
}
