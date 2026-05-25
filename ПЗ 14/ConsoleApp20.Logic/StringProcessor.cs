using System;
using System.Text;

namespace ConsoleApp20.Logic
{
    public class StringProcessor
    {
        /// <summary>
        /// Задача 1: Поменять местами буквы в парах (первую со второй, третью с четвертой и т.д.)
        /// </summary>
        public static string SwapPairs(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            if (input.Length % 2 != 0)
                throw new ArgumentException("Слово должно иметь четное количество букв");

            char[] chars = input.ToCharArray();
            for (int i = 0; i < chars.Length; i += 2)
            {
                // Меняем местами i и i+1 символы
                char temp = chars[i];
                chars[i] = chars[i + 1];
                chars[i + 1] = temp;
            }

            return new string(chars);
        }

        /// <summary>
        /// Задача 2а: Удалить первую букву 'о' со смещением всех символов влево
        /// </summary>
        public static char[] RemoveFirstO(char[] chars)
        {
            if (chars == null || chars.Length == 0)
                return chars;

            // Ищем первую букву 'о' (русскую или английскую)
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == 'о' || chars[i] == 'o' ||
                    chars[i] == 'О' || chars[i] == 'O') // Добавил заглавные
                {
                    // Сдвигаем ВСЕ символы после i-го на одну позицию влево
                    for (int j = i; j < chars.Length - 1; j++)
                    {
                        chars[j] = chars[j + 1];
                    }
                    // Последний символ заменяем на '_'
                    chars[chars.Length - 1] = '_';
                    break; // Важно! Выходим после первого удаления
                }
            }
            return chars;
        }

        /// <summary>
        /// Задача 2б: Удалить последнюю букву 'л' со смещением всех символов влево
        /// </summary>
        public static char[] RemoveLastL(char[] chars)
        {
            if (chars == null || chars.Length == 0)
                return chars;

            // Ищем последнюю букву 'л' (с конца)
            for (int i = chars.Length - 1; i >= 0; i--)
            {
                if (chars[i] == 'л' || chars[i] == 'l' ||
                    chars[i] == 'Л' || chars[i] == 'L') // Добавил заглавные
                {
                    // Сдвигаем ВСЕ символы после i-го на одну позицию влево
                    for (int j = i; j < chars.Length - 1; j++)
                    {
                        chars[j] = chars[j + 1];
                    }
                    // Последний символ заменяем на '_'
                    chars[chars.Length - 1] = '_';
                    break; // Важно! Выходим после первого удаления (с конца)
                }
            }
            return chars;
        }

        /// <summary>
        /// Задача 2: Комбинированная операция (удалить первую 'о' и последнюю 'л')
        /// </summary>
        public static string ProcessTask2(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            // Копируем строку в массив символов
            char[] chars = input.ToCharArray();

            // Удаляем первую 'о'
            chars = RemoveFirstO(chars);

            // Удаляем последнюю 'л' (из уже измененного массива!)
            chars = RemoveLastL(chars);

            return new string(chars);
        }

        /// <summary>
        /// Задача 3: Переставить первую букву на место последней
        /// </summary>
        public static string MoveFirstToLast(string input)
        {
            if (string.IsNullOrEmpty(input) || input.Length == 1)
                return input;

            char[] chars = input.ToCharArray();
            char firstChar = chars[0];

            // Сдвигаем ВСЕ символы, начиная с 1-го индекса, влево
            for (int i = 0; i < chars.Length - 1; i++)
            {
                chars[i] = chars[i + 1];
            }

            // Последний символ становится первым
            chars[chars.Length - 1] = firstChar;

            return new string(chars);
        }

        /// <summary>
        /// Демонстрационная версия с подробным выводом каждого шага
        /// </summary>
        public static string DemonstrateTask2(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            Console.WriteLine($"Исходная строка: {input}");
            char[] chars = input.ToCharArray();
            Console.WriteLine($"Массив: [{string.Join(", ", chars)}]");

            // Удаление первой 'о'
            Console.WriteLine("\n--- Удаление первой 'о' ---");
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == 'о' || chars[i] == 'o')
                {
                    Console.WriteLine($"Найдена 'о' на позиции {i}");

                    // Сдвиг влево
                    for (int j = i; j < chars.Length - 1; j++)
                    {
                        chars[j] = chars[j + 1];
                        Console.WriteLine($"Сдвиг {j}: [{string.Join(", ", chars)}]");
                    }

                    chars[chars.Length - 1] = '_';
                    Console.WriteLine($"После замены: [{string.Join(", ", chars)}]");
                    break;
                }
            }

            // Удаление последней 'л'
            Console.WriteLine("\n--- Удаление последней 'л' ---");
            for (int i = chars.Length - 1; i >= 0; i--)
            {
                if (chars[i] == 'л' || chars[i] == 'l')
                {
                    Console.WriteLine($"Найдена 'л' на позиции {i}");

                    // Сдвиг влево
                    for (int j = i; j < chars.Length - 1; j++)
                    {
                        chars[j] = chars[j + 1];
                        Console.WriteLine($"Сдвиг {j}: [{string.Join(", ", chars)}]");
                    }

                    chars[chars.Length - 1] = '_';
                    Console.WriteLine($"После замены: [{string.Join(", ", chars)}]");
                    break;
                }
            }

            string result = new string(chars);
            Console.WriteLine($"\nРезультат: {result}");
            return result;
        }
    }
}