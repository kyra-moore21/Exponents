using System.Reflection.Metadata.Ecma335;
using System.Xml.Serialization;

bool runProgram = true;

Console.WriteLine("Learn your squares and cubes.");

//loop
while (runProgram)
{
    //main program
    Console.WriteLine("Enter an integer:");
    int num1 = int.Parse(Console.ReadLine());

    //validation & max number
    if(num1 <=0)
    {
        Console.WriteLine("Invalid Input");
        continue;
    } else if(num1 >= 1290)
    {
        Console.WriteLine("Number too high, please use a lower number.");
        continue;
    }

    Console.WriteLine($"{"Number", -10}\t{"Squared", -10}\t{"Cubed", -10}");
    Console.WriteLine($"{"=======", -10}\t{"=======",-10}\t{"=======", -10}");
    for(int i = 1; i <= num1; i++)
    {
        Console.WriteLine($"{i,7}{Squared(i),16}{Cubed(i),16}");
        
    }

    //get out of loop
    while (true)
    {
        Console.WriteLine("Continue? (y/n)");
        string choice = Console.ReadLine().ToLower().Trim();
        if (choice == "y")
        {
            break;
        } else if (choice == "n")
        {
            runProgram = false;
            break;
        } else
        {
            Console.WriteLine("Invalid Input");
        }
    }
}

static int Squared(int sq)
{
    return sq * sq;
}
static int Cubed(int cu)
{
    return cu * cu * cu;
}
