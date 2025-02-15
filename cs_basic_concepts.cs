using System;
using static System.Console;

class Program
{
    static void Main()
    {
        WriteLine("Выберите задание:\n1. Вычислить a^n\n2. Найти число n после манипуляций с числом x");
        Write("Введите номер задания (1 или 2): ");
        int choice = int.Parse(ReadLine());

        if (choice == 1)
        {
            // Задание 1: Вычисление a в степени n
            Write("Введите основание степени a: ");
            int baseNumber = int.Parse(ReadLine());

            Write("Введите показатель степени n: ");
            int exponent = int.Parse(ReadLine());

            int powerResult = Power(baseNumber, exponent);
            WriteLine($"{baseNumber}^{exponent} = {powerResult}");
        }
        else if (choice == 2)
        {
            // Задание 2: Нахождение числа n после манипуляций с числом x
            Write("Введите число x (x >= 100): ");
            string inputNumber = ReadLine();

            if (inputNumber.Length < 3)
            {
                WriteLine("Число x должно быть не менее 3 цифр.");
                return;
            }

            char secondDigit = inputNumber[1];
            string numberWithoutSecondDigit = inputNumber.Remove(1, 1);
            string resultNumber = numberWithoutSecondDigit + secondDigit;

            WriteLine($"Полученное число: {resultNumber}");
        }
        else
        {
            WriteLine("Неверный выбор. Пожалуйста, выберите 1 или 2.");
        }
    }

    // Метод для вычисления степени числа
    static int Power(int baseNumber, int exponent)
    {
        int result = 1;
        for (int iterationNumber = 0; iterationNumber < exponent; ++iterationNumber)
        {
            result *= baseNumber;
        }
        return result;
    }
}
