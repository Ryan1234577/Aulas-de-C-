using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Data e hora atual:
            //DateTime hoje = DateTime.Now;
            //Console.WriteLine("Data e hora atual:"+hoje);

            //DateTime hoje = DateTime.Today;
            //Console.WriteLine(hoje.ToString());

            //Criando uma data manualmente:
            //DateTime aniversario = new DateTime(2007,02,12);
            //Console.WriteLine(aniversario);

            //Criando uma data e hora manualmente:
            //DateTime aniversario = new DateTime(2007, 02, 12, 16, 54, 00);
            //Console.WriteLine(aniversario);

            /*
            dd > dia
            MM > mês
            yyyy > ano
            HH > hora (24h)
            mm > minutos
            ss > segundos
             */

            //testes da tabela acima:
            //DateTime data = DateTime.Now;
            //Console.WriteLine(data.ToString("dd/MM/yyyy"));
            //Console.WriteLine(data.ToString("dd/MM/yyyy"));
            //Console.WriteLine(data.ToString("HH:mm"));
            //Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm:ss"));


            //Adição de dias da data:
            //DateTime hoje = DateTime.Now;
            //Console.WriteLine("Hoje:" + hoje);
            //Console.WriteLine("Mais 10 dias: " + hoje.AddDays(10));


            //Adição de meses da data:
            //DateTime hoje = DateTime.Now;
            //Console.WriteLine("Hoje:" + hoje);
            //Console.WriteLine("Mais 2 meses: " + hoje.AddMonths(4));


            //Adição de anos da data:
            //DateTime hoje = DateTime.Now;
            //Console.WriteLine("Hoje:" + hoje);
            //Console.WriteLine("Mais 2 meses: " + hoje.AddYears(2));


            // Exemplo prático:
            //Console.WriteLine("Digite uma data (dd/MM/yyyy)");
            //DateTime date = DateTime.Parse(Console.ReadLine());
            //Console.WriteLine("Você digitou:"+date.ToString("dd/MM/yyyy"));


            // Exemplo prático 2 (idade):
            //Console.WriteLine("Digite o ano de nascimento:");
            //DateTime ano = int.Parse(Console.ReadLine());
            //int idade = DateTime.Now.Year - ano;
            //Console.WriteLine("idade: " + idade);

            // Exemplo de todos os atributos:
            DateTime inicio = new DateTime(2026, 05, 20);
            DateTime fim = new DateTime(2026,05,25);
            TimeSpan diferenca = fim - inicio;
            Console.WriteLine( "Dias: " + diferenca.Days );
            Console.WriteLine("Horas: " + diferenca.Hours);
            Console.WriteLine("Minutos: " + diferenca.Minutes);
            Console.WriteLine("Segundos: " + diferenca.Seconds);

        }
    }
}
