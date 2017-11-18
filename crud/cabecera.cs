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
    public partial class cabecera : Form
    {
        public cabecera()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string i = txtfini.Text;
            string f = txtffinal.Text;
            DateTime x = Convert.ToDateTime(i);
            DateTime y = Convert.ToDateTime(f);
            operaciones oper = new operaciones();
            oper.consultasinreaultado("insert into cabecera_nomina(nomina_id,nombre_empresa,tipo_nomina,fecha_inicio,fecha_final) values('"+txtnid.Text+"','"+txtnombreemp.Text+"','"+txttipono.Text+"','"+txtfini+"','"+txtffinal+"')");

        }
    }
}
