using SOLID_With_DotNet.AllInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_With_DotNet.AllClasses
{
    public class StudentDataAccessLayerLogic : IStudentDataAccessLayerLogic
    {
        public Student GetStudentDetails(int id)
        {
            //throw new NotImplementedException();
            Student student = new Student()
            {
                ID = id,
                Name = "Azhaan Hussain Khan",
                Class = "H1",
                Result = "Pass"
            };
            return student;
        }
    }
}
