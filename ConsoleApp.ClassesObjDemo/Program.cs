Console.WriteLine("Sample");

//Creating an oblect
Person person = new Person();

Console.Write("Enter First Name: ");
person.FirstName = Console.ReadLine();

Console.Write("Enter Last Name: ");
person.LastName = Console.ReadLine();

Console.Write("Enter Age: ");
person.Age = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Salary: ");
double salary = Convert.ToInt32(Console.ReadLine());
person.setSalary(salary);

//Console.WriteLine($"First name is {person.FirstName}");
//Console.WriteLine($"Last name is {person.LastName}");
Console.WriteLine($"Full name is {person.getFullName()}");
Console.WriteLine($"Born year is {person.getBirthYear()}");
Console.WriteLine($"The salary is {person.getSalary()}");