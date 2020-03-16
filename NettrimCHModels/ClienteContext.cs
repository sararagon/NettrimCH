using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace NettrimCHModels
{
    class ClienteContext : DbContext
    {
        public ClienteContext(DbContextOptions<ClienteContext> options) : base(options)
        {
        }
         
 
        public DbSet<Cliente> Clientes { get; set; }
        
    }
}
