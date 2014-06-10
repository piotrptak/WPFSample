using Pptak.WPFSample.DOM;
using Pptak.WPFSample.DomainServices;
using Pptak.WPFSample.Stubs.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Pptak.WPFSample.Stubs
{
    public class StubPupilRepository : IRepository<Pupil>
    {
        private IList<Pupil> pupils;
        private IRepositoryLocator repoLocator;

        public StubPupilRepository(IRepositoryLocator repoLocator)
        {
            this.pupils = PupilHelpers.InitializeStub();
            this.repoLocator = repoLocator;
        }

        public Pupil Add(Pupil entity)
        {
            if (this.pupils.First(d => d.Id.Equals(entity.Id)) == null)
            {
                this.pupils.Add(entity);
                return entity;
            }
            else
                throw new ArgumentException("Pupil aready exists"); //Your own pupil's specific exception should be implemented here;
        }

        public bool Update(Pupil entity)
        {
            try
            {
                var currentPupil = this.pupils.First(d => d.Id.Equals(entity.Id));
                if (currentPupil == null)
                    throw new ArgumentException("Pupil does not exist");
                else
                {
                    currentPupil.Firstname = entity.Firstname;
                    currentPupil.Lastname = entity.Lastname;
                    currentPupil.Birthday = entity.Birthday;
                    currentPupil.MobilePhone = entity.MobilePhone;
                    currentPupil.Phone = entity.Phone;
                    repoLocator.InstitutionRepo.Update(entity.Institution);
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Delete(Pupil entity)
        {
            var currentPupil = this.pupils.First(d => d.Id.Equals(entity.Id));
            if (currentPupil == null)
                throw new ArgumentException("Pupil does not exist");
            this.pupils.Remove(currentPupil);
            return true;
        }

        public Pupil Get(Func<Pupil, bool> filter)
        {
            return this.pupils.FirstOrDefault(filter);
        }

        public IList<Pupil> GetAll()
        {
            return this.pupils;
        }
    }
}
