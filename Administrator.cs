using System;

namespace West;

class Administrator
{
    private DateTime _startDate = DateTime.Now;
// autoimplementerare
    public string Name {get; private set;} // setting prop with constractor or change i method which is in class
    public string LastName {get; init;} = ""; // assigned in initializer

    public string FullName {get{return this.Name + " " + this.LastName;}} // getting data from name and lastname readonly

    public int CourseId {get;} // setting data with constractor, the same as readonly.

    public string Test {get; init;} = "Not the best practice"; // object creation only,  its a setter


 public string StartDate 
    {
        get{return _startDate.ToShortDateString();} // return string type
        set{_startDate = DateTime.Parse(value);} // setting the current date-time to field
    }
    // constructor simple
    public Administrator(string name)
    {
       CourseId = new Random().Next(10,100);
        Name  = name;
    }

}
