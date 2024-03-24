using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;

namespace ToDoListApp.Models
{
    public class ToDoContextFactory : IDesignTimeDbContextFactory<ToDoContext>
    {
        public ToDoContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ToDoContext>();
            optionsBuilder.UseSqlite("Data Source=ToDoListApp.db");

            return new ToDoContext(optionsBuilder.Options);
        }
    }
}
