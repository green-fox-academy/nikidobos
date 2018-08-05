package com.todos.todoapp.Controllers;

import com.todos.todoapp.Models.Todo;
import com.todos.todoapp.Services.TodoService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

@RestController
public class TodoRestController {

  @Autowired
  private TodoService todoService;

  public TodoRestController(TodoService todoService) {
    this.todoService = todoService;
  }

  @GetMapping("/rest")
  public Iterable<Todo> getAllTodos(){
    return todoService.getAllTodos();
  }

  @PostMapping("/rest")
  public Iterable<Todo> addNewTodo(@RequestBody(required = true) String title, Todo todo){
     todoService.addTodoFromBody(title);
     return todoService.getAllTodos();
  }

  @GetMapping("/rest/{id}")
  public Todo getTodo(@PathVariable(value = "id") Long id){
    return todoService.findTodoById(id);
  }
}
