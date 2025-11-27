using SOLID_With_DotNet.AllInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_With_DotNet.AllClasses
{
    public class StudentBusinessLayerLogic
    {
        readonly IStudentDataAccessLayerLogic _IStudentDataAccessLayerLogic;
        public StudentBusinessLayerLogic()
        {
            _IStudentDataAccessLayerLogic = StudentDataAccessLayerFactory.GetStudentDataAccessLayerObj();
        }
        public Student GetStudentDetails(int id)
        {
            return _IStudentDataAccessLayerLogic.GetStudentDetails(id);
        }
    }
}
