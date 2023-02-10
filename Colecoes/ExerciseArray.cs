using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
     class ExerciseArray { //ARRAY NÃO CRESCE, SE É 5, É 5 E ACABOU, MAS DA PRA MANDAR DE UMA ARRAY PRA OUTRA
        public static void Executar() {
            string[] alunos = new string[5];
            alunos[0] = "Chayenne";
            alunos[1] = "Julia";
            alunos[2] = "Iris";
            alunos[3] = "Thais";
            alunos[4] = "Michele"; // NÃO ACESSA PELO NOME, SÓ INDEX

            foreach (var aluno in alunos) {
                Console.WriteLine(aluno);
            }

            double somatorio = 0;
            double[] notas = { 9.0, 9.5, 10, 10, 9.4 };
            foreach (var nota in notas) {
                somatorio += nota;
            }

            double media = somatorio / notas.Length;
            Console.WriteLine(media);

            char[] letras = { 'A', 'r', 'r', 'a', 'y' };
            string palavra = new string(letras);
            Console.WriteLine(palavra);

            //for(int i = 0; i < notas.Length; i++) {Console.WriteLine(notas[i])}
        
    
        }
        
        
       

    }
}
