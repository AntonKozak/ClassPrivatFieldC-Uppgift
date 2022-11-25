using System;

namespace West;


public abstract class Person // abstract class for future child class structure 
{
    public string Name { get; }
    public int Age { get; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public virtual void Teach()
    {
        Console.WriteLine("This is Tech() method from the Person class");
    }
}



