using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Actores: ClaseMaestra
    {
        public int ActorId { get; set; }
        public string Nombre { get; set; }
        ConexionBaseD conexion = new ConexionBaseD();
        public Actores()
        {
            this.ActorId = 0;
            this.Nombre = "";
        }

        public Actores(int actorId, string nombre)
        {
            this.ActorId = actorId;
            this.Nombre = nombre;
        }

        public override bool Insertar()
        {
            bool retorno = false;
            retorno = conexion.Ejecutar(String.Format("Insert Into Actores (Nombre) Values('{0}')", this.Nombre));
            return retorno;
        }
        public int ObtenerId(string Nombre)
        {
            return (int)conexion.ObtenerDatos(String.Format("Select ActorId From Actores Where Nombre = '{0}'", Nombre)).Rows[0]["ActorId"];
        }
        public override bool Editar()
        {
            bool retorno = false;
            retorno = conexion.Ejecutar(String.Format("Update Actores Set Nombre= '{0}' Where ActorId = {1}", this.Nombre, this.ActorId));
            return retorno;
        }

        public override bool Eliminar()
        {
            bool retorno = false;
            retorno = conexion.Ejecutar(String.Format("Delete  Actores Where ActorId ={0}", this.ActorId));
            return retorno;
        }

        public override bool Buscar(int idBuscado)
        {
            DataTable dt = new DataTable();
            dt = (conexion.ObtenerDatos(String.Format("Select ActorId, Nombre From Where ActorId = {0}", this.ActorId)));
            if (dt.Rows.Count > 0)
            {
                this.ActorId = (int)dt.Rows[0]["ActorId"];
                this.Nombre = dt.Rows[0]["Nombre"].ToString();
            }
            return dt.Rows.Count > 0;
        }

        public override DataTable Listado(string campos, string condicion, string orden)
        {
            string ordenFinal = "";
            if (!orden.Equals(""))
                ordenFinal = " Orden by  " + orden;

            return conexion.ObtenerDatos(("Select " + campos +
                " From Actores Where " + condicion + ordenFinal));
        }
    }
}
