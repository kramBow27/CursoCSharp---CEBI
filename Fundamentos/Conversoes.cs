using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
     class Conversoes {
        public static void Executar() {
            int inteiro = 10;
            double quebrado = inteiro; //ARMAZENA CERTINHO INT PRA DOUBLE, PORQUE DOUBLE CABE MAIS QUE INT
            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaTruncada = (int)nota;
            Console.WriteLine("Nota Truncada: {0}", notaTruncada);
            Console.Write("Digite sua idade : ");
            string idade = Console.ReadLine(); // READ LINE É PRA STRING, READ PRA INT
            int idadeInteiro = int.Parse(idade);
            Console.WriteLine("Sua idade é " + idadeInteiro);

            idadeInteiro = Convert.ToInt32(idade);
            Console.WriteLine(idadeInteiro);
            Console.WriteLine("Digite um número ");
            
            int.TryParse(Console.ReadLine(), out int numero);
            Console.WriteLine(numero);





        }
    }
}
