using MySql.Data.MySqlClient;
using ServiceHubClass;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceHubClass
{
    public class Categoria
    {
        // atributos (Propriedades):
        // receber = set;
        // entregar = get;
        //private int id;
        //private string? nome;
        //private string? sigla;
        // Propriedades:
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Sigla { get; set; }

        // construtores (métodos)
        public Categoria(string? nome, string? sigla)
        {
            Nome = nome;
            Sigla = sigla;
        }
        public Categoria() { 
            Id = 0;
        }
        public Categoria(int id, string? nome, string? sigla)
        {
            Id = id;
            Nome = nome;
            Sigla = sigla;
        }



        // Métodos (Funcionalidades RFs) - inserir, atualizar, listar, obterPorId(id), excluir(id)
        public void Inserir()
        {
            // O método é chamado

            var cmd = Banco.Abrir();
            if (cmd.Connection.State == ConnectionState.Open)
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_categoria_insert";
                cmd.Parameters.AddWithValue("spnome", Nome);
                cmd.Parameters.AddWithValue("spsigla", Sigla);
                Id = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Connection.Close();
            }
        }

        public static Categoria ObterPorId(int id)
        {

        }

    }
}
