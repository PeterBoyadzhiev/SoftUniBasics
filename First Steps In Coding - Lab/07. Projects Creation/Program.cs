using System;

namespace _07._Projects_Creation
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfTheArchitect = Console.ReadLine();
            int numberOfProjects = int.Parse(Console.ReadLine());
            int timeForProject = 3;
            int TotalTime = numberOfProjects * timeForProject;
            Console.WriteLine($"The architect {nameOfTheArchitect} will need {TotalTime} hours to complete {numberOfProjects} project/s.");
        }
    }
}
