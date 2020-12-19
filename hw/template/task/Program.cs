using System;

namespace template
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first, last, step [f_l_h]");
            int[] i = Array.ConvertAll(Console.ReadLine().Split(" "), item => int.Parse(item));
            Progression val = new ArithmeticProgression(i[0], i[1], i[2]);
            val.TemplateMethod();
        }
    }
}
