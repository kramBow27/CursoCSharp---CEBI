using System;


namespace CursoCSharp.Estruturas_de_Controle {
     class EstruturaIf {
        public static void Executar() {
            bool bomComportamento = false;
            string entrada;

            Console.WriteLine("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota); /// o tipo de saida é sempre o que chama o método
           
            Console.WriteLine("Possui bom comporatamento? (S/N): ");
            entrada = Console.ReadLine();

            //if (entrada == "S" || entrada ==  "s") 
            //    bomComportamento = true;

            //bomComportamento = entrada == "S" || entrada == "s";
            bomComportamento = entrada.ToLower() == "s";
            
            if(nota >= 9.0 && bomComportamento) {
                Console.WriteLine("Quadro de honra");
            }
               


            
        }
    }
}
