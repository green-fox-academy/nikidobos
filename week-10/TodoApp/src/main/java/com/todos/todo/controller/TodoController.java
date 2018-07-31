package com.todos.todo.controller;

import com.todos.todo.service.TodoService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;

@Controller
public class TodoController {

  @Autowired
  private TodoService service;
}
