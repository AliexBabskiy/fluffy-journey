using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Добро пожаловать. Нажмите на Enter клавишу для запуска.\n");
        while (true)
        {
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                break;
            }
        }

        object choice;
        int result;

        do
        {
            Console.WriteLine("1. Игра \"Угадай число\"");
            Console.WriteLine("2. Таблица умножения ");
            Console.WriteLine("3. Вывод делителей числа");
            Console.WriteLine("4. Выйти из программы");

            while (true)
            {
                Console.WriteLine("Выберите действие:");
                string singl = Console.ReadLine();
                if (int.TryParse(singl, out int number))
                {
                    choice = number;
                    break;
                }

                else
                {
                    Console.WriteLine("Введены некорректные значения. Попробуйте еще раз. \n");
                }
            }

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Игра \"Угадай число\"\n");
                    Ugaday();
                    break;
                case 2:
                    Console.WriteLine("Таблица умножения:\n");
                    Umnoz();

                    break;
                case 3:
                    Console.WriteLine("Вывод делителей числа\n");
                    Delit();
                    break;
                case 4:
                    Console.WriteLine("Завершение работы нажмите Escape.");
                    while (true)
                    {
                        ConsoleKeyInfo key = Console.ReadKey();
                        if (key.Key == ConsoleKey.Escape)
                        {
                            return;
                        }
                    }
                default:
                    Console.WriteLine("Данная функция отсутствует. Попробуйте еще раз. \n");
                    break;
            }

        }
        while (Convert.ToInt32(choice) != 4);

    }
    static void Ugaday()
    {
        Random rnd = new Random();
        int ran = rnd.Next(1, 100);

        int num;
        int n = ran;
        while (true)
        {
            Console.WriteLine("Введите число: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num > n)
            {
                Console.WriteLine("Взять меньше");

            }
            if (num < n)
            {
                Console.WriteLine("Взять больше");

            }
            if (num == n)
            {
                Console.WriteLine("Вено\n");
                return;
            }
        }
    }
    static void Umnoz()
    {
        int i;
        int[,] umn = new int[9, 9] { { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, { 1, 2, 3, 4, 5, 6, 7, 8, 9 } };

        for (int m = 0; m < umn.GetLength(0); m++)
        {
            i = 1 + m;
            for (int n = 0; n < umn.GetLength(1); n++)
            {
                Console.Write(umn[m, n] * i + "\t");
            }
            Console.WriteLine("\n");
        }
    }
    static void Delit()
    {

        Console.WriteLine("Введите число");
        int num = Convert.ToInt32(Console.ReadLine());

        int i = 1;
        var list = new List<int>() { num / i };

        do
        {
            if ((num % i) == 0) // остаток от числа равен нулю
            {
                list.Add(num / i);
            }
            i++;
        }
        while (i <= num);
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}