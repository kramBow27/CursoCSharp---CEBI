using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    class ExerciseQueue {
        public static void Executar() {
            //FIRST IN FIRST OUT FIFO
            var fila = new Queue<string>();
            fila.Enqueue("fulano");
            fila.Enqueue("Sicrano");
            fila.Enqueue("Beltrano");
            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Count);

            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Count);

            foreach (var pessoa in fila) {
                Console.WriteLine(pessoa);
            }

            var salada = new Queue();
            salada.Enqueue(3);
            salada.Enqueue("item");
            salada.Enqueue(true);
            salada.Enqueue(3.14);
            Console.WriteLine(salada.Contains("Item")); // NÃO ENCONTRARAs
            Console.WriteLine(salada.Contains("Item")); // cAse SenSItive
        }
    }
}
