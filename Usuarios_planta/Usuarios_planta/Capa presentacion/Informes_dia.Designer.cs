namespace Usuarios_planta.Capa_presentacion
{
    partial class Informes_dia
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
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.cmbinformes = new System.Windows.Forms.ComboBox();
            this.Btn_busqueda = new System.Windows.Forms.PictureBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_informes = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEstado_Cargue = new System.Windows.Forms.ComboBox();
            this.lblEstado_Cargue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_busqueda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_informes)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Usuarios_planta.Properties.Resources.índice1;
            this.pictureBox8.Location = new System.Drawing.Point(3, 12);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(120, 77);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 43;
            this.pictureBox8.TabStop = false;
            // 
            // cmbinformes
            // 
            this.cmbinformes.BackColor = System.Drawing.SystemColors.Menu;
            this.cmbinformes.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbinformes.FormattingEnabled = true;
            this.cmbinformes.Items.AddRange(new object[] {
            "Aprobada",
            "Devuelta",
            "Negada",
            "Reproceso Scoring",
            "Suspendida"});
            this.cmbinformes.Location = new System.Drawing.Point(12, 134);
            this.cmbinformes.Name = "cmbinformes";
            this.cmbinformes.Size = new System.Drawing.Size(194, 28);
            this.cmbinformes.TabIndex = 95;
            this.cmbinformes.SelectedValueChanged += new System.EventHandler(this.cmbinformes_SelectedValueChanged);
            this.cmbinformes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbinformes_KeyPress);
            // 
            // Btn_busqueda
            // 
            this.Btn_busqueda.BackColor = System.Drawing.Color.White;
            this.Btn_busqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_busqueda.Image = global::Usuarios_planta.Properties.Resources.search_26px;
            this.Btn_busqueda.Location = new System.Drawing.Point(212, 134);
            this.Btn_busqueda.Name = "Btn_busqueda";
            this.Btn_busqueda.Size = new System.Drawing.Size(30, 28);
            this.Btn_busqueda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_busqueda.TabIndex = 90;
            this.Btn_busqueda.TabStop = false;
            this.Btn_busqueda.Click += new System.EventHandler(this.Btn_busqueda_Click);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(12, 109);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(165, 21);
            this.label36.TabIndex = 89;
            this.label36.Text = "Estado Operaciones";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(157)))));
            this.label1.Location = new System.Drawing.Point(601, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 32);
            this.label1.TabIndex = 98;
            this.label1.Text = "Datos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_informes
            // 
            this.dgv_informes.AllowUserToAddRows = false;
            this.dgv_informes.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_informes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_informes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_informes.Location = new System.Drawing.Point(306, 125);
            this.dgv_informes.Name = "dgv_informes";
            this.dgv_informes.Size = new System.Drawing.Size(738, 484);
            this.dgv_informes.TabIndex = 97;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(157)))));
            this.label3.Location = new System.Drawing.Point(436, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 43);
            this.label3.TabIndex = 96;
            this.label3.Text = "Informes";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbEstado_Cargue
            // 
            this.cmbEstado_Cargue.BackColor = System.Drawing.SystemColors.Menu;
            this.cmbEstado_Cargue.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado_Cargue.FormattingEnabled = true;
            this.cmbEstado_Cargue.Items.AddRange(new object[] {
            "Ok Cargue",
            "Pendiente Cargue"});
            this.cmbEstado_Cargue.Location = new System.Drawing.Point(12, 205);
            this.cmbEstado_Cargue.Name = "cmbEstado_Cargue";
            this.cmbEstado_Cargue.Size = new System.Drawing.Size(194, 28);
            this.cmbEstado_Cargue.TabIndex = 99;
            this.cmbEstado_Cargue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbEstado_Cargue_KeyPress);
            // 
            // lblEstado_Cargue
            // 
            this.lblEstado_Cargue.AutoSize = true;
            this.lblEstado_Cargue.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado_Cargue.Location = new System.Drawing.Point(12, 180);
            this.lblEstado_Cargue.Name = "lblEstado_Cargue";
            this.lblEstado_Cargue.Size = new System.Drawing.Size(123, 21);
            this.lblEstado_Cargue.TabIndex = 100;
            this.lblEstado_Cargue.Text = "Estado Cargue";
            // 
            // Informes_dia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1147, 630);
            this.Controls.Add(this.lblEstado_Cargue);
            this.Controls.Add(this.cmbEstado_Cargue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_informes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbinformes);
            this.Controls.Add(this.Btn_busqueda);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.pictureBox8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Informes_dia";
            this.Text = "Informes_dia";
            this.Load += new System.EventHandler(this.Informes_dia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_busqueda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_informes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.ComboBox cmbinformes;
        private System.Windows.Forms.PictureBox Btn_busqueda;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_informes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbEstado_Cargue;
        private System.Windows.Forms.Label lblEstado_Cargue;
    }
}