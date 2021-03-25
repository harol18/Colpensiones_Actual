﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using System.Globalization;
using Color = System.Drawing.Color;

namespace Usuarios_planta.Capa_presentacion
{
    public partial class Formdia : Form
    {
        MySqlConnection con = new MySqlConnection("server=;Uid=;password=;database=dblibranza;port=3306;persistsecurityinfo=True;");


        Comandos cmds = new Comandos();
        dia_dia cmds_dia = new dia_dia();
        Conversion c = new Conversion();
        private Button currentBtn;


        public Formdia()
        {
            InitializeComponent();
        }

        bool move = false;

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(251, 187, 33);
            public static Color color2 = Color.FromArgb(52, 179, 29);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(53, 41, 237);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (Button)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = Color.FromArgb(215, 219, 222);
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(0, 66, 84);
                currentBtn.ForeColor = Color.Gainsboro;
            }
        }

        DateTime fecha = DateTime.Now;
        DateTime fecha1 = DateTime.Now;

        private void Formdia_Load(object sender, EventArgs e)
        {      
            lblfecha_actual.Text = fecha.ToString("yyyy-MM-dd");
            dtpcargue.Text = "01/01/2020";
            dtpfecha_rpta.Text = "01/01/2020";
            lblrescate.Visible = false;
            lbafiliacion.Visible = false;
            cmds_dia.Total_Fecha_Rta(lblfecha_actual, lblhoy);
            cmds_dia.Total_Fecha_Rta_anterior(lblfecha_actual, lblFecha_anterior);           
        }

        private void Txtafiliacion2_Validated(object sender, EventArgs e)
        {
            if (Txtafiliacion1.Text == Txtafiliacion2.Text)
                lbafiliacion.Text = "Ok Afiliacion";
            else
            {
                MessageBox.Show("Numero de Afiliacion no coincide");
                lbafiliacion.Visible = false;
                Txtafiliacion1.Focus();
                Txtafiliacion1.Text = "";
                Txtafiliacion2.Text = "";
            }
        }

        private void Txtscoring_Validated(object sender, EventArgs e)
        {
            string extrae;

            extrae = Txtscoring.Text.Substring(Txtscoring.Text.Length - 5); // extrae los ultimos 5 digitos del textbox 
            Txtpagare.Text = "0158" + extrae;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
            Form formulario = new VoBo();
            formulario.Show();
        }

        private void Btnbuscar_Click(object sender, EventArgs e)
        {
            cmds_dia.buscar_colp(Txtradicado, Txtcedula, Txtnombre, TxtEstado_cliente, Txtafiliacion1, Txtafiliacion2, cmbtipo, Txtscoring, Txtconsecutivo,
                             cmbfuerza, cmbdestino, Txtrtq, Txtmonto, Txtplazo, Txtcuota, Txttotal, Txtpagare, Txtnit, Txtcuota_letras,
                             Txttotal_letras, cmbestado, cmbcargue, dtpcargue, cmbresultado, cmbrechazo, dtpfecha_rpta,
                             Txtplano_dia, Txtplano_pre, TxtN_Plano, Txtcomentarios);

        }

        private void Txtcedula_TextChanged(object sender, EventArgs e)
        {
            string largo = Txtcedula.Text;
            string length = Convert.ToString(largo.Length);

            if (length == "6")
            {
                Txtplano_dia.Text = "DIA000000" + Txtcedula.Text;
                Txtplano_pre.Text = "PRE000000" + Txtcedula.Text;
            }
            else if (length == "7")
            {
                Txtplano_dia.Text = "DIA00000" + Txtcedula.Text;
                Txtplano_pre.Text = "PRE00000" + Txtcedula.Text;
            }
            else if (length == "8")
            {
                Txtplano_dia.Text = "DIA0000" + Txtcedula.Text;
                Txtplano_pre.Text = "PRE0000" + Txtcedula.Text;
            }
            else if (length == "9")
            {
                Txtplano_dia.Text = "DIA000" + Txtcedula.Text;
                Txtplano_pre.Text = "PRE000" + Txtcedula.Text;
            }
            else if (length == "10")
            {
                Txtplano_dia.Text = "DIA00" + Txtcedula.Text;
                Txtplano_pre.Text = "PRE00" + Txtcedula.Text;
            }
        }

        private void Txtcuota_TextChanged(object sender, EventArgs e)
        {
            Txtcuota_letras.Text = c.enletras(Txtcuota.Text).ToUpper() + " PESOS";
        }

        private void cmbrechazo_MouseClick(object sender, MouseEventArgs e)
        {
            string query = "SELECT id_rechazo, codigo from tfrechazos_colp";
            MySqlCommand comando = new MySqlCommand(query, con);
            MySqlDataAdapter da1 = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da1.Fill(dt);
            cmbrechazo.ValueMember = "id_rechazo";
            cmbrechazo.DisplayMember = "codigo";
            cmbrechazo.DataSource = dt;
        }
        private void Txttotal_TextChanged(object sender, EventArgs e)
        {
            Txttotal_letras.Text = c.enletras(Txttotal.Text).ToUpper() + " PESOS";
        }       

        private void Txtmonto_Validated(object sender, EventArgs e)
        {
            if (Convert.ToDouble(Txtmonto.Text) > 0)
            {
                Txtmonto.Text = string.Format("{0:#,##0}", double.Parse(Txtmonto.Text));

            }
            else if (Txtmonto.Text == "")
            {
                Txtmonto.Text = Convert.ToString(0);
            }
        }

        private bool validar()
        {
            bool ok = true;

            if (Txtafiliacion1.Text == "")
            {
                ok = false;
                epError.SetError(Txtafiliacion1, "Debes digitar N° Afiliacion");
            }
            if (Txtafiliacion2.Text == "")
            {
                ok = false;
                epError.SetError(Txtafiliacion2, "Debes digitar N° Afiliacion");
            }
            if (Txtscoring.Text == "")
            {
                ok = false;
                epError.SetError(Txtscoring, "Debes digitar N° Scoring");
            }
            if (Txtmonto.Text == "")
            {
                ok = false;
                epError.SetError(Txtmonto, "Debes digitar Monto");
            }
            if (Txtplazo.Text == "")
            {
                ok = false;
                epError.SetError(Txtplazo, "Debes digitar Plazo");
            }
            if (Txtplazo.Text == "")
            {
                ok = false;
                epError.SetError(cmbestado, "Debes seleccionar estado de la operacion");
            }            
            return ok;
        }

        private void BorrarMensajeError()
        {
            epError.SetError(Txtafiliacion1, "");
            epError.SetError(Txtafiliacion2, "");
            epError.SetError(Txtscoring, "");
            epError.SetError(Txtmonto, "");
            epError.SetError(Txtplazo, "");
            epError.SetError(cmbestado, "");
        }

        private void Txtcuota_Validated(object sender, EventArgs e)
        {
            Txtcuota.Text = string.Format("{0:#,##0}", double.Parse(Txtcuota.Text));
            Txttotal.Text = (double.Parse(Txtcuota.Text) * double.Parse(Txtplazo.Text)).ToString();

            if (Convert.ToDouble(Txttotal.Text) > 0)
            {
                Txttotal.Text = string.Format("{0:#,##0}", double.Parse(Txttotal.Text));

            }
            else if (Txttotal.Text == "")
            {
                Txttotal.Text = Convert.ToString(0);
            }
        }

        private void TxtEstado_cliente_TextChanged(object sender, EventArgs e)
        {
            if (TxtEstado_cliente.Text == "Fallecido")
            {
                MessageBox.Show("Por favor validar cliente fallecido");
            }
        }

        private void Txtcedula_Validated(object sender, EventArgs e)
        {
            cmds_dia.buscar_fallecido(Txtcedula, TxtEstado_cliente);
            
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            BorrarMensajeError();
            if (validar())
            {
                cmds_dia.Insertar_colp(Txtradicado, Txtcedula, Txtnombre, TxtEstado_cliente, Txtafiliacion1, Txtafiliacion2, cmbtipo,
                                   Txtscoring, Txtconsecutivo, cmbfuerza, cmbdestino, Txtrtq, Txtmonto, Txtplazo, Txtcuota, Txttotal, Txtpagare, Txtnit,
                                   Txtcuota_letras, Txttotal_letras, cmbestado, cmbcargue, dtpcargue, cmbresultado,
                                   cmbrechazo, dtpfecha_rpta, Txtplano_dia, Txtplano_pre, TxtN_Plano, Txtcomentarios);                
            }
        }

        private void cmbestado_SelectedIndexChanged(object sender, EventArgs e)
        {
            string extrae;
            extrae = usuario.Identificacion.Substring(usuario.Identificacion.Length - 3); // extrae los ultimos 5 digitos del textbox 
            
            if (cmbestado.Text == "Aprobada")
            {
                Txtcomentarios.Text = "Crédito Aprobado Scoring: " + Txtscoring.Text + " Monto: " + Txtmonto.Text + " Plazo: " + Txtplazo.Text + " Meses" + " Destino: " + cmbdestino.Text + " " + extrae;
            }
            else if (cmbestado.Text == "Negada")
            {
                Txtcomentarios.Text = "Crédito Negado por el convenio debido a: " + " "+ extrae;
            }
            else if (cmbestado.Text == "Devuelta")
            {
                Txtcomentarios.Text = "Operacion devuelta por: " + " " + extrae;
            }
            else if (cmbestado.Text == "Suspendida" && cmbrestriccion.Text=="SI")
            {
                cod_suspendido.Visible = true;
                Txtcomentarios.Text = fecha.ToString("ddMMyyyy") + " ISS Convenio se encuentra en periodo de restriccion desde dd/mm/yyyy hasta dd/mm/yyyy con posible fecha de respuesta el dd/mm/yyyy. Se radica en plataforma el dia " + dtpcargue.Text + " 907" + " " + extrae;
            }
            else if (cmbestado.Text == "Suspendida" && cmbrestriccion.Text == "NO")
            {
                cod_suspendido.Visible = true;
                Txtcomentarios.Text = fecha.ToString("ddMMyyyy") + " ISS Operacion se radica en plataforma el " + dtpcargue.Text + " CON POSIBLE FECHA DE RESPUESTA EL " + dtpfecha_rpta.Text + " " + extrae;
            }
        }

        private void cmbresultado_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtpfecha_rpta.Text = fecha.ToString("dd/MM/yyyy");

            if (cmbdestino.Text== "Retanqueo" && cmbresultado.Text=="Negada" )
            {
                lblrescate.Visible = true;
            }
            else if (cmbdestino.Text == "CPK Consumo RTQ" && cmbresultado.Text == "Negada")
            {
                MessageBox.Show("Proceder a recuperar el descuento");
            }
            else
            {
                lblrescate.Visible = false;
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Close();
            Form formulario = new VoBo();
            formulario.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox12_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == true)
            {
                this.Location = Cursor.Position;
            }
        }

        private void pictureBox12_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
        }

        private void pictureBox12_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void cmbrestriccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string extrae;
            extrae = usuario.Identificacion.Substring(usuario.Identificacion.Length - 3); // extrae los ultimos 5 digitos del textbox 

            if (cmbestado.Text == "Suspendida" && cmbrestriccion.Text == "SI")
            {
                Txtcomentarios.Text = fecha.ToString("ddMMyyyy") + " ISS Convenio se encuentra en periodo de restriccion desde dd/mm/yyyy hasta dd/mm/yyyy con posible fecha de respuesta el " + dtpfecha_rpta.Text + " Se radica en plataforma el dia " + fecha.ToString("dd/MM/yyyy") + " 907" + " "+ extrae;
            }
            else if (cmbestado.Text == "Suspendida" && cmbrestriccion.Text == "NO")
            {
                Txtcomentarios.Text = fecha.ToString("ddMMyyyy") + " ISS Operacion se radica en plataforma el " + fecha.ToString("dd/MM/yyyy") + " CON POSIBLE FECHA DE RESPUESTA EL " + dtpfecha_rpta.Text + " 908" +
                    " " + extrae;
            }
        }

        private void Btn_busqueda_Click(object sender, EventArgs e)
        {
            dgv_datos_plano.DataSource = null;
            cmds.busqueda_plano(dgv_datos_plano, Txtbusqueda);
        }       

        private void cod_suspendido_SelectedIndexChanged(object sender, EventArgs e)
        {
            string extrae;            
            extrae = usuario.Identificacion.Substring(usuario.Identificacion.Length - 3); // extrae los ultimos 5 digitos del textbox 
            
            if (cmbestado.Text == "Suspendida" && cod_suspendido.Text == "904")
            {
                Txtcomentarios.Text = fecha.ToString("ddMMyyyy") + " ISS operación con novedad en el convenio 10005 El número de libranza registrado en el archivo plano préstamo NO coincide con el indicado en la imagen de la plantilla autorización descuentos. convenio se encuentra en periodo de restriccion desde el dd/MM/yyyy hasta dd/MM/yyyy con posible fecha de respuesta el dd/MM/yyyy se vuelve a radicar en plataforma el dia " + dtpcargue.Text + " " + extrae + " 904";
            }
            else if (cmbestado.Text == "Suspendida" && cod_suspendido.Text == "907")
            {
                Txtcomentarios.Text = fecha.ToString("ddMMyyyy") + " Convenio se encuentra en periodo de restriccion desde el dd/MM/yyyy hasta dd/MM/yyyy con posible fecha de respuesta el dd/MM/yyyy se radica en plataforma el dia " + dtpcargue.Text + " " + extrae + " 907";
            }
            else if (cmbestado.Text == "Suspendida" && cod_suspendido.Text == "908")
            {
                Txtcomentarios.Text = fecha.ToString("ddMMyyyy") + " ISS Operacion se radica en plataforma el " + dtpcargue.Text + " con posible fecha de respuesta el dia  " + dtpfecha_rpta.Text + extrae + " 908";

            }
            else if (cmbestado.Text == "Suspendida" && cod_suspendido.Text == "914")
            {
                Txtcomentarios.Text = fecha.ToString("ddMMyyyy") + " Operacion reportada al area de retoques por novedad evaluacion y sancion " + extrae + " 914";
            }
            else if (cmbestado.Text == "Suspendida" && cod_suspendido.Text == "919")
            {
                Txtcomentarios.Text = fecha.ToString("ddMMyyyy") + " Se reporta al area de scoring / Cierre Operativo para ratificacion de condiciones del credito " + extrae + " 919";
            }
            else if (cmbestado.Text == "Suspendida" && cod_suspendido.Text=="920")
            {                
                Txtcomentarios.Text = fecha.ToString("ddMMyyyy") + " Convenio ISS Destino " + cmbdestino.Text + " Se reporta novedad a area encargada " + extrae + " 920" ;
            }
            else if (cmbestado.Text == "Suspendida" && cod_suspendido.Text == "928")
            {
                Txtcomentarios.Text = fecha.ToString("ddMMyyyy") + " Se reporta al area de seguros bbva en espera de respuesta para continuar tramite de visto bueno pagador convenio ISS " + extrae + " 928";
            }            
            else
            {

            }
        }

        private void cmbdestino_Validated(object sender, EventArgs e)
        {
            if (cmbdestino.Text == "Retanqueo" || cmbdestino.Text == "CPK Consumo RTQ")
            {
                cmds_dia.buscar_recaudo(Txtcedula);
            }
        }      

        private void Txtcuota_letras_KeyPress(object sender, KeyPressEventArgs e)
        {
            Txtcuota_letras.ReadOnly = true;
        }

        private void Txttotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            Txttotal.ReadOnly = true;
        }

        private void Txttotal_letras_KeyPress(object sender, KeyPressEventArgs e)
        {
            Txttotal_letras.ReadOnly = true;
        }

        private void Txtpagare_KeyPress(object sender, KeyPressEventArgs e)
        {
            Txtpagare.ReadOnly = true;
        }

        private void Txtplano_dia_KeyPress(object sender, KeyPressEventArgs e)
        {
            Txtplano_dia.ReadOnly = true;
        }

        private void Txtplano_pre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Txtplano_pre.ReadOnly = true;
        }

        private void TxtN_Plano_KeyPress(object sender, KeyPressEventArgs e)
        {
            TxtN_Plano.ReadOnly = true;
        }

        private void Txtnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            Txtnit.ReadOnly = true;
        }

        private void BtnCopiar_Plazo_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(Txtplazo.Text, true);
        }

        private void BtnCopiar_Cuota_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(Txtcuota.Text, true);
        }

        private void BtnCopiar_Cuota_Letras_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(Txtcuota_letras.Text, true);
        }

        private void BtnCopiar_Total_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(Txttotal.Text, true);
        }

        private void BtnCopiar_Total_Letras_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(Txttotal_letras.Text, true);
        }

        private void BtnCopiar_Pagare_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(Txtpagare.Text, true);
        }

        private void BtnCopiar_Dia_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(Txtplano_dia.Text, true);
        }

        private void BtnCopiar_Pre_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(Txtplano_pre.Text, true);
        }

        private void BtnCopiar_Plano_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(TxtN_Plano.Text, true);
        }

        private void BtnCopiar_Nit_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(Txtnit.Text, true);
        }

        private void BtnCopiar_Comentarios_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(Txtcomentarios.Text, true);
        }

        private void cmbtipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbtipo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Txtradicado.Text = null;
            Txtcedula.Text = null;
            Txtradicado.Text = null;
            Txtcedula.Text = null;
            Txtnombre.Text = null;
            TxtEstado_cliente.Text = null;
            Txtafiliacion1.Text = null;
            Txtafiliacion2.Text = null;
            cmbtipo.Text = null;
            Txtscoring.Text = null;
            Txtconsecutivo.Text = null;
            cmbfuerza.Text = null;
            cmbdestino.Text = null;
            Txtrtq.Text = null;
            Txtmonto.Text = null;
            Txtplazo.Text = null;
            Txtcuota.Text = null;
            Txttotal.Text = null;
            Txtpagare.Text = null;
            Txtnit.Text = null;
            Txtcuota_letras.Text = null;
            Txttotal_letras.Text = null;
            cmbestado.Text = null;
            cmbcargue.Text = null;
            dtpcargue.Text = "01/01/2020";
            cmbresultado.Text = null;
            cmbrechazo.Text = null;
            dtpfecha_rpta.Text = "01/01/2020";
            Txtplano_dia.Text = null;
            Txtplano_pre.Text = null;
            TxtN_Plano.Text = null;
            Txtcomentarios.Text = null;
            cod_suspendido.Text = null;
            cmds_dia.Total_Fecha_Rta(lblfecha_actual, lblhoy);
            cmds_dia.Total_Fecha_Rta_anterior(lblfecha_actual, lblFecha_anterior);
        }

        private void dtpcargue_ValueChanged(object sender, EventArgs e)
        {
            string extrae;
            extrae = usuario.Identificacion.Substring(usuario.Identificacion.Length - 3); // extrae los ultimos 5 digitos del textbox 

            string d = dtpcargue.Value.DayOfWeek.ToString();
            DateTime dt = new DateTime();
            dt = Convert.ToDateTime(dtpcargue.Value);
            dt = dt.AddDays(0);

            if (d == "Monday" || d== "Tuesday")
            {
                dtpfecha_rpta.Value = dt.AddDays(3);
            }
            else if (d == "Wednesday" || d == "Thursday" || d == "Friday")
            {
                dtpfecha_rpta.Value = dt.AddDays(5);
            }

            if (cmbestado.Text == "Aprobada")
            {
                Txtcomentarios.Text = "Crédito Aprobado Scoring: " + Txtscoring.Text + " Monto: " + Txtmonto.Text + " Plazo: " + Txtplazo.Text + " Meses" + " Destino: " + cmbdestino.Text + " " + extrae;
            }
            else if (cmbestado.Text == "Negada")
            {
                Txtcomentarios.Text = "Crédito Negado por el convenio debido a: " + " " + extrae;
            }
            else if (cmbestado.Text == "Devuelta")
            {
                Txtcomentarios.Text = "Operacion devuelta por: ";
            }
            else if (cmbestado.Text == "Suspendida" && cmbrestriccion.Text == "SI")
            {
                cod_suspendido.Visible = true;
                Txtcomentarios.Text = fecha.ToString("ddMMyyyy") + " ISS Convenio se encuentra en periodo de restriccion desde dd/mm/yyyy hasta dd/mm/yyyy con posible fecha de respuesta el dd/mm/yyyy. Se radica en plataforma el dia " + dtpcargue.Text + " 907 " + extrae;
            }
            else if (cmbestado.Text == "Suspendida" && cmbrestriccion.Text == "NO")
            {
                cod_suspendido.Visible = true; 
                Txtcomentarios.Text = fecha.ToString("ddMMyyyy") + " ISS Operacion se radica en plataforma el " + dtpcargue.Text + " CON POSIBLE FECHA DE RESPUESTA EL " + dtpfecha_rpta.Text + " 908" +
                    " " + extrae;
            }
            else if (cmbestado.Text == "Suspendida" && cod_suspendido.Text == "904")
            {
                Txtcomentarios.Text = fecha.ToString("ddMMyyyy") + " ISS operación con novedad en el convenio 10005 El número de libranza registrado en el archivo plano préstamo NO coincide con el indicado en la imagen de la plantilla autorización descuentos. convenio se encuentra en periodo de restriccion desde el dd/MM/yyyy hasta dd/MM/yyyy con posible fecha de respuesta el dd/MM/yyyy se vuelve a radicar en plataforma el dia " + dtpcargue.Text + " " + extrae + " 904";
            }
            else if (cmbestado.Text == "Suspendida" && cod_suspendido.Text == "907")
            {
                Txtcomentarios.Text = fecha.ToString("ddMMyyyy") + " Convenio se encuentra en periodo de restriccion desde el dd/MM/yyyy hasta dd/MM/yyyy con posible fecha de respuesta el dd/MM/yyyy se radica en plataforma el dia " + dtpcargue.Text + " " + extrae + " 907 ";
            }
            else if (cmbestado.Text == "Suspendida" && cod_suspendido.Text == "908")
            {
                Txtcomentarios.Text = fecha.ToString("ddMMyyyy") + " ISS Operacion se radica en plataforma el " + dtpcargue.Text + " con posible fecha de respuesta el dia  " + dtpfecha_rpta.Text + extrae + " " + " 908 ";

            }
            else if (cmbestado.Text == "Suspendida" && cod_suspendido.Text == "914")
            {
                Txtcomentarios.Text = fecha.ToString("ddMMyyyy") + " Operacion reportada al area de retoques por novedad evaluacion y sancion " + extrae + " 914";
            }
            else if (cmbestado.Text == "Suspendida" && cod_suspendido.Text == "919")
            {
                Txtcomentarios.Text = fecha.ToString("ddMMyyyy") + " Se reporta al area de scoring / Cierre Operativo para ratificacion de condiciones del credito " + extrae + " 919";
            }
            else if (cmbestado.Text == "Suspendida" && cod_suspendido.Text == "920")
            {
                Txtcomentarios.Text = fecha.ToString("ddMMyyyy") + " Convenio ISS Destino " + cmbdestino.Text + " Se reporta novedad a area encargada " + extrae + " 920";
            }
            else if (cmbestado.Text == "Suspendida" && cod_suspendido.Text == "928")
            {
                Txtcomentarios.Text = fecha.ToString("ddMMyyyy") + " Se reporta al area de seguros bbva en espera de respuesta para continuar tramite de visto bueno pagador convenio ISS " + extrae + " 928";
            }

            else if (cmbestado.Text == "Suspendida" && cmbrestriccion.Text == "")
            {
                cod_suspendido.Visible = true;
                Txtcomentarios.Text = fecha.ToString("ddMMyyyy") + " ISS Operacion se radica en plataforma el " + dtpcargue.Text + " CON POSIBLE FECHA DE RESPUESTA EL " + dtpfecha_rpta.Text + " 908" + " " + extrae;
            }
        }

        private void dtpfecha_rpta_ValueChanged(object sender, EventArgs e)
        {
            string extrae;
            extrae = usuario.Identificacion.Substring(usuario.Identificacion.Length - 3); // extrae los ultimos 5 digitos del textbox 

            if (cmbestado.Text == "Aprobada")
            {
                Txtcomentarios.Text = "Crédito Aprobado Scoring: " + Txtscoring.Text + " Monto: " + Txtmonto.Text + " Plazo: " + Txtplazo.Text + " Meses" + " Destino: " + cmbdestino.Text + " " + extrae;
            }
            else if (cmbestado.Text == "Negada")
            {
                Txtcomentarios.Text = "Crédito Negado por el convenio debido a: " + " " + extrae;
            }
            else if (cmbestado.Text == "Devuelta")
            {
                Txtcomentarios.Text = "Operacion devuelta por: " + " " + extrae;
            }
            else if (cmbestado.Text == "Suspendida" && cmbrestriccion.Text == "SI")
            {
                cod_suspendido.Visible = true;
                Txtcomentarios.Text = fecha.ToString("ddMMyyyy") + " ISS Convenio se encuentra en periodo de restriccion desde dd/mm/yyyy hasta dd/mm/yyyy con posible fecha de respuesta el dd/mm/yyyy. Se radica en plataforma el dia " + dtpcargue.Text + " 907" + " " + extrae;
            }
            else if (cmbestado.Text == "Suspendida" && cmbrestriccion.Text == "NO")
            {
                cod_suspendido.Visible = true;
                Txtcomentarios.Text = fecha.ToString("ddMMyyyy") + " ISS Operacion se radica en plataforma el " + dtpcargue.Text + " CON POSIBLE FECHA DE RESPUESTA EL " + dtpfecha_rpta.Text + " " + extrae;
            }
            else if (cmbestado.Text == "Suspendida" && cmbrestriccion.Text == "")
            {
                cod_suspendido.Visible = true;
                Txtcomentarios.Text = fecha.ToString("ddMMyyyy") + " ISS Operacion se radica en plataforma el " + dtpcargue.Text + " CON POSIBLE FECHA DE RESPUESTA EL " + dtpfecha_rpta.Text + " " + extrae;
            }
        }

        private void cmbcargue_SelectedIndexChanged(object sender, EventArgs e)
        {
            string extrae;
            extrae = usuario.Identificacion.Substring(usuario.Identificacion.Length - 3); // extrae los ultimos 5 digitos del textbox 

            if (cmbestado.Text == "Aprobada")
            {
                Txtcomentarios.Text = "Crédito Aprobado Scoring: " + Txtscoring.Text + " Monto: " + Txtmonto.Text + " Plazo: " + Txtplazo.Text + " Meses" + " Destino: " + cmbdestino.Text + " " + extrae;
            }
            else if (cmbestado.Text == "Negada")
            {
                Txtcomentarios.Text = "Crédito Negado por el convenio debido a: " + " " + extrae;
            }
            else if (cmbestado.Text == "Devuelta")
            {
                Txtcomentarios.Text = "Operacion devuelta por: " + " " + extrae;
            }
            else if (cmbestado.Text == "Suspendida" && cmbrestriccion.Text == "")
            {           
                cod_suspendido.Visible = true;
                Txtcomentarios.Text = fecha.ToString("ddMMyyyy") + " ISS Operacion se radica en plataforma el " + dtpcargue.Text + " CON POSIBLE FECHA DE RESPUESTA EL " + dtpfecha_rpta.Text + " 908" +
                    " " + extrae;
            }
            else if (cmbestado.Text == "Suspendida" && cmbrestriccion.Text == "SI")
            {
                cod_suspendido.Visible = true;
                Txtcomentarios.Text = fecha.ToString("ddMMyyyy") + " ISS Convenio se encuentra en periodo de restriccion desde dd/mm/yyyy hasta dd/mm/yyyy con posible fecha de respuesta el dd/mm/yyyy. Se radica en plataforma el dia " + dtpcargue.Text + " 907" + " " + extrae;
            }
            else if (cmbestado.Text == "Suspendida" && cmbrestriccion.Text == "NO")
            {
                cod_suspendido.Visible = true;
                Txtcomentarios.Text = fecha.ToString("ddMMyyyy") + " ISS Operacion se radica en plataforma el " + dtpcargue.Text + " CON POSIBLE FECHA DE RESPUESTA EL " + dtpfecha_rpta.Text + " 908" +
                    " " + extrae;
            }
        }

        private void dtpfecha_rpta_ValueChanged_1(object sender, EventArgs e)
        {
            string extrae;
            extrae = usuario.Identificacion.Substring(usuario.Identificacion.Length - 3); // extrae los ultimos 5 digitos del textbox 

            if (cmbestado.Text == "Aprobada")
            {
                Txtcomentarios.Text = "Crédito Aprobado Scoring: " + Txtscoring.Text + " Monto: " + Txtmonto.Text + " Plazo: " + Txtplazo.Text + " Meses" + " Destino: " + cmbdestino.Text + " " + extrae;
            }
            else if (cmbestado.Text == "Negada")
            {
                Txtcomentarios.Text = "Crédito Negado por el convenio debido a: " + " " + extrae;
            }
            else if (cmbestado.Text == "Devuelta")
            {
                Txtcomentarios.Text = "Operacion devuelta por: " + " " + extrae;
            }
            else if (cmbestado.Text == "Suspendida" && cmbrestriccion.Text == "")
            {
                cod_suspendido.Visible = true;
                Txtcomentarios.Text = fecha.ToString("ddMMyyyy") + " ISS Operacion se radica en plataforma el " + dtpcargue.Text + " CON POSIBLE FECHA DE RESPUESTA EL " + dtpfecha_rpta.Text + " 908" + " " + extrae;
            }
            else if (cmbestado.Text == "Suspendida" && cmbrestriccion.Text == "SI")
            {
                cod_suspendido.Visible = true;
                Txtcomentarios.Text = fecha.ToString("ddMMyyyy") + " ISS Convenio se encuentra en periodo de restriccion desde dd/mm/yyyy hasta dd/mm/yyyy con posible fecha de respuesta el dd/mm/yyyy. Se radica en plataforma el dia " + dtpcargue.Text + " 907" + " " + extrae;
            }
            else if (cmbestado.Text == "Suspendida" && cmbrestriccion.Text == "NO")
            {
                cod_suspendido.Visible = true;
                Txtcomentarios.Text = fecha.ToString("ddMMyyyy") + " ISS Operacion se radica en plataforma el " + dtpcargue.Text + " CON POSIBLE FECHA DE RESPUESTA EL " + dtpfecha_rpta.Text + " 908" + " " + extrae;
            }
        }

        private void Txtcedula_TextChanged_1(object sender, EventArgs e)
        {
            string largo = Txtcedula.Text;
            string length = Convert.ToString(largo.Length);

            if (length == "6")
            {
                Txtplano_dia.Text = "DIA000000" + Txtcedula.Text;
                Txtplano_pre.Text = "PRE000000" + Txtcedula.Text;
            }
            else if (length == "7")
            {
                Txtplano_dia.Text = "DIA00000" + Txtcedula.Text;
                Txtplano_pre.Text = "PRE00000" + Txtcedula.Text;
            }
            else if (length == "8")
            {
                Txtplano_dia.Text = "DIA0000" + Txtcedula.Text;
                Txtplano_pre.Text = "PRE0000" + Txtcedula.Text;
            }
            else if (length == "9")
            {
                Txtplano_dia.Text = "DIA000" + Txtcedula.Text;
                Txtplano_pre.Text = "PRE000" + Txtcedula.Text;
            }
            else if (length == "10")
            {
                Txtplano_dia.Text = "DIA00" + Txtcedula.Text;
                Txtplano_pre.Text = "PRE00" + Txtcedula.Text;
            }
        }

        private void Txtcedula_Validated_1(object sender, EventArgs e)
        {
            cmds.buscar_fallecido(Txtcedula, TxtEstado_cliente);
        }

        private void cmbdestino_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbfuerza_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            cmds_dia.Datos_fecha_hoy(dgvPendientes_rta, lblfecha_actual);
        }

        private void dgvPendientes_rta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Txtbusqueda.Text = dgvPendientes_rta.CurrentRow.Cells[0].Value.ToString();
        }

        private void dgv_datos_plano_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Txtradicado.Text = dgv_datos_plano.CurrentRow.Cells[0].Value.ToString();
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            cmds_dia.Datos_fecha_anterior(dgvPendientes_rta, lblfecha_actual);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            cmds_dia.Datos_fecha_anterior(dgvPendientes_rta, lblfecha_actual);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            cmds_dia.Datos_fecha_hoy(dgvPendientes_rta, lblfecha_actual);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmCodigos_Suspension();
            formulario.Show();
        }
    }
}
