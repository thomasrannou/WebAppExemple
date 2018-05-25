using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebAppExemple.Model
{
    public class ContexteExemple : DbContext
    {
        /// <summary>
        /// Collection de clients
        /// </summary>
        public DbSet<Client> Clients { get; set; }

        /// <summary>
        /// Constructeur avec options
        /// </summary>
        /// <param name="options"></param>
        public ContexteExemple(DbContextOptions<ContexteExemple> options) : base(options)
        {
        }

        /// <summary>
        /// Constructeur de base
        /// </summary>
        public ContexteExemple() : base()
        {
        }
    }
}
