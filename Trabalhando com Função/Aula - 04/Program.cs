using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Aula___04
{
    internal class Program
    {

        //Estrutura
        //tipoRetorno Nome da função (parametros)
        //{
        //return
        //}


        //Exemplo:
        static void MostrarMenu()//->(parametros)
        {
            Console.WriteLine("====MENU====");
            Console.WriteLine("1 - Cadastrar");
            Console.WriteLine("2 - Listar");
            Console.WriteLine("3 - Sair");
        }


        static int Dobro(int n)
        {
            return n * 2;
        }


        static int Somar(int n1, int n2)
        {
            return (n1 + n2);
        }

        static string Saudação(string nome)
        {
            return "Hello " +nome+ ", seja bem vindo";
        }

        static bool Aprovado(double nota)
        {
            return nota >= 6 ;
        }

        static void Main(string[] args)
        {
            //função mostrar menu:
            //MostrarMenu();


            //função Dobro:
            //int resultado;
            //resultado= Dobro(10);
            //Console.WriteLine("Dobro = "+resultado);


            //função Somar:
            //int valor1, valor2;
            //Console.WriteLine("Digite o primeiro número : ");
            //valor1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o segundo número : ");
            //valor2 = int.Parse(Console.ReadLine());
            //int resultado;
            //resultado = valor1 + valor2;
            //Console.WriteLine("Soma = " + resultado);


            //função Saudação (Strinng):
            //string nome;
            //Console.WriteLine("Digite seu nome:");
            //nome = Console.ReadLine();
            //Console.WriteLine(Saudação(nome));


            //função Aprovado (Boleano):
            //Console.WriteLine("Digite a nota do aluno: ");
            //double nota = double.Parse(Console.ReadLine());
            //bool resultado = Aprovado(nota);
            //if (resultado) {
            //    Console.WriteLine("Aprovado");
            //}
            //else
            //{
            //    Console.WriteLine("Aluno Reprovado");
            //}
            //Console.ReadKey();




            //Recursividade - função chama ela mesma
            //Recursiva m=new Recursiva();
            //m.Executar("TI101", 5);

        }
        public class Recursiva
        {
            //metodo:
            public void Executar(string mensagem, int n)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(mensagem);
                }
            }
        }
    }
}
