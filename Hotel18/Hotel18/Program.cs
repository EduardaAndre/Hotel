using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Hotel18
{
    class Program
    {


        static void Main(string[] args)
        {
            Hospedes[] quarto = new Hospedes[10];

            Console.WriteLine("Digite quantos hospedes irão se hospedar: ");
            int aluguel = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Hospedes> lista = new List<Hospedes>();

            for (int m = 0; m < aluguel; m++)
            {
                Hospedes cliente = new Hospedes();

                Console.WriteLine("Digite o nome do cliente: ");
                cliente.Nome = Console.ReadLine();

                Console.WriteLine("Digite o e-mail do cliente: ");
                cliente.Email = Console.ReadLine();

                bool cheking = false;

                do
                {
                    Console.WriteLine("Escolha o quarto: ");
                    for (int n = 0; n < 10; n++)
                    {
                        if (quarto[n] == null)
                        {
                            Console.Write(" Quarto: " + n.ToString() + " - Vago ");
                        }
                        else
                        {
                            Console.Write(" Quarto: " + n.ToString() + " - Ocupado ");
                        }
                    }
                    
                    int numero = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    if (quarto[numero] == null)
                    {
                        quarto[numero] = cliente;
                        cheking = true;
                    }
                    else
                    {
                        Console.WriteLine("Quarto ocupado!");
                    }
                } while (cheking == false);

            }

            int count = 0;
            for (int m = 0; m < 10; m++)
            {
                if (quarto[m] != null)
                {
                    count++;
                }
            }
            Console.WriteLine("Quantos quartos estão alugados? " + count);

            count = 1;
            string listaHospide = "";
            for (int m = 0; m < 10; m++)
            {
                if (quarto[m] != null)
                {
                    Console.WriteLine("Hospede #" + count.ToString());
                    Console.WriteLine("Nome: " + quarto[m].Nome);
                    Console.WriteLine("E-Mail: " + quarto[m].Email);
                    Console.WriteLine("");
                    Console.WriteLine("Quarto: " + m);
                    
                    count++;
                    listaHospide += m.ToString() + ": " + quarto[m].Nome + ", " + quarto[m].Email + "\n";
                }
            }

            Console.WriteLine("Quartos Ocupados");
            Console.WriteLine(listaHospide);

        }
    }
}