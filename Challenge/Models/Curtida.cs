using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Text;

namespace Models
{
   public class Curtida
    {
        public Curtida()
        {

        }

        public int IdCurtida { get; set; }
        public string IpCurtida { get; set; }
        public int QtdeCurtidas { get; set; }
        public string Brownser { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<Curtida> Todos()
        {
            
            var lista = new List<Curtida>();

            SqlConnection conn = new SqlConnection(Conexao.Dados);

            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM TB_CURTIDAS", conn);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lista.Add(new Curtida
                {
                    IdCurtida = Convert.ToInt32(reader["ID_CURTIDA"]),
                    IpCurtida = reader["IP_CURTIDA"].ToString(),
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
        /// <param name="Curtida"></param>
        /// <returns></returns>
        public bool AtualizaCurtidas(Curtida Curtida)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Conexao.Dados);

                conn.Open();

                SqlCommand cmd = new SqlCommand(@"UPDATE TB_CURTIDAS SET QTDE_CURTIDA = @QtdeCurtidas WHERE ID_Curtida = @IdCurtida  ", conn);
                cmd.Parameters.AddWithValue("@IdCurtida", Curtida.IdCurtida);
                cmd.Parameters.AddWithValue("@QtdeCurtidas", Curtida.QtdeCurtidas);

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
