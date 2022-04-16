//Declaring 'ants' variable and setting it to 0
int ants = 0;

Console.WriteLine("Hello!");
Console.WriteLine("There are " + ants + " ants in your back garden.");
Console.WriteLine("Type the number of ants you see and press enter");

//Gets the user input and writes to console
ants = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("There is now " + ants + " ants in the garden!");