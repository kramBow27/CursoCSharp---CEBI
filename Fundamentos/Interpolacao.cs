using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
     class Interpolacao {
        public static void Executar() {
            string produto = "Notebook Gamer";
            string marca = "Dell";
            double preco = 6500.98;

            Console.WriteLine("O " + produto + " da marca " + marca + " CUSTA " + preco);
            Console.WriteLine(" O {1} que é o {1} também pode ser {0} mas se for {2} então {0} não é, ou também pode ser tudo junto, o {0}, {1}, {2}", produto, preco, marca);
            Console.WriteLine($"A {marca} {produto} {preco} é isso ai meu amigo");
        }
    }
}
