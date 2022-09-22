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
            try 
            { 
                ContaCorrente conta = new ContaCorrente(0,0);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Erro no parâmetro: {ex.ParamName}");
                Console.WriteLine("Ocorreu um tipo de ArgumentException");
                Console.WriteLine(ex.Message);
            }
            
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
                TestaDivisao(2); 
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
