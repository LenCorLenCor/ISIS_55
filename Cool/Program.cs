﻿using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Введите первое число:");
        double number1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите оператор (+, -, *, /, v):");
        char op = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        double number2 = Convert.ToDouble(Console.ReadLine());
        double result = 0;
        switch (op)
        {
            case '+':
                result = number1 + number2;
                break;
            case '-':
                result = number1 - number2;
                break;
            case '*':
                result = number1 * number2;
                break;
            case '/':
                result = number1 / number2;
                break;
            case 'v':
                result = Math.Sqrt(number1);
                break;
            default:
                Console.WriteLine("Неверный оператор.");
                break;
        }
        Console.WriteLine("Результат: " + result);
        Console.ReadLine();
    }
}