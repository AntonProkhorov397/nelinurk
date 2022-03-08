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
            Nelinurk Kujund = new Nelinurk();
            Console.WriteLine("Sisetage laius ja kõrgus ");
            Kujund.Laius = double.Parse(Console.ReadLine());
            Kujund.Korgus = double.Parse(Console.ReadLine());
            Kujund.Figura();

            Console.ReadLine();
        }
    }
}
