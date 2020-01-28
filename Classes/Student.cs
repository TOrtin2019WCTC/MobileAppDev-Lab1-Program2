using System;
namespace MobileAppLab1Program2.Classes
{
    public class Student : Person
    {
        public int CreditsEarned { get; set; }


        public Student()
        {

        }

        public override void DisplayPerson()
        {

            Console.WriteLine($"Name: {this.Name}");
            Console.WriteLine($"id: {this.Id}");
            Console.WriteLine($"Age: {this.Age}");
            Console.WriteLine($"Program: {this.Program}");
            Console.WriteLine($"Credits Earned: {this.CreditsEarned}");
        }


    }
}
