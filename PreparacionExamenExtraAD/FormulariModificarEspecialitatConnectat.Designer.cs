namespace PreparacionExamenExtraAD
{
    partial class FormulariModificarEspecialitatConnectat
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
            this.groupBoxEspecialitat = new System.Windows.Forms.GroupBox();
            this.dataGridViewEspecialitats = new System.Windows.Forms.DataGridView();
            this.groupBoxEspecialitats = new System.Windows.Forms.GroupBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.textBoxGrau = new System.Windows.Forms.TextBox();
            this.comboBoxProfesores = new System.Windows.Forms.ComboBox();
            this.comboBoxEsport = new System.Windows.Forms.ComboBox();
            this.labelGrau = new System.Windows.Forms.Label();
            this.labelProfessor = new System.Windows.Forms.Label();
            this.labelEsport = new System.Windows.Forms.Label();
            this.groupBoxEspecialitat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEspecialitats)).BeginInit();
            this.groupBoxEspecialitats.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxEspecialitat
            // 
            this.groupBoxEspecialitat.Controls.Add(this.dataGridViewEspecialitats);
            this.groupBoxEspecialitat.Location = new System.Drawing.Point(12, 12);
            this.groupBoxEspecialitat.Name = "groupBoxEspecialitat";
            this.groupBoxEspecialitat.Size = new System.Drawing.Size(474, 275);
            this.groupBoxEspecialitat.TabIndex = 0;
            this.groupBoxEspecialitat.TabStop = false;
            this.groupBoxEspecialitat.Text = "Especialitats";
            // 
            // dataGridViewEspecialitats
            // 
            this.dataGridViewEspecialitats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEspecialitats.Location = new System.Drawing.Point(15, 19);
            this.dataGridViewEspecialitats.Name = "dataGridViewEspecialitats";
            this.dataGridViewEspecialitats.Size = new System.Drawing.Size(443, 238);
            this.dataGridViewEspecialitats.TabIndex = 0;
            this.dataGridViewEspecialitats.SelectionChanged += new System.EventHandler(this.dataGridViewEspecialitats_SelectionChanged);
            this.dataGridViewEspecialitats.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewEspecialitats_MouseClick);
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
            this.groupBoxEspecialitats.TabIndex = 1;
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
            this.comboBoxProfesores.FormattingEnabled = true;
            this.comboBoxProfesores.Location = new System.Drawing.Point(93, 62);
            this.comboBoxProfesores.Name = "comboBoxProfesores";
            this.comboBoxProfesores.Size = new System.Drawing.Size(350, 21);
            this.comboBoxProfesores.TabIndex = 5;
            // 
            // comboBoxEsport
            // 
            this.comboBoxEsport.FormattingEnabled = true;
            this.comboBoxEsport.Location = new System.Drawing.Point(93, 33);
            this.comboBoxEsport.Name = "comboBoxEsport";
            this.comboBoxEsport.Size = new System.Drawing.Size(350, 21);
            this.comboBoxEsport.TabIndex = 4;
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
            // FormulariModificarEspecialitatConnectat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 482);
            this.Controls.Add(this.groupBoxEspecialitats);
            this.Controls.Add(this.groupBoxEspecialitat);
            this.Name = "FormulariModificarEspecialitatConnectat";
            this.Text = "Connectat";
            this.Activated += new System.EventHandler(this.FormulariModificarEspecialitatConnectat_Activated);
            this.Load += new System.EventHandler(this.FormulariModificarEspecialitatConnectat_Load);
            this.groupBoxEspecialitat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEspecialitats)).EndInit();
            this.groupBoxEspecialitats.ResumeLayout(false);
            this.groupBoxEspecialitats.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxEspecialitat;
        private System.Windows.Forms.GroupBox groupBoxEspecialitats;
        private System.Windows.Forms.DataGridView dataGridViewEspecialitats;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.TextBox textBoxGrau;
        private System.Windows.Forms.ComboBox comboBoxProfesores;
        private System.Windows.Forms.ComboBox comboBoxEsport;
        private System.Windows.Forms.Label labelGrau;
        private System.Windows.Forms.Label labelProfessor;
        private System.Windows.Forms.Label labelEsport;
    }
}