using Pptak.WPFSample.DOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pptak.WPFSample.DomainServices
{
    public interface IRepositoryLocator
    {
        IRepository<Pupil> PupilRepo { get; }
        IRepository<Institution> InstitutionRepo { get; }
    }
}
