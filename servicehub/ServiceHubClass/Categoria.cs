using MySql.Data.MySqlClient;
using ServicehubClass;
using System;
using System.Collections.Generic;
using System.Data;

namespace ServiceHubClass
{
    public class Categoria
    {
        // PROPRIEDADES
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Sigla { get; set; }

        // CONSTRUTORES
        public Categoria()
        {
            Id = 0;
        }

        public Categoria(int id)
        {
            Id = id;
        }

        public Categoria(string? nome, string? sigla)
        {
            Nome = nome;
            Sigla = sigla;
        }

        public Categoria(int id, string? nome, string? sigla)
        {
            Id = id;
            Nome = nome;
            Sigla = sigla;
        }

        // INSERIR
        public void Inserir()
        {
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

        // OBTER POR ID
        public static Categoria ObterPorId(int id)
        {
            Categoria cat = new();

            var cmd = Banco.Abrir();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM categorias WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", id);

            var dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                cat = new Categoria(
                    dr.GetInt32("id"),

                    dr["nome"] != DBNull.Value
                        ? dr["nome"].ToString()
                        : "",

                    dr["sigla"] != DBNull.Value
                        ? dr["sigla"].ToString()
                        : ""
                );
            }

            dr.Close();
            cmd.Connection.Close();

            return cat;
        }

        // LISTAR
        public static List<Categoria> ObterLista(string busca = "")
        {
            List<Categoria> categorias = new();

            var cmd = Banco.Abrir();

            if (cmd.Connection.State == ConnectionState.Open)
            {
                cmd.CommandType = CommandType.Text;

                // COM BUSCA
                if (!string.IsNullOrEmpty(busca))
                {
                    cmd.CommandText =
                        "SELECT * FROM categorias " +
                        "WHERE nome LIKE @busca " +
                        "ORDER BY nome";

                    cmd.Parameters.AddWithValue("@busca", "%" + busca + "%");
                }
                else
                {
                    cmd.CommandText =
                        "SELECT * FROM categorias ORDER BY nome";
                }

                var dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Categoria cat = new Categoria(
                        dr.GetInt32("id"),

                        dr["nome"] != DBNull.Value
                            ? dr["nome"].ToString()
                            : "",

                        dr["sigla"] != DBNull.Value
                            ? dr["sigla"].ToString()
                            : ""
                    );

                    categorias.Add(cat);
                }

                dr.Close();
                cmd.Connection.Close();
            }

            return categorias;
        }

        // ATUALIZAR
        public bool Atualizar()
        {
            bool atualizada = false;

            if (Id < 1)
                return atualizada;

            var cmd = Banco.Abrir();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_categoria_update";

            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spsigla", Sigla);

            if (cmd.ExecuteNonQuery() > 0)
            {
                atualizada = true;
            }

            cmd.Connection.Close();

            return atualizada;
        }

        // EXCLUIR
        public void Excluir()
        {
            var cmd = Banco.Abrir();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_categoria_delete";

            cmd.Parameters.AddWithValue("spid", Id);

            cmd.ExecuteNonQuery();

            cmd.Connection.Close();
        }
    }
}