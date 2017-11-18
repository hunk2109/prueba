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
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace crud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            if (cmbtablas.Text == ("Empleado"))
            {
                frn_empleaado f = new frn_empleaado();
                f.Show();
            }

            else if (cmbtablas.Text == ("Cargo"))
            {
                frn_cargo f = new frn_cargo();
                f.Show();
            }
            else if (cmbtablas.Text == ("Detalles Nomina"))
            {
                nomina f = new nomina();
                f.Show();
            }

            else if (cmbtablas.Text == ("Cabecera Nomina"))
            {
                cabecera f = new cabecera();
                f.Show();
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdbid.Checked == true)
                {
                    operaciones oper = new operaciones();
                    dgvdatos.DataSource = oper.cosnsultaconresultado("select " + txtcondiocional.Text + "  from  empleado where empleado_id = '" + txtbuscar.Text + "'");
                }

                else if (rdbnombre.Checked == true)
                {
                    operaciones oper = new operaciones();
                    dgvdatos.DataSource = oper.cosnsultaconresultado("select " + txtcondiocional.Text + "  from  empleado where nombre = '" + txtbuscar.Text + "'");
                }
                else if (rdbapellido.Checked == true)
                {
                    operaciones oper = new operaciones();
                    dgvdatos.DataSource = oper.cosnsultaconresultado("select " + txtcondiocional.Text + "  from  empleado where apellido = '" + txtbuscar.Text + "'");
                }

                else if (rdbcedula.Checked == true)
                {
                    operaciones oper = new operaciones();
                    dgvdatos.DataSource = oper.cosnsultaconresultado("select " + txtcondiocional.Text + "  from  empleado where cedula = '" + txtbuscar.Text + "'");
                }

                else if (rdbsexo.Checked == true)
                {
                    operaciones oper = new operaciones();
                    dgvdatos.DataSource = oper.cosnsultaconresultado("select " + txtcondiocional.Text + "  from  empleado where sexo = '" + txtbuscar.Text + "'");
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            operaciones oper = new operaciones();
            string resultado = oper.conectar();
            MessageBox.Show(resultado);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cmbtablas.Text == "Empleado")
            {
                operaciones oper = new operaciones();
                dgvdatos.DataSource = oper.cosnsultaconresultado("select * from  empleado ");
            }

            else if (cmbtablas.Text == "Cargo")
            {
                operaciones oper = new operaciones();
                dgvdatos.DataSource = oper.cosnsultaconresultado("select * from  cargo ");

            }

            else if (cmbtablas.Text == "Detalles Nomina")
            {
                operaciones oper = new operaciones();
                dgvdatos.DataSource = oper.cosnsultaconresultado("select * from  detalle_nomina ");
            }

            else if (cmbtablas.Text == "Cabecera Nomina")
            {
                operaciones oper = new operaciones();
                dgvdatos.DataSource = oper.cosnsultaconresultado("select * from  cabecera_nomina ");

            }

        }

        private void cmbtablas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rdbid_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dgvdatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cmbtablas.Text == "Empleado")
            {
                datos_generales f = new datos_generales();
                f.Show();
            }

            else if (cmbtablas.Text == "Cabecera Nomina")
            {
                cabeceraactuali f = new cabeceraactuali();
                f.Show();

            }




        }

        private void btnprueba_Click(object sender, EventArgs e)
        {
            datos_generales f = new datos_generales();
            f.Show();
        }

        private void btnimp_Click(object sender, EventArgs e)
        {
            if (cmbtablas.Text == "Empleado")
            {

                operaciones oper = new operaciones();
                DataSet ds = new DataSet();

                DataTable dt = oper.cosnsultaconresultado(" SELECT * FROM empleado");
                ds.Tables.Add(dt);

                ds.WriteXml(@"C:\bdd\empleado.xml");

                frm_visor f = new frm_visor("visorempl.rpt");
                f.Show();
            }

            else if(cmbtablas.Text == "Detalles Nomina")
            {
                operaciones oper = new operaciones();
                DataSet ds = new DataSet();

                DataTable dt = oper.cosnsultaconresultado(" SELECT * FROM detalle_nomina");
                ds.Tables.Add(dt);

                ds.WriteXml(@"C:\bdd\nomina.xml");

                frm_visor f = new frm_visor("visordn.rpt");
                f.Show();
            }

            else if (cmbtablas.Text == "Cargo")
            {
                operaciones oper = new operaciones();
                DataSet ds = new DataSet();

                DataTable dt = oper.cosnsultaconresultado(" SELECT * FROM cargo");
                ds.Tables.Add(dt);

                ds.WriteXml(@"C:\bdd\Cargo.xml");

                frm_visor f = new frm_visor("visorcar.rpt");
                f.Show();
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {




        }


            
    
    

       
    }
}
