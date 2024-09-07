namespace ApiClass.Interfaces
using ApiClass.Models;
{
    public interface IStudentRepository
    {
        Task<Student> GetStudentById(int id);
        Task<IEnumerable<Student>> GetAllStudents();
        Task AddStudent(Student student);
        Task UpdateStudent(Student student);
        Task DeleteStudent(int id);
    }
}
