namespace ApiClass.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Course { get; set; }

        public Student(int id, string firstName, string lastName, int age, string course)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Course = course;
        }
    }

}
