package com.todos.todoapp.Services;

import com.todos.todoapp.Models.Todo;

import java.util.List;

public interface TodoService {

  Iterable<Todo> getAllTodos();
  void updateTodo(Todo todo, Long id);
  Todo findTodoById(Long id);
  void addTodo(Todo todo);
  void addTodoFromBody(String title);
}
