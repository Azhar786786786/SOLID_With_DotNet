using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_With_DotNet.AllClasses
{
    class PolymorphismClass
    {
    }
    class Person
    {
        public string Name { get; set; }
        public DateTime InsertedOn { get; set; }
        public virtual void DoWokr()
        {
            Console.WriteLine("Person work running");
        }
    }
    class Engineer : Person
    {
        public override void DoWokr()
        {
            base.DoWokr();
        }
    }

    class Tester : Person
    {
        public override void DoWokr()
        {
            //base.DoWokr();
            Console.WriteLine("Tester work running");
        }
    }

    class Other : Person
    {
        public new void DoWokr()
        {
            //base.DoWokr();
            Console.WriteLine("Other work running");
        }
    }
}
