using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pptak.WPFSample.DOM;
using Pptak.WPFSample.DomainServices;
using Pptak.WPFSample.Stubs;
using Pptak.WPFSample.Stubs.Helpers;

namespace Pptak.WPFSample.Tests
{
    [TestClass]
    public class Tests_PupilRepository
    {
        private IRepositoryLocator repositoryLocator;

        [TestInitialize]
        public void Initialize()
        {
            this.repositoryLocator = new StubRepositoryLocator();
        }
        [TestCleanup]
        public void Clean()
        {
            this.repositoryLocator = null;
        }

        [TestMethod]
        public void AddUNILogin_Success()
        {
            //Arrange
            var pupilForCreation = PupilHelpers.CreateUNILoginPupil(Guid.NewGuid().ToString());
            //Act
            var newlyCreatedPupil = this.repositoryLocator.PupilRepo.Add(pupilForCreation);
            //Assert
            Assert.AreEqual(newlyCreatedPupil, this.repositoryLocator.PupilRepo.Get(d => d.Id == newlyCreatedPupil.Id));
            

        }
        [TestMethod]
        public void AddPupil_Failure_PupilAlreadyExists()
        {
        }

        [TestMethod]
        public void AddPupil_Failure_InsuficcientData()
        {

        }
        [TestMethod]
        public void GetPupil_Success()
        {
            IRepository<Pupil> repo = new Stubs.StubPupilRepository(repositoryLocator);
            repo.Get(d => d.Id == Guid.NewGuid());
        }
        [TestMethod]
        public void GetPupil_Failure_PupilDoesNotExist()
        {

        }
        [TestMethod]
        public void UpdatePupil_Success()
        {

        }
        [TestMethod]
        public void UpdatePupil_Failure_PupilDoesNotExist()
        {

        }
        [TestMethod]
        public void UpdatePupil_Failure_PupilWithTheSameIdAlreadyExists()
        {

        }
    }
}
