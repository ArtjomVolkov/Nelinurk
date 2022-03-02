using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nelinurk
{
    public class Nelinuk
    {
        int laius;
        int korgus;
        int tuup;
        int pindala;
        int umbermoot;
        public Nelinuk() { }
        public Nelinuk(int korgus, int laius)
        {
            this.korgus = korgus;
            this.laius = laius;

        }
        public int Arvu()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Sisestage nurk {i + 1}: ");
                tuup = int.Parse(Console.ReadLine());
            }
            return tuup;
        }
        public int Pindala()
        {
            pindala = korgus * laius;
            return pindala;
        }
        public int Umbermoot()
        {
            umbermoot = (korgus + laius) * 2;
            return umbermoot;
        }
        public void Hommik()
        {
            Console.WriteLine($"Pindala: {Pindala()}\nÜmbermõõt: {Umbermoot()}");
        }

    }
}
