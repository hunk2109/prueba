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
    public partial class cabeceraactuali : Form
    {
        public cabeceraactuali()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnbuscarcn_Click(object sender, EventArgs e)
        {
            operaciones oper = new operaciones();
            DataTable dgvdatos = oper.cosnsultaconresultado("select * from detalle_nomina inner join cabecera_nomina,cargo where detalle_id = '"+txtidcn.Text+"' and nomina_id = '"+txtidcn.Text+"' and cargo_id = '"+txtidcn.Text+"' ");
            foreach(DataRow dr in dgvdatos.Rows)
            {
                string idnomina,isr,tnomina,fecha_i,fecha_f,isrc,ddss,s_neto,t_otros,t_dedu,sueld,empl_id;
                idnomina = dr["nomina_id"].ToString();
                txtidn.Text = idnomina;
                isr = dr["nombre_empresa"].ToString();
                txtnomemp.Text = isr;
                tnomina = dr["tipo_nomina"].ToString();
                txtipo.Text = tnomina;
                fecha_i = dr["fecha_inicio"].ToString();
                txtfini.Text = fecha_i;
                fecha_f = dr["fecha_final"].ToString();
                txtffinal.Text = fecha_f;
                isrc = dr["i_s_r"].ToString();
                txtisr.Text = isrc;
                ddss = dr["deduccion_ss"].ToString();
                txtdss.Text = ddss;
                s_neto = dr["sueldo_neto"].ToString();
                txtsneto.Text = s_neto;
                t_otros = dr["otros"].ToString();
                txtotros.Text = t_otros;
                t_dedu = dr["total_deduc"].ToString();
                txttdeducc.Text = t_dedu;
                sueld = dr["sueldo"].ToString();
                txtsueldo.Text = sueld;
                empl_id = dr["Empleado_empleado_id"].ToString();
                txtidempc.Text = empl_id;


            }
        }

        private void cabeceraactuali_Load(object sender, EventArgs e)
        {

        }
    }
}
