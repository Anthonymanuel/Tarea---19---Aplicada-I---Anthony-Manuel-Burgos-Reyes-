using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class Estudios: ClaseMaestra
    {
        public int EstudioId { get; set; }
        public string NombreEstudio { get; set; }
        ConexionBaseD  conexion = new ConexionBaseD();
        public Estudios()
        {
            this.EstudioId = 0;
            this.NombreEstudio = "";
        }
        public Estudios(int estudioId,string nombreEstudio)
        {
            this.EstudioId = estudioId;
            this.NombreEstudio = nombreEstudio;
        }

        public override bool Insertar()
        {
            bool retorno = false;
            retorno =  conexion.Ejecutar(String.Format("Insert Into Estudios (NombreEstudio) values('{0}')",this.NombreEstudio));
            return retorno;
        }

        public override bool Editar()
        {
            bool retorno = false;

            retorno = conexion.Ejecutar(String.Format("update Estudios set NombreEstudio= '{0}' where EstudioId= '{1}'", this.NombreEstudio,this.EstudioId));
            return retorno;
        }

        public override bool Eliminar()
        {
            bool retorno = false;
            retorno = conexion.Ejecutar(String.Format("Delete  Estudios  where  EstudioId = {0}", this.EstudioId));
            return retorno;

        }

        public override bool Buscar(int idBuscado)
        {
            DataTable dt = new DataTable();
            dt=(conexion.ObtenerDatos(String.Format("Select EstudioId, NombreEstudio from Estudio where EstudioId = '{0}'",this.EstudioId)));
            if(dt.Rows.Count > 0)
            {
                this.EstudioId = (int)dt.Rows[0]["EstudioId"];
                this.NombreEstudio = dt.Rows[0]["NombreEstudio"].ToString();
            }
            return dt.Rows.Count > 0;
        }

        public override DataTable Listado(string campos, string condicion, string orden)
        {
            string ordenFinal = ""; 
            if (!orden.Equals(""))
                ordenFinal = " orden by  " + orden;

            return conexion.ObtenerDatos(("Select " + campos +
                " from Estudios where " + condicion + ordenFinal));
        }
    }
}
