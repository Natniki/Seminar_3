//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("input 5-dig number: ");
int number = Convert.ToInt32(Console.ReadLine());
    if(number < 10000 || number > 100000)
    {
        Console.WriteLine($"{number} => is not 5-digit number!!!");
    }
    else
    {
        int result =  number;
        int num1 = result / 10000;
        int num2 = result / 1000 % 10;
        int num11 = result % 10;
        int num22 = result /10 % 10;
            if(num1==num11 || num2==num22)
                Console.WriteLine($"{number}=> is polindrom ");
            else
            {
                Console.WriteLine($"{number}=> is NOT a polindrom ");
            }
    }

    







   
        