using System;
namespace MobileAppLab1Program2.Classes
{
    public abstract class Person
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string Age { get; set; }
        public Program Program { get; set; }

        public abstract void DisplayPerson();


    }
}
