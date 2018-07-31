package com.todos.todo.controller;

import com.todos.todo.service.TodoService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;

import java.util.Map;

@Controller
public class TodoController {

  @Autowired
  private TodoService service;

  @RequestMapping("/")
  public String todos(Map<String, Object> model){
    model.put("title", "feed the monkey");
    return "alltodos";
  }

}
