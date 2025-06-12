namespace ControleConsultorio
{
    partial class frmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.gbIntervaloDatas = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.gbFiltroPesquisa = new System.Windows.Forms.GroupBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.rbMedico = new System.Windows.Forms.RadioButton();
            this.rbPaciente = new System.Windows.Forms.RadioButton();
            this.gbConsultasdoDia = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.consultaTableAdapter1 = new ControleConsultorio.Consultorio_CsDataSetTableAdapters.ConsultaTableAdapter();
            this.ID_CONSULTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_PACIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_MEDICO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Retorno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_PACIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_MEDICO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.gbIntervaloDatas.SuspendLayout();
            this.gbFiltroPesquisa.SuspendLayout();
            this.gbConsultasdoDia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(790, 38);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::ControleConsultorio.Properties.Resources.checkbox;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripButton1.Size = new System.Drawing.Size(56, 35);
            this.toolStripButton1.Text = "Médicos";
            this.toolStripButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::ControleConsultorio.Properties.Resources.termometro;
            this.toolStripButton2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(61, 35);
            this.toolStripButton2.Text = "Pacientes";
            this.toolStripButton2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(63, 35);
            this.toolStripButton3.Text = "Consultas";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // gbIntervaloDatas
            // 
            this.gbIntervaloDatas.BackColor = System.Drawing.Color.Transparent;
            this.gbIntervaloDatas.Controls.Add(this.label2);
            this.gbIntervaloDatas.Controls.Add(this.label1);
            this.gbIntervaloDatas.Controls.Add(this.dateTimePicker2);
            this.gbIntervaloDatas.Controls.Add(this.dateTimePicker1);
            this.gbIntervaloDatas.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbIntervaloDatas.Location = new System.Drawing.Point(12, 57);
            this.gbIntervaloDatas.Name = "gbIntervaloDatas";
            this.gbIntervaloDatas.Size = new System.Drawing.Size(230, 100);
            this.gbIntervaloDatas.TabIndex = 1;
            this.gbIntervaloDatas.TabStop = false;
            this.gbIntervaloDatas.Text = "Intervalo entre datas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Até:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "De:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(85, 57);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(132, 26);
            this.dateTimePicker2.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(85, 20);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(132, 26);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // gbFiltroPesquisa
            // 
            this.gbFiltroPesquisa.BackColor = System.Drawing.Color.Transparent;
            this.gbFiltroPesquisa.Controls.Add(this.txtPesquisa);
            this.gbFiltroPesquisa.Controls.Add(this.btnPesquisar);
            this.gbFiltroPesquisa.Controls.Add(this.rbMedico);
            this.gbFiltroPesquisa.Controls.Add(this.rbPaciente);
            this.gbFiltroPesquisa.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFiltroPesquisa.Location = new System.Drawing.Point(257, 57);
            this.gbFiltroPesquisa.Name = "gbFiltroPesquisa";
            this.gbFiltroPesquisa.Size = new System.Drawing.Size(269, 100);
            this.gbFiltroPesquisa.TabIndex = 2;
            this.gbFiltroPesquisa.TabStop = false;
            this.gbFiltroPesquisa.Text = "Filtro de pesquisa";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(6, 33);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(257, 25);
            this.txtPesquisa.TabIndex = 2;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(156, 71);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(107, 23);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // rbMedico
            // 
            this.rbMedico.AutoSize = true;
            this.rbMedico.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMedico.Location = new System.Drawing.Point(79, 72);
            this.rbMedico.Name = "rbMedico";
            this.rbMedico.Size = new System.Drawing.Size(66, 19);
            this.rbMedico.TabIndex = 0;
            this.rbMedico.TabStop = true;
            this.rbMedico.Text = "Médico";
            this.rbMedico.UseVisualStyleBackColor = true;
            // 
            // rbPaciente
            // 
            this.rbPaciente.AutoSize = true;
            this.rbPaciente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPaciente.Location = new System.Drawing.Point(6, 71);
            this.rbPaciente.Name = "rbPaciente";
            this.rbPaciente.Size = new System.Drawing.Size(73, 19);
            this.rbPaciente.TabIndex = 0;
            this.rbPaciente.TabStop = true;
            this.rbPaciente.Text = "Paciente";
            this.rbPaciente.UseVisualStyleBackColor = true;
            // 
            // gbConsultasdoDia
            // 
            this.gbConsultasdoDia.BackColor = System.Drawing.Color.Transparent;
            this.gbConsultasdoDia.Controls.Add(this.label3);
            this.gbConsultasdoDia.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConsultasdoDia.Location = new System.Drawing.Point(532, 57);
            this.gbConsultasdoDia.Name = "gbConsultasdoDia";
            this.gbConsultasdoDia.Size = new System.Drawing.Size(231, 100);
            this.gbConsultasdoDia.TabIndex = 2;
            this.gbConsultasdoDia.TabStop = false;
            this.gbConsultasdoDia.Text = "Consultas do dia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "label3";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_CONSULTA,
            this.ID_PACIENTE,
            this.ID_MEDICO,
            this.Retorno,
            this.NOME_PACIENTE,
            this.NOME_MEDICO,
            this.HORARIO,
            this.DATA});
            this.dataGridView1.Location = new System.Drawing.Point(12, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(773, 280);
            this.dataGridView1.TabIndex = 3;
            // 
            // consultaTableAdapter1
            // 
            this.consultaTableAdapter1.ClearBeforeFill = true;
            // 
            // ID_CONSULTA
            // 
            this.ID_CONSULTA.DataPropertyName = "ID_CONSULTA";
            this.ID_CONSULTA.HeaderText = "Código";
            this.ID_CONSULTA.Name = "ID_CONSULTA";
            this.ID_CONSULTA.Width = 80;
            // 
            // ID_PACIENTE
            // 
            this.ID_PACIENTE.DataPropertyName = "ID_PACIENTE";
            this.ID_PACIENTE.HeaderText = "Id paciente";
            this.ID_PACIENTE.Name = "ID_PACIENTE";
            this.ID_PACIENTE.Visible = false;
            // 
            // ID_MEDICO
            // 
            this.ID_MEDICO.DataPropertyName = "ID_MEDICO";
            this.ID_MEDICO.HeaderText = "Id medico";
            this.ID_MEDICO.Name = "ID_MEDICO";
            this.ID_MEDICO.Visible = false;
            // 
            // Retorno
            // 
            this.Retorno.DataPropertyName = "Retorno";
            this.Retorno.HeaderText = "Retorno";
            this.Retorno.Name = "Retorno";
            this.Retorno.Visible = false;
            // 
            // NOME_PACIENTE
            // 
            this.NOME_PACIENTE.DataPropertyName = "NOME_PACIENTE";
            this.NOME_PACIENTE.HeaderText = "Paciente";
            this.NOME_PACIENTE.Name = "NOME_PACIENTE";
            this.NOME_PACIENTE.Width = 220;
            // 
            // NOME_MEDICO
            // 
            this.NOME_MEDICO.DataPropertyName = "NOME_MEDICO";
            this.NOME_MEDICO.HeaderText = "Médico";
            this.NOME_MEDICO.Name = "NOME_MEDICO";
            this.NOME_MEDICO.Width = 220;
            // 
            // HORARIO
            // 
            this.HORARIO.DataPropertyName = "HORARIO";
            this.HORARIO.HeaderText = "Horário";
            this.HORARIO.Name = "HORARIO";
            this.HORARIO.Width = 125;
            // 
            // DATA
            // 
            this.DATA.DataPropertyName = "DATA";
            this.DATA.HeaderText = "Data";
            this.DATA.Name = "DATA";
            this.DATA.Width = 125;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ControleConsultorio.Properties.Resources._1600px_COLOURBOX34432642;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(790, 455);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbConsultasdoDia);
            this.Controls.Add(this.gbFiltroPesquisa);
            this.Controls.Add(this.gbIntervaloDatas);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ControleConsultas";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbIntervaloDatas.ResumeLayout(false);
            this.gbIntervaloDatas.PerformLayout();
            this.gbFiltroPesquisa.ResumeLayout(false);
            this.gbFiltroPesquisa.PerformLayout();
            this.gbConsultasdoDia.ResumeLayout(false);
            this.gbConsultasdoDia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.GroupBox gbIntervaloDatas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox gbFiltroPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.RadioButton rbMedico;
        private System.Windows.Forms.RadioButton rbPaciente;
        private System.Windows.Forms.GroupBox gbConsultasdoDia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Consultorio_CsDataSetTableAdapters.ConsultaTableAdapter consultaTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CONSULTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PACIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_MEDICO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Retorno;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_PACIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_MEDICO;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA;
    }
}

