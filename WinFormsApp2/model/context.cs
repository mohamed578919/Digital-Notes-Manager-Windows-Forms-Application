using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp2.model
{
    internal class context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=DESKTOP-75NNU9R;Database=mycompanydb;Trusted_Connection=True;Encrypt=False;";
            optionsBuilder.UseSqlServer(connectionString);
        }
        public virtual DbSet<Note> notes { get; set; }
    }
}
