using BakingApp.L0.AdataAccess.Domain;
using BakingApp.L0.AdataAccess.Facade;
using BakingApp.L0.AdataAccess.Implementations;
using BakingApp.L1.Business.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakingApp.L1.Business.Implementations
{
    public class ComptesBusinessImpl : ICompteBusiness
    {
        private IComptesRepository repository = new ComptesRepositoryImpl_EF();

        public decimal? ConsulterSolde(string numero)
        {
            var resultat = repository.FindById(numero);
            return resultat?.Solde;
        }
        public IEnumerable<Compte> TousLesComptes()
        {
            return repository.FindAll();
        }
    }
}
