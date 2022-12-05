using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskM.Models;

namespace TaskM.Data
{
    public class TaskMContext : DbContext
    {
        public TaskMContext (DbContextOptions<TaskMContext> options)
            : base(options)
        {
        }

        public DbSet<TaskM.Models.EmployeeDetails> EmployeeDetails { get; set; }
    }
}
