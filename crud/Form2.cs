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
    public partial class frn_cargo : Form
    {
        public frn_cargo()
        {
            InitializeComponent();
        }

        private void btnguardcargo_Click(object sender, EventArgs e)
        {
            operaciones oper = new operaciones();
            oper.consultasinreaultado("insert into cargo(cargo,sueldo,Empleado_empleado_id) values('" + txtcargo.Text+ "','"+ txtsueldo.Text +"','" +txtidemplecargo.Text+"')");
        }

        private void btnborrarcargo_Click(object sender, EventArgs e)
        {
            txtcargoid.Text = ("");
            txtcargo.Text = ("");
            txtidemplecargo.Text = ("");
        }
    }
}
