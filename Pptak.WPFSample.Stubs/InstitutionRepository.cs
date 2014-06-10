using Pptak.WPFSample.DOM;
using Pptak.WPFSample.DomainServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pptak.WPFSample.Stubs
{
    internal class InstitutionRepository : IRepository<Institution>
    {
        private IRepositoryLocator repoLocator;
        public InstitutionRepository(IRepositoryLocator repoLocator)
        {
            this.repoLocator = repoLocator;
        }

        public Institution Add(Institution entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(Institution entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Institution entity)
        {
            throw new NotImplementedException();
        }

        public Institution Get(Func<Institution, bool> filter)
        {
            throw new NotImplementedException();
        }

        public IList<Institution> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
