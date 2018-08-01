package com.todos.todo.model;

import javax.persistence.Entity;
import javax.persistence.Id;
import java.util.Date;

@Entity
public class Todo {

  @Id
  private Long id;
  private String title;
  private boolean urgent;
  private boolean done;

  public Long getId() {
    return id;
  }

  public void setId(Long id) {
    this.id = id;
  }

  public String getTitle() {
    return title;
  }

  public void setTitle(String title) {
    this.title = title;
  }

}
