namespace crud
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvdatos = new System.Windows.Forms.DataGridView();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btncrear = new System.Windows.Forms.Button();
            this.cmbtablas = new System.Windows.Forms.ComboBox();
            this.txtcondiocional = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.rdbid = new System.Windows.Forms.RadioButton();
            this.rdbnombre = new System.Windows.Forms.RadioButton();
            this.rdbapellido = new System.Windows.Forms.RadioButton();
            this.rdbcedula = new System.Windows.Forms.RadioButton();
            this.rdbsexo = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnimp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvdatos
            // 
            this.dgvdatos.AllowUserToOrderColumns = true;
            this.dgvdatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvdatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdatos.Location = new System.Drawing.Point(12, 66);
            this.dgvdatos.Name = "dgvdatos";
            this.dgvdatos.ReadOnly = true;
            this.dgvdatos.Size = new System.Drawing.Size(867, 303);
            this.dgvdatos.TabIndex = 0;
            this.dgvdatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdatos_CellContentClick);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbuscar.Location = new System.Drawing.Point(532, 9);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(181, 20);
            this.txtbuscar.TabIndex = 1;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnbuscar.Location = new System.Drawing.Point(719, 7);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 2;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btncrear
            // 
            this.btncrear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncrear.Location = new System.Drawing.Point(590, 397);
            this.btncrear.Name = "btncrear";
            this.btncrear.Size = new System.Drawing.Size(75, 23);
            this.btncrear.TabIndex = 3;
            this.btncrear.Text = "crear";
            this.btncrear.UseVisualStyleBackColor = true;
            this.btncrear.Click += new System.EventHandler(this.btncrear_Click);
            // 
            // cmbtablas
            // 
            this.cmbtablas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbtablas.FormattingEnabled = true;
            this.cmbtablas.Items.AddRange(new object[] {
            "Empleado",
            "Cargo",
            "Detalles Nomina",
            "Cabecera Nomina"});
            this.cmbtablas.Location = new System.Drawing.Point(673, 397);
            this.cmbtablas.Name = "cmbtablas";
            this.cmbtablas.Size = new System.Drawing.Size(121, 21);
            this.cmbtablas.TabIndex = 5;
            this.cmbtablas.SelectedIndexChanged += new System.EventHandler(this.cmbtablas_SelectedIndexChanged);
            // 
            // txtcondiocional
            // 
            this.txtcondiocional.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcondiocional.Location = new System.Drawing.Point(719, 40);
            this.txtcondiocional.Name = "txtcondiocional";
            this.txtcondiocional.Size = new System.Drawing.Size(100, 20);
            this.txtcondiocional.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(545, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tablas";
            // 
            // btnmostrar
            // 
            this.btnmostrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmostrar.Location = new System.Drawing.Point(800, 397);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(75, 23);
            this.btnmostrar.TabIndex = 8;
            this.btnmostrar.Text = "Mostrar";
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // rdbid
            // 
            this.rdbid.AutoSize = true;
            this.rdbid.Location = new System.Drawing.Point(81, 14);
            this.rdbid.Name = "rdbid";
            this.rdbid.Size = new System.Drawing.Size(36, 17);
            this.rdbid.TabIndex = 9;
            this.rdbid.TabStop = true;
            this.rdbid.Text = "ID";
            this.rdbid.UseVisualStyleBackColor = true;
            this.rdbid.CheckedChanged += new System.EventHandler(this.rdbid_CheckedChanged);
            // 
            // rdbnombre
            // 
            this.rdbnombre.AutoSize = true;
            this.rdbnombre.Location = new System.Drawing.Point(123, 14);
            this.rdbnombre.Name = "rdbnombre";
            this.rdbnombre.Size = new System.Drawing.Size(62, 17);
            this.rdbnombre.TabIndex = 10;
            this.rdbnombre.TabStop = true;
            this.rdbnombre.Text = "Nombre";
            this.rdbnombre.UseVisualStyleBackColor = true;
            // 
            // rdbapellido
            // 
            this.rdbapellido.AutoSize = true;
            this.rdbapellido.Location = new System.Drawing.Point(191, 14);
            this.rdbapellido.Name = "rdbapellido";
            this.rdbapellido.Size = new System.Drawing.Size(62, 17);
            this.rdbapellido.TabIndex = 11;
            this.rdbapellido.TabStop = true;
            this.rdbapellido.Text = "Apellido";
            this.rdbapellido.UseVisualStyleBackColor = true;
            // 
            // rdbcedula
            // 
            this.rdbcedula.AutoSize = true;
            this.rdbcedula.Location = new System.Drawing.Point(259, 14);
            this.rdbcedula.Name = "rdbcedula";
            this.rdbcedula.Size = new System.Drawing.Size(58, 17);
            this.rdbcedula.TabIndex = 12;
            this.rdbcedula.TabStop = true;
            this.rdbcedula.Text = "Cedula";
            this.rdbcedula.UseVisualStyleBackColor = true;
            // 
            // rdbsexo
            // 
            this.rdbsexo.AutoSize = true;
            this.rdbsexo.Location = new System.Drawing.Point(323, 14);
            this.rdbsexo.Name = "rdbsexo";
            this.rdbsexo.Size = new System.Drawing.Size(49, 17);
            this.rdbsexo.TabIndex = 13;
            this.rdbsexo.TabStop = true;
            this.rdbsexo.Text = "Sexo";
            this.rdbsexo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 26);
            this.label2.TabIndex = 14;
            this.label2.Text = "Seleccione \r\nun campo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(596, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(638, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 26);
            this.label4.TabIndex = 16;
            this.label4.Text = "Lo que quiere \r\nmostrar";
            // 
            // btnimp
            // 
            this.btnimp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnimp.Location = new System.Drawing.Point(12, 425);
            this.btnimp.Name = "btnimp";
            this.btnimp.Size = new System.Drawing.Size(75, 23);
            this.btnimp.TabIndex = 17;
            this.btnimp.Text = "Imprimir";
            this.btnimp.UseVisualStyleBackColor = true;
            this.btnimp.Click += new System.EventHandler(this.btnimp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(891, 460);
            this.Controls.Add(this.btnimp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdbsexo);
            this.Controls.Add(this.rdbcedula);
            this.Controls.Add(this.rdbapellido);
            this.Controls.Add(this.rdbnombre);
            this.Controls.Add(this.rdbid);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcondiocional);
            this.Controls.Add(this.cmbtablas);
            this.Controls.Add(this.btncrear);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.dgvdatos);
            this.Name = "Form1";
            this.Text = "Compañia del Caribe CXA";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdatos;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btncrear;
        private System.Windows.Forms.ComboBox cmbtablas;
        private System.Windows.Forms.TextBox txtcondiocional;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.RadioButton rdbid;
        private System.Windows.Forms.RadioButton rdbnombre;
        private System.Windows.Forms.RadioButton rdbapellido;
        private System.Windows.Forms.RadioButton rdbcedula;
        private System.Windows.Forms.RadioButton rdbsexo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnimp;
    }
}

