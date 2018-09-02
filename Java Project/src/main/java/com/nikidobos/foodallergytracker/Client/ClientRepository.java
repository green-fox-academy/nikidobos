package com.nikidobos.foodallergytracker.Client;

import org.springframework.data.repository.CrudRepository;
import org.springframework.stereotype.Repository;

@Repository
public interface ClientRepository extends CrudRepository<Client, Long> {
  Client save(Client client);
}
