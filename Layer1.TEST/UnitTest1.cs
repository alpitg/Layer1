using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using Layer1.DATA.Repositories;
using Layer1.ENTITIES.Model;
using Layer1.SERVICES.Services;
using Moq;
using System.Web;
using Layer1.WEB.App_Start;
using Layer1.SERVICES.Abstract;
using Layer1.DATA.Infrastructure;
using Layer1.VIEWMODEL.StudentVM;

namespace Layer1.Test
{
    [TestClass]
    public class UnitTest1
    {
        private readonly IAddStudentService _addStudentService;
        public UnitTest1()
        {
            _addStudentService = new AddStudentService(new EntityBaseRepository<AddStudent>(new DbFactory()), new UnitOfWork(new DbFactory()));
        }

        [InlineData(1)]
        [Theory]
        public void GetSudentByIdTest(long id)
        {
            var student = _addStudentService.GetStudentById(id);
            Xunit.Assert.Equal(student.Id, id);   // Expecting the studentid of get record and passed id to be same.
        }

        [Fact]
        public void AddSudentByIdTest()
        {
            var Student = new AddStudent()
            {
                AdditionalDetails = "LostContactNo",
                Address = "Mihan,Nagpur",
                ChildFirstName = "Alex",
                ChildLastName = "Fernan",
                City = "Nagpur",
                Country = "India",
                DOB = "sd",
                Enrolledclass = "1",
                EnrolledEndDate = "18-07-1996",
                EnrolledRoom = "A",
                EnrolledStartDate = "17-07-1996",
                GuardianEmailId = "abc@gmail.com",
                GuardianFirstName = "Tom",
                GuardianLastName = "Fernan",
                GuardianMobile = "9787877665",
                GuardianRelation = "Uncle",
                Id = 1,
                IsDeleted = false,
                ParentEmailId = "xyz@gmail.com",
                ParentFatherName = "Lee",
                ParentMobile = "9767676766",
                ParentMotherName = "Lara",
                PostalCode = 214525,
                State = "Maharashtra"
            };

            // Mocking a repository
            var StudentRepositoryMock = new Mock<IEntityBaseRepository<AddStudent>>();

            // Expecting repo to return the passed student object
            StudentRepositoryMock.Setup(m => m.GetSingle(1)).Returns(Student).Verifiable();

            // Mocking a UnitOfWork
            var unitOfWorkMock = new Mock<IUnitOfWork>();

            // Passing a service constructor repo and unutofwork
            IAddStudentService studentservice = new AddStudentService(StudentRepositoryMock.Object, unitOfWorkMock.Object);

            var actual = studentservice.GetStudentById(3);

            StudentRepositoryMock.Verify();//verify that GetByID was called based on setup.

            //Assert
            Xunit.Assert.NotNull(actual);  //assert that a result was returned
        }

        [TestMethod]
        [Fact]
        public void GetAllStudents()
        {
            var studentList = _addStudentService.GetAllStudentsWithoutParam();
            Xunit.Assert.NotEmpty(studentList);
        }


        


    }
}



