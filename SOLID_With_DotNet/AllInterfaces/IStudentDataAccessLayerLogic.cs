using SOLID_With_DotNet.AllClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_With_DotNet.AllInterfaces
{
    public interface IStudentDataAccessLayerLogic
    {
        Student GetStudentDetails(int id);
    }
}
