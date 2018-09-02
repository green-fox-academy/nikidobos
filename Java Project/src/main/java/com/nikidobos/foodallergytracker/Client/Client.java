package com.nikidobos.foodallergytracker.Client;

import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

import javax.persistence.*;
import java.util.Date;
import java.util.List;

@Entity
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
  private Date dateOfBirth;
  private Date dateOfRegistration;
  @ManyToMany
  private List<Allergy> allergies;

  public Client(String firstName, String lastName, String location, Date dateOfBirth, Date dateOfRegistration, List<Allergy> allergies) {
    this.firstName = firstName;
    this.lastName = lastName;
    this.location = location;
    this.dateOfBirth = dateOfBirth;
    this.dateOfRegistration = dateOfRegistration;
    this.allergies = allergies;
  }
}

