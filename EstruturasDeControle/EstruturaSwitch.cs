using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Estruturas_de_Controle {
    class EstruturaSwitch {
        public static void Execuar() {
            Console.WriteLine("Avalie atendimento com 1 a 5: ");
            int.TryParse(Console.ReadLine(), out int avaliacao);

            switch (avaliacao) {
                case 0:
                    Console.WriteLine("Péssimo");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("ruim");
                    break;
                case 3:
                    Console.WriteLine("Regular");
                    break;
                case 4:
                    Console.WriteLine("Bom");
                    break;
                case 5:
                    Console.WriteLine("Ótimo");
                    break;
                default:
                    Console.WriteLine("Nota invalida");
                        break;

            }
            Console.WriteLine("Fim");
        }
    }
}
