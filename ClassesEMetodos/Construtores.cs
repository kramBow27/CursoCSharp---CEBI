using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
   class Carro {
        public string Modelo;
        public string Fabricante;
        public int Ano;

        public Carro(string modelo, string fabricante, int ano) {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;

        }
    }
    class Construtores {
        public static void Executar() {
            var carro1 = new Carro("3251", "BMW", 2017);
            
            Console.WriteLine($"{carro1.Fabricante} {carro1.Modelo} {carro1.Ano} ");
            var carro2 = new Carro("9090", "FORD", 2018);
            Console.WriteLine($"{carro2.Ano}{carro2.Modelo}{carro2.Fabricante}");

        
        }
    }
}
