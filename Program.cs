using System;
class MainProgramm {
  static void Main() {
            string[] mass;
            Console.WriteLine("Введите слова через пробел: ");
            string words = Console.ReadLine();
            mass = words.Split(' ');
            var result = new string[mass.Length];
            var realSize = 0;
            foreach (var value in mass )