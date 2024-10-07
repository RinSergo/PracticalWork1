using System;

namespace PracticalWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Выберите номер задания:\n" +
                    "1. Разработайте программу, которая принимает четыре числа и находит среднее значение между ними.\n" +
                    "2. Разработайте программу-калькулятор, в которой можно выбрать действие для двух вводимых пользователем чисел:\n" +
                    "   a. сложение\n   b. вычитание\n   c. умножение\n   d. деление\n   e. нахождение остатка (оператор %)\n" +
                    "3. Разработайте программу для конвертации температуры между градусами Цельсия, Кельвина, Фаренгейта.\n" +
                    "4. Разработайте программу, которая позволяет определить имя файла (с расширением) по введенному пути.\n" +
                    "5. Разработайте программу для нахождения самого длинного слова в предложении.\n" +
                    "6. Разработайте программу, которая может перемножить два массива значений.\n" +
                    "7. Разработайте программу, которая может найти максимальное и минимальное число из пяти введенных.\n" +
                    "8. Разработайте программу, которая выводит “пирамиду” из чисел из количества уровней, введенных пользователем.\n" +
                    "9. Часть 2. Напечатать полную таблицу умножения в виде:...\n" +
                    "10. (21) Часть 3. Разработайте программу, которая выполняет следующие действия:\n" +
                    "   1. Складывает цифры целого числа\n   2. Перемножает цифры целого числа\n   3. Вычитает цифры целого числа");
                int userChoice = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (userChoice)
                {
                    case 1:
                        task1();
                        break;
                    case 2:
                        task2();
                        break;
                    case 3:
                        task3();
                        break;
                    case 4:
                        task4();
                        break;
                    case 5:
                        task5();
                        break;
                    case 6:
                        task6();
                        break;
                    case 7:
                        task7();
                        break;
                    case 8:
                        task8();
                        break;
                    case 9:
                        task9();
                        break;
                    case 10:
                        task10();
                        break;
                }
                Console.Clear();
            }
        }

        static void task1()
        {
            Console.WriteLine("Задача 1. Разработайте программу, которая принимает четыре числа и находит среднее значение между ними.");
            Console.WriteLine("Enter the First number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the SecondFirst number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Third number: ");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Fourth number: ");
            int num4 = int.Parse(Console.ReadLine());
            double averageOfNumbers = (num1 + num2 + num3 + num4) / 4.0;
            Console.WriteLine($"The average of {num1}, {num2}, {num3}, {num4} is: {averageOfNumbers}");
            Console.WriteLine("Задача завершена, нажмите на любую клавишу, чтобы вернуться к списку задач:");
            Console.ReadKey();
        }
        static void task2()
        {
            Console.WriteLine("Задача 2. Разработайте программу-калькулятор, в которой можно выбрать действие для двух вводимых пользователем чисел:\n" +
                "   a. сложение\n   b. вычитание\n   c. умножение\n   d. деление\n   e. нахождение остатка (оператор %)");
            Console.WriteLine("Введите два числа (через пробел): ");
            int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int num1 = arr[0];
            int num2 = arr[1];
            Console.WriteLine($"Вы ввели числа: {num1} and {num2} \nКакое действие Выполнить?\n" +
                $"1. Сложение\n2. Вычитание\n3. Умножение\n4. Деление\n5. Нахождение остатка");
            int userChoice = int.Parse(Console.ReadLine());
            switch (userChoice)
            {
                case 1:
                    Console.WriteLine($"Результат: {num1} + {num2} = {num1 + num2}");
                    break;
                case 2:
                    Console.WriteLine($"Результат: {num1} - {num2} = {num1 - num2}");
                    break;
                case 3:
                    Console.WriteLine($"Результат: {num1} * {num2} = {num1 * num2}");
                    break;
                case 4:
                    Console.WriteLine($"Результат: {num1} / {num2} = {Math.Round(((double)num1 / num2), 3)}");
                    break;
                case 5:
                    Console.WriteLine($"Результат: {num1} % {num2} = {num1 % num2}");
                    break;
            }
            Console.WriteLine("Задача завершена, нажмите на любую клавишу, чтобы вернуться к списку задач:");
            Console.ReadKey();
        }
        static void task3()
        {
            Console.WriteLine("Задача 3. Разработайте программу для конвертации температуры между градусами Цельсия, Кельвина, Фаренгейта.");
            Console.WriteLine("Выберите шкалу вводимой температуры: \n" +
               "1. Цельсий\n" +
               "2. Кельвин\n" +
               "3. Фаренгейт");
            int scale1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите показатель температуры (градусы): ");
            double temp = double.Parse(Console.ReadLine());
            Console.WriteLine("Выберите тип шкалы для конвертации: \n" +
                "1. Цельсий\n" +
                "2. Кельвин\n" +
                "3. Фаренгейт");
            int scale2 = int.Parse(Console.ReadLine());
            string scaleOne = "";
            string scaleTwo = "";
            switch (scale1)
            {
                case 1:
                    scaleOne = "Цельсий";
                    break;
                case 2:
                    scaleOne = "Кельвин";
                    break;
                case 3:
                    scaleOne = "Фаренгейт";
                    break;
            }
            switch (scale2)
            {
                case 1:
                    if (scale1 == 2)
                    {
                        temp = temp - 273.15;
                    }
                    if (scale1 == 3)
                    {
                        temp = (temp - 32) * (5 / 9.0);
                    }
                    scaleTwo = "Цельсий";
                    break;
                case 2:
                    if (scale1 == 1)
                    {
                        temp = temp + 273.15;
                    }
                    if (scale1 == 3)
                    {
                        temp = (temp - 32) * (5 / 9.0) + 273.15;
                    }
                    scaleTwo = "Кельвин";
                    break;
                case 3:
                    if (scale1 == 1)
                    {
                        temp = temp * (9 / 5.0) + 32;
                    }
                    if (scale1 == 2)
                    {
                        temp = (temp - 273.15) * (5 / 9.0) + 32;
                    }
                    scaleTwo = "Фаренгейт";
                    break;
            }
            Console.WriteLine($"Вы выбрали: {scaleOne} -> {scaleTwo}\n" +
                $"Результат конвертации: {Math.Round(temp, 1)}");
            Console.WriteLine("Задача завершена, нажмите на любую клавишу, чтобы вернуться к списку задач:");
            Console.ReadKey();
        }
        static void task4()
        {
            Console.WriteLine("Задача 4. Разработайте программу, которая позволяет определить имя файла (с расширением) по введенному пути.");
            Console.WriteLine("Введите путь до файла: ");
            string way = Console.ReadLine();
            string[] subs = way.Split("/");
            string fileName = subs[subs.Length - 1];
            Console.WriteLine($"Имя файла: {fileName}");
            Console.WriteLine("Задача завершена, нажмите на любую клавишу, чтобы вернуться к списку задач:");
            Console.ReadKey();
        }
        static void task5()
        {
            Console.WriteLine("Задача 5. Разработайте программу для нахождения самого длинного слова в предложении.");
            Console.WriteLine("Введите предложение: ");
            string str = Console.ReadLine();
            string[] subs = str.Split(" ");
            string longWord = subs[0];
            foreach (string word in subs)
            {
                if(word.Length > longWord.Length)
                {
                    longWord = word;
                }
            }
            Console.WriteLine($"Самое длинное слово: {longWord}");
            Console.WriteLine("Задача завершена, нажмите на любую клавишу, чтобы вернуться к списку задач:");
            Console.ReadKey();
        }
        static void task6()
        {
            Console.WriteLine("Задача 6. Разработайте программу, которая может перемножить два массива значений.");
            Console.WriteLine("Введите значения для первого массива через пробел: ");
            int[] arr1 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Console.WriteLine("Введите значения для второго массива через пробел: ");
            int[] arr2 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Console.Write("Результат: ");
            for(int i = 0; i < arr1.Length; i++)
            {
                try
                {
                    Console.Write($"{arr1[i] * arr2[i]} ");
                }
                catch
                {
                    Console.WriteLine("Ошибка! Массивы разных размеров, поэтому дальнейшее перемножение невозможно.");
                }
            }
            Console.WriteLine("Задача завершена, нажмите на любую клавишу, чтобы вернуться к списку задач:");
            Console.ReadKey();
        }
        static void task7()
        {
            Console.WriteLine("Задача 7. Разработайте программу, которая может найти максимальное и минимальное число из пяти введенных.");
            Console.WriteLine("Введите пять чисел: ");
            int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int max = arr.Max();
            int min = arr.Min();
            Console.WriteLine($"Максимальное число: {max}");
            Console.WriteLine($"Минимальное число: {min}");
            Console.WriteLine("Задача завершена, нажмите на любую клавишу, чтобы вернуться к списку задач:");
            Console.ReadKey();
        }
        static void task8()
        {
            Console.WriteLine("Задача 8. Разработайте программу, которая выводит “пирамиду” из чисел из количества уровней, введенных пользователем.");
            Console.WriteLine("Введите количество ступеней: ");
            int numOfSteps = Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= numOfSteps; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Задача завершена, нажмите на любую клавишу, чтобы вернуться к списку задач:");
            Console.ReadKey();
        }
        static void task9()
        {
            Console.WriteLine("Задача 1. Часть 2. Напечатать полную таблицу умножения в виде:");
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.Write($"{i} x {j} = {i * j}   ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Задача завершена, нажмите на любую клавишу, чтобы вернуться к списку задач:");
            Console.ReadKey();
        }
        static void task10()
        {
            Console.WriteLine("Задача 21. Часть 3. Разработайте программу, которая выполняет следующие действия:\n" +
                "   1. Складывает цифры целого числа\n   2. Перемножает цифры целого числа\n   3. Вычитает цифры целого числа");
            int num = 0;
            bool b = true;
            while (b)
            {
                Console.WriteLine("Введите целое число: ");
                string str = Console.ReadLine();
                if (int.TryParse(str, out int val))
                {
                    num = int.Parse(str);
                    b = false;
                }
                else
                {
                    Console.WriteLine("Ошибка! Введено не целое число!");
                }
            }
            num = Math.Abs(num);
            Console.WriteLine("Выберите действие:\n" +
                "1. Сложить цифры целого числа\n" +
                "2. Перемножить цифры целого числа\n" +
                "3. Вычесть цифры целого числа");
            int userChoice = int.Parse(Console.ReadLine());
            switch (userChoice)
            {
                case 1:
                    int sum = 0;
                    if (num != 0)
                    {
                        while (num > 0)
                        {
                            sum += num % 10;
                            num /= 10;
                        }
                    }
                    Console.WriteLine($"Сумма цифер целого числа: {sum}");
                    break;
                case 2:
                    int prod = 0;
                    if (num != 0)
                    {
                        prod = 1;
                        while (num > 0)
                        {
                            if ((num % 10) != 0)
                            {
                                prod *= num % 10;
                            }
                            num /= 10;
                        }
                    }
                    Console.WriteLine($"Произведение цифер целого числа: {prod}");
                    break;
                case 3:
                    Console.WriteLine($"К сожалению, в задании не сказано, из чего нужно вычитать цифры числа(");
                    break;
            }
            Console.WriteLine("Задача завершена, нажмите на любую клавишу, чтобы вернуться к списку задач:");
            Console.ReadKey();
        }
    }
}