using JWT_Auth.Models;
using JWT_Auth.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWT_Auth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        private IStudent _student;

        //initializing the object for interface
        public StudentController(IStudent student)
        {
            _student = student;
        }

        [HttpGet]
        public async Task<ActionResult<List<Student>>> GetAllStudents()
        {
            var students = await _student.GetAllStudents();//controller wait for services for response
            if (students == null)
            {
                return NotFound("No Students Found");
            }
            return Ok(students);
        }

        [HttpGet("{rollno}")]
        public async Task<ActionResult<Student>> GetStudentByRollno(int rollno)
        {
            Student student;
            try
            {
                student = await _student.GetStudentByRollno(rollno);

            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
            return Ok(student);
        }

        [HttpPost]

        public async Task<ActionResult<List<Student>>> AddStudent(Student student)
        {
            var students = await _student.AddStudent(student);
            return Ok(students);
        }

        [HttpPut]

        public async Task<ActionResult<Student>> UpdateStudent(int rollno, Student student)
        {
            Student students;
            try
            {
                students = await _student.UpdateStudent(rollno, student);
                return Ok(students);
            }   
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }

        }

        [HttpDelete]
        public async Task<ActionResult<List<Student>>> DeleteStudent(int rollno)
        {
            try
            {
                var students = await _student.DeleteStudent(rollno);
                return Ok(students);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }

        }

    }
}
