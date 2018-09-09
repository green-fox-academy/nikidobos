package com.nikidobos.foodallergytracker.Client;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;

@Controller
public class ClientController {

  private ClientService clientService;

  @Autowired
  public ClientController(ClientService clientService) {
    this.clientService = clientService;
  }

  @GetMapping("/clients")
  public String listClients(Model model){
    model.addAttribute("clients", clientService.getAllClients());
    return "clients";
  }

  @GetMapping("/clients/new")
  public String addNewClient(){
    return "addnewclient";
  }

  @PostMapping("/clients/new")
  public String addNewClient(Client client){
    clientService.saveNewClient(client);
    return "addnewclient";
  }
}

