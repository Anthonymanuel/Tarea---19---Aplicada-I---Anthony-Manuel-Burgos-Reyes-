using System;
using System.Collections;
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
    public partial class RegistroPelicula : Form
    {
        Peliculas pelicula = new Peliculas();
        DataTable dt = new DataTable();
        Actores actor = new Actores();
        Generos genero = new Generos();

        string datos,datos2,datos3;
        public RegistroPelicula()
        {
            InitializeComponent();
            CategoriaIdComboBox.SelectedIndex = 0;
        }

        string direccion,video,mensaje,mensajeEliminar;
        private int Validar()
        {
            if (PeliculaIdTextBox.Text.Length == 0)
            {
                mensaje = "Se ha registrado la pelicula";
                mensajeEliminar = "Error Pelicula ID incorecto";
                
                return 0;
            }
            else
            {
                 mensajeEliminar = "La pelicula se ha eliminado";
                mensaje = "Se ha editado la pelicula";
                return 1;
            }
        }
        private void Datos()
        {
            if (Validar() > 0)
            {
               pelicula.PeliculaId = Convert.ToInt32(PeliculaIdTextBox.Text);
            }
            pelicula.Titulo = TituloTextBox.Text;
            pelicula.Descripcion = DescripcionTextBox.Text;
            pelicula.Ano = int.Parse(AnoTextBox.Text);
            pelicula.Calificacion = int.Parse(CalificacionTextBox.Text);
            pelicula.Imbd = int.Parse(IMDBTextBox.Text);
            pelicula.categoriaId = int.Parse(CategoriaIdComboBox.Text);
            pelicula.Direccion = direccion;
            pelicula.Video = video;
            for (int x =0; x< GeneroListView.Items.Count; x++)
            {
                pelicula.AgregarGenero(genero.ObtenerId(GeneroListView.Items[x].Text), GeneroListView.Items[x].Text);
            }
            
            for (int x = 0; x < ActorListView.Items.Count; x++)
            {
                pelicula.AgregarActor(actor.ObtenerId(ActorListView.Items[x].Text),ActorListView.Items[x].Text);    
            }

        }
        private void NuevoButton_Click(object sender, EventArgs e)
        {
            PeliculaIdTextBox.Clear();
            TituloTextBox.Clear();
            DescripcionTextBox.Clear();
            AnoTextBox.Clear();
            CalificacionTextBox.Clear();
            IMDBTextBox.Clear();
            FotoPictureBox.Image = null;
            ReproductorAxWindowsMediaPlayer1.URL = null;
            ActorComboBox.Text = "";
            GeneroComboBox.Text = "";
            EstudioTextBox.Text = "";
            ActorListView.Items.Clear();
            GeneroListView.Items.Clear();
            CategoriaIdComboBox.Text = "";
            pelicula.Limpiar();
        }
        private void GuardarButton_Click(object sender, EventArgs e)
        {   
            if (Validar() == 0)
            {
                Datos();
                pelicula.Insertar();
                NuevoButton.PerformClick();
               
            }
            if (Validar() > 0)
            {
                Datos();
                pelicula.Editar();
                NuevoButton.PerformClick();
                
            }
               
            MessageBox.Show(mensaje);
        }
        
        private void RegistroPelicula_Load(object sender, EventArgs e)
        {
            Generos genero = new Generos();
            GeneroComboBox.DataSource = genero.Listado("GeneroId ,Descripcion ", " 1=1", "");
            GeneroComboBox.DisplayMember = "Descripcion";
            GeneroComboBox.ValueMember = "Descripcion";

            Actores actor = new Actores();
            ActorComboBox.DataSource = actor.Listado("ActorId, Nombre ", " 1=1", "");
            ActorComboBox.DisplayMember = "Nombre";
            ActorComboBox.ValueMember = "Nombre";

            Estudios estudio = new Estudios();
            EstudioComboBox.DataSource = estudio.Listado("EstudioId, NombreEstudio", "1=1","");
            EstudioComboBox.DisplayMember = "NombreEstudio";
            EstudioComboBox.ValueMember = "NombreEstudio";
        }

        private void GeneroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            datos = GeneroComboBox.SelectedValue.ToString();
            
        }

        private void ActorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            datos2 = ActorComboBox.SelectedValue.ToString();
        }

        private void EstudioComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            datos3 = EstudioComboBox.SelectedValue.ToString();
            pelicula.Estudio = datos3;
        }

        private void SeleccionButton_Click(object sender, EventArgs e)
        {
           
            GeneroListView.Items.Add(datos);
        }

        private void SeleccionaButton_Click(object sender, EventArgs e)
        {
           ActorListView.Items.Add(datos2);
        }

        private void Seleccionar1Button_Click(object sender, EventArgs e)
        {
            EstudioTextBox.Text = datos3;
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (Validar() > 0)
            {
                pelicula.PeliculaId = Convert.ToInt32(PeliculaIdTextBox.Text);

                if (pelicula.Eliminar())
                {
                    MessageBox.Show(mensajeEliminar);
                    NuevoButton.PerformClick();
                }
                else
                {
                    MessageBox.Show(mensajeEliminar);
                }
            }

        }
        private void SeleccionarButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscar = new OpenFileDialog();
            buscar.Filter = "Archivo de imagen|*.png;*.bmp*.gif;*.jpg;*.tif ";
            buscar.Title = "";
            buscar.FileName = "Seleccione una imagen";
            buscar.InitialDirectory = "C:\\Users\\.\\Desktop";
            if(buscar.ShowDialog()== DialogResult.OK)
            {
                direccion = buscar.FileName;
                FotoPictureBox.ImageLocation = direccion;
            }
        }

       
        private void SeleccionarVideoButton_Click(object sender, EventArgs e)
         {
            OpenFileDialog buscar = new OpenFileDialog();
            buscar.Filter = "Archivo de Video|*.mp4;*.avi ";
            buscar.Title = "";
            buscar.FileName = "Seleccione un Video";
            buscar.InitialDirectory = "C:\\Users\\.\\Desktop";
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                video = buscar.FileName;
                ReproductorAxWindowsMediaPlayer1.URL = video;
                
            }   
        }
    }
}
