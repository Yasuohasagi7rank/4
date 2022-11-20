using System;

namespace _3._15
{
    class Program
    {
        static void Main(string[] args)
        {
            bool A, B, C;
            bool Aitog, Bitog, Citog;
            A = true;
            B = false;
            C = false;

            Aitog = !A || !B;
            Bitog = A & (A || !B);
            Citog = (!A || B) & B;

            Console.WriteLine("Результат: \n{0} \n{1} \n{2} ", Aitog, Bitog, Citog);
            Console.ReadLine();
        }
    }
}
