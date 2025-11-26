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

            Console.Read();
        }
    }
}
