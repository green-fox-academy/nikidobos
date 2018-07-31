package com.todos.todo.model;

import javax.persistence.Entity;
import javax.persistence.Id;

@Entity
public class Todo {

  @Id
  private long id;
  private String title;

}
