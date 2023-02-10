﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
   class LendoDados {
        public static void Executar() {
            Console.Write("Qual é o seu nome?");
            string nome = Console.ReadLine();

            Console.Write("Qual é a sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Qual é o seu salário? ");
            double salario = double.Parse(Console.ReadLine(), 
                CultureInfo.InvariantCulture); //CULTURA PELO JEITO SE REFERE A LINGUAGEM E SISTEMAS DE MEDIDAS ADOTADOS EM DETERMINADOS PAÍSES

            Console.WriteLine($"{nome}{idade}R${salario}");

        }
    }
}
