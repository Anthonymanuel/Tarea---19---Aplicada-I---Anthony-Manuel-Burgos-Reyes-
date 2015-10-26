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
    public partial class RegistroActores : Form
    {
        string mensaje,mensajeEditar;
        Actores actor = new Actores();
        public RegistroActores()
        {
            InitializeComponent();
        }
        private int Validar()
        {
            if (ActorIdTextBox.Text.Length == 0)
            {
                mensaje = "Se ha guardado el Actor";
                mensajeEditar = "Error Actor ID incorecto";
                return 0;
            }
            else
            {
                mensajeEditar = "El Actor se ha eliminado";
                mensaje = "Se ha editado el Actor";
                return 1;
            }
        }
        private void NuevoButton_Click(object sender, EventArgs e)
        {
            ActorIdTextBox.Clear();
            NombreTextBox.Clear();

        }
        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if (Validar() == 0)
            {
                if (NombreTextBox.Text.Length != 0)
                {
                    actor.Nombre = NombreTextBox.Text;
                    actor.Insertar();
                    NuevoButton.PerformClick();
                }
            }
            if (ActorIdTextBox.Text.Length > 0)
            {
                actor.ActorId = int.Parse(ActorIdTextBox.Text);
                actor.Nombre = NombreTextBox.Text;
                actor.Editar();
                NuevoButton.PerformClick();
            }
            MessageBox.Show(mensaje);

        }
        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (Validar() > 0)
            {
                actor.ActorId = int.Parse(ActorIdTextBox.Text);

                if (actor.Eliminar())
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
