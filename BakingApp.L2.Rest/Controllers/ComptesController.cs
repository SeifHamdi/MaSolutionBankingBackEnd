using BakingApp.L0.AdataAccess.Domain;
using BakingApp.L1.Business.Facade;
using BakingApp.L1.Business.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BakingApp.L2.Rest.Controllers
{
    public class ComptesController : ApiController
    {
        private ICompteBusiness business; // = new ComptesBusinessImpl();

        public ComptesController(ICompteBusiness business)
        {
            this.business = business;
        }

        // GET api/comptes
        public IEnumerable<Compte> Get()
        {
            return business.TousLesComptes();
        }
    }
}
