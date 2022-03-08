using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nelinurk
{
    public class Nelinurk
    {
        double laius;
        double korgus;
        Tuup tuup;

        public Nelinurk() { }
        public Nelinurk(double Laius, double Korgus, Tuup tuup)
        {
            korgus = Laius;
            laius = Korgus;
            this.tuup = tuup;
        }
        public Nelinurk(Tuup tuup)
        {
            this.tuup = tuup;
        }
        public double Laius
        {
            set { laius = value; }
            get { return laius; }
        }
        public double Korgus
        {
            set { korgus = value; }
            get { return korgus; }
        }
        public Tuup Tuup
        {
            get { return tuup; }
        }
        public double Pindala()
        {
            double pindala = laius * korgus;
            return pindala;
        }
        public double Perimetr()
        {
            double P = (laius + korgus) * 2;
            return P;
        }
        public void Figura()
        {
            Console.WriteLine("Ruut/1, ristkülik/2, romb/3 ");
            string symbol = Console.ReadLine();
            if (symbol == "1")
            {
                Nelinurk ruut = new Nelinurk(laius, korgus, Tuup.ruut);
                Console.WriteLine($"Nelinurga ümbermõõt - {ruut.Perimetr()} cm, pindala - {ruut.Pindala()} cm2 ja nelinurga tüüp on {Tuup.ruut}");
            }
            else if (symbol == "2")
            {
                Nelinurk ristkylik = new Nelinurk(laius, korgus, Tuup.ristkylik);
                Console.WriteLine($"Nelinurga ümbermõõt - {ristkylik.Perimetr()} cm, pindala - {ristkylik.Pindala()} cm2 ja nelinurga tüüp on {Tuup.ristkylik}");
            }
            else if (symbol == "3")
            {
                Console.WriteLine("Palun kirjuta rombi pikkus - pindala leidmiseks");
                double pikkus = double.Parse(Console.ReadLine());
                Nelinurk romb = new Nelinurk(laius, korgus, Tuup.romb);
                Console.WriteLine($"Nelinurga ümbermõõt - {romb.Perimetr()} cm, pindala - {pikkus * laius} cm2 ja nelinurga tüüp on {Tuup.romb}");
            }
            else
            {
                Console.WriteLine("Vale andmetüüp");
            }
        }
    }
}
