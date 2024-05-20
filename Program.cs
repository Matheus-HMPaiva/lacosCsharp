using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacosIterativos
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 5; i++ )
            {
                Console.WriteLine("Valor de i é " + i);
            }

            int cont = 3;
            while(cont < 10)
            {
                Console.WriteLine(cont);
                cont ++;
            }
            double j =10;
            do 
            {
                    Console.WriteLine(j);
                    j = j*1.5;

            }while(j<100);
            //Foreach
            // Percorre todos os elementos de um conjunto
            int[] conjunto = { 1, 2, 3, 4};
            foreach(int numero in conjunto)
            {
                Console.WriteLine("Esse elemento do conjunto tem valor " + numero + "! Somando esse valor a 10 temos " + (numero+10));
            }

        }
    }
}