﻿//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
int N = 30, i= 1;
Console.Write($"Чётные числа от 1 до {N} => ");
while (i <= N)
{
    if (i%2 == 0)
    {
       Console.Write($"{i} "); 
    }
    i++;
}
  