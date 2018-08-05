package com.todos.todoapp.Services;

import com.fasterxml.jackson.annotation.JacksonAnnotationsInside;
import com.todos.todoapp.Models.Todo;
import com.todos.todoapp.Repositories.TodoRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class TodoServiceImpl implements TodoService {

  @Autowired
  private TodoRepository todoRepository;

  public TodoServiceImpl(TodoRepository todoRepository) {
    this.todoRepository = todoRepository;
  }

  @Override
  public Iterable<Todo> getAllTodos() {
    return todoRepository.findAll();
  }

  @Override
  public void updateTodo(Todo todo, Long id) {
    todo.setId(id);
    todoRepository.save(todo);
  }

  @Override
  public Todo findTodoById(Long id) {
    return todoRepository.findItemById(id);
  }

  @Override
  public void addTodo(Todo todo) {
    todoRepository.save(todo);
  }

  @Override
  public void addTodoFromBody(String title) {
    Todo newTodo = new Todo();
    newTodo.setTitle(title);
    todoRepository.save(newTodo);
  }
}
