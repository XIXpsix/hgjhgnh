using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        // Задача 1: Найти k-ю цифру в последовательности 10111213...9899
        static void Task1()
        {
            Console.WriteLine("\n--- Задача 1 ---");
            Console.Write("Введите k (1-180): ");

            if (!int.TryParse(Console.ReadLine(), out int k))
            {
                Console.WriteLine("Ошибка: введите целое число!");
                return;
            }

            if (k < 1 || k > 180)
            {
                Console.WriteLine("Ошибка: k должно быть от 1 до 180");
                return;
            }

            // Строим последовательность из двузначных чисел
            string sequence = "";
            for (int i = 10; i <= 99; i++)
            {
                sequence += i.ToString();
            }

            Console.WriteLine($"Последовательность: {sequence}");
            Console.WriteLine($"{k}-я цифра: {sequence[k - 1]}");
        }

        // Задача 2: Переставить буквы между k-й и s-й в обратном порядке
        static void Task2()
        {
            string word = "информационное"; // слово из 15 букв

            Console.WriteLine("\n--- Задача 2 ---");
            Console.WriteLine($"Исходное слово (15 букв): {word}");
            Console.Write("Введите k и s (k < s, от 1 до 15): ");

            string[] inputs = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            if (inputs.Length < 2)
            {
                Console.WriteLine("Ошибка: введите два числа!");
                return;
            }

            if (!int.TryParse(inputs[0], out int k) || !int.TryParse(inputs[1], out int s))
            {
                Console.WriteLine("Ошибка: введите целые числа!");
                return;
            }

            if (k < 1 || s > 15 || k >= s)
            {
                Console.WriteLine("Ошибка: некорректные значения k и s");
                Console.WriteLine("Требования: 1 <= k < s <= 15");
                return;
            }

            // Сохраняем исходное слово для сравнения
            string original = word;

            // Корректируем индексы (в C# строки индексируются с 0)
            int start = k - 1; // позиция k-й буквы
            int end = s - 1;   // позиция s-й буквы

            Console.Write($"Буквы для перестановки (с {k + 1}-й по {s - 1}-ю): ");
            for (int i = start + 1; i < end; i++)
            {
                Console.Write(word[i]);
            }
            Console.WriteLine();

            // Преобразуем строку в массив char для изменения
            char[] charArray = word.ToCharArray();

            // Переворачиваем часть между k и s (с k+1 по s-1)
            Array.Reverse(charArray, start + 1, end - start - 1);

            word = new string(charArray);

            Console.WriteLine($"Результат: {word}");
        }

        // Задача 3: Найти сумму всех чисел в тексте
        static void Task3()
        {
            Console.WriteLine("\n--- Задача 3 ---");
            Console.Write("Введите текст: ");
            string text = Console.ReadLine();

            int sum = 0;
            string numStr = "";
            int numberCount = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];

                if (char.IsDigit(c))
                {
                    numStr += c; // накапливаем цифры числа
                }
                else
                {
                    if (!string.IsNullOrEmpty(numStr))
                    {
                        int number = int.Parse(numStr);
                        sum += number;
                        numberCount++;
                        Console.WriteLine($"Найдено число: {number}");
                        numStr = "";
                    }
                }
            }

            // Проверяем, осталось ли число в конце строки
            if (!string.IsNullOrEmpty(numStr))
            {
                int number = int.Parse(numStr);
                sum += number;
                numberCount++;
                Console.WriteLine($"Найдено число: {number}");
            }

            if (numberCount == 0)
            {
                Console.WriteLine("В тексте не найдено чисел.");
            }
            else
            {
                Console.WriteLine($"Количество найденных чисел: {numberCount}");
                Console.WriteLine($"Сумма всех чисел: {sum}");
            }
        }

        // Дополнительная задача: Найти сумму чисел с учетом знака минус
        static void Task3_Advanced()
        {
            Console.WriteLine("\n--- Задача 3 (расширенная) ---");
            Console.Write("Введите текст: ");
            string text = Console.ReadLine();

            int sum = 0;
            string numStr = "";
            bool isNegative = false;
            int numberCount = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];

                // Проверяем на знак минус перед числом
                if (c == '-' && i + 1 < text.Length && char.IsDigit(text[i + 1]))
                {
                    isNegative = true;
                    continue;
                }

                if (char.IsDigit(c))
                {
                    numStr += c;
                }
                else
                {
                    if (!string.IsNullOrEmpty(numStr))
                    {
                        int number = int.Parse(numStr);
                        if (isNegative) number = -number;

                        sum += number;
                        numberCount++;
                        Console.WriteLine($"Найдено число: {(isNegative ? "-" : "")}{numStr}");

                        numStr = "";
                        isNegative = false;
                    }
                }
            }

            // Проверяем, осталось ли число в конце строки
            if (!string.IsNullOrEmpty(numStr))
            {
                int number = int.Parse(numStr);
                if (isNegative) number = -number;

                sum += number;
                numberCount++;
                Console.WriteLine($"Найдено число: {(isNegative ? "-" : "")}{numStr}");
            }

            if (numberCount == 0)
            {
                Console.WriteLine("В тексте не найдено чисел.");
            }
            else
            {
                Console.WriteLine($"Количество найденных чисел: {numberCount}");
                Console.WriteLine($"Сумма всех чисел: {sum}");
            }
        }

        // Функция для демонстрации примеров работы
        static void Demo()
        {
            Console.WriteLine("\n=== ДЕМОНСТРАЦИЯ РАБОТЫ ===");

            // Демо задачи 1
            Console.WriteLine("\nЗадача 1 (пример для k=25):");
            int k = 25;
            string sequence = "";
            for (int i = 10; i <= 99; i++)
            {
                sequence += i.ToString();
            }
            Console.WriteLine("Последовательность: 10 11 12 ... 98 99");
            Console.WriteLine($"{k}-я цифра: {sequence[k - 1]}");

            // Демо задачи 2
            Console.WriteLine("\nЗадача 2 (пример для k=3, s=8):");
            string word = "информационное";
            Console.WriteLine($"Исходное слово: {word}");

            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray, 2, 5); // с 3-й по 7-ю (индексы 2-6)
            word = new string(charArray);

            Console.WriteLine($"После перестановки букв с 4-й по 7-ю: {word}");

            // Демо задачи 3
            Console.WriteLine("\nЗадача 3 (пример для текста 'abc123 def45 6gh'):");
            string text = "abc123 def45 6gh";
            Console.WriteLine($"Текст: {text}");

            int sum = 0;
            string numStr = "";
            foreach (char c in text)
            {
                if (char.IsDigit(c))
                {
                    numStr += c;
                }
                else
                {
                    if (!string.IsNullOrEmpty(numStr))
                    {
                        sum += int.Parse(numStr);
                        numStr = "";
                    }
                }
            }
            if (!string.IsNullOrEmpty(numStr))
            {
                sum += int.Parse(numStr);
            }
            Console.WriteLine($"Сумма чисел: {sum}");
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

           
            while (true)
            {
                Console.WriteLine("\n========== МЕНЮ ==========");
                Console.WriteLine("1 - Найти k-ю цифру (10111213...9899)");
                Console.WriteLine("2 - Переставить буквы в слове");
                Console.WriteLine("3 - Найти сумму чисел в тексте");
                Console.WriteLine("4 - Найти сумму чисел (с учетом знака минус)");
                Console.WriteLine("5 - Демонстрация примеров");
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
                        Task3_Advanced();
                        break;
                    case 5:
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