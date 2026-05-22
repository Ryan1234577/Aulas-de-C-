using System;

using System.Collections.Generic;

using System.Linq;

using System.Linq.Expressions;

using System.Text;

using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace servicehub

{

    public static class Banco

    {

        //string de conexão com o banco de dados (Mariadb)

        public static string? StrConn { get; set; }

        // metodo para abrir a conexão com o banco de dados - entrega uma conexão aberta,

        // no objetode comando Sql (um objeto do tipo MySqlCommand)

        public static MySqlCommand Abrir(string strConn = "")

        {

            MySqlCommand cmd = new();

            StrConn = strConn;

            if (StrConn == string.Empty)

                //StrConn = $@"server=10.91.47.48;database=servicehubdb01;user=root;password=P@ssw0rd";
                StrConn = $@"server=10.91.47.48;database=comercialdb01;user=root;password=P@ssw0rd";


            MySqlConnection cn = new(StrConn);

            try

            {

                cn.Open();

                cmd.Connection = cn;

            }

            catch (MySqlException ex)

            {

                Console.WriteLine(ex.Message);

            }
            
            return cmd;

        }

    }

}

