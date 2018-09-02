package com.nikidobos.foodallergytracker.Client;

import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

import javax.persistence.*;
import java.util.Date;

@Entity
@Table(name="clients")
@Getter
@Setter
@NoArgsConstructor
public class Client {

  @Id
  @GeneratedValue(strategy = GenerationType.AUTO)
  private Long id;
  private String firstName;
  private String lastName;
  private String location;
  private String dateOfBirth;
  private String dateOfRegistration;

  public Client(String firstName, String lastName, String location, String dateOfBirth,
                String dateOfRegistration) {
    this.firstName = firstName;
    this.lastName = lastName;
    this.location = location;
    this.dateOfBirth = dateOfBirth;
    this.dateOfRegistration = dateOfRegistration;
  }
}

