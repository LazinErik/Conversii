using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Conversii
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nrBinar = "";
            int nrZecimal = 0;
            int putere = 0;
            Console.Write("Numarul in binar este: ");
            nrBinar = Console.ReadLine();
            while (nrBinar.Length > 0)
            {
                nrZecimal += (int.Parse(nrBinar[nrBinar.Length - 1].ToString())) * (int)Math.Pow(2, putere);
                nrBinar = nrBinar.Substring(0, nrBinar.Length - 1);
                putere++;
            }
            Console.WriteLine("Numarul in zecimal este: " + nrZecimal);
        }
    }
}
