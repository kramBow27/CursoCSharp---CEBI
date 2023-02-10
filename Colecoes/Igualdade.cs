using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    internal class Igualdade {
        public static void Executar() {
            var p1 = new Produto("Caneta", 1);
            var p2 = new Produto("Caneta", 1);
            var p3 = p2;

            //COMPARA ENDEREÇO DE MEMÓRIA

            Console.WriteLine(p1 == p2); // NÃO É IGUAL
            Console.WriteLine(p3 == p2);// IGUAL
            
            Console.WriteLine(p1.Equals(p2));// faz a mesma coisa
        }
    }
}
