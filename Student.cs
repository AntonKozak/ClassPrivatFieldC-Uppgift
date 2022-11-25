using System;

namespace West;

public class Student : Person // Inheritance from person
{
    readonly string _lesson = "C#";
    private string _lastName = "";
    private string _group = string.Empty;
   
    // getting setting properties
    public string Group
    {
        get { return _group; }
        set
        {
            if (value == String.Empty)
            {
                Console.WriteLine("Can not be empty");
            }
            else
            {
                this._group = value;
            }
        }
    }
    // Getting readonly with some data...
    public string Lesson
    {
        get{return _lesson;}
    }

    // Constractor for the some logic
    public Student(string name, string lastName, int age, string group) : base(name, age)
    {
        _group = group;
        _lastName = lastName;
    }
    // overriting abstract method
    public override void Teach()
    {
        Console.WriteLine($"{Name} is learning: ");
    }
    // Making new properti to make Anton Kozak in the futher
    public string FullName
    {
        get 
        {
            string FullName = Name + " " + _lastName;
            return FullName;
        }
    }
}

