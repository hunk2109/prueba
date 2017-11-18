namespace crud
{
    partial class cabecera
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtnid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombreemp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttipono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtfini = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtffinal = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de nomina";
            // 
            // txtnid
            // 
            this.txtnid.Location = new System.Drawing.Point(133, 10);
            this.txtnid.Name = "txtnid";
            this.txtnid.Size = new System.Drawing.Size(100, 20);
            this.txtnid.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre de la empresa";
            // 
            // txtnombreemp
            // 
            this.txtnombreemp.Location = new System.Drawing.Point(133, 50);
            this.txtnombreemp.Name = "txtnombreemp";
            this.txtnombreemp.Size = new System.Drawing.Size(100, 20);
            this.txtnombreemp.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo de nomina";
            // 
            // txttipono
            // 
            this.txttipono.Location = new System.Drawing.Point(133, 91);
            this.txttipono.Name = "txttipono";
            this.txttipono.Size = new System.Drawing.Size(100, 20);
            this.txttipono.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha de inicio";
            // 
            // txtfini
            // 
            this.txtfini.Location = new System.Drawing.Point(133, 126);
            this.txtfini.Name = "txtfini";
            this.txtfini.Size = new System.Drawing.Size(100, 20);
            this.txtfini.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha final";
            // 
            // txtffinal
            // 
            this.txtffinal.Location = new System.Drawing.Point(133, 157);
            this.txtffinal.Name = "txtffinal";
            this.txtffinal.Size = new System.Drawing.Size(100, 20);
            this.txtffinal.TabIndex = 9;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(13, 326);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 10;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.Location = new System.Drawing.Point(420, 325);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(75, 23);
            this.btnborrar.TabIndex = 11;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.UseVisualStyleBackColor = true;
            // 
            // cabecera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 361);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtffinal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtfini);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txttipono);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnombreemp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnid);
            this.Controls.Add(this.label1);
            this.Name = "cabecera";
            this.Text = "cabecera";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombreemp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttipono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtfini;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtffinal;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnborrar;
    }
}