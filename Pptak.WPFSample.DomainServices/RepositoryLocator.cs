using Pptak.WPFSample.DOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pptak.WPFSample.DomainServices
{
    public class RepositoryLocator : IRepositoryLocator
    {
        //TODO: implement for DB
        public IRepository<Pupil> PupilRepo
        {
            get { throw new NotImplementedException(); }
        }

        public IRepository<Institution> InstitutionRepo
        {
            get { throw new NotImplementedException(); }
        }
    }
}
