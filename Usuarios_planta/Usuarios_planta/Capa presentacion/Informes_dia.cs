using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Usuarios_planta.Capa_presentacion
{
    public partial class Informes_dia : Form
    {

        dia_dia cmds_dia = new dia_dia();

        public Informes_dia()
        {
            InitializeComponent();
        }

        private void Btn_busqueda_Click(object sender, EventArgs e)
        {
            if (cmbinformes.Text == "Suspendida" && cmbEstado_Cargue.Text=="")
            {
                MessageBox.Show("Debe seleccionar el estado del cargue");  
            }
            else if (cmbinformes.Text == "Suspendida")
            {
                cmds_dia.Informe_dia2(dgv_informes, cmbEstado_Cargue, cmbinformes);
            }
            else
            {
                cmds_dia.Informe_dia(dgv_informes, cmbinformes);
            }
            
        }

        private void Informes_dia_Load(object sender, EventArgs e)
        {
            lblEstado_Cargue.Visible = false;
            cmbEstado_Cargue.Visible = false;
        }

        private void cmbinformes_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbinformes.Text== "Suspendida")
            {
                lblEstado_Cargue.Visible = true;
                cmbEstado_Cargue.Visible = true;
            }
            else
            {
                lblEstado_Cargue.Visible = false;
                cmbEstado_Cargue.Visible = false;
            }
        }

        private void cmbinformes_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbEstado_Cargue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
