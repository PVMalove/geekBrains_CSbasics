﻿using System;
using System.Collections.Generic;

namespace SupportClasses
{
    public class OutputHelpers
    {
        /// <summary>
        /// Метод завершения программы.
        /// </summary>
        public static void Delay()
        {
            Console.SetCursorPosition(0, Console.WindowHeight - 1);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Для завершения программы нажмите любую клавишу...");
            Console.ReadKey();
        }

        /// <summary>
        /// Вывод информации о номере домашней работы, студенте.
        /// </summary>
        /// <param name="homeworkNumber">Номер домашней работы</param>
        /// <param name="fullName">ФИО Студента</param>
        public static void PrintOutStartInformation(int homeworkNumber, string fullName)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("==========================");
            Console.WriteLine($"Домашняя работа. Лекция №{homeworkNumber}");
            Console.WriteLine($"Студент: {fullName}");
            Console.WriteLine("==========================\n");
            Console.ResetColor();
        }

        /// <summary>
        /// Меню задач
        /// </summary>
        /// <param name="count">количество задач</param>
        public static void TasksMenu(int count)
        {
            var task = new List<string>() { "Задача 1", "Задача 2", "Задача 3", "Задача 4",
                "Задача 5", "Задача 6", "Задача 7", "Задача 8", "Задача 9", "Задача 10" };

            if (count <= 10)
            {
                var range = task.GetRange(0, count);
                TextColor("Menu:", ConsoleColor.DarkYellow);

                for (int i = 0; i < range.Count; i++)
                {
                    Console.WriteLine($"[{i + 1}].....{task[i]}");
                }

                TextColor("[0]...Exit", ConsoleColor.Red);
            }
            else
            {
                Console.WriteLine("Ошибка! Неверное количество задач.");
                Console.ReadKey();
            }                
        }

        public static void TextColor(string text, ConsoleColor consoleColor )
        {
            Console.ForegroundColor = consoleColor;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}