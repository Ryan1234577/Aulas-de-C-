using ServicehubClass;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceHubClass
{
    public class Usuario
    {
        public Usuario() { }
        // Atributos | id nome email senha ativo

        public int Id { get; set; }

        public string Email { get; set; }

        public string Nome { get; set; }

        public string Senha { get; set; }


        public bool Ativo { get; set; }

        // metodos

        public Usuario(int id, string? email, string? nome, string senha, bool ativo)
        {
            Id = id;
            Email = email;
            Nome = nome;
            Senha = senha;
            Ativo = ativo;
        }

        public Usuario(string? email, string? nome, string senha, bool ativo)
        {
            Email = email;
            Nome = nome;
            Senha = senha;
            Ativo = ativo;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            if (cmd.Connection.State == System.Data.ConnectionState.Open)

            { 
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_usuario_insert";
                cmd.Parameters.AddWithValue("spemail", Email);
                cmd.Parameters.AddWithValue("spnome", Nome);
                cmd.Parameters.AddWithValue("spsenha", Senha);
                cmd.Parameters.AddWithValue("spativo", Ativo);
                Id = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Connection.Close();

            }
        }

        public bool Atualizar()
        {
            bool atualizado = false;
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_produto_insert";
            cmd.Parameters.AddWithValue("spids", Id);
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spsenha", Senha);
            cmd.Parameters.AddWithValue("spativo", Ativo);;
            if (cmd.ExecuteNonQuery() > 0)
                atualizado = true;
            cmd.Connection.Close();
            return atualizado;
        }

        public static Usuario ObterPorId(int id)
        {
            Usuario usuario = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from usuarios  where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                usuario = new(
                    dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetBoolean(4));
            }
            return usuario;
        }

        public static List<Usuario> ObterLista()
        {
            List<Usuario> usuarios = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from usuarios order by descricao";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                usuarios.Add(new(
                   dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetBoolean(4)));
            }
            dr.Close();
            cmd.Connection.Close();
            return usuarios;
        }

        public bool Autenticar()
        {
            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Senha))
            {
                Console.WriteLine("E-mail ou senha não preenchidos.");
                return false;
            }
            if (Ativo)
            {
                Console.WriteLine("Usuário inativo não pode se autenticar.");
                return false;
            }
            Console.WriteLine($"Usuário {Nome} autenticado com sucesso!");
            return true;
        }

        public bool AlterarSenha()
        {
            Console.Write("Digite a nova senha: ");
            string novaSenha = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(novaSenha) || novaSenha.Length < 6)
            {
                Console.WriteLine("Senha inválida! A senha deve ter pelo menos 6 caracteres.");
                return false;
            }
            Senha = novaSenha;
            Console.WriteLine("Senha alterada com sucesso!");
            return true;
        }


    }
}
