using SOLID_With_DotNet.AllClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_With_DotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.ID = 101;
            employee.Name = "Added NewEmplyee";

            Notifier notifier = new SMSNotifier();
            notifier.Notify();

            notifier = new LetterNotifier();
            notifier.Notify();

            notifier = new PhoneNotifier();
            notifier.Notify();

            notifier = new EmailNotifier();
            notifier.Notify();

            //Checking for polymorphism concept
            //PolymorphismClass polymorphismClass = new PolymorphismClass();
            //polymorphismClass.
            Console.WriteLine("============================================================");
            Person person = new Person();
            person.DoWokr();

            Person eng = new Engineer();
            eng.DoWokr();

            Person test = new Tester();
            test.DoWokr();

            Person oth = new Other();
            oth.DoWokr();
            //Polymorphism end here

            Console.Read();
        }
    }
}
