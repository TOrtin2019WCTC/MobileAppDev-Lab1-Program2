using System;
using System.Collections.Generic;
using MobileAppLab1Program2.Classes;

namespace MobileAppLab1Program2
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            List<Person> People = new List<Person>();
            string Name;
            string Age;
            string Id;
            Program Program;
            string ans;

            do
            {


                Console.WriteLine("1. Student");
                Console.WriteLine("2. Teacher");
                Console.WriteLine("3. Exit");
                ans = Console.ReadLine();




                if (ans.Equals("1") || ans.Equals("2"))
                {


                    Console.WriteLine("Enter Name:");
                    Name = Console.ReadLine();
                    Console.WriteLine("Enter Age:");
                    Age = Console.ReadLine();
                    Console.WriteLine("Enter Id: ");
                    Id = Console.ReadLine();
                    Console.WriteLine("Enter Program:");
                    int programNum = 1;
                    foreach (Program p in Enum.GetValues(typeof(Program)))
                    {
                        Console.WriteLine($"{programNum}: {p}");
                        programNum++;
                    }
                    string response = Console.ReadLine();
                    switch (response)
                    {
                        case "1":
                            Program = Program.IT;
                            break;
                        case "2":
                            Program = Program.Business;
                            break;
                        case "3":
                            Program = Program.Accounting;
                            break;
                        case "4":
                            Program = Program.Culinary;
                            break;
                        default:
                            Program = Program.Undeclared;
                            break;

                    }


                    switch (ans)
                    {
                        case "1":
                            Student student = new Student();
                            student.Name = Name;
                            student.Age = Age;
                            student.Id = Id;
                            student.Program = Program;

                            Console.WriteLine("Enter Credits Earned:");
                            student.CreditsEarned = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"{student.Name} added");
                            People.Add(student);

                            break;

                        case "2":
                            Teacher teacher = new Teacher();
                            teacher.Name = Name;
                            teacher.Age = Age;
                            teacher.Id = Id;
                            teacher.Program = Program;

                            Console.WriteLine("Enter years of service");
                            teacher.YearsOfService = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"{teacher.Name} added");
                            People.Add(teacher);

                            break;



                    }
                }
            } while (ans.Equals("1") || ans.Equals("2"));




            foreach (Person p in People)
            {
                p.DisplayPerson();
                Console.WriteLine("----------");
            }



        }
    }
}
