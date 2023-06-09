﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo
{
    internal class Media
    {
        public static void Aluno()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Digite o nome do aluno");
            string nome = Console.ReadLine();
            int qtdNotas = 3;

            Console.WriteLine("");
            Console.WriteLine("Digite as " + qtdNotas + " notas do aluno " + nome);

            List<int> notas = new List<int>();
            int totalNotas = 0;
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("Digite a nota número " + i);
                int nota = int.Parse(Console.ReadLine());
                totalNotas += nota;
                notas.Add(nota);
            }

            int media = totalNotas / notas.Count();
            Console.WriteLine("");
            Console.WriteLine("A média do aluno " + nome + " é igual a " + media + "!");
            Console.WriteLine("");
            Console.WriteLine("Suas notas são : ");
            Console.WriteLine("");
            foreach (int nota in notas)
            {
                Console.WriteLine("Nota : " + nota + "\n");
            }
            Console.ResetColor();
        }
    }
}
