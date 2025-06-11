using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleConsultorio
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmMedicos novoMedico = new frmMedicos();
            novoMedico.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmPacientes novoPaciente = new frmPacientes();
            novoPaciente.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmConsultas novoConsulta = new frmConsultas();
            novoConsulta.ShowDialog();
        }
    }
}
