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
    public partial class RegistroGeneros : Form
    {
        Generos genero = new Generos();
        string mensaje,mensajeEditar;
        public RegistroGeneros()
        {
            InitializeComponent();
        }
        private int  Validar()
        {
            if (GeneroIdTextBox.Text.Length == 0)
            {
                mensaje = "Se ha guardado el genero";
                mensajeEditar = "Error genero ID incorecto";
                return 0;
            }
            else
            {
                mensajeEditar = "El genero se ha eliminado";
                mensaje = "se ha editado el genero";
                return 1;
            }
        }
        private void NuevoButton_Click(object sender, EventArgs e)
        {
            GeneroIdTextBox.Clear();
            DescripcionRichTextBox.Clear();

        }
        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if (Validar() == 0)
            {
                if (DescripcionRichTextBox.Text.Length != 0)
                {
                    genero.Descripcion = DescripcionRichTextBox.Text;
                    genero.Insertar();
                    NuevoButton.PerformClick();
                }
            }
            if (GeneroIdTextBox.Text.Length > 0)
            {
                genero.GeneroId = int.Parse(GeneroIdTextBox.Text);
                genero.Descripcion = DescripcionRichTextBox.Text;
                genero.Editar();
                NuevoButton.PerformClick();
            }
            MessageBox.Show(mensaje);

        }
        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (Validar() > 0)
            {
                genero.GeneroId = int.Parse(GeneroIdTextBox.Text);

                if (genero.Eliminar())
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
