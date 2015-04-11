namespace PreparacionExamenExtraAD
{
    partial class FormulariModificarEspecialitatsDesconnectat
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
            this.groupBoxEspecialitats = new System.Windows.Forms.GroupBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.textBoxGrau = new System.Windows.Forms.TextBox();
            this.comboBoxProfesores = new System.Windows.Forms.ComboBox();
            this.bindingSourceProfesores = new System.Windows.Forms.BindingSource(this.components);
            this.gimnasioExamenDataSet = new PreparacionExamenExtraAD.gimnasioExamenDataSet();
            this.comboBoxEsport = new System.Windows.Forms.ComboBox();
            this.bindingSourceDeportes = new System.Windows.Forms.BindingSource(this.components);
            this.labelGrau = new System.Windows.Forms.Label();
            this.labelProfessor = new System.Windows.Forms.Label();
            this.labelEsport = new System.Windows.Forms.Label();
            this.groupBoxDeportes = new System.Windows.Forms.GroupBox();
            this.dataGridViewDeportes = new System.Windows.Forms.DataGridView();
            this.iddeporteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descdeporteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxEspecialidades = new System.Windows.Forms.GroupBox();
            this.dataGridViewEspecialitats = new System.Windows.Forms.DataGridView();
            this.iddeporteDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceEspecialidades = new System.Windows.Forms.BindingSource(this.components);
            this.deportesTableAdapter = new PreparacionExamenExtraAD.gimnasioExamenDataSetTableAdapters.deportesTableAdapter();
            this.especialidadesTableAdapter = new PreparacionExamenExtraAD.gimnasioExamenDataSetTableAdapters.especialidadesTableAdapter();
            this.profesoresTableAdapter = new PreparacionExamenExtraAD.gimnasioExamenDataSetTableAdapters.profesoresTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxEspecialitats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProfesores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gimnasioExamenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDeportes)).BeginInit();
            this.groupBoxDeportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeportes)).BeginInit();
            this.groupBoxEspecialidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEspecialitats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEspecialidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxEspecialitats
            // 
            this.groupBoxEspecialitats.Controls.Add(this.buttonCancelar);
            this.groupBoxEspecialitats.Controls.Add(this.buttonAceptar);
            this.groupBoxEspecialitats.Controls.Add(this.textBoxGrau);
            this.groupBoxEspecialitats.Controls.Add(this.comboBoxProfesores);
            this.groupBoxEspecialitats.Controls.Add(this.comboBoxEsport);
            this.groupBoxEspecialitats.Controls.Add(this.labelGrau);
            this.groupBoxEspecialitats.Controls.Add(this.labelProfessor);
            this.groupBoxEspecialitats.Controls.Add(this.labelEsport);
            this.groupBoxEspecialitats.Location = new System.Drawing.Point(12, 293);
            this.groupBoxEspecialitats.Name = "groupBoxEspecialitats";
            this.groupBoxEspecialitats.Size = new System.Drawing.Size(474, 177);
            this.groupBoxEspecialitats.TabIndex = 3;
            this.groupBoxEspecialitats.TabStop = false;
            this.groupBoxEspecialitats.Text = "Especilitat";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(367, 135);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 8;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(275, 135);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 7;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // textBoxGrau
            // 
            this.textBoxGrau.Location = new System.Drawing.Point(93, 92);
            this.textBoxGrau.Name = "textBoxGrau";
            this.textBoxGrau.Size = new System.Drawing.Size(350, 20);
            this.textBoxGrau.TabIndex = 6;
            // 
            // comboBoxProfesores
            // 
            this.comboBoxProfesores.DataSource = this.bindingSourceProfesores;
            this.comboBoxProfesores.DisplayMember = "nombre";
            this.comboBoxProfesores.FormattingEnabled = true;
            this.comboBoxProfesores.Location = new System.Drawing.Point(93, 62);
            this.comboBoxProfesores.Name = "comboBoxProfesores";
            this.comboBoxProfesores.Size = new System.Drawing.Size(350, 21);
            this.comboBoxProfesores.TabIndex = 5;
            // 
            // bindingSourceProfesores
            // 
            this.bindingSourceProfesores.DataMember = "profesores";
            this.bindingSourceProfesores.DataSource = this.gimnasioExamenDataSet;
            // 
            // gimnasioExamenDataSet
            // 
            this.gimnasioExamenDataSet.DataSetName = "gimnasioExamenDataSet";
            this.gimnasioExamenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxEsport
            // 
            this.comboBoxEsport.DataSource = this.bindingSourceDeportes;
            this.comboBoxEsport.DisplayMember = "desc_deporte";
            this.comboBoxEsport.FormattingEnabled = true;
            this.comboBoxEsport.Location = new System.Drawing.Point(93, 33);
            this.comboBoxEsport.Name = "comboBoxEsport";
            this.comboBoxEsport.Size = new System.Drawing.Size(350, 21);
            this.comboBoxEsport.TabIndex = 4;
            // 
            // bindingSourceDeportes
            // 
            this.bindingSourceDeportes.DataMember = "deportes";
            this.bindingSourceDeportes.DataSource = this.gimnasioExamenDataSet;
            // 
            // labelGrau
            // 
            this.labelGrau.AutoSize = true;
            this.labelGrau.Location = new System.Drawing.Point(12, 92);
            this.labelGrau.Name = "labelGrau";
            this.labelGrau.Size = new System.Drawing.Size(30, 13);
            this.labelGrau.TabIndex = 3;
            this.labelGrau.Text = "Grau";
            // 
            // labelProfessor
            // 
            this.labelProfessor.AutoSize = true;
            this.labelProfessor.Location = new System.Drawing.Point(12, 62);
            this.labelProfessor.Name = "labelProfessor";
            this.labelProfessor.Size = new System.Drawing.Size(51, 13);
            this.labelProfessor.TabIndex = 2;
            this.labelProfessor.Text = "Professor";
            // 
            // labelEsport
            // 
            this.labelEsport.AutoSize = true;
            this.labelEsport.Location = new System.Drawing.Point(12, 33);
            this.labelEsport.Name = "labelEsport";
            this.labelEsport.Size = new System.Drawing.Size(37, 13);
            this.labelEsport.TabIndex = 1;
            this.labelEsport.Text = "Esport";
            // 
            // groupBoxDeportes
            // 
            this.groupBoxDeportes.Controls.Add(this.dataGridViewDeportes);
            this.groupBoxDeportes.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDeportes.Name = "groupBoxDeportes";
            this.groupBoxDeportes.Size = new System.Drawing.Size(474, 131);
            this.groupBoxDeportes.TabIndex = 2;
            this.groupBoxDeportes.TabStop = false;
            this.groupBoxDeportes.Text = "Deportes";
            // 
            // dataGridViewDeportes
            // 
            this.dataGridViewDeportes.AutoGenerateColumns = false;
            this.dataGridViewDeportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDeportes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddeporteDataGridViewTextBoxColumn,
            this.descdeporteDataGridViewTextBoxColumn});
            this.dataGridViewDeportes.DataSource = this.bindingSourceDeportes;
            this.dataGridViewDeportes.Location = new System.Drawing.Point(15, 19);
            this.dataGridViewDeportes.Name = "dataGridViewDeportes";
            this.dataGridViewDeportes.Size = new System.Drawing.Size(443, 96);
            this.dataGridViewDeportes.TabIndex = 0;
            // 
            // iddeporteDataGridViewTextBoxColumn
            // 
            this.iddeporteDataGridViewTextBoxColumn.DataPropertyName = "id_deporte";
            this.iddeporteDataGridViewTextBoxColumn.HeaderText = "id_deporte";
            this.iddeporteDataGridViewTextBoxColumn.Name = "iddeporteDataGridViewTextBoxColumn";
            this.iddeporteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descdeporteDataGridViewTextBoxColumn
            // 
            this.descdeporteDataGridViewTextBoxColumn.DataPropertyName = "desc_deporte";
            this.descdeporteDataGridViewTextBoxColumn.HeaderText = "desc_deporte";
            this.descdeporteDataGridViewTextBoxColumn.Name = "descdeporteDataGridViewTextBoxColumn";
            // 
            // groupBoxEspecialidades
            // 
            this.groupBoxEspecialidades.Controls.Add(this.dataGridViewEspecialitats);
            this.groupBoxEspecialidades.Location = new System.Drawing.Point(14, 161);
            this.groupBoxEspecialidades.Name = "groupBoxEspecialidades";
            this.groupBoxEspecialidades.Size = new System.Drawing.Size(474, 126);
            this.groupBoxEspecialidades.TabIndex = 3;
            this.groupBoxEspecialidades.TabStop = false;
            this.groupBoxEspecialidades.Text = "Especialidades";
            // 
            // dataGridViewEspecialitats
            // 
            this.dataGridViewEspecialitats.AutoGenerateColumns = false;
            this.dataGridViewEspecialitats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEspecialitats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddeporteDataGridViewTextBoxColumn1,
            this.dniDataGridViewTextBoxColumn,
            this.gradoDataGridViewTextBoxColumn});
            this.dataGridViewEspecialitats.DataSource = this.bindingSourceEspecialidades;
            this.dataGridViewEspecialitats.Location = new System.Drawing.Point(15, 19);
            this.dataGridViewEspecialitats.Name = "dataGridViewEspecialitats";
            this.dataGridViewEspecialitats.Size = new System.Drawing.Size(443, 92);
            this.dataGridViewEspecialitats.TabIndex = 0;
            this.dataGridViewEspecialitats.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // iddeporteDataGridViewTextBoxColumn1
            // 
            this.iddeporteDataGridViewTextBoxColumn1.DataPropertyName = "id_deporte";
            this.iddeporteDataGridViewTextBoxColumn1.HeaderText = "id_deporte";
            this.iddeporteDataGridViewTextBoxColumn1.Name = "iddeporteDataGridViewTextBoxColumn1";
            // 
            // dniDataGridViewTextBoxColumn
            // 
            this.dniDataGridViewTextBoxColumn.DataPropertyName = "dni";
            this.dniDataGridViewTextBoxColumn.HeaderText = "dni";
            this.dniDataGridViewTextBoxColumn.Name = "dniDataGridViewTextBoxColumn";
            // 
            // gradoDataGridViewTextBoxColumn
            // 
            this.gradoDataGridViewTextBoxColumn.DataPropertyName = "grado";
            this.gradoDataGridViewTextBoxColumn.HeaderText = "grado";
            this.gradoDataGridViewTextBoxColumn.Name = "gradoDataGridViewTextBoxColumn";
            // 
            // bindingSourceEspecialidades
            // 
            this.bindingSourceEspecialidades.DataMember = "especialidades";
            this.bindingSourceEspecialidades.DataSource = this.gimnasioExamenDataSet;
            // 
            // deportesTableAdapter
            // 
            this.deportesTableAdapter.ClearBeforeFill = true;
            // 
            // especialidadesTableAdapter
            // 
            this.especialidadesTableAdapter.ClearBeforeFill = true;
            // 
            // profesoresTableAdapter
            // 
            this.profesoresTableAdapter.ClearBeforeFill = true;
            // 
            // FormulariModificarEspecialitatsDesconnectat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 484);
            this.Controls.Add(this.groupBoxEspecialidades);
            this.Controls.Add(this.groupBoxEspecialitats);
            this.Controls.Add(this.groupBoxDeportes);
            this.Name = "FormulariModificarEspecialitatsDesconnectat";
            this.Text = "Desconnectat";
            this.Load += new System.EventHandler(this.FormulariModificarEspecialitatsDesconnectat_Load);
            this.groupBoxEspecialitats.ResumeLayout(false);
            this.groupBoxEspecialitats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProfesores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gimnasioExamenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDeportes)).EndInit();
            this.groupBoxDeportes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeportes)).EndInit();
            this.groupBoxEspecialidades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEspecialitats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEspecialidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxEspecialitats;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.TextBox textBoxGrau;
        private System.Windows.Forms.ComboBox comboBoxProfesores;
        private System.Windows.Forms.ComboBox comboBoxEsport;
        private System.Windows.Forms.Label labelGrau;
        private System.Windows.Forms.Label labelProfessor;
        private System.Windows.Forms.Label labelEsport;
        private System.Windows.Forms.GroupBox groupBoxDeportes;
        private System.Windows.Forms.DataGridView dataGridViewDeportes;
        private System.Windows.Forms.GroupBox groupBoxEspecialidades;
        private System.Windows.Forms.DataGridView dataGridViewEspecialitats;
        private System.Windows.Forms.BindingSource bindingSourceDeportes;
        private gimnasioExamenDataSet gimnasioExamenDataSet;
        private gimnasioExamenDataSetTableAdapters.deportesTableAdapter deportesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddeporteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descdeporteDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSourceEspecialidades;
        private gimnasioExamenDataSetTableAdapters.especialidadesTableAdapter especialidadesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddeporteDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSourceProfesores;
        private gimnasioExamenDataSetTableAdapters.profesoresTableAdapter profesoresTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}