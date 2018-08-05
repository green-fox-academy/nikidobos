package com.todos.todoapp.SecurityConfig;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.security.config.annotation.authentication.builders.AuthenticationManagerBuilder;
import org.springframework.security.config.annotation.web.builders.HttpSecurity;
import org.springframework.security.config.annotation.web.configuration.EnableWebSecurity;
import org.springframework.security.config.annotation.web.configuration.WebSecurityConfiguration;
import org.springframework.security.config.annotation.web.configuration.WebSecurityConfigurerAdapter;

import static org.hibernate.cfg.AvailableSettings.USER;

@EnableWebSecurity
public class SecurityConfig extends WebSecurityConfigurerAdapter {

  private static final String USER = "USER";
  private static final String ADMIN = "ADMIN";

  @Override
  public void configure(HttpSecurity httpSecurity) throws Exception {
    httpSecurity.authorizeRequests()
            .antMatchers("/rest").hasRole(USER)
        .and()
            .formLogin();
  }

  @Autowired
  public void configureGlobal(AuthenticationManagerBuilder auth) throws Exception {
    auth.inMemoryAuthentication()
          .withUser("john").password("pw").roles(USER)
        .and()
        .withUser("emily").password("apple").roles(USER, ADMIN);
  }
}

