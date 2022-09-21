using System;
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
            /*ContaCorrente conta = new ContaCorrente(7480, 874250);
            Console.WriteLine(ContaCorrente.TaxaOperacao);*/
            Metodo();

            Console.ReadLine();
        }
        private static void Metodo()
        {
            try
            {
                TestaDivisao(0);

            } catch (DivideByZeroException excecao)
            {
                Console.WriteLine("Ocorreu um erro. Não é possível dividir um número por 0.");
                Console.WriteLine(excecao.Message);
                Console.WriteLine(excecao.StackTrace);
            }
            
        }

        private static void TestaDivisao(int divisor)
        {
            int resultado = Dividir(10, divisor);
            Console.WriteLine($"Resultado da divisão de 10 por {divisor} é {resultado}");
        }

        private static int Dividir(int numero, int divisor)
        {
            return numero/divisor;
        }
    }
}
