using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hello_World_REST_App.Models
{
    public class Greetings
    {
        long id;
        string Content;

        public long Id { get => id; set => id = value; }
        public string Content1 { get => Content; set => Content = value; }


    }
}
