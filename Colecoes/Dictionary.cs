using System;
using System.Collections.Generic;

namespace CursoCSharp.Colecoes {
    class ExerciseDictionary {
        public static void Executar() {
            var filmes = new Dictionary<int, string>();

            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "Homem Araha");
            filmes.Add(2004, "Os Incríveis");
            filmes.Add(2006, "O Grande Truque");

            if (filmes.TryGetValue(2004, out string filme2004)) {
                Console.WriteLine("2004: " + filmes[2004]);
            }

            if (filmes.TryGetValue(2008, out string filme2008)) {
                Console.WriteLine("2008: " + filmes[2008]);
                Console.WriteLine("2008: " + filmes.TryGetValue(2004, out string filme));
            } else {
                Console.WriteLine("Filme 2008 não encontrado");
            }
        }
    }
}
