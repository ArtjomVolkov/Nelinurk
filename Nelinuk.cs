using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nelinurk
{
    public class Nelinuk
    {
        int pikkus;
        int korgus;
        int pindala;
        int laius;
        bool g;
        string type;
        double ombermoot;
        int[] tuup = new int[4];
        public Nelinuk() { }
        public Nelinuk(int pikkus, int laius, int korgus)
        {
            this.pikkus = pikkus;
            this.laius = laius;
            this.korgus = korgus;
        }
        public Nelinuk(int pikkus, int korgus)
        {
            this.pikkus = pikkus;
            this.korgus = pikkus;
        }
        public string Tuup
        {
            get
            {
                if (pikkus == laius && korgus == 0)
                {
                    type = "Ruut";
                }
                else if (pikkus != laius)
                {
                    type = "Ristkülik";
                }
                else if (tuup[0] + tuup[1] == 180 || tuup[0] + tuup[2] == 180)
                {
                    type = "Parallelogramm";
                }
                return type;
            }

        }
        public bool Figura
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < tuup.Length; i++)
                {
                    sum += tuup[i];

                }
                if (sum != 360)
                {
                    g = true;
                }
                else
                {
                    g = false;
                }
                return g;
            }

        } 
        public double Pindala()
        {
            if (type == "Ruut" )
            {
                pindala = pikkus * pikkus;
                Console.WriteLine($"Nelinurga tüüp => Ruut");
            }
            else if (type == "Ristkülik")
            {
                pindala = pikkus * laius;
                Console.WriteLine($"Nelinurga tüüp => Ristkülik");
            }
            else if (type == "Parallelogramm")
            {
                pindala = korgus * pikkus;
                Console.WriteLine($"Nelinurga tüüp => Parallelogramm");
            }
            else
            {
                Console.WriteLine("Figuuri ei eksisteeri!");
            }
            return pindala;
        }
        public double Ombermoot()
        {
            ombermoot = (pikkus + laius) * 2;
            return ombermoot;
        }
        public void Task()
        {
            if (g == false)
            {
                Console.WriteLine($"Pindala: {Pindala()}\nÕmbermõõt: {Ombermoot()}");
            }
            else if (g == true)
            {
                Console.WriteLine("Figuuri ei eksisteeri!");
            }

        }
    }
}
