package com.todos.todo.service;

import com.todos.todo.model.Todo;
import com.todos.todo.repository.TodoRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class TodoService {

  @Autowired
  private TodoRepository repository;

  public void addNewTodo(Todo todo){
    repository.save(todo);
  }
}
