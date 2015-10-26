using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class Generos : ClaseMaestra
    {
        ConexionBaseD conexion = new ConexionBaseD();
        public int GeneroId { get; set; }
        public string Descripcion { get; set; }

        public Generos()
        {
            this.Descripcion = "";
            this.GeneroId = 0;
        }
        public Generos(int generoId, string descripcion)
        {
            this.GeneroId = generoId;
            this.Descripcion = descripcion;
        }


        public override bool Insertar()
        {
            bool retorno = false;
            retorno = conexion.Ejecutar(String.Format("Insert Into Generos (Descripcion) Values ('{0}')", this.Descripcion));
            return retorno;
        }

        public int ObtenerId(string Nombre)
        {
            return (int)conexion.ObtenerDatos(String.Format("Select GeneroId From Generos Where Descripcion = '{0}'", Nombre)).Rows[0]["GeneroId"];
        }

        public override bool Editar()
        {
            bool retorno = false;
            retorno = conexion.Ejecutar(String.Format("Update Generos Set Descripcion = '{0}' Where GeneroId = {1}", this.Descripcion, this.GeneroId));
            return retorno;
        }

        public override bool Eliminar()
        {
            bool retorno = false;
            retorno = conexion.Ejecutar(String.Format("Delete Generos Where GeneroId = {0}", this.GeneroId));
            return retorno;

        }

        public override bool Buscar(int idBuscado)
        {
            DataTable dt = new DataTable();
            dt = conexion.ObtenerDatos((String.Format("Select Descipcion From Generos Where GeneroId = {0}", this.GeneroId)));
            if (dt.Rows.Count > 0)
            {
                this.GeneroId = (int)dt.Rows[0]["GeneroId"];
                this.Descripcion = dt.Rows[0]["Descripcion"].ToString();
            }


            return dt.Rows.Count > 0;

        }
        public override DataTable Listado(string campos, string condicion, string orden)
        {
            string ordenFinal = "";
            if (!orden.Equals(""))
                ordenFinal = " Orden by  " + orden;

            return conexion.ObtenerDatos(("Select " + campos +
                " From Generos Where " + condicion + ordenFinal));
        }
    }
}
