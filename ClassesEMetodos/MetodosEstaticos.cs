using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    public class CalculadoraEstatica {
        public static int Somar(int a, int b) {
            return a + b;
        } // MÉTODOS ESTATICOS NÃO PODEM SER CHAMADOS ATRAVÉS DE INSTANCIAS DE OBJETOS, APENAS PELO PRÓPRIO OBJETO SI PRÓPRIO 

        public static int Multiplicar(int a, int b) {
            return a * b;
        }
    }
    internal class MetodosEstaticos {
        public static void Executar() {
            var resultado = CalculadoraEstatica.Multiplicar(2, 2);

        }
    }
}
