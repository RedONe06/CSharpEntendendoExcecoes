﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Metodo();
            } 
            catch (Exception exception)
            {
                Console.Write(exception.Message);
                Console.Write(exception.StackTrace);

            }

            Console.ReadLine();
        }
        private static void Metodo()
        {
                TestaDivisao(0); 
        }

        private static void TestaDivisao(int divisor)
        {
            int resultado = Dividir(10, divisor);
            Console.WriteLine($"Resultado da divisão de 10 por {divisor} é {resultado}");
        }

        private static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero/divisor;
            }
            catch
            {
                Console.WriteLine($"Exceção com número = {numero} e divisor = {divisor}");
                throw;
            }
        }
    }
}
