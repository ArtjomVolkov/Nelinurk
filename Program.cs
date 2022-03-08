using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nelinurk
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            Console.Write("Sisesta pikkus => ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Sisestage laius => ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Sisesta kõrgus => ");
            c = int.Parse(Console.ReadLine());
            if (a != 0 && b != 0 && c == 0)
            {
                Nelinuk figura = new Nelinuk(a, b, c);
                string tuup = figura.Tuup;
                figura.Task();
            }
            else if (a != 0 && b != 0 && c != 0)
            {
                Nelinuk figura = new Nelinuk(a, b, c);
                string tuup = figura.Tuup;
                figura.Task();
            }
            else
            {
                Console.WriteLine("Figuuri ei eksisteeri!");
            }
            Console.ReadKey();
        }
    }
}
