using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud
{
    public partial class datos_generales : Form
    {
        public datos_generales()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {

            operaciones oper = new operaciones();
            DataTable dgvdatos = oper.cosnsultaconresultado("select * from empleado inner join  cargo where empleado_id = '" + txtdgid.Text + "' and Empleado_empleado_id = '" + txtdgid.Text + "'");

            foreach (DataRow dr in dgvdatos.Rows)

            {

                string nombre, apellido, sexo, cargo, fecha_nac, fecha_ingre, salario;
                nombre = dr["nombre"].ToString();
                txtdatosnombre.Text = nombre;
                apellido = dr["apellido"].ToString();
                txtapellidod.Text = apellido;
                sexo = dr["sexo"].ToString();
                txtsexo.Text = sexo;
                fecha_nac = dr["fecha_naci"].ToString();
                txtnaci.Text = fecha_nac;
                fecha_ingre = dr["fecha_ingr"].ToString();
                txtingre.Text = fecha_ingre;
                salario = dr["sueldo"].ToString();
                txtsalario.Text = salario;
                cargo = dr["cargo"].ToString();
                txtcargo.Text = cargo;

                try
                {
                    pictureBox1.Image = Image.FromFile(@"C:\bdd\" + txtapellidod.Text + ".jpg");
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnedad_Click(object sender, EventArgs e)
        {
            try
            {
                string i = txtnaci.Text;
                DateTime x = Convert.ToDateTime(i);
                int edad = DateTime.Today.AddTicks(-x.Ticks).Year - 1;
                txtcaledad.Text = Convert.ToString(edad);
                edad.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void datos_generales_Load(object sender, EventArgs e)
        {
            
        }

        private void btnantig_Click(object sender, EventArgs e)
        {
            try
            {
                string i = txtingre.Text;
                DateTime x = Convert.ToDateTime(i);
                int ingreso = DateTime.Today.AddTicks(-x.Ticks).Year - 1;
                txtantiguedad.Text = Convert.ToString(ingreso);
                ingreso.ToString();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
