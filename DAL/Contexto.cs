using Microsoft.EntityFrameworkCore;
using RegistroConDetalle.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroConDetalle.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Permisos> Permisos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = DATA\RolesControl.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Permisos>().HasData(new Permisos
            {
                PermisoId = 1,
                Nombre = "Administrar",
                Descripcion = "Permiso para administrar el sistema"
            });
            modelBuilder.Entity<Permisos>().HasData(new Permisos
            {
                PermisoId = 2,
                Nombre = "Abrir tienda",
                Descripcion = "Permiso para abrir la tienda"
            });
            modelBuilder.Entity<Permisos>().HasData(new Permisos
            {
                PermisoId = 3,
                Nombre = "Vacaciones",
                Descripcion = "Permiso para pedir vacaciones"
            });

        }

    }
}
