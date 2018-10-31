using BakingApp.L0.AdataAccess.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakingApp.L1.Business.Facade
{
    public interface ICompteBusiness
    {
        decimal? ConsulterSolde(string numero);
        IEnumerable<Compte> TousLesComptes();
    }
}
