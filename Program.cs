using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.Estruturas_de_Controle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OrientacaoObjetos;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentário - Fundamentos", Comentarios.Executar },
                {"Variaveis E Constantes - Fundamentos", VariaveisEConstantes.Executar },
                {"Inferência de Tipos - Fundamentos", Inferencia.Executar },
                {"Interpolação - Fundamentos", Interpolacao.Executar },
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar },
                {"Lendo Dados no Console - Fundamentos", LendoDados.Executar },
                {"Formatando Números - Fundamentos", FormatandoNumeros.Executar },
                {"Conversões - Fundamentos", Conversoes.Executar },
                { "Operadores Aritmeticos - Fundamentos", OperadoresAritmeticos.Executar },
                { "Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar },
                { "Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar },
                { "Operadores de Atribuicao", OperadoresDeAtribuicao.Executar},
                { "Operadores Unários", OperadoresUnarios.Executar},
                {"Operador Ternário", OperadorTernario.Executar },
                //Estruturas de Controle
                {"Estrutura de Controle If - Estruturas de Controle", EstruturaIf.Executar },
                {"Estrutura de Controle If/Else - Estruturas de Controle", EstruturaIfElse.Executar },
                {"Estrutura de Controle If/Else/If - Estruturas de Controle", EstruturaIfElseIf.Executar },
                {"Estrutura de Controle Switch - Estruturas de Controle", EstruturaIfElseIf.Executar },
                {"Estrutura de Controle While - Estruturas de Controle", EstruturaWhile.Executar },
                {"Estrutura de Controle Do/While - Estruturas de Controle", EstruturaDoWhile.Executar },
                {"Estrutura de Controle For - Estruturas de Controle", EstruturaFor.Executar },
                {"Estrutura de Controle ForEach - Estruturas de Controle", EstruturaForEach.Executar },
                {"Estrutura de Controle Usando Break - Estruturas de Controle", UsandoBreak.Executar },
                {"Estrutura de Controle Usando Continue - Estruturas de Controle", UsandoContinue.Executar },
                //CLASSES E MÉTODOS 
                {"Classes e Métodos - Classes e Métodos", Membros.Executar },
                {"Construtores - Classes e Métodos", Construtores.Executar },
                {"Métodos com Retorno - Classes e Métodos", MetodosComRetorno.Executar },
                {"Métodos Estaticos - Classes e Métodos", MetodosEstaticos.Executar },
                {"Atributos Estaticos - Classes e Métodos", AtributosEstaticos.Executar },
                {"Desafio Estatico - Classes e Métodos", DesafioAtributo.Executar },
                {"Parametros Variáveis - Classes e Métodos", ParametrosVariaveis.Executar },
                {"Parametros Nomeados - Classes e Métodos", ParametrosNomeados.Executar },
                {"Getters e Setters - Classes e Métodos", GettersSetters.Executar },
                {"Propiedades - Classes e Métodos", Propriedades.Executar },
                {"Atributos Read Only - Classes e Métodos", AtributosReadOnly.Executar },
                {"Enum- Classes e Métodos", ExemploEnum.Executar },
                {"Struct - Classes e Métodos", Struct.Executar },
                {"Struct Vs Classes - Classes e Métodos", StructVsClasse.Executar },
                {"Valor Vs Referencia - Classes e Métodos", ValorVsReferencia.Executar },
                {"Parametros Por Referencia - Classes e Métodos", ParametrosPorReferencia.Executar },
                {"Parametros Padrao - Classes e Métodos", ParametrosPadrao.Executar },
                //COLEÇÕES
                {"Array - Coleções", ExerciseArray.Executar },
                {"List - Coleções", ExerciseSet.Executar },
                {"ArrayList - Coleções", ExerciseArrayList.Executar },
                {"Set - Coleções", ExerciseSet.Executar },
                {"Queue - Coleções", ExerciseQueue.Executar },
                {"Igualdade - Coleções", Igualdade.Executar },
                {"Stack - Coleções", ExerciseStack.Executar },
                {"Dictionary - Coleções", ExerciseDictionary.Executar },
                //ORIENTAÇÃOOBJETOS
                {"Herança - Orientação a Objetos", Heranca.Executar },
                {"Palavra This - Construtores - Orientação a Objetos", PalavraThis.Executar },
                {"Encapsulamento - Construtores - Orientação a Objetos", OrientacaoObjetos.Encapsulamento.Executar },
                {"Polimorfismo - Construtores - Orientação a Objetos", OrientacaoObjetos.Polimorfismo.Executar },
                {"Classes Abstratsa - Construtores - Orientação a Objetos", OrientacaoObjetos.Abstract.Executar },
                {"Interfaces - Construtores - Orientação a Objetos", OrientacaoObjetos.Interface.Executar },
                {"Sealed - Construtores - Orientação a Objetos", OrientacaoObjetos.Sealed.Executar },
                //METODOS E FUNÇÕES
                {"Exemplo Lambda - Métodos e Funções", MetodosEFuncoes.ExemploLambda.Executar },
                {"Delegate Com Lambda -  Métodos e Funções", MetodosEFuncoes.DelegateComLambda.Executar },
                {"Usando Delegates -  Métodos e Funções", MetodosEFuncoes.UsandoDelegates.Executar },
                {"Delegates Com Funções Anonimas -  Métodos e Funções", MetodosEFuncoes.DelegatesComFuncoesAnonimas.Executar },
                {"Passando Delegates Como Parâmetros -  Métodos e Funções", MetodosEFuncoes.PassandoDelegateComoParametro.Executar },
                {"Métodos De Extensão -  Métodos e Funções", MetodosEFuncoes.MetodosDeExtensao.Executar },
                //EXCEÇÕES
                {"Primeira Exceção -  Exceções", Excecoes.PrimeiraExcecao.Executar },
                {"Exceções Personalizadas -  Exceções", Excecoes.ExcecoesPersonalizadas.Executar },


            });

            central.SelecionarEExecutar();
        }
    }
}