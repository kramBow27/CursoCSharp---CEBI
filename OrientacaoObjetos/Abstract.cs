using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OrientacaoObjetos {

    public abstract class Celular { // NÃO PODE SER INSTANCIADA DIRETAMENTE
        public abstract string Assistente();
        public string Tocar() {
            return "trim trim trim ";
        }
    }

    public class Samsung : Celular {
        public override string Assistente() {
            return "Olá! Meu nome é Bixby";
        }
    }

    public class IPhone : Celular {
        public override string Assistente() {
            return "Olá meu nome é SIRI";
        }
    }

    internal class Abstract {
        public static void Executar() {
            var celulares = new List<Celular>
            {
                new IPhone(),
                new Samsung()
            };

            foreach (var celular in celulares) {
                Console.WriteLine(celular.Assistente());
            }


        }
    }

}