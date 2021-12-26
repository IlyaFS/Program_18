using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "([]{})[]";
            Stack<char> lesson18 = new Stack<char>();


            foreach (char c in s)
            {
                if (c == '[')
                    lesson18.Push(']');
                if (c == '(')
                    lesson18.Push(')');
                if (c == '{')
                    lesson18.Push('}');
                if (c == ']' || c == ')' || c == '}')
                    lesson18.Pop();
            }
            if (lesson18.Count != 0)
                Console.WriteLine("Внимание! Скобки рассталены не правильно");
            else
            {
                Console.WriteLine("Скобки рассталены правильно");
            }
            Console.ReadKey();
        }
    }

}


// Дана строка, содержащая скобки трёх видов (круглые, квадратные и фигурные) и любые другие символы. Проверить, корректно ли в ней расставлены скобки.
//    Например, в строке ([]{ })[] скобки расставлены корректно, а в строке ([]] — нет.
//    Указание: задача решается однократным проходом по символам заданной строки слева направо;
//для каждой открывающей скобки в строке в стек помещается соответствующая закрывающая,
//    каждая закрывающая скобка в строке должна соответствовать скобке из вершины стека (при этом скобка с вершины стека снимается);
//в конце прохода стек должен быть пуст.