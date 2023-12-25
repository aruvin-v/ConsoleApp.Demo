//Declaring the variables
string firstName = string.Empty;
string lastName = string.Empty;
int age;
int retirementAge;
int yearOfBirth;
int remainingWorkYears;
decimal salary;
char gender;
bool working = true;

//Prompt the user for input
Console.Write("Please enter your Firstname: ");
firstName = Console.ReadLine();

Console.Write("Please enter your Lastname: ");
lastName = Console.ReadLine();

Console.Write("Please enter your age: ");
age = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter your salary: $");
salary = Convert.ToDecimal(Console.ReadLine());

Console.Write("Please enter your gender(M or F): ");
gender = Convert.ToChar(Console.ReadLine());

Console.Write("Are you working? (true or falses): ");
working = Convert.ToBoolean(Console.ReadLine());

//Process the data
retirementAge = 60;
yearOfBirth = DateTime.Now.Year - age;
remainingWorkYears = retirementAge - age;

//Printing the details to the User
Console.WriteLine("----------Employee Details----------");
Console.WriteLine($"Full Name: {firstName} {lastName}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Year of Birth: {yearOfBirth}");
Console.WriteLine($"Working Years Remaining: {remainingWorkYears}");
Console.WriteLine($"Salary: ${salary}");
if (gender == 'M') Console.WriteLine("Gender: Male");
else if (gender == 'F') Console.WriteLine("Gender: Female");
else Console.WriteLine("Gender: Unknown");
if (working) Console.WriteLine("Working: Yes");
else Console.WriteLine("Working: No");