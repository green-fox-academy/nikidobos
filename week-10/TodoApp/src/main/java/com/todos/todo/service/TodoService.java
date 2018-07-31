package com.todos.todo.service;

import com.todos.todo.model.Todo;
import com.todos.todo.repository.TodoRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class TodoService {

  @Autowired
  private TodoRepository repository;

  public void addNewTodo(Todo todo){
    repository.save(todo);
  }

  public List<Todo> getAllTodos(){
    return repository.findAll();
  }
}
