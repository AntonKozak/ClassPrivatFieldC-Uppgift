using System;

namespace West;

public class Teacher : Person
{
    private readonly string _lesson;
    readonly string _language;
    // Constructor for initializing private and base class 
    public Teacher(string name, int age, string lesson, string language) : base(name, age)
    {
        _lesson = lesson;
        _language = language;
    }
    // Method which is override 
    public override void Teach()
    {
        Console.WriteLine($"{Name} is teaching:{_language}");
    }
    // method return string type 
    public string GetLesson()
    {
        return _lesson;
    }
}


