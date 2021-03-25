
namespace Usuarios_planta.Capa_presentacion
{
    partial class FrmAdministrador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnCargar_asignacion = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Usuarios_planta.Properties.Resources.colpensiones;
            this.pictureBox6.Location = new System.Drawing.Point(905, 12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(145, 70);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 52;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Usuarios_planta.Properties.Resources.índice1;
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(111, 79);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 55;
            this.pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.iconPictureBox1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.BtnCargar_asignacion);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(394, 198);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(256, 253);
            this.panel3.TabIndex = 54;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconSize = 35;
            this.iconPictureBox1.Location = new System.Drawing.Point(109, 29);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(41, 35);
            this.iconPictureBox1.TabIndex = 5;
            this.iconPictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Roboto", 9F);
            this.label4.Location = new System.Drawing.Point(35, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 53);
            this.label4.TabIndex = 4;
            this.label4.Text = "Proceder a cargar el archivo de asignacion";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Cn", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(80, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Base Asignacion";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnCargar_asignacion
            // 
            this.BtnCargar_asignacion.BackColor = System.Drawing.Color.White;
            this.BtnCargar_asignacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCargar_asignacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCargar_asignacion.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnCargar_asignacion.Font = new System.Drawing.Font("Roboto Cn", 11.25F, System.Drawing.FontStyle.Bold);
            this.BtnCargar_asignacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(101)))), ((int)(((byte)(124)))));
            this.BtnCargar_asignacion.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnCargar_asignacion.IconColor = System.Drawing.Color.Black;
            this.BtnCargar_asignacion.IconSize = 16;
            this.BtnCargar_asignacion.Location = new System.Drawing.Point(27, 196);
            this.BtnCargar_asignacion.Name = "BtnCargar_asignacion";
            this.BtnCargar_asignacion.Rotation = 0D;
            this.BtnCargar_asignacion.Size = new System.Drawing.Size(203, 34);
            this.BtnCargar_asignacion.TabIndex = 1;
            this.BtnCargar_asignacion.Text = "Cargar Archivo";
            this.BtnCargar_asignacion.UseVisualStyleBackColor = false;
            this.BtnCargar_asignacion.Click += new System.EventHandler(this.BtnCargar_asignacion_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(101)))), ((int)(((byte)(124)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(254, 15);
            this.panel4.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Cn", 24F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(157)))));
            this.label2.Location = new System.Drawing.Point(334, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 38);
            this.label2.TabIndex = 53;
            this.label2.Text = "Cargue Archivos Asignacion";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1062, 592);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton BtnCargar_asignacion;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
    }
}