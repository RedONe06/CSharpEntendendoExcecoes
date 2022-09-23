using System;
using System.IO;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {   
            try
            {
                CarregarContas();
                Metodo();
                Console.ReadLine();

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

        private static void CarregarContas()
        {
            LeitorDeArquivo leitor = new LeitorDeArquivo("contas.txt");
            try
            {
                
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();

                leitor.Fechar();

            } catch(IOException ex)
            {
                Console.WriteLine("Exceção do tipo IOException capturada e tratada!");
            }
            finally
            {
                leitor.Fechar();
            }
            
        }
    }
}
