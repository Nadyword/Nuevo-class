using ApiClass.Dtos;
using ApiClass.Interfaces;
using ApiClass.Models;
using ApiClass.Exceptions;


namespace ApiClass.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<Dtos.StudentDto> GetStudentById(int id)
        {
            var student = await _studentRepository.GetStudentById(id);
            if (student == null)
            {
                throw new NotFoundException("Student not found");
            }
            
            return new StudentDto
            {
                Id = student.Id,
                FirstName = student.FirstName,
                LastName = student.LastName,
                Age = student.Age,
                Course = student.Course
            };
        }

        public async Task<IEnumerable<StudentDto>> GetAllStudents()
        {
            var students = await _studentRepository.GetAllStudents();
            return students.Select(s => new StudentDto
            {
                Id = s.Id,
                FirstName = s.FirstName,
                LastName = s.LastName,
                Age = s.Age,
                Course = s.Course
            }).ToList();
        }

        public async Task AddStudent(StudentDto studentDto)
        {
            var student = new Student
            {
                FirstName = studentDto.FirstName,
                LastName = studentDto.LastName,
                Age = studentDto.Age,
                Course = studentDto.Course
            };

            await _studentRepository.AddStudent(student);
        }

        public async Task UpdateStudent(int id, StudentDto studentDto)
        {
            var student = await _studentRepository.GetStudentById(id);
            if (student == null)
            {
                throw new NotFoundException("Student not found");
            }

            student.FirstName = studentDto.FirstName;
            student.LastName = studentDto.LastName;
            student.Age = studentDto.Age;
            student.Course = studentDto.Course;

            await _studentRepository.UpdateStudent(student);
        }

        public async Task DeleteStudent(int id)
        {
            await _studentRepository.DeleteStudent(id);
        }

        Task<StudentDto> IStudentService.GetStudentById(int id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<StudentDto>> IStudentService.GetAllStudents()
        {
            throw new NotImplementedException();
        }

    }
}
