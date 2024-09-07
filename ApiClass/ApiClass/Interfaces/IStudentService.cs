namespace ApiClass.Interfaces;
using ApiClass.Dtos;
{
    public interface IStudentService
    {
        Task<StudentDto> GetStudentById(int id);
        Task<IEnumerable<StudentDto>> GetAllStudents();
        Task AddStudent(StudentDto student);
        Task UpdateStudent(int id, StudentDto student);
        Task DeleteStudent(int id);
    }
}
