using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace escolhaparesouimpares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("escola entre pares ou impares(1=i e 0=p)");
           int opc= int.Parse(Console.ReadLine());
            int cont = opc;

            while (cont <= 20) 
            {
            Console.WriteLine(cont);
                cont += 2; 
            }
            Console.ReadKey();
        }
    }
}
