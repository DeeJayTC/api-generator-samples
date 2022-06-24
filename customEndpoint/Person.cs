using TCDev.APIGenerator.Attributes;
using TCDev.APIGenerator.Interfaces;

namespace remote_api
{
    [Api("/students")]
    public class Student : IObjectBase<int>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public void BeforeDelete(Student student)
        {
            // Before Delete hook to make custom validations
        }

    }

    [Api("/teachers")]
    public class Teacher : IObjectBase<int>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public void BeforeCreate(Teacher newTeacher)
        {
            // Before Create hook to make custom validations
        }
    }

    [Api("/courses")]
    public class Course : IObjectBase<int>
    {
        public int Id { get; set; }
        public List<Student> Students { get; set; }
        public Teacher Teacher { get; set; }
        public List<DateTime> Schedule { get; set; }
    }

}
