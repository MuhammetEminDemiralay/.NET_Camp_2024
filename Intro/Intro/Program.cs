// See https://aka.ms/new-console-template for more information
using Intro.Business;
using Intro.Entities;

Console.WriteLine("Hello, World!");


CourseManager courseManager = new();
Course[] courses = courseManager.GetAll();

for (int i = 0; i < courses.Length; i++)
{
    Console.WriteLine(courses[i].Name + " - " + courses[i].Price + " - " + courses[i].Description);
}