using SOLID_With_DotNet.AllInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_With_DotNet.AllClasses
{
    public class StudentDataAccessLayerFactory
    {
        public static IStudentDataAccessLayerLogic GetStudentDataAccessLayerObj()
        {
            return new StudentDataAccessLayerLogic();
        }
    }
}
