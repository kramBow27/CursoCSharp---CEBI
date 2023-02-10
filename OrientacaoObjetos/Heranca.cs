﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OrientacaoObjetos {

    public class Carro {
        protected readonly int VelocidadeMaxima; //não pode ser alterada, readonly
        int VelocidadeAtual;

        public Carro(int velocidadeMaxima ) {
            VelocidadeMaxima = velocidadeMaxima;
           
        }

        protected int AlterarVelocidade(int delta) {
            int novaVelocidade = VelocidadeAtual + delta;

            if (novaVelocidade < 0) {
                VelocidadeAtual = 0;
            } else if (novaVelocidade > VelocidadeMaxima) {
                VelocidadeAtual = VelocidadeMaxima;
            } else {
                VelocidadeAtual = novaVelocidade;
            }

            return VelocidadeAtual;
        }

        public virtual int Acelerar() {
            return AlterarVelocidade(5);

        }

        public int Frear() {
            return AlterarVelocidade(-5);
        }

    }


    public class Uno : Carro {
        public Uno() : base(200) {

        }
        
    }

    public class Ferrari : Carro {
        public Ferrari() : base(300) {

        }

        public override int Acelerar() {
            return AlterarVelocidade(15);
        }

        public new int Frear() { //Qdo atribuido ao nível mais genérico (polimorfismo) será chamado o método do tipo Pai
            return AlterarVelocidade(-15);
        }
    }
    internal class Heranca {
        public static void Executar() {
            Console.WriteLine("Uno...");
            Uno carro1 = new Uno();
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());

            Console.WriteLine("Ferrari");

            Ferrari carro2 = new Ferrari();

            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());

            Console.WriteLine("Ferrari com tipo carro...");
            Carro carro3 = new Ferrari(); // POLIFORMISMO
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());

            Console.WriteLine("Uno com tipo carro...");
            carro3 = new Uno(); // POLIFORMISMO
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());




        }
    }
}
