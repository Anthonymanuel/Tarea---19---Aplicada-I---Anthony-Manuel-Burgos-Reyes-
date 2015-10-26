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
    public partial class RegistroEstudios : Form
    {
        string mensaje, mensajeEditar;
        Estudios estudio = new Estudios();
        public RegistroEstudios()
        {
            InitializeComponent();
        }
        private int Validar()
        {
            if (EstudioIdTextBox.Text.Length == 0)
            {
                mensaje = "Se ha guardado el Estudio";
                mensajeEditar = "Error Estudio ID incorecto";
                return 0;
            }
            else
            {
                mensajeEditar = "El Estudio se ha eliminado";
                mensaje = "Se ha Estudio el Actor";
                return 1;
            }
        }
        private void NuevoButton_Click(object sender, EventArgs e)
        {
            EstudioIdTextBox.Clear();
            NombreEstudioTextBox.Clear();

        }
      

        private void GuardarButton_Click_1(object sender, EventArgs e)
        {
            if (Validar() == 0)
            {
                if (NombreEstudioTextBox.Text.Length != 0)
                {
                    estudio.NombreEstudio = NombreEstudioTextBox.Text;
                    estudio.Insertar();
                    NuevoButton.PerformClick();
                }
            }
            if (EstudioIdTextBox.Text.Length > 0)
            {
                estudio.EstudioId = int.Parse(EstudioIdTextBox.Text);
                estudio.NombreEstudio = NombreEstudioTextBox.Text;
                estudio.Editar();
                NuevoButton.PerformClick();
            }
            MessageBox.Show(mensaje);
        }

        private void EliminarButton_Click_1(object sender, EventArgs e)
        {
            if (Validar() > 0)
            {
                estudio.EstudioId = int.Parse(EstudioIdTextBox.Text);

                if (estudio.Eliminar())
                {
                    MessageBox.Show(mensajeEditar);
                    NuevoButton.PerformClick();
                }
                else
                {
                    MessageBox.Show(mensajeEditar);
                }
            }
        } 
    }
}
