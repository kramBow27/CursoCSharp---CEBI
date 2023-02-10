using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class VariaveisEConstantes { //ClasesNamespacesFuncoes
        public static void Executar() {
            // AREA DE CIRCUNFERENCIA
            double raio = 4.5;
            const double PI = 3.14;
            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("A AREA É " + area);

            // tipos internos
            bool estaChovendo = true; //VARIAVELS EM camelCase
            Console.WriteLine("Esta chovendo " + estaChovendo);

            byte idade = 100; // VAI DE 0 a 256 (O 0 CONTA NÉ, MEU AMIGO?)
            Console.WriteLine("A IDADE É " + idade);
            sbyte saldoDeGols = sbyte.MinValue; //FUNÇÃO A TIPOS PRIMITIVOS NÃO PRECISAM DE PARENTESES?? PRECISA VER
            Console.WriteLine("O saldo de gols é " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("O salario é " + salario);

            int menorValorInt = int.MinValue;
            Console.WriteLine("O menor valor do int é " + menorValorInt);

            int maiorValorInt = int.MaxValue;
            Console.WriteLine("O maior valor do int é " + maiorValorInt);

            uint indiaPopulation = uint.MaxValue;
            Console.WriteLine("A população da  Índia é aproximadamente " + indiaPopulation);

            long menorValorLong = long.MinValue;
            Console.WriteLine("O menor valor do long é " + menorValorLong);

            long maiorValorLong = long.MaxValue;
            Console.WriteLine("O maior valor do long é " + maiorValorLong);

            ulong maiorValorLongSemSinal = ulong.MaxValue;
            Console.WriteLine("O maior valor do ulong sem sinal é " + maiorValorLongSemSinal);

            float valorFloat = 128.9f;
            Console.WriteLine("O valor float precisa ter um f" + valorFloat);

            double todoODinheiroDoMundo = double.MaxValue;
            Console.WriteLine("Um valor absurdo é " + todoODinheiroDoMundo);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Essa é a distancia entre estrelas e planetas: " + distanciaEntreEstrelas);

            char letra = 'a'; //ASPAS SIMPLES EM UMA LETRA SÓ
            Console.WriteLine("Quando é CHAR tem que usar aspas simples " + letra);

            string frase = "Essa é uma string, ai é aspas duplas";
            Console.WriteLine(frase);





        }
    }
}
