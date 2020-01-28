using System;
namespace MobileAppLab1Program2.Classes
{
    public class Teacher : Person
    {
        public int YearsOfService { get; set; }


        public Teacher()
        {
        }

        public override void DisplayPerson()
        {

            Console.WriteLine($"Name: {this.Name}");
            Console.WriteLine($"id: {this.Id}");
            Console.WriteLine($"Age: {this.Age}");
            Console.WriteLine($"Program: {this.Program}");
            Console.WriteLine($"Credits Earned: {this.YearsOfService}");
        }
    }
}
