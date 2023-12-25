//Declare
List<string> names = new List<string>();
string name = "";

//Add values to the list
while (name != "-1")
{
    Console.Write("Enter name: ");
    name = Console.ReadLine();
    if(!string.IsNullOrEmpty(name) && !name.Equals("-1"))
    {
        names.Add(name);
        Console.Write($"{name} was added successfully\n");
    }
}

//Print values in the list
foreach(var item in names)
{
    Console.WriteLine(item);
}