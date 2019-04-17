using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.DAL
{
    public class HastanelerContext : DbContext
    {
        public DbSet<Hastaneler> Hastanelers { get; set; }
        public DbSet<Doktorlar> Doktorlars { get; set; }
        public DbSet<Ilceler> Ilcelers { get; set; }
        public DbSet<Iller> Illers { get; set; }
        public DbSet<Klinikler> Kliniklers { get; set; }
        public DbSet<Hastalar> Hastalars { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Randevular> Randevulars { get; set; }

    }
}
