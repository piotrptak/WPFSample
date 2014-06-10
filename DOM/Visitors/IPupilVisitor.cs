using Pptak.WPFSample.DOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pptak.WPFSample.DOM.Visitors
{
    public interface IPupilVisitor
    {
        void VisitUniLoginPupil(UNILoginPupil pupil);
        void VisitAspNetPupil(AspNetPupil pupil);
    }
}
