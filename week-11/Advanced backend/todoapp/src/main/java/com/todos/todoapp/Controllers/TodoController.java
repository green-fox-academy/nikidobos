package com.todos.todoapp.Controllers;

import com.todos.todoapp.Models.Todo;
import com.todos.todoapp.Services.TodoService;
import com.todos.todoapp.Services.TodoServiceImpl;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;

@Controller
public class TodoController {

  @Autowired
  private TodoServiceImpl todoService;

  public TodoController(TodoServiceImpl todoService) {
    this.todoService = todoService;
  }

  @GetMapping("")
  public String listAllTodos(Model model){
    Iterable<Todo> allTodos = todoService.getAllTodos();
    model.addAttribute("todos", allTodos);
    return "todo";
  }

  @GetMapping("/addtodo")
  public String addNewTodo(){
    return "add";
  }

  @PostMapping("/addtodo")
  public String addNewTodo(Todo todo){
    todoService.addTodo(todo);
    return "redirect:";
  }

  @GetMapping("/edit/{id}")
  public String editTodo(@PathVariable(value = "id") Model model, Long id){
    model.addAttribute("selectedTodo", todoService.findTodoById(id));
    return "edit";
  }

  @PostMapping("/edit/{id}")
  public String editTodo(@PathVariable(value = "id") @ModelAttribute Todo todo, Long id){
    todoService.updateTodo(todo, id);
    return "edit";
  }
}
