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
    public partial class frmConsultas : Form
    {
        public frmConsultas()
        {
            InitializeComponent();
        }

        private void consultaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.consultaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.consultorio_CsDataSet);

        }

        private void consultaBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.consultaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.consultorio_CsDataSet);

        }

        private void frmConsultas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'consultorio_CsDataSet.Paciente'. Você pode movê-la ou removê-la conforme necessário.
            this.pacienteTableAdapter.Fill(this.consultorio_CsDataSet.Paciente);
            // TODO: esta linha de código carrega dados na tabela 'consultorio_CsDataSet.Medico'. Você pode movê-la ou removê-la conforme necessário.
            this.medicoTableAdapter.Fill(this.consultorio_CsDataSet.Medico);
            // TODO: esta linha de código carrega dados na tabela 'consultorio_CsDataSet.Consulta'. Você pode movê-la ou removê-la conforme necessário.
            this.consultaTableAdapter.Fill(this.consultorio_CsDataSet.Consulta);

        }

        private void iD_MEDICOComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
