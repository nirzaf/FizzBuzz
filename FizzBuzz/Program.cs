using static System.Console;
using static System.Environment;


WriteLine("Enter initial value");
int x = Convert.ToInt32(ReadLine());
WriteLine("Enter ending value");
int y = Convert.ToInt32(ReadLine());

if (x >= y)
{
    WriteLine("Beginning value cannot be greater than ending value");
    Exit(0);
}


//Fizz buzz solution
for (int i = x; i <= y; i++)
{

    if(i % 3 == 0 && i % 5 == 0)
        WriteLine("Fizz Buzz"); 
    else if (i%5==0)
        WriteLine("Buzz");
    else if(i % 3 == 0)
        WriteLine("Fizz");
    else
    {
        WriteLine(i);
    }
}

ReadKey();