using CursoCSharp.OrientacaoObjetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes {

    delegate double Operacao(double x, double y);

    internal class DelegateComLambda {



        public static void Executar() {
            Operacao sum = (x, y) => x + y;
            Operacao sub = (x, y) => x - y;
            Operacao times = (x, y) => x * y;
            Operacao all = (x, y) => times(sum(x,y), sub(x,y));

            Console.WriteLine(sum(3, 3));
            Console.WriteLine(sub(78, 3));
            Console.WriteLine(times(3, 3));
            Console.WriteLine(all(93, 3));

        }
    }
}
