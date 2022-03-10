using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO_2
{
    internal class Program
    {

        private const string _sim = "SIM";

        static void Main(string[] args)
        {
            string continuar = string.Empty;
            decimal valorUm = 0.0m;
            decimal valorDois = 0.0m;

            try
            {
                do
                {
                    Console.WriteLine("Informe a operação matematica" + "que deseja efetuar (+, -, *, /,%):");

                    char operacao = char.Parse(Console.ReadLine());
                    switch (operacao)

                    {
                        case '+':
                            Console.WriteLine("informe o primeiro valor da soma:");
                            valorUm = decimal.Parse(Console.ReadLine());

                            Console.WriteLine("informe o segundo valor para a soma:");
                            valorDois = decimal.Parse(Console.ReadLine());

                            Console.WriteLine($" O resultado da soma é {valorUm + valorDois }");
                            break;

                        case '-':
                            Console.WriteLine("informe o primeiro valor da subtração:");
                            valorUm = decimal.Parse(Console.ReadLine());

                            Console.WriteLine("informe o segundo valor para a subtração:");
                            valorDois = decimal.Parse(Console.ReadLine());

                            Console.WriteLine($" O resultado da subtração é {valorUm - valorDois }");
                            break;

                        case '*':
                            Console.WriteLine("informe o primeiro valor da multiplicação:");
                            valorUm = decimal.Parse(Console.ReadLine());

                            Console.WriteLine("informe o segundo valor para a multiplicação:");
                            valorDois = decimal.Parse(Console.ReadLine());

                            Console.WriteLine($" O resultado da multiplicação é {valorUm * valorDois }");
                            break;

                        case '/':
                            Console.WriteLine("informe o primeiro valor da divisão:");
                            valorUm = decimal.Parse(Console.ReadLine());

                            Console.WriteLine("informe o segundo valor para a divisão:");
                            valorDois = decimal.Parse(Console.ReadLine());

                            Console.WriteLine($" O resultado da divisão é {valorUm / valorDois }");
                            break;

                        case '%':
                            Console.WriteLine("informe o primeiro valor do resto da divisão:");
                            valorUm = decimal.Parse(Console.ReadLine());

                            Console.WriteLine("informe o segundo valor do resto da divisão:");
                            valorDois = decimal.Parse(Console.ReadLine());

                            Console.WriteLine($" O resultado do resto da divisão é {valorUm + valorDois }");
                            break;

                        default:
                            throw new Exception("operação matematica não" + "configurada! Verifique.");
                    }

                    Console.WriteLine("Deseja Continuar? [sim/nao]");
                    continuar = Console.ReadLine();


                } while (_sim.Equals(continuar.ToUpper()));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }

            

        }

    }
}