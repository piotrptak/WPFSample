using Pptak.WPFSample.DOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pptak.WPFSample.Stubs.Helpers
{
    internal static class InstitutioHelpers
    {
        internal static Institution CreateTestInsitution(string prefix)
        {
            return new Institution()
            {
                InstitutionNumber= prefix,
                City = "City_"+prefix,
                Name = "Name_"+prefix, 
                PostCode = "PostCode_"+prefix, 
                Street = "Street_"+prefix, 
                StreetNumber = "StreetNumber_"+prefix ,
            };
        }
    }
}
