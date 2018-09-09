package com.nikidobos.foodallergytracker.Client;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class ClientServiceImpl implements ClientService {

  private ClientRepository clientRepository;

  @Autowired
  public ClientServiceImpl(ClientRepository clientRepository) {
    this.clientRepository = clientRepository;
  }

  @Override
  public Client saveNewClient(Client client) {
    clientRepository.save(client);
    return client;
  }

  @Override
  public Iterable<Client> getAllClients() {
    return clientRepository.findAll();
  }
}

