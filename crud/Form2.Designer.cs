namespace crud
{
    partial class frn_cargo
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtcargoid = new System.Windows.Forms.TextBox();
            this.txtcargo = new System.Windows.Forms.TextBox();
            this.btnguardcargo = new System.Windows.Forms.Button();
            this.btnborrarcargo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtidemplecargo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsueldo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cargo_id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cargo";
            // 
            // txtcargoid
            // 
            this.txtcargoid.Location = new System.Drawing.Point(86, 27);
            this.txtcargoid.Name = "txtcargoid";
            this.txtcargoid.Size = new System.Drawing.Size(100, 20);
            this.txtcargoid.TabIndex = 2;
            // 
            // txtcargo
            // 
            this.txtcargo.Location = new System.Drawing.Point(86, 58);
            this.txtcargo.Name = "txtcargo";
            this.txtcargo.Size = new System.Drawing.Size(100, 20);
            this.txtcargo.TabIndex = 3;
            // 
            // btnguardcargo
            // 
            this.btnguardcargo.Location = new System.Drawing.Point(12, 336);
            this.btnguardcargo.Name = "btnguardcargo";
            this.btnguardcargo.Size = new System.Drawing.Size(75, 23);
            this.btnguardcargo.TabIndex = 4;
            this.btnguardcargo.Text = "Guardar";
            this.btnguardcargo.UseVisualStyleBackColor = true;
            this.btnguardcargo.Click += new System.EventHandler(this.btnguardcargo_Click);
            // 
            // btnborrarcargo
            // 
            this.btnborrarcargo.Location = new System.Drawing.Point(197, 336);
            this.btnborrarcargo.Name = "btnborrarcargo";
            this.btnborrarcargo.Size = new System.Drawing.Size(75, 23);
            this.btnborrarcargo.TabIndex = 5;
            this.btnborrarcargo.Text = "Borrar";
            this.btnborrarcargo.UseVisualStyleBackColor = true;
            this.btnborrarcargo.Click += new System.EventHandler(this.btnborrarcargo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Empleado ID";
            // 
            // txtidemplecargo
            // 
            this.txtidemplecargo.Location = new System.Drawing.Point(86, 144);
            this.txtidemplecargo.Name = "txtidemplecargo";
            this.txtidemplecargo.Size = new System.Drawing.Size(100, 20);
            this.txtidemplecargo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sueldo";
            // 
            // txtsueldo
            // 
            this.txtsueldo.Location = new System.Drawing.Point(86, 101);
            this.txtsueldo.Name = "txtsueldo";
            this.txtsueldo.Size = new System.Drawing.Size(100, 20);
            this.txtsueldo.TabIndex = 9;
            // 
            // frn_cargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 371);
            this.Controls.Add(this.txtsueldo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtidemplecargo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnborrarcargo);
            this.Controls.Add(this.btnguardcargo);
            this.Controls.Add(this.txtcargo);
            this.Controls.Add(this.txtcargoid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frn_cargo";
            this.Text = "frn_cargo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcargoid;
        private System.Windows.Forms.TextBox txtcargo;
        private System.Windows.Forms.Button btnguardcargo;
        private System.Windows.Forms.Button btnborrarcargo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtidemplecargo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsueldo;
    }
}