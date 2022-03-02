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
            Nelinuk neli = new Nelinuk(4, 3);
            neli.Arvu();
            neli.Hommik();
            Console.ReadKey();
        }
    }
}
