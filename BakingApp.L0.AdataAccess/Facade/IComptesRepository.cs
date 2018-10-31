using BakingApp.L0.AdataAccess.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakingApp.L0.AdataAccess.Facade
{
    public interface IComptesRepository
    {
        // CRUD contract
        void Create(Compte c);
        Compte FindById(string id);
        IEnumerable<Compte> FindAll();
        void Update(Compte c);
        void Delete(string id);
    }
}
