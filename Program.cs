using System;
using System.Collections.Generic;

namespace West;

 public class Program
{
    static void Main(string[] args)
    {
        var teacher = new Teacher("Michael", 45, "Programmering", "C#");// reference till class Teacher
        Console.WriteLine($"Teacher is: {teacher.Name} Age:{teacher.Age} Can:{teacher.GetLesson()}");
        teacher.Teach();

        var student = new Student("Anton","Kozak", 31, "WU22");
        Console.WriteLine("Group: " + student.Group);

        List<Student> students = new List<Student>();
        students.Add(student);

         Console.WriteLine($"Student {students.Count} is:{student.FullName} Age:{student.Age} Group:{student.Group} Learning:{student.Lesson}");

         var admin = new Administrator("Kim")// constructor 
         {
            LastName = "Svensson", // initializing
            Test = "Test init" 
         };
         
         Console.WriteLine($"{admin.Test} {admin.FullName} administrator. He gonna check course:{admin.CourseId} and it is {teacher.GetLesson()} group: {student.Group} with amount of students:{students.Count}.");

    }
}
