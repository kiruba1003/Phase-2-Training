using StudentDetails.Model;
namespace StudentDetails.Services.Interfaces
{
    public interface IStudent
    {
        Task<List<Student>> GetAllStudents();

        Task<Student> GetStudentByRollno(int rollno);

        Task<List<Student>> AddStudent(Student student);

        Task<Student> UpdateStudent(int id,Student student);

        Task<List<Student>> DeleteStudent(int id);
      
    }
}
