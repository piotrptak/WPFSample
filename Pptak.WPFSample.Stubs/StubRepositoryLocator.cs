using Pptak.WPFSample.DOM;
using Pptak.WPFSample.DomainServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pptak.WPFSample.Stubs
{
    public class StubRepositoryLocator : IRepositoryLocator
    {
        private IRepository<Pupil> pupilRepo;
        private IRepository<Institution> institutionRepo;

        public StubRepositoryLocator()
        {
            this.pupilRepo = new StubPupilRepository(this);
            this.institutionRepo = new InstitutionRepository(this);
        }

        public IRepository<Pupil> PupilRepo
        {
            get { return this.pupilRepo; }
        }

        public IRepository<Institution> InstitutionRepo
        {
            get { return this.institutionRepo; }
        }
    }
}
