//Class - blueprint
//Single Responsibility Priciple
public class Person
{
    //public Properties (like nouns)
    public string FirstName { get; set; } //Get and Set are Accessors
    public string LastName { get; set; }
    public int Age { get; set; }
    //Private fields
    private double _salary { get; set; }

    public void setSalary(double value)
    {
        _salary = value;
    }
    public double getSalary()
    {
        return _salary;
    }
    public string getFullName()
    {
        return FirstName + " " + LastName;
    }
    //method overloading
    public string getFullName(string middleName)
    {
        return FirstName + " " + middleName + " " + LastName;
    }
    public int getBirthYear()
    {
        int birthYear = DateTime.Now.Year - Age;
        return birthYear;
    }
}