using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_With_DotNet.AllClasses
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public void Update()
        {
            //Employee Details
            Console.WriteLine("Updating employee with ID: ", this.ID);
        }
    }
    public class EmployeeSalaryCalculator
    {
        public void CalculateSalary()
        {
            //Hours/Role/Bonus
            //Console.WriteLine("Calculating salary for employee: ", Employee.Name);
        }
    }
    public abstract class Notifier
    {
        public abstract void Notify();
    }
    public class EmailNotifier : Notifier
    {
        public override void Notify()
        {
            //Email/SMS/Letter
            Console.WriteLine("Notification Send with Email successfully");
        }
    }
    public class SMSNotifier : Notifier
    {
        public override void Notify()
        {
            //Email/SMS/Letter
            Console.WriteLine("Notification Send with SMS successfully");
        }
    }
    public class LetterNotifier : Notifier
    {
        public override void Notify()
        {
            //Email/SMS/Letter
            Console.WriteLine("Notification Send with Letter successfully");
        }
    }
    public class PhoneNotifier : Notifier
    {
        public override void Notify()
        {
            //Email/SMS/Letter
            Console.WriteLine("Notification Send with Phone successfully");
        }
    }
}
