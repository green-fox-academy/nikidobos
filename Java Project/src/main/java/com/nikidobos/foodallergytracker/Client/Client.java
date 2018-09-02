package com.nikidobos.foodallergytracker.Client;

import lombok.Getter;
import lombok.Setter;

import javax.persistence.*;
import java.util.Date;
import java.util.List;

@Entity
@Getter
@Setter
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

}

