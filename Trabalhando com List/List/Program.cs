using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> Convocacao = new List<string>();

            // Goleiros
            Convocacao.Add("Hugo Souza");
            Convocacao.Add("Ederson");
            Convocacao.Add("Bento");

            // Defensores
            Convocacao.Add("Marquinhos");
            Convocacao.Add("Danilo");
            Convocacao.Add("Ibañez");
            Convocacao.Add("Alex Sandro");
            Convocacao.Add("Léo Pereira");
            Convocacao.Add("Carlos Augusto");
            Convocacao.Add("Wesley");

            // Meio-Campistas
            Convocacao.Add("Casemiro");
            Convocacao.Add("Bruno Guimarães");
            Convocacao.Add("Fabinho");
            Convocacao.Add("Lucas Paquetá");
            Convocacao.Add("Danilo");
            Convocacao.Add("Andrey");

            //Atacantes
            Convocacao.Add("Vinicius Junior");
            Convocacao.Add("Raphinha");
            Convocacao.Add("Neymar");
            Convocacao.Add("Endrick");
            Convocacao.Add("Luiz Henrique");
            Convocacao.Add("Matinelli");

            foreach (string nome in Convocacao)
            {
                Console.WriteLine(nome);
            }





        }
    }
}
