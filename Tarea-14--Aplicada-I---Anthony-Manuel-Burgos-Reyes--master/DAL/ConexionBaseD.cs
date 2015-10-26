using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;



namespace DAL
{   /// <summary>
    /// Clase conexion
    /// </summary>
    public class ConexionBaseD
    {

        private SqlConnection Con;
        private SqlCommand Cmd;
       
       

        public ConexionBaseD()
        {
            Con = new SqlConnection("Data Source = ROOT-PC\\SURPUSER; Initial Catalog = PeliculaDB; Integrated Security = True");
            Cmd = new SqlCommand();
          
            
        }
        /// <summary>
        /// Ejecuta  comandos de  la base de datos
        /// </summary>
        /// <param name="comando">El comando  sql que se desea ejecutar</param>
        /// <returns>Verdadero o Falso dependiendo de si ejecuto correctamente o no</returns>
        public bool Ejecutar(String comando)
        {
            bool retor = false;

            try
            {
                Con.Open();
                Cmd.Connection = Con;
                Cmd.CommandText = comando;
                Cmd.ExecuteNonQuery();
                retor = true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                Con.Close();
            }
            return retor;
        }
        /// <summary>
        /// Para obtener datos de la tabla de la base de datos
        /// </summary>
        /// <param name="comando">El comando  sql que se desea ejecutar</param>
        /// <returns>retorna la tabla de la base de datos</returns> 
        public DataTable ObtenerDatos(String comando)
        {
            SqlDataAdapter adapter;
            DataTable dt = new DataTable();

            try
            {
                Con.Open();
                Cmd.Connection = Con;
                Cmd.CommandText = comando;

                adapter = new SqlDataAdapter(Cmd);
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                Con.Close();
            }

            return dt;
        }
        public Object ObtenerValor(String ComandoSql)
        {
            Object retorno = null;

            try
            {
                Con.Open();
                Cmd.Connection = Con;
                Cmd.CommandText = ComandoSql;
                retorno = Cmd.ExecuteScalar();
                retorno = true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Con.Close();
            }

            return retorno;
        }
    }
}
