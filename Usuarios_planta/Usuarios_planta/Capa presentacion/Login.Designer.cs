namespace Usuarios_planta.Capa_presentacion
{
    partial class Login
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
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.Txtusuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txtcontraseña = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.btnSalir = new System.Windows.Forms.Button();
            this.BtnCambiar_Contraseña = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.White;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton3.ForeColor = System.Drawing.Color.White;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconSize = 19;
            this.iconButton3.Location = new System.Drawing.Point(198, 106);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Rotation = 0D;
            this.iconButton3.Size = new System.Drawing.Size(18, 20);
            this.iconButton3.TabIndex = 27;
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // Txtusuario
            // 
            this.Txtusuario.BackColor = System.Drawing.Color.White;
            this.Txtusuario.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.Txtusuario.Location = new System.Drawing.Point(33, 46);
            this.Txtusuario.Multiline = true;
            this.Txtusuario.Name = "Txtusuario";
            this.Txtusuario.Size = new System.Drawing.Size(162, 24);
            this.Txtusuario.TabIndex = 8;
            this.Txtusuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.label2.Location = new System.Drawing.Point(30, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Usuario";
            // 
            // Txtcontraseña
            // 
            this.Txtcontraseña.BackColor = System.Drawing.Color.White;
            this.Txtcontraseña.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.Txtcontraseña.Location = new System.Drawing.Point(33, 103);
            this.Txtcontraseña.Multiline = true;
            this.Txtcontraseña.Name = "Txtcontraseña";
            this.Txtcontraseña.PasswordChar = '*';
            this.Txtcontraseña.Size = new System.Drawing.Size(162, 24);
            this.Txtcontraseña.TabIndex = 10;
            this.Txtcontraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.label3.Location = new System.Drawing.Point(30, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Contraseña";
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Location = new System.Drawing.Point(33, 150);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(81, 35);
            this.btnIngresar.TabIndex = 12;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.Ingresar);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.White;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconSize = 15;
            this.iconButton1.Location = new System.Drawing.Point(35, 48);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(18, 20);
            this.iconButton1.TabIndex = 25;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.White;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconSize = 15;
            this.iconButton2.Location = new System.Drawing.Point(34, 106);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Rotation = 0D;
            this.iconButton2.Size = new System.Drawing.Size(18, 20);
            this.iconButton2.TabIndex = 26;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(114, 150);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(81, 35);
            this.btnSalir.TabIndex = 28;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.Salir);
            // 
            // BtnCambiar_Contraseña
            // 
            this.BtnCambiar_Contraseña.AutoSize = true;
            this.BtnCambiar_Contraseña.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCambiar_Contraseña.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.BtnCambiar_Contraseña.ForeColor = System.Drawing.Color.Navy;
            this.BtnCambiar_Contraseña.Location = new System.Drawing.Point(49, 204);
            this.BtnCambiar_Contraseña.Name = "BtnCambiar_Contraseña";
            this.BtnCambiar_Contraseña.Size = new System.Drawing.Size(124, 15);
            this.BtnCambiar_Contraseña.TabIndex = 29;
            this.BtnCambiar_Contraseña.Text = "Cambiar Contraseña";
            this.BtnCambiar_Contraseña.Click += new System.EventHandler(this.BtnCambiar_Contraseña_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.BtnCambiar_Contraseña);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.iconButton3);
            this.panel1.Controls.Add(this.btnIngresar);
            this.panel1.Controls.Add(this.iconButton2);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.Txtusuario);
            this.panel1.Controls.Add(this.Txtcontraseña);
            this.panel1.Location = new System.Drawing.Point(59, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 228);
            this.panel1.TabIndex = 32;
            // 
            // Login
            // 
            this.AcceptButton = this.btnIngresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Usuarios_planta.Properties.Resources.descarga;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(357, 362);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.TextBox Txtusuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txtcontraseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIngresar;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label BtnCambiar_Contraseña;
        private System.Windows.Forms.Panel panel1;
    }
}