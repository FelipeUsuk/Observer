using Observer.Implementacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int valor = 0;
            Random random = new Random();
            var monitor = new MonitorMercado("PETR4");
            monitor.Adicionar(new MensageiroSlack());
            monitor.Adicionar(new MensageiroEmail());
            monitor.Adicionar(new MensageiroVoz());

            Console.WriteLine("**Monitor de PETR4**");
            Console.WriteLine("**UTILIZANDO NUMEROS ALEATORIOS - SE O VALOR DA AÇÃO FOR MAIOR QUE 95 O SERVIDOR CAI - **");

            Console.ReadKey();

            for (int i =0; i< 100; i++)
            {

                
                int valorNovo = random.Next(0, 100);

                Console.WriteLine("Valor Anterior= " + valor);
                Console.WriteLine("Valor Atual= " + valorNovo);

                if (valorNovo >= 96)
                {
                    monitor.Notificar("SERVIDOR CAIU !!");
                    break;
                }

                if (valorNovo > valor)
                    monitor.Notificar("Valorizou");
                else
                    monitor.Notificar("Desvalorizou");

                valor = valorNovo;

                Console.WriteLine();
                Thread.Sleep(1500);
            }

            Console.ReadKey();
        }
    }
}
