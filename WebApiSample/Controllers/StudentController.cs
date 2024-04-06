using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiSample.Models.DTO;
using WebApiSample.Models.ORM;

namespace WebApiSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        AcademyIstanbulContext context;
        public StudentController()
        {
            context = new AcademyIstanbulContext();
        }

        [HttpPost]
        public IActionResult AddStudent(CreateStudentRequestDto requestModel)
        {
            Student student = new Student();
            student.Name = requestModel.Name;
            student.Surname = requestModel.Surname;
            student.Email = requestModel.Email;
            student.Phone = requestModel.Phone;
            student.BirthDate = requestModel.BirthDate;

            context.Students.Add(student);
            context.SaveChanges();

            return Ok();
        }
        [HttpPut("{id}")]
        public IActionResult UpdateStudent(int id, UpdateStudentRequestDto model)
        {
            Student student = context.Students.FirstOrDefault(x => x.ID == id);

            if (student == null)
            {
                return NotFound();
            }

            student.Name = model.Name;
            student.Surname= model.Surname;
            student.Email = model.Email;
            student.Phone = model.Phone;
            student.BirthDate = model.BirthDate;

            context.SaveChanges();
            return Ok();
        }
    }
}
