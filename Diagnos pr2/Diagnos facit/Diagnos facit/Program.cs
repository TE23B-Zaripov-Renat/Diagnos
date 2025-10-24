Console.WriteLine("Vilket Monster vill du spela som?");
Console.WriteLine("1. Pennywise");
Console.WriteLine("2. Megatron");
Console.WriteLine("3. Frankenstein");

string choice = Console.ReadLine();

if (choice == "1")
{
    Pennywise player = new();
}

else if (choice == "2")
{
    Megatron player = new();
}
else if (choice == "3")
{
    Frankenstein player = new();
}