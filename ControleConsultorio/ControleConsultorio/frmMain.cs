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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtPesquisa.Text == "")
            {
                dataGridView1.DataSource = consultaTableAdapter1.
                GetConsultas(dateTimePicker1.Value);
            }
            else
            {
                if (rbMedico.Checked == true)
                {
                    dataGridView1.DataSource = consultaTableAdapter1.
                    GetMedico(txtPesquisa.Text,dateTimePicker1.Value,dateTimePicker2.Value);
                }
                else
                {
                    dataGridView1.DataSource = consultaTableAdapter1.
                    GetPaciente(txtPesquisa.Text, dateTimePicker1.Value, dateTimePicker2.Value);
                }
            }
            
        }
    }
}
