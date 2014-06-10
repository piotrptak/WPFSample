using Pptak.WPFSample.DOM.Visitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pptak.WPFSample.DOM
{
    public abstract class Pupil
    {
        public Guid Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthday { get; set; }
        public string Phone { get; set; }
        public string MobilePhone { get; set; }
        public virtual Institution Institution { get; set; }

        public abstract void AcceptVisitor(IPupilVisitor visitor);

    }
    //ordinary pupil having UNILogin assigned
    public class UNILoginPupil : Pupil
    {
        public string UNILoginUsername { get; set; }

        public override void AcceptVisitor(IPupilVisitor visitor)
        {
            visitor.VisitUniLoginPupil(this);
        }
    }

    //internal user - without UNILogin 
    public class AspNetPupil : Pupil
    {
        public string AspNetUsername { get; set; }

        public override void AcceptVisitor(IPupilVisitor visitor)
        {
            visitor.VisitAspNetPupil(this);
        }
    }
}
