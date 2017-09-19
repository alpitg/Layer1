using Layer1.ENTITIES.Model;
using Layer1.SERVICES.Abstract;
using Layer1.VIEWMODEL.StudentVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Layer1.WEB.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class StudentController : ApiController
    {


        private readonly IAddStudentService _iAddStudentService;

        public StudentController(IAddStudentService iAddStudentService)
        {
            _iAddStudentService = iAddStudentService;
        }


        // GET: api/Home
        [HttpGet]
        [Route("api/Student/")]
        public IHttpActionResult GetAllStudent()
        {
            var a = _iAddStudentService.GetAllStudentsWithoutParam();

            return Ok(a);
        }


        // GET: api/Home/5
        [HttpGet]
        [Route("api/Student/{id}")]
        public IHttpActionResult GetById(long id)
        {
            var a = _iAddStudentService.GetStudentById(id);
            return Ok(a);
        }



        // POST: api/Home
        [Route("api/Student/")]
        [HttpPost]
        public IHttpActionResult Post([FromBody] AddStudentViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var a = _iAddStudentService.AddStudent(model);

            return Ok(a);
        }



    }
}
