package com.todos.todoapp.Repositories;

import com.todos.todoapp.Models.Todo;
import org.springframework.data.repository.CrudRepository;
import org.springframework.stereotype.Repository;

@Repository
public interface TodoRepository extends CrudRepository<Todo, Long> {
  Todo findItemById(Long id);
  //void saveFromBody(String title);
}
