﻿Console.WriteLine("Please enter the value of n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("You've entered: " + n);
for (int i = n; i > 0;)
{
    Console.WriteLine(n);
    if(n % 2 == 0)
    {
        n = n / 2;
    }
    else
    {
        n = n * 3 + 1;
    }

    i = n;
    if(i == 1)
    {
        Console.WriteLine(n);
        break;
    }
}
Console.ReadLine();