string name = "Roman Reigns";//declaring a variable of type string
Console.WriteLine(name);
Console.WriteLine("I am " + name);//String concatenation
Console.WriteLine($"My name is {name}"); //String interpolation
Console.WriteLine("Name is {0}", name);//Formatted string

//Calculate Birth of Year using age
int age = 24;
int yearOfBirth = DateTime.Now.Year - age;
Console.WriteLine($"My age is {age} and I was born in {yearOfBirth}");

bool isAlive = true;
if (isAlive) Console.WriteLine("He is alive");
else Console.WriteLine("He is dead!");