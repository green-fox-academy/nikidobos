﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba.Models
{
    public class BankAccount
    {
        public string Name { get; set; }
        public int Balance { get; set; }
        public string AnimalType { get; set; }
        public bool IsKing { get; set; }
        public bool IsGood { get; set; }

        public BankAccount(string name, int balance, string animalType, bool isKing, bool isGood)
        {
            this.Name = name;
            this.Balance = balance;
            this.AnimalType = animalType;
            this.IsKing = isKing;
            this.IsGood = isGood;
        }

        public BankAccount()
        {
        }

        public void AddMoney()
        {
            if (IsKing)
            {
                Balance += 100;
            }
            else
            {
                Balance += 10;
            }
        }
    }
}
