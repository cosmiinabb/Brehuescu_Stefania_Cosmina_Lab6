using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Brehuescu_Stefania_Cosmina_Lab6.Models;

namespace Brehuescu_Stefania_Cosmina_Lab6.Data
{
    public class Brehuescu_Stefania_Cosmina_Lab6Context : DbContext
    {
        public Brehuescu_Stefania_Cosmina_Lab6Context (DbContextOptions<Brehuescu_Stefania_Cosmina_Lab6Context> options)
            : base(options)
        {
        }

        public DbSet<Brehuescu_Stefania_Cosmina_Lab6.Models.Book> Book { get; set; }
    }
}
