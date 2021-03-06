﻿using Microsoft.EntityFrameworkCore;
using RedditAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditAPI.Repositories
{
    public class RedditDbContext: DbContext
    {
        public DbSet<Post> Posts { get; set; }

        public RedditDbContext(DbContextOptions<RedditDbContext> options) : base(options)
        {

        }
    }
}
