using System;
using ConsoleApp20.Logic;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Практическое занятие №14. Вариант 20");
            Console.WriteLine("Операции со строками\n");

            while (true)
            {
                Console.WriteLine("Выберите задачу:");
                Console.WriteLine("1 - Поменять местами буквы в парах");
                Console.WriteLine("2 - Удалить первую 'о' и последнюю 'л'");
                Console.WriteLine("3 - Переставить первую букву в конец");
                Console.WriteLine("0 - Выход");
                Console.Write("Ваш выбор: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Task1();
                        break;
                    case "2":
                        Task2();
                        break;
                    case "3":
                        Task3();
                        break;
                    case "0":
                        Console.WriteLine("Программа завершена.");
                        return;
                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте снова.\n");
                        break;
                }
            }
        }

        static void Task1()
        {
            Console.Write("\nВведите слово из четного числа букв: ");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Строка не может быть пустой!\n");
                return;
            }

            try
            {
                string result = StringProcessor.SwapPairs(input);
                Console.WriteLine($"Результат: {result}\n");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}\n");
            }
        }

        static void Task2()
        {
            Console.Write("\nВведите слово: ");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Строка не может быть пустой!\n");
                return;
            }

            string result = StringProcessor.ProcessTask2(input);

            // Определяем, были ли удалены символы
            bool removedO = input.IndexOf('о') != -1 || input.IndexOf('o') != -1;
            bool removedL = input.LastIndexOf('л') != -1 || input.LastIndexOf('l') != -1;

            Console.WriteLine($"Результат: {result}");
            Console.WriteLine($"Была удалена первая 'о': {(removedO ? "да" : "нет")}");
            Console.WriteLine($"Была удалена последняя 'л': {(removedL ? "да" : "нет")}\n");
        }

        static void Task3()
        {
            Console.Write("\nВведите слово: ");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Строка не может быть пустой!\n");
                return;
            }

            string result = StringProcessor.MoveFirstToLast(input);
            Console.WriteLine($"Результат: {result}\n");
        }
    }
}