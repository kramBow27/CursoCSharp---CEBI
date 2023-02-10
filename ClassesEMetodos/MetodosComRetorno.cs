using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    class MetodosComRetorno {
        class CalculadoraCadeia {
            int memoria;

            public CalculadoraCadeia Somar(int a) {
                memoria += a;
                return this;
            }
            public CalculadoraCadeia Multiplicar(int a) {
                memoria *= a;
                return this;
            }
            public CalculadoraCadeia Limpar() {
                memoria = 0;
                return this;
            }

            public CalculadoraCadeia Imprimir() {
                Console.WriteLine(memoria);
                return this;
            }

            public int Resultado() {
                return memoria;
            }
        }
        class CalculadoraComum {
            public int Somar(int a, int b) {
                return a + b;
            }
            public int Subtrair(int a, int b) {
                return a - b;
            }
            public int Multiplicar(int a, int b) {
                return a * b;
            }

            public int Dividir(int a, int b) {
                return a / b;
            }
        }
        public static void Executar() {
            var calculdora = new CalculadoraComum();
            Console.WriteLine(calculdora.Somar(2,3));
            Console.WriteLine(calculdora.Subtrair(9, 13));
            Console.WriteLine(calculdora.Multiplicar(10, 8));
            Console.WriteLine(calculdora.Dividir(8, 2));

            var calculadoraCadeia = new CalculadoraCadeia();
            calculadoraCadeia.Somar(3).Multiplicar(3).Imprimir().Limpar().Imprimir();
            var resultado = calculadoraCadeia.Somar(2).Multiplicar(900).Resultado();
            Console.WriteLine(resultado);
        }
    }
}
