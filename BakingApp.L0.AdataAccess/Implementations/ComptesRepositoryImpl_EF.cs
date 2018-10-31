using BakingApp.L0.AdataAccess.Domain;
using BakingApp.L0.AdataAccess.Facade;
using BakingApp.L0.AdataAccess.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakingApp.L0.AdataAccess.Implementations
{
    public class ComptesRepositoryImpl_EF : IComptesRepository
    {
        public void Create(Compte c)
        {
            using (var ctxt = new BankingContext())
            {
                ctxt.Comptes.Add(c);
                ctxt.SaveChanges();
            }
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Compte> FindAll()
        {
            using (var ctxt = new BankingContext())
            {
                return ctxt.Comptes.ToList();
            }
        }

        public Compte FindById(string id)
        {
            using (var ctxt = new BankingContext())
            {
                return ctxt.Comptes.Find(id);
            }
        }

        public void Update(Compte c)
        {
            throw new NotImplementedException();
        }
    }
}
