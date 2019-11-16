using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebZoo.Models.Zoo;

namespace WebZoo.Data
{
    public class ZooContext : DbContext
    {
        public ZooContext(DbContextOptions<ZooContext> options) : base(options)
        {
        }

        public DbSet<Animal> Animais { get; set; }
        public DbSet<Especie> Especies { get; set; }
    }
}
