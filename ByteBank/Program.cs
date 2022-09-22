using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {   
            try
            {
                ContaCorrente conta1 = new ContaCorrente(234,1231);
                ContaCorrente conta2 = new ContaCorrente(2342,1231);

                conta1.Depositar(50);
                Console.WriteLine(conta1.Saldo);
                conta1.Transferir(500, conta2);
                Console.WriteLine(conta1.Saldo);

                Metodo();
            } 
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Erro no parâmetro: {ex.ParamName}");
                Console.WriteLine("Ocorreu um tipo de ArgumentException");
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
                

            } catch(SaldoInsuficienteException ex)
            {
                Console.WriteLine("Exceção do tipo SaldoInsuficienteException.");
                Console.WriteLine(ex.Message);
            }
            catch (OperacaoFinanceiraException ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);

                Console.WriteLine("Informações da Inner Exception (exceção interna): ");
                
                Console.WriteLine(ex.InnerException.Message);
                Console.WriteLine(ex.InnerException.StackTrace);
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
