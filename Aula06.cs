using System;

namespace Aula06
{
    internal class Aula06
    {
        static void Main(string[] args)
        {
            //POO é uma representação do mundo real na programação
            //CLASSE / OBJETO = ABSTRATO / FÍSICO
            //POO = Programação Orientada a Objeto

            //Todas as variáveis em uma classe são chamadas de propriedade

            //Uma classe possui:

            //propriedade (atributos) / características;
            //métodos (funções)

            // 4 PILARES DE POO:
            // Encapsulamento; Abstração; Herança e Polimorfismo

            // 1º - PILAR ENCAPSULAMENTO
            // Agrupar o que faz sentido estar junto!

            // 2º - PILAR ABSTRAÇÃO
            //Ato de esconder os detalhes
            //Colocar um objeto na memória
            //Instanciar uma classe

            // 3º - PILAR HERANÇA
            //Capacidade de um objeto HERDAR propriedade, métodos e eventos de
            //outro obejto

            //4º - PIAR POLIMORFISMO
            //Quando um método pode ser executado de formas diferentes
            //Exemplo: Classe Animal com método EmitirSom

            Carro fusca = new Carro();
            fusca.placa = "ZZZZ";
            fusca.chassi = "111";
            fusca.peso = 20;

            fusca.Andar();
            fusca.ConsultarQuantidadeCombustivel();

            Moto suzuki = new Moto();
            suzuki.placa = "aaa";
            suzuki.chassi = "2222";
            suzuki.guidao = "";
            suzuki.Andar();

                        
        }

        //Criar a classe Carro
        class Carro
        {
           public string placa, chassi, cor, peso;

            //Todas as variáveis de uma classe são chamadas de Propriedades
            //dentro de uma CLASSE todas as FUNÇÕES são chamadas de MÉTODOS!

            //Níveis de acesso  
            //public = público
            //private = privado

            // SE NÃO INFORMAR o TIPO, ELE SERÁ PRIVATE!




            public void Andar()
            {
                //
            }

            void LigarSeta()
            {

            }

            void ConsultarQuantidadeCombustível()
            {

            }      
        }

        //: Carro => Moto herda todas as propriedades
        class Moto : Carro
        {
            public string guidao;
        }



        static void NumeroMaior()
        {
            //2 - CRIE UM ALGORITMO QUE LÊ 3 NÚMEROS INTEIROS E RETORNE QUAL É O MAIOR

            Console.WriteLine("Aula 04 - Exercício 02\n\n");

            Console.Write("Digie o primeiro número: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Digie o segundo número: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.Write("Digie o terceiro número: ");
            int n3 = int.Parse(Console.ReadLine());

            //F9 = DEBUG (depuração do código)
            //F10 = EXECUTAR LINHA POR LINHA
            //F11 = ENTRA NA FUNÇÃO
            //F5 = EXECUTA ATÉ O FINAL OU ATÉ O PRÓXIMO BREAKPOINT

            int resultado = Maior(n1, n2, n3);
            Console.WriteLine("O maior número é: {0}", resultado);
        }

        //Vamos criar uma função
        //static vamos iniciar com static o MAIN
        //(para manter a comunicação)

        //int = representa a saída da função
        
        //Maior = nome da fumção
        
        //() parênteses sem nada dentro representa que a função
        //não receberá nenhum parâmetro para executar   

        //(int n1, int n2, int n3) = representa os parâmetros que a função
        // irá receber (tipo e nome da variável)

        static int Maior(int n1, int n2, int n3)
        {
            int maiorNumero;
            if (n1 > n2 && n1 > n3)
            {
                maiorNumero = n1;
            }
            else if (n2 > n3)
            {
                maiorNumero = n2;
            }
            else
            {
                maiorNumero = n3;
            }
            //Vamos informar qual é o retorno da nossa função
            //utilizando a palavra reservada "return"
            return maiorNumero;
        }

    }
}
