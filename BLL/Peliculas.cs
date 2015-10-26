using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using System.IO;
using System.Drawing;

namespace BLL
{    /// <summary>
    /// Clase pelicula
    /// </summary>
    public class Peliculas : ClaseMaestra
    {
        

        public int PeliculaId { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public int Ano { get; set; }
        public int Calificacion { get; set; }
        public int Imbd  { get; set; }
        public int categoriaId { get; set; }
        public string Direccion { get; set; }
        public string Video { get; set; }
        public string Genero { get; set; }
        public string Actor { get; set; }
        public string Estudio { get; set; }
        public List<Actores> Actores { get; set; }
        public List<Generos> Generos { get; set; }

        public Peliculas()
        {
            this.PeliculaId = 1;
            this.Titulo = "";
            this.Descripcion = "";
            this.Ano = 0;
            this.Calificacion = 0;
            this.Imbd = 0;
            this.categoriaId = 0;
            this.Direccion = "";
            this.Video = "";
            this.Estudio = "";
            Actores = new List<Actores>();
            Generos = new List<Generos>();
        }
        public void AgregarActor(int ActorId, string Nombre)
        {
            this.Actores.Add(new Actores(ActorId, Nombre));
        }

        public void AgregarGenero(int GeneroId, string Descripcion)
        {
            this.Generos.Add(new Generos(GeneroId, Descripcion));
        }

        ConexionBaseD conexion = new ConexionBaseD();
        /// <summary>
        /// Insertar elementos en una base de datos
        /// </summary>
        /// <returns>verdadero o falso si se ejecuto corectamente o no</returns>
        public override bool Insertar()
        {
            bool retorno = false;
            StringBuilder Comando = new StringBuilder();
            retorno = conexion.Ejecutar(String.Format("Insert Into Peliculas (Titulo,Descripcion,Ano,Calificacion,IMBD, CategoriaId,Foto,Video,Estudio) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", this.Titulo, this.Descripcion, this.Ano, this.Calificacion, this.Imbd, this.categoriaId, this.Direccion, this.Video, this.Estudio));
            if (retorno)
            {
                this.PeliculaId = (int)conexion.ObtenerDatos("Select Max(PeliculaId) as PeliculaId From Peliculas ").Rows[0]["PeliculaId"];
                foreach (var actor in this.Actores)
                {
                    Comando.AppendLine(String.Format("Insert Into PeliculasActores(PeliculaId,ActorId) Values({0},{1})", this.PeliculaId, actor.ActorId));
                }

                foreach (var genero in this.Generos)
                {
                    Comando.AppendLine(String.Format("Insert Into PeliculasGeneros(PeliculaId,GeneroId) values({0},{1})", this.PeliculaId, genero.GeneroId));
                }
                retorno = conexion.Ejecutar(Comando.ToString());
            }
            return retorno;
        }
        public void Limpiar()
        {
            Actores.Clear();
            Generos.Clear();
             
        }
        /// <summary>
        /// Para Actulizar  los elementos de una tabla de una base de datos
        /// </summary>
        /// <returns>retorna true si actuliza y false sino se actualizo</returns>
        public override bool Editar()
        {
            bool retorno = false;
            StringBuilder Comando = new StringBuilder();

            retorno = conexion.Ejecutar(String.Format("Update Peliculas Set Titulo = '{0}',Descripcion='{1}',Ano ='{2}',Calificacion='{3}',IMBD='{4}',CategoriaId='{5}',Foto='{6}',Video='{7}',Genero= '{8}',Actor= '{9}',Estudio= '{10}' where PeliculaId= {11}", this.Titulo, this.Descripcion, this.Ano, this.Calificacion, this.Imbd, this.categoriaId, this.Direccion, this.Video, this.Genero, this.Actor, this.Estudio, this.PeliculaId));
            if (retorno)
            {
                conexion.Ejecutar("Delete From Peliculas Where PeliculaId =" + this.PeliculaId);
                foreach (var actor in this.Actores)
                {
                    Comando.AppendLine(String.Format("Insert Into PeliculasActores(PeliculaId,ActorId) Values({0},{1})", this.PeliculaId, actor.ActorId));
                }

                foreach (var genero in this.Generos)
                {
                    Comando.AppendLine(String.Format("Insert Into PeliculasGeneros(PeliculaId,GeneroId) Values ({0},{1})", this.PeliculaId, genero.GeneroId));
                }
                retorno = conexion.Ejecutar(Comando.ToString());
            }
            return retorno;

        }
        /// <summary>
        /// Para Eleminar elemento de una tabla de una base de datos
        /// </summary>
        /// <returns>retorna el metodo Obtenerconexion y este a su vez un datatable</returns>

        public override bool Eliminar()
        {
            bool retorno = false;
            retorno = conexion.Ejecutar("Delete  From Peliculas Where PeliculaId = " + this.PeliculaId + "; " +
                                            "Delete From PeliculasActores Where PeliculaId= " + this.PeliculaId + "; " +
                                            "Delete From PeliculasGeneros Where PeliculaId= " + this.PeliculaId);

            return retorno;
        }
        /// <summary>
        /// Para Buscar elemento de una tabla de una base de datos
        /// </summary>
        /// <returns>retorna el metodo Obtenerconexion y este a su vez un datatable</returns>
        public override bool Buscar(int IdBuscado)
        {
            DataTable dt = new DataTable();
            DataTable dtActores = new DataTable();
            DataTable dtGeneros = new DataTable();
            dt = conexion.ObtenerDatos(String.Format("Select * From Peliculas Where PeliculaId={0}", IdBuscado));
            if (dt.Rows.Count > 0)
            {
                this.Titulo = dt.Rows[0]["Titulo"].ToString();
                this.Descripcion = dt.Rows[0]["Descripcion"].ToString();
                this.Ano = (int)dt.Rows[0]["Ano"];
                this.Calificacion = (int)dt.Rows[0]["Calificacion"];
                this.Imbd = (int)dt.Rows[0]["IMBD"];
                this.categoriaId = (int)dt.Rows[0]["CategoriaId"];
                this.Direccion = dt.Rows[0]["Foto"].ToString();
                this.Video = dt.Rows[0]["Video"].ToString();
                

                dtActores = conexion.ObtenerDatos("Select p.ActorId,a.Nombre " +
                                                   "From PeliculasActores p " +
                                                   "Inner Join Actores a On p.ActorId = a.ActorId" +
                                                   "Where p.PeliculaId= " + this.PeliculaId);
                dtGeneros = conexion.ObtenerDatos("Select p.GeneroId,g.Descripcion " +
                                                   "From PeliculasGeneros p " +
                                                   "Inner Join Generos g  On p.GeneroId = g.GeneroId" +
                                                   "Where p.PeliculaId= " + this.PeliculaId);
                foreach (DataRow row in dtActores.Rows)
                {
                    this.AgregarActor((int)row["ActorId"], row["Nombre"].ToString());
                }

                foreach (DataRow row in dtGeneros.Rows)
                {
                    this.AgregarGenero((int)row["GeneroId"], row["Descripcion"].ToString());
                }

            }

            return dt.Rows.Count > 0;
        }


        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            string ordenFinal = ""; //!orden.Equals("") ? " orden by  " + orden : "";
            if (!Orden.Equals(""))
                ordenFinal = " Orden by  " + Orden;

            return conexion.ObtenerDatos(("Select " + Campos +
                " From Peliculas Where " + Condicion + ordenFinal));
        }
    }
}
