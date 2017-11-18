using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud
{
    public partial class frn_empleaado : Form
    {
        public frn_empleaado()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
             if (string.IsNullOrEmpty(txtape.Text))
            {
                MessageBox.Show("Favor ingrese el Apellido del ampleado antes!");
            }
            else
            {
                string start = Convert.ToString(txtfoto.Text);
                string end = @"C:\bdd\" +txtape.Text+".jpg";
                File.Copy(start, end);
            }
                string photo = txtape.Text;
                operaciones oper = new operaciones();
                oper.consultasinreaultado("insert into empleado(nombre,apellido,cedula,sexo,fecha_naci,fecha_ingr,foto) values('" + txtnom.Text + "','" + txtape.Text + "','" + txtcedula.Text + "','" + texsex.Text + "','" + txtnacimiento.Text + "','" + txtingreso.Text + "','"+photo+"')");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                        


                    
            
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            texid.Text = ("");
            txtnom.Text = ("");
            txtape.Text = ("");
            texsex.Text = ("");
            txtcedula.Text = ("");
            txtnacimiento.Text = ("");
            txtingreso.Text = ("");

        }

        private void btnexam_Click(object sender, EventArgs e)
        {
            OpenFileDialog select = new OpenFileDialog();
            select.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png";
            if (select.ShowDialog() == DialogResult.OK)
            {
                txtfoto.Text = select.FileName;
                if (string.IsNullOrEmpty(txtfoto.Text))
                {
                    Bitmap picture = new Bitmap("");
                    potoemp.Image = (Image)picture;
                }
                else
                {
                    Bitmap picture = new Bitmap(txtfoto.Text);
                    potoemp.Image = (Image)picture;
                }
            }
            
        }
    }
}
