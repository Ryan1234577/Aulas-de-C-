using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula___03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Trabalhando com Array no C#

            // Declaração:

            // forma 1 - definindo tamanho 
            // tipo [] nome_do_array  = new int [ tamanho ]
            //int[] numero = new int[5];

            // forma 2 - inserindo valores diretamente: 
            //int[] numeros = { 10, 20, 30 };

            // forma 3 - utilizando new
            //int[] numeros = new int[2];
            //int[] numeros = { 10, 20, 30, };
            //Console.WriteLine(numeros[0]);
            //Console.WriteLine(numeros[1]);
            //Console.WriteLine(numeros[2]);

            // Array Resize = aumenta posição
            //int[] numeros = { 10, 20, 30, 40, 50 };
            //Array.Resize(ref numeros,5);
            //Console.WriteLine(numeros[0]);
            //numeros[0] = 100;
            //numeros[4] = 50;
            //Console.WriteLine(numeros[4]);


            // Atribuindo valor 
            //int[] numeros = { 10, 20, 30, 40 };
            //Array.Resize(ref numeros,5);
            //int valorZero = numeros[0];
            //numeros [0] = 100;
            //Console.WriteLine("O valor da posição 0 é = " + numeros[0]);
            //Console.WriteLine("O valor anterior da posição 0 é = " + valorZero);


            // Atribuindo valor sem precisar criar variavel
            //int[] numeros = { 10, 20, 30, 40 };
            //Array.Resize(ref numeros,5);
            //numeros[4] = numeros[0];
            //numeros [0] = 100;
            //Console.WriteLine("O valor da posição 0 é = " + numeros[0]);
            //Console.WriteLine("O valor anterior da posição 0 é = " + numeros[4]);


            //Console.WriteLine(numeros.Length), responsável po mostrar a quantidade de elementos dentro do array
            //int[] numeros = { 10, 20, 30, 40 };
            //Console.WriteLine(numeros.Length);



            /*criar um array com 5 posições sem valor
            pedir para o usuario digitar os valores
            exibir em um fluxo de repetição
            int[] gols = new int[5];
            for (int i = 0; i < gols.Length; i++)
            {
                Console.WriteLine("Digite um valor para adicionar ao Array:");
                gols[i] = int.Parse(Console.ReadLine());
                foreach (int gol in gols)
                {
                    Console.WriteLine("Valor = " +gol);
                }
            }
            */

            // Utilização de estrutura de repetição e foreach
            //string[] nomes = { " Ana ", " Carlos ", " Renata " };
            //foreach (string nome in nomes) //in = qual é o Array
            //{
            //  Console.WriteLine(nome);
            //} 
            //Console.ReadKey();


            //matriz
            int[,] matriz = { { 1, 2, 3, 4, 5, 6, 7, 8, 9, } };



        }
    }
}
