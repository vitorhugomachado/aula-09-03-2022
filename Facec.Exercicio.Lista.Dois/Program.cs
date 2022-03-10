using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facec.Exercicio.Lista.Dois
{
    internal class Program
    {
        static void Main(string[] args)

        {
            try
            {
                Console.WriteLine("Informe sua data de nascimento: ");
                DateTime data = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Sua idade é de: " +
                    $"{DateTime.Today.Year - data.Year}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);5
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
