using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Text;

namespace Models
{
   public class Usuario
    {
        public Usuario()
        {
        }

        public int IdUsuario { get; set; }
        public string IpUsuario { get; set; }
        public int QtdeCurtidas { get; set; }
        public string Brownser { get; set; }

        public static List<Usuario> Todos()
        {
            
            var lista = new List<Usuario>();

            SqlConnection conn = new SqlConnection(Conexao.Dados);

            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM TB_CURTIDAS", conn);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lista.Add(new Usuario
                {
                    IdUsuario = Convert.ToInt32(reader["ID_USUARIO"]),
                    IpUsuario = reader["IP_USUARIO"].ToString(),
                    Brownser = reader["BROWNSER"].ToString(),
                    QtdeCurtidas = (int)reader["QTDE_CURTIDA"]

                }); ; 
            }

            conn.Close();
            conn.Dispose();
            cmd.Dispose();

            return lista;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public bool AtualizaUsuarios(Usuario usuario)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Conexao.Dados);

                conn.Open();

                SqlCommand cmd = new SqlCommand(@"UPDATE TB_CURTIDAS SET QTDE_CURTIDA = @QtdeCurtidas WHERE ID_USUARIO = @IdUsuario  ", conn);
                cmd.Parameters.AddWithValue("@IdUsuario", usuario.IdUsuario);
                cmd.Parameters.AddWithValue("@QtdeCurtidas", usuario.QtdeCurtidas);

                cmd.ExecuteNonQuery();
                
            }
            catch (Exception)
            {
                throw;
            }
            return true;
        }
    }
}
