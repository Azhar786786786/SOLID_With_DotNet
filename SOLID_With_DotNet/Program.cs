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
            person.Name = "Added Person";
            person.InsertedOn = new DateTime(2025, 11, 26);
            person.DoWokr();

            Person eng = new Engineer();
            eng.Name = "Added Engineer";
            eng.InsertedOn = new DateTime(2025, 11, 26);
            eng.DoWokr();

            Person test = new Tester();
            test.Name = "Added Tester";
            test.InsertedOn = new DateTime(2025, 11, 26);
            test.DoWokr();

            Person oth = new Other();
            oth.Name = "Added Other";
            oth.InsertedOn = new DateTime(2025, 11, 26);
            oth.DoWokr();
            //Polymorphism end here

            //Student Dependency Inversion
            StudentBusinessLayerLogic studentBusinessLayerLogic = new StudentBusinessLayerLogic();
            Student student = studentBusinessLayerLogic.GetStudentDetails(101);
            Console.WriteLine($"ID : { student.ID}, " +
                $"Name : {student.Name}, " +
                $"Class : {student.Class}, " +
                $"Result : {student.Result}");

            Console.Read();
        }
    }
}
