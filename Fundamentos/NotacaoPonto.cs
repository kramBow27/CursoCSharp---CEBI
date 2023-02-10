using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class NotacaoPonto {
        public static void Executar() {

            var saudacao = " Ola".ToUpper().Insert(3, "Kentucky").Replace("Kentucky", "Cidade");
            Console.WriteLine("ToUpper, Insert, Replace" + saudacao);

            Console.WriteLine("Parece que todos as linguagens de programação usam length".Length);

            string valorComponente = null;
            Console.WriteLine(valorComponente?.Length);

        }
    }
}
