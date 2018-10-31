using BakingApp.L0.AdataAccess.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakingApp.L0.AdataAccess.Infrastructure
{
    public class BankingContext : DbContext
    {
        public BankingContext() : base("name=bankingdb")
        {

        }
        public virtual DbSet<Compte> Comptes { get; set; }
    }
}
