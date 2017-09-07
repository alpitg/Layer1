using Layer1.SERVICES.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Layer1.VIEWMODEL;
using AutoMapper;
using Layer1.ENTITIES;

namespace Layer1.SERVICES.Services
{
    class StudentService : IStudentService
    {
        public int AddStudent(CStudentViewModel addstudentmodel)
        {
            var data = Mapper.Map<CStudentViewModel, CStudent>(addstudentmodel);

            return 1;
        }

        public int DeleteStudent(long id)
        {
            throw new NotImplementedException();
        }

        public CStudentViewModel GetStudentById(int id)
        {
            throw new NotImplementedException();
        }

        public int UpdateStudent(long id, CStudentViewModel updateStudentModel)
        {
            throw new NotImplementedException();
        }
    }
}
