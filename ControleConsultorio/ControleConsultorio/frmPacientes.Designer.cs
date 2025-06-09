namespace ControleConsultorio
{
    partial class frmPacientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPacientes));
            System.Windows.Forms.Label iD_PACIENTELabel;
            System.Windows.Forms.Label nOME_PACIENTELabel;
            System.Windows.Forms.Label eNDERECOLabel;
            System.Windows.Forms.Label nUMEROLabel;
            System.Windows.Forms.Label bAIRROLabel;
            System.Windows.Forms.Label cIDADELabel;
            System.Windows.Forms.Label cEPLabel;
            System.Windows.Forms.Label sEXOLabel;
            System.Windows.Forms.Label tELEFONELabel;
            System.Windows.Forms.Label cELULARLabel;
            this.consultorio_CsDataSet = new ControleConsultorio.Consultorio_CsDataSet();
            this.pacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacienteTableAdapter = new ControleConsultorio.Consultorio_CsDataSetTableAdapters.PacienteTableAdapter();
            this.tableAdapterManager = new ControleConsultorio.Consultorio_CsDataSetTableAdapters.TableAdapterManager();
            this.pacienteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.pacienteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_PACIENTETextBox = new System.Windows.Forms.TextBox();
            this.nOME_PACIENTETextBox = new System.Windows.Forms.TextBox();
            this.eNDERECOTextBox = new System.Windows.Forms.TextBox();
            this.nUMEROTextBox = new System.Windows.Forms.TextBox();
            this.bAIRROTextBox = new System.Windows.Forms.TextBox();
            this.cIDADETextBox = new System.Windows.Forms.TextBox();
            this.cEPMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.sEXOComboBox = new System.Windows.Forms.ComboBox();
            this.tELEFONEMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cELULARMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            iD_PACIENTELabel = new System.Windows.Forms.Label();
            nOME_PACIENTELabel = new System.Windows.Forms.Label();
            eNDERECOLabel = new System.Windows.Forms.Label();
            nUMEROLabel = new System.Windows.Forms.Label();
            bAIRROLabel = new System.Windows.Forms.Label();
            cIDADELabel = new System.Windows.Forms.Label();
            cEPLabel = new System.Windows.Forms.Label();
            sEXOLabel = new System.Windows.Forms.Label();
            tELEFONELabel = new System.Windows.Forms.Label();
            cELULARLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.consultorio_CsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingNavigator)).BeginInit();
            this.pacienteBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // consultorio_CsDataSet
            // 
            this.consultorio_CsDataSet.DataSetName = "Consultorio_CsDataSet";
            this.consultorio_CsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pacienteBindingSource
            // 
            this.pacienteBindingSource.DataMember = "Paciente";
            this.pacienteBindingSource.DataSource = this.consultorio_CsDataSet;
            // 
            // pacienteTableAdapter
            // 
            this.pacienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConsultasTableAdapter = null;
            this.tableAdapterManager.MedicoTableAdapter = null;
            this.tableAdapterManager.PacienteTableAdapter = this.pacienteTableAdapter;
            this.tableAdapterManager.UpdateOrder = ControleConsultorio.Consultorio_CsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pacienteBindingNavigator
            // 
            this.pacienteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pacienteBindingNavigator.BindingSource = this.pacienteBindingSource;
            this.pacienteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pacienteBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pacienteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.pacienteBindingNavigatorSaveItem});
            this.pacienteBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pacienteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pacienteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pacienteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pacienteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pacienteBindingNavigator.Name = "pacienteBindingNavigator";
            this.pacienteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pacienteBindingNavigator.Size = new System.Drawing.Size(574, 25);
            this.pacienteBindingNavigator.TabIndex = 0;
            this.pacienteBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // pacienteBindingNavigatorSaveItem
            // 
            this.pacienteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pacienteBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pacienteBindingNavigatorSaveItem.Image")));
            this.pacienteBindingNavigatorSaveItem.Name = "pacienteBindingNavigatorSaveItem";
            this.pacienteBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.pacienteBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.pacienteBindingNavigatorSaveItem.Click += new System.EventHandler(this.pacienteBindingNavigatorSaveItem_Click_1);
            // 
            // iD_PACIENTELabel
            // 
            iD_PACIENTELabel.AutoSize = true;
            iD_PACIENTELabel.Location = new System.Drawing.Point(141, 74);
            iD_PACIENTELabel.Name = "iD_PACIENTELabel";
            iD_PACIENTELabel.Size = new System.Drawing.Size(77, 13);
            iD_PACIENTELabel.TabIndex = 1;
            iD_PACIENTELabel.Text = "ID PACIENTE:";
            // 
            // iD_PACIENTETextBox
            // 
            this.iD_PACIENTETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "ID_PACIENTE", true));
            this.iD_PACIENTETextBox.Location = new System.Drawing.Point(245, 71);
            this.iD_PACIENTETextBox.Name = "iD_PACIENTETextBox";
            this.iD_PACIENTETextBox.Size = new System.Drawing.Size(121, 20);
            this.iD_PACIENTETextBox.TabIndex = 2;
            // 
            // nOME_PACIENTELabel
            // 
            nOME_PACIENTELabel.AutoSize = true;
            nOME_PACIENTELabel.Location = new System.Drawing.Point(141, 100);
            nOME_PACIENTELabel.Name = "nOME_PACIENTELabel";
            nOME_PACIENTELabel.Size = new System.Drawing.Size(98, 13);
            nOME_PACIENTELabel.TabIndex = 3;
            nOME_PACIENTELabel.Text = "NOME PACIENTE:";
            // 
            // nOME_PACIENTETextBox
            // 
            this.nOME_PACIENTETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "NOME_PACIENTE", true));
            this.nOME_PACIENTETextBox.Location = new System.Drawing.Point(245, 97);
            this.nOME_PACIENTETextBox.Name = "nOME_PACIENTETextBox";
            this.nOME_PACIENTETextBox.Size = new System.Drawing.Size(121, 20);
            this.nOME_PACIENTETextBox.TabIndex = 4;
            // 
            // eNDERECOLabel
            // 
            eNDERECOLabel.AutoSize = true;
            eNDERECOLabel.Location = new System.Drawing.Point(141, 126);
            eNDERECOLabel.Name = "eNDERECOLabel";
            eNDERECOLabel.Size = new System.Drawing.Size(70, 13);
            eNDERECOLabel.TabIndex = 5;
            eNDERECOLabel.Text = "ENDERECO:";
            // 
            // eNDERECOTextBox
            // 
            this.eNDERECOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "ENDERECO", true));
            this.eNDERECOTextBox.Location = new System.Drawing.Point(245, 123);
            this.eNDERECOTextBox.Name = "eNDERECOTextBox";
            this.eNDERECOTextBox.Size = new System.Drawing.Size(121, 20);
            this.eNDERECOTextBox.TabIndex = 6;
            // 
            // nUMEROLabel
            // 
            nUMEROLabel.AutoSize = true;
            nUMEROLabel.Location = new System.Drawing.Point(141, 152);
            nUMEROLabel.Name = "nUMEROLabel";
            nUMEROLabel.Size = new System.Drawing.Size(58, 13);
            nUMEROLabel.TabIndex = 7;
            nUMEROLabel.Text = "NUMERO:";
            // 
            // nUMEROTextBox
            // 
            this.nUMEROTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "NUMERO", true));
            this.nUMEROTextBox.Location = new System.Drawing.Point(245, 149);
            this.nUMEROTextBox.Name = "nUMEROTextBox";
            this.nUMEROTextBox.Size = new System.Drawing.Size(121, 20);
            this.nUMEROTextBox.TabIndex = 8;
            // 
            // bAIRROLabel
            // 
            bAIRROLabel.AutoSize = true;
            bAIRROLabel.Location = new System.Drawing.Point(141, 178);
            bAIRROLabel.Name = "bAIRROLabel";
            bAIRROLabel.Size = new System.Drawing.Size(51, 13);
            bAIRROLabel.TabIndex = 9;
            bAIRROLabel.Text = "BAIRRO:";
            // 
            // bAIRROTextBox
            // 
            this.bAIRROTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "BAIRRO", true));
            this.bAIRROTextBox.Location = new System.Drawing.Point(245, 175);
            this.bAIRROTextBox.Name = "bAIRROTextBox";
            this.bAIRROTextBox.Size = new System.Drawing.Size(121, 20);
            this.bAIRROTextBox.TabIndex = 10;
            // 
            // cIDADELabel
            // 
            cIDADELabel.AutoSize = true;
            cIDADELabel.Location = new System.Drawing.Point(141, 204);
            cIDADELabel.Name = "cIDADELabel";
            cIDADELabel.Size = new System.Drawing.Size(50, 13);
            cIDADELabel.TabIndex = 11;
            cIDADELabel.Text = "CIDADE:";
            // 
            // cIDADETextBox
            // 
            this.cIDADETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "CIDADE", true));
            this.cIDADETextBox.Location = new System.Drawing.Point(245, 201);
            this.cIDADETextBox.Name = "cIDADETextBox";
            this.cIDADETextBox.Size = new System.Drawing.Size(121, 20);
            this.cIDADETextBox.TabIndex = 12;
            // 
            // cEPLabel
            // 
            cEPLabel.AutoSize = true;
            cEPLabel.Location = new System.Drawing.Point(141, 230);
            cEPLabel.Name = "cEPLabel";
            cEPLabel.Size = new System.Drawing.Size(31, 13);
            cEPLabel.TabIndex = 13;
            cEPLabel.Text = "CEP:";
            // 
            // cEPMaskedTextBox
            // 
            this.cEPMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "CEP", true));
            this.cEPMaskedTextBox.Location = new System.Drawing.Point(245, 227);
            this.cEPMaskedTextBox.Name = "cEPMaskedTextBox";
            this.cEPMaskedTextBox.Size = new System.Drawing.Size(121, 20);
            this.cEPMaskedTextBox.TabIndex = 14;
            // 
            // sEXOLabel
            // 
            sEXOLabel.AutoSize = true;
            sEXOLabel.Location = new System.Drawing.Point(141, 256);
            sEXOLabel.Name = "sEXOLabel";
            sEXOLabel.Size = new System.Drawing.Size(39, 13);
            sEXOLabel.TabIndex = 15;
            sEXOLabel.Text = "SEXO:";
            // 
            // sEXOComboBox
            // 
            this.sEXOComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "SEXO", true));
            this.sEXOComboBox.FormattingEnabled = true;
            this.sEXOComboBox.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMININO",
            "OUTRO"});
            this.sEXOComboBox.Location = new System.Drawing.Point(245, 253);
            this.sEXOComboBox.Name = "sEXOComboBox";
            this.sEXOComboBox.Size = new System.Drawing.Size(121, 21);
            this.sEXOComboBox.TabIndex = 16;
            // 
            // tELEFONELabel
            // 
            tELEFONELabel.AutoSize = true;
            tELEFONELabel.Location = new System.Drawing.Point(141, 283);
            tELEFONELabel.Name = "tELEFONELabel";
            tELEFONELabel.Size = new System.Drawing.Size(66, 13);
            tELEFONELabel.TabIndex = 17;
            tELEFONELabel.Text = "TELEFONE:";
            // 
            // tELEFONEMaskedTextBox
            // 
            this.tELEFONEMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "TELEFONE", true));
            this.tELEFONEMaskedTextBox.Location = new System.Drawing.Point(245, 280);
            this.tELEFONEMaskedTextBox.Name = "tELEFONEMaskedTextBox";
            this.tELEFONEMaskedTextBox.Size = new System.Drawing.Size(121, 20);
            this.tELEFONEMaskedTextBox.TabIndex = 18;
            // 
            // cELULARLabel
            // 
            cELULARLabel.AutoSize = true;
            cELULARLabel.Location = new System.Drawing.Point(141, 309);
            cELULARLabel.Name = "cELULARLabel";
            cELULARLabel.Size = new System.Drawing.Size(59, 13);
            cELULARLabel.TabIndex = 19;
            cELULARLabel.Text = "CELULAR:";
            // 
            // cELULARMaskedTextBox
            // 
            this.cELULARMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "CELULAR", true));
            this.cELULARMaskedTextBox.Location = new System.Drawing.Point(245, 306);
            this.cELULARMaskedTextBox.Name = "cELULARMaskedTextBox";
            this.cELULARMaskedTextBox.Size = new System.Drawing.Size(121, 20);
            this.cELULARMaskedTextBox.TabIndex = 20;
            // 
            // frmPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 450);
            this.Controls.Add(iD_PACIENTELabel);
            this.Controls.Add(this.iD_PACIENTETextBox);
            this.Controls.Add(nOME_PACIENTELabel);
            this.Controls.Add(this.nOME_PACIENTETextBox);
            this.Controls.Add(eNDERECOLabel);
            this.Controls.Add(this.eNDERECOTextBox);
            this.Controls.Add(nUMEROLabel);
            this.Controls.Add(this.nUMEROTextBox);
            this.Controls.Add(bAIRROLabel);
            this.Controls.Add(this.bAIRROTextBox);
            this.Controls.Add(cIDADELabel);
            this.Controls.Add(this.cIDADETextBox);
            this.Controls.Add(cEPLabel);
            this.Controls.Add(this.cEPMaskedTextBox);
            this.Controls.Add(sEXOLabel);
            this.Controls.Add(this.sEXOComboBox);
            this.Controls.Add(tELEFONELabel);
            this.Controls.Add(this.tELEFONEMaskedTextBox);
            this.Controls.Add(cELULARLabel);
            this.Controls.Add(this.cELULARMaskedTextBox);
            this.Controls.Add(this.pacienteBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPacientes";
            this.Text = "frmPacientes";
            this.Load += new System.EventHandler(this.frmPacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consultorio_CsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingNavigator)).EndInit();
            this.pacienteBindingNavigator.ResumeLayout(false);
            this.pacienteBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Consultorio_CsDataSet consultorio_CsDataSet;
        private System.Windows.Forms.BindingSource pacienteBindingSource;
        private Consultorio_CsDataSetTableAdapters.PacienteTableAdapter pacienteTableAdapter;
        private Consultorio_CsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pacienteBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton pacienteBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_PACIENTETextBox;
        private System.Windows.Forms.TextBox nOME_PACIENTETextBox;
        private System.Windows.Forms.TextBox eNDERECOTextBox;
        private System.Windows.Forms.TextBox nUMEROTextBox;
        private System.Windows.Forms.TextBox bAIRROTextBox;
        private System.Windows.Forms.TextBox cIDADETextBox;
        private System.Windows.Forms.MaskedTextBox cEPMaskedTextBox;
        private System.Windows.Forms.ComboBox sEXOComboBox;
        private System.Windows.Forms.MaskedTextBox tELEFONEMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox cELULARMaskedTextBox;
    }
}