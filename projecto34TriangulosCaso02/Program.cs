using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecto34TriangulosCaso02
{
    class Program
    {
        static void Main(string[] args)
        {
            int limite = 9;
            string espacio = "";
            for (int i = 1; i <= 9; i++)
            {
                for (int x = 1; x <= limite; x++)
                {

                    Console.Write("*");
                }
                espacio = espacio + " ";
                limite = limite - 1;
                Console.WriteLine();
                Console.Write(espacio);
            }


            Console.ReadKey();


        }
    }
}
