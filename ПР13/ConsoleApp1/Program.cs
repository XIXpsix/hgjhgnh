using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        // Задача 1: Найти n-ю цифру в последовательности 0123456789101112...1920
        static void Task1()
        {
            Console.WriteLine("\n--- Задача 1 ---");
            Console.Write("Введите n (1-32): ");

            if (!int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine("Ошибка: введите целое число!");
                return;
            }

            if (n < 1 || n > 32)
            {
                Console.WriteLine("Ошибка: n должно быть от 1 до 32");
                return;
            }

            // Строим последовательность из 0 и 20 первых натуральных чисел (0..20)
            string sequence = "";
            for (int i = 0; i <= 20; i++)
            {
                sequence += i.ToString();
            }

            Console.WriteLine($"Последовательность: {sequence}");
            Console.WriteLine($"Длина последовательности: {sequence.Length} цифр");
            Console.WriteLine($"{n}-я цифра: {sequence[n - 1]}");
        }

        // Задача 2: Переставить буквы между 2-й и 10-й в обратном порядке (с 3-й по 9-ю)
        static void Task2()
        {
            string word = "программирование"; // слово из 12 букв — замените своим

            // Обрезаем до 12 букв если длиннее
            if (word.Length > 12)
                word = word.Substring(0, 12);

            Console.WriteLine("\n--- Задача 2 ---");
            Console.WriteLine($"Слово из 12 букв: {word}");
            Console.WriteLine($"Длина слова: {word.Length}");

            // Буквы между 2-й и 10-й — это с 3-й по 9-ю (индексы 2..8)
            int start = 2; // индекс 3-й буквы (0-based)
            int end = 8;   // индекс 9-й буквы (0-based)
            int length = end - start + 1; // количество букв для переворота

            Console.Write($"Буквы с 3-й по 9-ю (до): ");
            for (int i = start; i <= end; i++)
                Console.Write(word[i]);
            Console.WriteLine();

            // Преобразуем в массив и переворачиваем нужный участок
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray, start, length);
            word = new string(charArray);

            Console.Write($"Буквы с 3-й по 9-ю (после): ");
            for (int i = start; i <= end; i++)
                Console.Write(word[i]);
            Console.WriteLine();

            Console.WriteLine($"Результат: {word}");
        }

        // Задача 3: Напечатать все цифры, имеющиеся в тексте
        static void Task3()
        {
            Console.WriteLine("\n--- Задача 3 ---");
            Console.Write("Введите текст: ");
            string text = Console.ReadLine();

            List<char> digits = new List<char>();

            foreach (char c in text)
            {
                if (char.IsDigit(c))
                {
                    digits.Add(c);
                }
            }

            if (digits.Count == 0)
            {
                Console.WriteLine("В тексте цифр не найдено.");
            }
            else
            {
                Console.Write("Найденные цифры: ");
                foreach (char d in digits)
                {
                    Console.Write(d + " ");
                }
                Console.WriteLine();
                Console.WriteLine($"Всего цифр: {digits.Count}");
            }
        }

        // Демонстрация всех задач с примерами
        static void Demo()
        {
            Console.WriteLine("\n=== ДЕМОНСТРАЦИЯ РАБОТЫ ===");

            // Демо задачи 1
            Console.WriteLine("\nЗадача 1 (пример для n=15):");
            string sequence = "";
            for (int i = 0; i <= 20; i++)
                sequence += i.ToString();
            Console.WriteLine($"Последовательность: {sequence}");
            Console.WriteLine($"15-я цифра: {sequence[14]}");

            // Демо задачи 2
            Console.WriteLine("\nЗадача 2:");
            string word = "программиров";
            Console.WriteLine($"Исходное слово: {word}");
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray, 2, 7); // индексы 2..8, длина 7
            word = new string(charArray);
            Console.WriteLine($"После перестановки букв с 3-й по 9-ю: {word}");

            // Демо задачи 3
            Console.WriteLine("\nЗадача 3 (пример для текста 'abc1 de23f 4gh'):");
            string text = "abc1 de23f 4gh";
            Console.Write("Цифры в тексте: ");
            foreach (char c in text)
            {
                if (char.IsDigit(c))
                    Console.Write(c + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            while (true)
            {
                Console.WriteLine("\n========== МЕНЮ ==========");
                Console.WriteLine("1 - Найти n-ю цифру (0 1 2 ... 19 20)");
                Console.WriteLine("2 - Переставить буквы в слове (с 3-й по 9-ю)");
                Console.WriteLine("3 - Напечатать все цифры из текста");
                Console.WriteLine("4 - Демонстрация примеров");
                Console.WriteLine("0 - Выход");
                Console.WriteLine("===========================");
                Console.Write("Выберите задачу: ");

                string input = Console.ReadLine();

                if (!int.TryParse(input, out int choice))
                {
                    Console.WriteLine("Ошибка: введите число!");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Task1();
                        break;
                    case 2:
                        Task2();
                        break;
                    case 3:
                        Task3();
                        break;
                    case 4:
                        Demo();
                        break;
                    case 0:
                        Console.WriteLine("\nПрограмма завершена. Спасибо за использование!");
                        return;
                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте снова.");
                        break;
                }

                Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                Console.ReadKey();
            }
        }
    }
}