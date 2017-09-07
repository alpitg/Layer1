using Layer1.VIEWMODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer1.SERVICES.Abstract
{
    interface IStudentService
    {
        CStudentViewModel GetStudentById(int id);

        // List<CStudentViewModel> GetAllStudents(CStudentViewModel model);

        int AddStudent(CStudentViewModel addStudentModel);

        int UpdateStudent(long id, CStudentViewModel updateStudentModel);

        int DeleteStudent(long id);
    }
}
