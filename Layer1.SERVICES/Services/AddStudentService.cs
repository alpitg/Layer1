using Layer1.SERVICES.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Layer1.VIEWMODEL.StudentVM;
using AutoMapper;
using Layer1.ENTITIES.Model;
using Layer1.DATA.Repositories;
using Layer1.DATA.Infrastructure;
using System.Web.Http.Cors;

namespace Layer1.SERVICES.Services
{
     public class AddStudentService : IAddStudentService
    {

        private readonly IEntityBaseRepository<AddStudent> _StudentRepository;

        private readonly IUnitOfWork _unitOfWork;

        public AddStudentService(
          IEntityBaseRepository<AddStudent> StudentRepository,
          IUnitOfWork unitOfWork
          )
        {
            _StudentRepository = StudentRepository;
            _unitOfWork = unitOfWork;

        }
        
        //Add
        public int AddStudent(AddStudentViewModel addStudentModel)
        {
            //throw new NotImplementedException();
            var studentData = Mapper.Map<AddStudentViewModel, AddStudent>(addStudentModel);

            _StudentRepository.Add(studentData);
            _unitOfWork.Commit();

            return 1;

        }

        //GetAll
        public List<AddStudentViewModel> GetAllStudentsWithoutParam()
        {
            //throw new NotImplementedException();
            var studentdata = _StudentRepository.GetAll().ToList();
            var studentModelData = Mapper.Map<List<AddStudent>, List<AddStudentViewModel>>(studentdata);
            return studentModelData;
        }

        public AddStudentViewModel GetStudentById(long id)
        {
            // throw new NotImplementedException();

            var studentByIdData = _StudentRepository.GetSingle(id);
            var studentModelData = Mapper.Map<AddStudent, AddStudentViewModel>(studentByIdData);
            return studentModelData;
        }
    }
}
