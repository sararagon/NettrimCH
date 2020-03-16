using Microsoft.EntityFrameworkCore;
using NettrimCHModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace NettrimCHServices.DAL
{
    class NettrimCHContext : DbContext
    {
        public NettrimCHContext(DbContextOptions<NettrimCHContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Proyecto> Proyectos { get; set; }
        public DbSet<Tarea> Tareas { get; set; }
    }
}
