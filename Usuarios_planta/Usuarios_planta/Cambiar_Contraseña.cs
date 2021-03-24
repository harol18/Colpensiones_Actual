using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Usuarios_planta
{
    public partial class Cambiar_Contraseña : Form
    {
        Comandos cmds = new Comandos();

        public Cambiar_Contraseña()
        {
            InitializeComponent();
        }

        private void BtnCambiar_Contraseña_Click(object sender, EventArgs e)
        {
            cmds.Actualizar_Contraseña(Txtusuario, Txtcontraseña);
            Txtusuario.Text = null;
            Txtcontraseña.Text = null;
        }
    }
}
