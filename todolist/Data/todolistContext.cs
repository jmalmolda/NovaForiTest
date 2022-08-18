using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using todolist.Models;

namespace todolist.Data
{
    public class todolistContext : DbContext
    {
        public todolistContext (DbContextOptions<todolistContext> options)
            : base(options)
        {
        }

        public DbSet<todolist.Models.ToDoTask> ToDoTask { get; set; } = default!;
    }
}
