//bibliotecas prontas!!
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto // agrupamento de classes
{
    internal class Program  // classe
    {
        static void Main(string[] args) //método de entrada
        {
            /*Console.WriteLine("Olá Mundo");
            Console.Write("Olá");
            Console.Write("Mundo");*/

            /*tipos de dados
            int idade = 19;
            double valor = 15.68;
            char caracter = 'A';
            string nome = "Ryan";
            bool verdadeiro = true;
            */


            /*conectar - juntar
            string nome = "Ryan";
            int idade = 19;
            //sobreNome = Camel;
            //sobre_nome = snake;
            Console.WriteLine("Nome :" + nome);
            Console.WriteLine("Idade :" + idade);
            */


            /*Constantes 
            const string aluno = "Guilherme";
            Console.WriteLine("O valor da constante é = " +aluno);
            */

            /*entrada de dados
            string nome;
            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine(); //ler o teclado
            Console.WriteLine("O nome digitado foi: " +nome); //conectar - juntar 
            //outro exemplo de entrada de dados
            int idade, anoNasc;
            Console.WriteLine("Digite o ano que você nasceu: ");
            anoNasc = int.Parse(Console.ReadLine());
            idade = 2026 - anoNasc;
            Console.WriteLine("Olá, você tem " + idade + " anos ");
            */


            /*Exercício prático: 
            int idade;
            double altura;
            Console.WriteLine("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua altura: ");
            altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Altura: " + altura);
            Console.ReadKey();
            */

            /*operadores lógicos para cálculos
            int a = 5;
            int b = 5;
            double resultado;
            Console.WriteLine(a + b); // soma
            Console.WriteLine(a - b); // subtração
            Console.WriteLine(a * b); // multiplicação
            resultado = (double) a / b;
            Console.WriteLine(resultado);// divisão
            Console.WriteLine(a % b); // resto da divisão
            int c = 5;
            Console.WriteLine(c / 3.000);
            */


            /*interpolação
            int a = 10;
            int b = 5;
            double resultado = (double)a / b;
            Console.WriteLine($"Divisão inteira : {a/b} ");
            //Limitar a quantidade de casas usando interpolação
            Console.WriteLine($"Divisão decimal : {resultado:F2} ");
            Console.ReadKey();
            */

            /*Exercicio par ou impar
            int numero;
            Console.WriteLine("Digite um número:");
            numero = int.Parse(Console.ReadLine());
            if (numero %2 == 0) {
                Console.WriteLine("O número que você digitou é par");
            }
            else
            {
                Console.WriteLine("O número digitado é ímpar");
            }
            Console.ReadKey();
            */

            /*comparação simples
            int num = 10;
            if (num == 0)
            {
                Console.WriteLine("Num. igual a 10");
            }
            Console.WriteLine("Próxima Linha");   
            */

        }
    }
}
                
                                  