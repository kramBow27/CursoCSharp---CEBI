using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    class FormatandoNumeros {
        public static void Executar() { //MODIFICADORE MODIFICADORES MODIFICADORES FORMATAM FORMATAM FORMATAM
            double valor = 1575.00;
            Console.WriteLine(valor.ToString("F1")); //F DE FLOAT, QTAS CASAS
            Console.WriteLine(valor.ToString("C")); // C DE CURRENCY
            Console.WriteLine(valor.ToString("P")); // P De Porcentagem
            Console.WriteLine(valor.ToString("#.##"));

            CultureInfo culture = new CultureInfo("pt-BR"); //INFORMAÇÃO DE CULTURA
            Console.WriteLine(valor.ToString("C0", culture));
            culture = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C3", culture));
            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));

        }
    }
}
