using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Todo.Models;

namespace Todo.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<TodoItem> Todos { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
