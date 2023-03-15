using Calculo;
using Funções;
using Diretorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tela
{
    internal class Menu
    {
        public const int SAIDA_PROGRAMA = 0;
        public const int TABUADA = 1;
        public const int CALCULO_MEDIA = 2;
        public const int LER_ARQUIVO = 3;

        public static void Criar() 
        {
            Console.WriteLine("Digite seu nome de usuário : ");
            string nome = Console.ReadLine();
            Console.WriteLine();

            while (true)
            {

                string mensagem = "Olá, " + nome + "! Bem-vindo ao programa Utilizando Programação Funcional.\n" +
                    "\nDigite uma das opções abaixo :\n" +
                    "\n0 - Sair do programa" +
                    "\n1 - Tabuada" +
                    "\n2 - Calcular média de notas" +
                    "\n3 - Ler arquivo";

                Console.WriteLine(mensagem);


                int valor = int.Parse(Console.ReadLine());


                if (valor == SAIDA_PROGRAMA)
                {
                    break;
                }
                else if (valor == TABUADA)
                {
                    Console.WriteLine("Deseja a tabuada de qual número?");
                    int numero = int.Parse(Console.ReadLine());
                    Tabuada.Calcular(numero);
                }
                else if (valor == CALCULO_MEDIA)
                {
                    Media.Aluno();

                }
                else if (valor == LER_ARQUIVO)
                {
                    Diretorio.Arquivo.Ler(1);
                }
                else
                {
                    Console.WriteLine("Opção inválida! Digite novamente");
                    Console.WriteLine("Opção inválida! Digite novamente");
                }
            }
    }

        
            
    }
}
