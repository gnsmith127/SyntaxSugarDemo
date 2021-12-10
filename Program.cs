using System;

namespace SyntaxSugarDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var answer = 4;
            
            if (answer < 9)
            {
                Console.WriteLine($"{answer} is less than nine");
            }
            else
            {
                Console.WriteLine($"{answer} is greater than or equal to nine"); ;
            }
            Console.WriteLine(answer);
        }
    }
}
