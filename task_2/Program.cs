﻿
  //Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

// ВАРИАНТ РЕШЕНИЯ task_1 С ИСПОЛИЗОВАНИЕМ МЕТОДА 

void Ansve(int result)
{
    
    int num1 = result / 1000;
    int last = result % 10;
    int last2 = result /10 % 10;
    int num2 = last*10+last2; 
        if(num1==num2)
            Console.WriteLine($"{result}=> is polindrom ");
        else
        {
            Console.WriteLine($"{result}=> is NOT a polindrom ");
        }
}

Console.WriteLine("input 5-dig number: ");
int number = Convert.ToInt32(Console.ReadLine());
    if(number < 10000 || number > 100000)
    {
        Console.WriteLine($"{number} => is not 5-digit number!!!");
    }
    else
    {
        Ansve(number);
    }