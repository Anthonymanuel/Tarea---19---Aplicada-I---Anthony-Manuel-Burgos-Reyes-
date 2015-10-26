using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroPelicula
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroPelicula registro = new RegistroPelicula();
            registro.MdiParent = this;
            registro.Show();
            
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaDePelicula consulta = new ConsultaDePelicula();
            consulta.MdiParent = this;
            consulta.Show();
        }

        private void generoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroGeneros genero = new RegistroGeneros();
            genero.MdiParent = this;
            genero.Show();
        }

        private void actorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroActores actor = new RegistroActores();
            actor.MdiParent = this;
            actor.Show();
        }

        private void estudioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroEstudios estudio = new RegistroEstudios();
            estudio.MdiParent= this;
            estudio.Show();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta consulta = new Consulta();
            BLL.ConsultaPelicula consultaPelicula = new BLL.ConsultaPelicula();
            consulta.ConsultaCrystalReportViewer.ReportSource = consultaPelicula;
            consulta.ConsultaCrystalReportViewer.RefreshReport();
            consulta.ShowDialog();
        }
    }
}
