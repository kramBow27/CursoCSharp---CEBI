using CursoCSharp.Fundamentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Estruturas_de_Controle {
    class EstruturaIfElse {
        public static void Executar() {
            double nota = 7.0;
            if (nota >= 7.0) {
                Console.WriteLine("Aprovado!");
                Console.WriteLine("Não fez mais que sua obrigação...");

            } else {
                Console.WriteLine("recuperação");
                Console.WriteLine("Que feio");
            }
        }
    }
}
