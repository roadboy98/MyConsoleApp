using System;
using Ants;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Declaring 'ants' variable and setting it to 0
int ants = 0;

//Intro
Console.WriteLine("Hello!");
Console.WriteLine("There are " + ants + " ants in your back garden.");
Console.WriteLine("Type the number of ants you see and press enter");

//Gets the user input and writes to console
ants = Convert.ToInt32(Console.ReadLine());

//Displays the number of updated ants to the user
Console.WriteLine("There is now " + ants + " ants in the garden!");

//Displays the ants health
Console.WriteLine("The ants health is " + Convert.ToInt32(AntsHealth.anthealth));

Console.WriteLine("Type '1' to take 50 health off the ant");

if (Console.ReadLine() == "1")
{
    AntsHealth.anthealth = 50;

    Console.WriteLine("You took 50 health off the ant!");
    Console.WriteLine("The ants health is now " + AntsHealth.anthealth);

} else
{
    Console.WriteLine("You entered the wrong number!");
}

