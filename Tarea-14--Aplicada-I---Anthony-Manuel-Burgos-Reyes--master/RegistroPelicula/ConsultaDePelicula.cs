using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace RegistroPelicula
{
    public partial class ConsultaDePelicula : Form
    {
        public ConsultaDePelicula()
        {
            InitializeComponent();
            
        }
        private void ConsultaForm_Load(object sender, EventArgs e)
        {
            ConsultaComboBox.SelectedIndex = 0;
        }

        private void BuscarButton_Click_1(object sender, EventArgs e)
        {
            Peliculas pelicula = new Peliculas();
            DataTable dt = new DataTable();
            string consulta;
            switch (ConsultaComboBox.SelectedIndex) {
              case 0:
            
                if (PeliculaIdTextBox.Text.Trim().Length == 0)
                {
                    consulta = "1=1";
                }
                else
                {
                    consulta = "PeliculaId = " + PeliculaIdTextBox.Text;
                }


                dt = pelicula.Listado(" PeliculaId,Titulo,Descripcion,Ano,Calificacion,IMBD,CategoriaId,Foto,Video, Genero, Actor, Estudio", consulta,"");
                MostrarDataGridView.DataSource = dt;
                ReproductorAxWindowsMediaPlayer1.URL = Convert.ToString(MostrarDataGridView.CurrentRow.Cells["Video"].Value);
                FotoPictureBox.ImageLocation = Convert.ToString(MostrarDataGridView.CurrentRow.Cells["Foto"].Value);
                    break;
            
            case 1:
            
                if (PeliculaIdTextBox.Text.Trim().Length == 1)
                {
                    consulta = "2=2";
                }
                else
                {
                    consulta = "Titulo = '" +PeliculaIdTextBox.Text + "'";
                }
                    dt = pelicula.Listado(" PeliculaId,Titulo,Descripcion,Ano,Calificacion,IMBD, CategoriaId,Foto,Video,Genero,Actor,Estudio", consulta,"");
                    MostrarDataGridView.DataSource = dt;
                    ReproductorAxWindowsMediaPlayer1.URL = Convert.ToString(MostrarDataGridView.CurrentRow.Cells["Video"].Value);
                    FotoPictureBox.ImageLocation = Convert.ToString(MostrarDataGridView.CurrentRow.Cells["Foto"].Value);
                    break;
           case  2:
            
                if (PeliculaIdTextBox.Text.Trim().Length == 2)
                {
                    consulta = "3=3";
                }
                else
                {
                    consulta = "Descripcion =" + "'" + PeliculaIdTextBox.Text + "'";
                }
                    dt = pelicula.Listado(" PeliculaId,Titulo,Descripcion,Ano,Calificacion,IMBD, CategoriaId,Foto,Video,Genero,Actor,Estudio", consulta,"");
                    MostrarDataGridView.DataSource = dt;
                    FotoPictureBox.ImageLocation = Convert.ToString(MostrarDataGridView.CurrentRow.Cells["Foto"].Value);
                    ReproductorAxWindowsMediaPlayer1.URL = Convert.ToString(MostrarDataGridView.CurrentRow.Cells["Video"].Value);
                    break;
             case 3:
                    if (PeliculaIdTextBox.Text.Trim().Length == 3)
                    {
                        consulta = "4=4";
                    }
                    else
                    {
                        consulta = "Ano =" + PeliculaIdTextBox.Text ;
                    }
                    dt = pelicula.Listado(" PeliculaId,Titulo,Descripcion,Ano,Calificacion,IMBD, CategoriaId,Foto,Video,Genero,Actor,Estudio", consulta,"");
                    MostrarDataGridView.DataSource = dt;
                    FotoPictureBox.ImageLocation = Convert.ToString(MostrarDataGridView.CurrentRow.Cells["Foto"].Value);
                    ReproductorAxWindowsMediaPlayer1.URL = Convert.ToString(MostrarDataGridView.CurrentRow.Cells["Video"].Value);
                    break;
                case 5:
                    if (PeliculaIdTextBox.Text.Trim().Length == 4)
                    {
                        consulta = "5=5";
                    }
                    else
                    {
                        consulta = "Calificacion ="+ PeliculaIdTextBox.Text;
                    }
                    dt = pelicula.Listado(" PeliculaId,Titulo,Descripcion,Ano,Calificacion,IMBD, CategoriaId,Foto,Video,Genero,Actor,Estudio", consulta,"");
                    MostrarDataGridView.DataSource = dt;
                    ReproductorAxWindowsMediaPlayer1.URL = Convert.ToString(MostrarDataGridView.CurrentRow.Cells["Video"].Value);
                    FotoPictureBox.ImageLocation = Convert.ToString(MostrarDataGridView.CurrentRow.Cells["Foto"].Value);
                    break;
                case 6:
                    if (PeliculaIdTextBox.Text.Trim().Length == 5)
                    {
                        consulta = "6=6";
                    }
                    else
                    {
                        consulta = "IMBD =" +  PeliculaIdTextBox.Text ;
                    }
                    dt = pelicula.Listado(" PeliculaId,Titulo,Descripcion,Ano,Calificacion,IMBD, CategoriaId,Foto,Video,Genero,Actor,Estudio", consulta,"");
                    MostrarDataGridView.DataSource = dt;
                    FotoPictureBox.ImageLocation = Convert.ToString(MostrarDataGridView.CurrentRow.Cells["Foto"].Value);
                    ReproductorAxWindowsMediaPlayer1.URL = Convert.ToString(MostrarDataGridView.CurrentRow.Cells["Video"].Value);
                    break;
                case 7:
                    if (PeliculaIdTextBox.Text.Trim().Length == 5)
                    {
                        consulta = "6=6";
                    }
                    else
                    {
                        consulta = "ClasificacionId =" + PeliculaIdTextBox.Text ;
                    }
                    dt = pelicula.Listado(" PeliculaId,Titulo,Descripcion,Ano,Calificacion,IMBD, CategoriaId,Foto,Video,Genero,Actor,Estudio", consulta,"");
                    MostrarDataGridView.DataSource = dt;
                    ReproductorAxWindowsMediaPlayer1.URL = Convert.ToString(MostrarDataGridView.CurrentRow.Cells["Video"].Value);
                    FotoPictureBox.ImageLocation = Convert.ToString(MostrarDataGridView.CurrentRow.Cells["Foto"].Value);
                    break;
             

        }
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            ReproductorAxWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            ReproductorAxWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            ReproductorAxWindowsMediaPlayer1.Ctlcontrols.play();

        }
    }
}
