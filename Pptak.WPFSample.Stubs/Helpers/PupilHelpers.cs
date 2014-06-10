using Pptak.WPFSample.DOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pptak.WPFSample.Stubs.Helpers
{
    public static class PupilHelpers
    {
        public static IList<Pupil> InitializeStub(int numberOfPupils=20)
        {
            IList<Pupil> result = new List<Pupil>();
            for (int i = 0; i < numberOfPupils; i++)
            {
                string prefix = Guid.NewGuid().ToString();
                Pupil pupil = new Random().Next(1, 2) == 1 ? CreateAspNetPupil(prefix) : CreateUNILoginPupil(prefix);
                result.Add(pupil);
            }
            return result;
        }
        public static Pupil CreateAspNetPupil(string prefix)
        {
            return new AspNetPupil()
            {
                AspNetUsername = "aspnetusername_" + prefix,
                Birthday = CommonHelpers.RandomDay(),
                Firstname = "Firstname_" + prefix,
                Lastname = "Lastname_" + prefix,
                MobilePhone = "MobilePhone_" + prefix,
                Phone = "Phone_" + prefix,
                Institution = InstitutioHelpers.CreateTestInsitution(prefix)
            };
        }

        public static Pupil CreateUNILoginPupil(string prefix)
        {
            return new UNILoginPupil()
            {
                UNILoginUsername = "uniloginusername_" + prefix,
                Birthday = CommonHelpers.RandomDay(),
                Firstname = "Firstname_" + prefix,
                Lastname = "Lastname_" + prefix,
                MobilePhone = "MobilePhone_" + prefix,
                Phone = "Phone_" + prefix,
                Institution = InstitutioHelpers.CreateTestInsitution(prefix)
            };
        }
    }
}
