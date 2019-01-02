using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] chiffres = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            for (int i = 10; i > 0; i -= 1)
            {
                Console.WriteLine(chiffres[i]);
            }
        }
    }
}
