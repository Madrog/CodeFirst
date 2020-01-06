using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Samples.AspCoreEF.DAL.EF.Models;

namespace Samples.AspCoreEF.DAL.EF.EntityFrameworkContext
{
    public class TaskSystemDbContext : DbContext
    {
        public TaskSystemDbContext(DbContextOptions<TaskSystemDbContext> dbContextOption) : base(dbContextOption)
        {
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Task> Tasks { get; set; }
    }
}
