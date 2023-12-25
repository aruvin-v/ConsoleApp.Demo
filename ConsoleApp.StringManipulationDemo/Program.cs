string firstName = "Samuel";
string lastName = "Maxson";

//Concatenation
string fullName = firstName +" " + lastName;

//String length
int length = firstName.Length;
Console.WriteLine($"Your first name contains {length} characters");

//Replace string
string newName = firstName.Replace('S', 'D');
Console.WriteLine($"The new name is {newName}");

//Split string
string[] splitName = fullName.Split(' ');
for(int i = 0; i < splitName.Length; i++)
{
    Console.WriteLine(splitName[i]);
}

//Compare strings
string sampleStr = null;
if (string.IsNullOrEmpty(sampleStr))
{
    Console.WriteLine("String is null");
}
if(firstName != lastName)
{
    Console.WriteLine("Names are distinct");
}

