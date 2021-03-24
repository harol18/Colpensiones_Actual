using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using MySql.Data.MySqlClient;
using System.IO;
using System.Runtime.InteropServices;

namespace Usuarios_planta.Capa_presentacion
{
    public partial class FrmAdministrador : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;Uid=root;password=Indr42020$;database=dblibranza;port=3306;persistsecurityinfo=True;");

        public FrmAdministrador()
        {
            InitializeComponent();
        }

        private void BtnCargar_asignacion_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Title = "Importar archivo (.xlsx, .xlsx)";
            d.Filter = "xlsx|*.xlsx";
            if (d.ShowDialog() == DialogResult.OK)
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO datos_asignacion(Radicado,Cedula,Nombre_Cliente,Scoring,Consecutivo,Monto_Aprobado,Plazo_Aprobado) " +
                    "values (@Radicado,@Cedula,@Nombre_Cliente,@Scoring,@Consecutivo,@Monto_Aprobado,@Plazo_Aprobado)";

                Excel.Application xlApp = new Excel.Application();
                Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(d.FileName);
                Excel.Worksheet xlWorksheet = xlWorkbook.Sheets[1];
                Excel.Range range = xlWorksheet.UsedRange;
                int rows = range.Rows.Count;
                int cols = range.Columns.Count;
                for (int i = 2; i <= rows; i++)
                {

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@Radicado", range.Cells[i, 1].Value2.ToString()); 
                    cmd.Parameters.AddWithValue("@Cedula", range.Cells[i, 2].Value2.ToString());
                    cmd.Parameters.AddWithValue("@Nombre_Cliente", range.Cells[i, 3].Value2);
                    cmd.Parameters.AddWithValue("@Scoring", range.Cells[i, 4].Value2.ToString());
                    cmd.Parameters.AddWithValue("@Consecutivo", range.Cells[i, 5].Value2.ToString());
                    cmd.Parameters.AddWithValue("@Monto_Aprobado", range.Cells[i, 6].Value2.ToString());
                    cmd.Parameters.AddWithValue("@Plazo_Aprobado", range.Cells[i, 7].Value2.ToString());
                    cmd.ExecuteNonQuery();
                }
                ///cerrar excel///
                Marshal.ReleaseComObject(range);
                Marshal.ReleaseComObject(xlWorksheet);
                xlWorkbook.Close();
                Marshal.ReleaseComObject(xlWorkbook);
                xlApp.Quit();
                Marshal.ReleaseComObject(xlApp);
                con.Close();
                MessageBox.Show("Ok cargue Archivo en la base de datos");
            }
        }
    }
}
