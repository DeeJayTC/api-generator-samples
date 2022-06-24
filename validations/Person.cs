using TCDev.APIGenerator.Attributes;
using TCDev.APIGenerator.Data;
using TCDev.APIGenerator.Hooks;
using TCDev.APIGenerator.Interfaces;

namespace remote_api
{
    [Api("/students")]
    public class Student : IObjectBase<int>, IBeforeCreate<Student>, IBeforeDelete<Student>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        //################# Validation Sample #################
        public Task<Student> BeforeCreate(Student newItem, IApplicationDataService<GenericDbContext, AuthDbContext> data)
        {
            // always set last name 
            newItem.LastName = "holla!";
            return Task.FromResult(newItem);
        }

        public Task<bool> BeforeDelete(Student item, IApplicationDataService<GenericDbContext, AuthDbContext> data)
        {
           // Delete is only allowed if not in any courses
           if(data.GenericData.Set<Course>().Any(p=>p.Students.Any(p=>p.Id == item.Id))){
                return Task.FromResult(false);
            }
            return Task.FromResult(true);
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
