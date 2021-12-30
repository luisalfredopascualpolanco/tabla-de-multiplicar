using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto10._9
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int numero, posicion;
                Console.Write("Cual tabla quiere ver? ");
                numero = int.Parse(Console.ReadLine());
                for (int i = 0; i < 13; i++)
                {
                    posicion = i + 1;
                    Console.WriteLine(posicion+" x "+numero+" = "+(posicion*numero));
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Ha introducido un dato invalido.");             
            }
            Console.ReadKey();
        }
    }
}
