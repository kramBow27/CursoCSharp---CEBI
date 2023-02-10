using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OrientacaoObjetos {

    interface OperacaoBinaria {
        int Operacao(int a, int b); //sempre é publico
    }

    class Soma : OperacaoBinaria {
        public int Operacao(int a, int b) {
            return a + b;
        }
    }

    class Subtracao : OperacaoBinaria {
        public int Operacao(int a, int b) {
            return a - b;
        }
    }

    class Divisao : OperacaoBinaria {
        public int Operacao(int a, int b) {
            return a / b;
        }
    }

    class Multiplicacao : OperacaoBinaria {
        public int Operacao(int a, int b) {
            return a * b;
        }
    }

    class Calculadora {
        List<OperacaoBinaria> operacoes = new List<OperacaoBinaria>
        {
            new Soma(),
            new Subtracao(),
            new Divisao(),
            new Multiplicacao(),
        };

        public string ExecutarOperacoes(int a, int b) {
            string resultado = "";
            foreach(var op in operacoes) {
                resultado += $"Usando {op.GetType().Name} = {op.Operacao(a, b)}\n";
            }
            return resultado;
        }

     
    }
    internal class Interface {
        public static void Executar() {
            Calculadora calculadora = new Calculadora();
            Console.WriteLine(calculadora.ExecutarOperacoes(3, 6));


        }
    }
}
