﻿// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.WriteLine("input numA");
// var numA = Convert.ToInt32(Console.ReadLine());
// var i = 1;
// var result = 0;
// if(numA>0)
// {   
//     for (i <= numA; i++;)
//     {
//         result = result + Math.Pow(i,3);
//         Console.WriteLine(result);
//     }
    
// }
// else
// {
//     for (i >= numA; i++;)
//     {
//      result = result + Math.Pow(i,3);
//      Console.WriteLine(result);
//     }
// }


Console.WriteLine("input numA");
var numA = Convert.ToInt32(Console.ReadLine());
var numB = 1;
if (numA > 0)
{
    while(numB <= numA)
    {
        var square =(Math.Pow(numB,3));
        numB++;
        Console.WriteLine(square);
    }

}
else
    {
        while(numB >= numA)
        {
            var square =(Math.Pow(numB,3));
            numB--;
            Console.WriteLine(square);
        }
    }