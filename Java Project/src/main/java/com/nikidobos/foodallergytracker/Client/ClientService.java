package com.nikidobos.foodallergytracker.Client;

import org.springframework.stereotype.Service;

import java.util.List;

public interface ClientService {
  Client saveNewClient(Client client);
  Iterable<Client> getAllClients();
}
