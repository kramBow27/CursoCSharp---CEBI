﻿using System;
using System.Collections.Generic;

using System.Text;

namespace CursoCSharp.ClassesEMetodos { // O QUE HABITA O MESMO ESPAÇO NÃO PRECISA SER IMPORTADO
  class Membros {
        public static void Executar() {
           Pessoa sicrano = new Pessoa();
            sicrano.Nome = "Renato";
            sicrano.Idade = 21;

           Console.WriteLine($"{sicrano.Nome} tem {sicrano.Idade} anos");
            sicrano.ApresentarNoConsole();

            var fulano = new Pessoa();
            fulano.Nome = "Beto";
            fulano.Idade = 21;

            var apresentacaoDoFulano = fulano.Apresentar();
            Console.WriteLine(apresentacaoDoFulano.Length);
            Console.WriteLine(apresentacaoDoFulano);
            fulano.Zerar();
            Console.WriteLine(apresentacaoDoFulano);

        }   
    }
}
