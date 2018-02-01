using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.Configuration;

namespace TodoDemoApp.Models
{
    public class TodoContext : DbContext
    {
        private IConfiguration Configuration { get; }

        public TodoContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = Convert.ToString(Configuration["Data:ConnectionString"]);
            optionsBuilder.UseSqlServer(@connectionString);
        }

        public DbSet<TodoItem> TodoItems { get; set; }  
        
        public DbSet<Person> Persons { get; set; } 
    }
}
