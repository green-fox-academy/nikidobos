using List_Todos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace List_Todos.Repositories
{
    public class TodoDbContext : DbContext
    {
        public DbSet<Todo> todos { get; set; }
    }
}
