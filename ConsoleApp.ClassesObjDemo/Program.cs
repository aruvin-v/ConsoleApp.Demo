Console.WriteLine("Sample");
string middleName = string.Empty;
//Creating an oblect
Person person = new Person();

Console.Write("Enter First Name: ");
person.FirstName = Console.ReadLine();

Console.Write("Enter Middle Name: ");
middleName = Console.ReadLine();

Console.Write("Enter Last Name: ");
person.LastName = Console.ReadLine();

Console.Write("Enter Age: ");
person.Age = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Salary: ");
double salary = Convert.ToInt32(Console.ReadLine());
person.setSalary(salary);

if (string.IsNullOrEmpty(middleName))
{
    Console.WriteLine($"Full name is {person.getFullName()}");
}
else
{
    Console.WriteLine($"Full name is {person.getFullName(middleName)}");
}

//Console.WriteLine($"First name is {person.FirstName}");
//Console.WriteLine($"Last name is {person.LastName}");
Console.WriteLine($"Born year is {DateUtil.YearOfBirth(person.Age)}");
Console.WriteLine($"The salary is ${person.getSalary()}");