using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nelinurk
{
    public class Nelinurkk
    {
        double korgus, laius;
        Tuup tuup;

        public Nelinurkk() { }
        public Nelinurkk(double Korgus, double Laius, Tuup tuup)
        {
            korgus = Korgus;
            laius = Laius;
            this.tuup = tuup;
        }
        public Nelinurkk(Tuup tuup)
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
            double pindala = korgus * laius;
            return pindala;
        }
        public double Perimetr()
        {
            double P = korgus * 2 + laius * 2;
            return P;
        }
        public void Figura()
        {
            Console.WriteLine("Ruut/1, ristkülik/2, romb/3 ");
            string symbol = Console.ReadLine();
            if (symbol == "1")
            {
                Nelinurkk ruut = new Nelinurkk(korgus, laius, Tuup.ruut);
                Console.WriteLine($"Nelinurga ümbermõõt - {ruut.Perimetr()} cm, pindala - {ruut.Pindala()} cm2 ja nelinurga tüüp on {Tuup.ruut}");
            }
            else if (symbol == "2")
            {
                Nelinurkk ristkylik = new Nelinurkk(korgus, laius, Tuup.ristkylik);
                Console.WriteLine($"Nelinurga ümbermõõt - {ristkylik.Perimetr()} cm, pindala - {ristkylik.Pindala()} cm2 ja nelinurga tüüp on {Tuup.ristkylik}");
            }
            else if (symbol == "3")
            {
                Console.WriteLine("Palun kirjuta rombi pikkus - pindala leidmiseks");
                double pikkus = double.Parse(Console.ReadLine());
                Nelinurkk romb = new Nelinurkk(korgus, laius, Tuup.romb);
                Console.WriteLine($"Nelinurga ümbermõõt - {romb.Perimetr()} cm, pindala - {pikkus * laius} cm2 ja nelinurga tüüp on {Tuup.romb}");
            }
            else
            {
                Console.WriteLine("Vale andmetüüp");
            }
        }
    }
}
