using System;

namespace GitRepoDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to simulate new Git repository with Student Console application.");
            Student student = new Student("Md.Tanvir","Rahman","Anik");
            Console.WriteLine(student.GetFullName());
            Console.ReadKey();
        }
    }
}
