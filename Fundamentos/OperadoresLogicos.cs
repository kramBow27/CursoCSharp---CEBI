using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class OperadoresLogicos {
        public static void Executar() {
            var executouTrabalho1 = true;
            var executouTrabalho2 = false;

            //OPERADORES FAZEM OPERAÇÕES, PARECE ÓBVIO, MAS NÃO É TANTO ASSIM
            //OPERAÇÕES GERAM RESULTADOS
            //RESULTADOS SÃO ARMAZENADOS EM VARIÁVEIS

            var comprouTv50 = executouTrabalho1 && executouTrabalho2; //ARMAZENA O RESULTADO DE UMA EXPRESSÃO DE OPERADORES LÓGICOS EM VARIAVEIS OU CONSTANTES, DEPENDENDO DO CASO
            Console.WriteLine("Comprou a Tv 50? {0}", comprouTv50);

            var comprouSorvete = executouTrabalho1 || executouTrabalho2;
            Console.WriteLine("Comprou o sorvete? {0}", comprouSorvete);

            var comprouTv32 = executouTrabalho1 ^ executouTrabalho2;
            Console.WriteLine("Comprou TV 32? {0}", comprouTv32);

            Console.WriteLine("Mais saudável? {0}", !comprouSorvete); //VARIÁVEL COMPROU SORVETE DECLARADA ANTERIORMENTE NA LINHA 20
        }
    }
}
