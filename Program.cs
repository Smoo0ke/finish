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
            {
                if (value.Length <= 3)
                {
                    result[realSize] = value;
                    realSize++;
                }
            }
            Console.WriteLine("Слов до 3 сиволов в строке: " + string.Join(null+' ', result, 0, realSize));
            Console.ReadKey(true);
  }
}
