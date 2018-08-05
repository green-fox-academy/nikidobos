package com.todos.todoapp.Models;

import javax.persistence.*;

@Entity
@Table(name = "todos")
public class Todo {

  @Id
  @GeneratedValue(strategy = GenerationType.AUTO)
  private Long id;
  private String Title;
  private boolean isUrgent;
  private boolean isDone;

  public Long getId() {
    return id;
  }

  public void setId(Long id) {
    this.id = id;
  }

  public String getTitle() {
    return Title;
  }

  public void setTitle(String title) {
    Title = title;
  }

  public boolean isUrgent() {
    return isUrgent;
  }

  public void setUrgent(boolean urgent) {
    isUrgent = urgent;
  }

  public boolean isDone() {
    return isDone;
  }

  public void setDone(boolean done) {
    isDone = done;
  }
}
