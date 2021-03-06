
namespace InventarioEmpresa
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.cbMostrar = new System.Windows.Forms.CheckBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(27, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.White;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtUsuario.Location = new System.Drawing.Point(183, 26);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(137, 22);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.Text = "admin";
            // 
            // txtContrasena
            // 
            this.txtContrasena.BackColor = System.Drawing.Color.White;
            this.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContrasena.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtContrasena.Location = new System.Drawing.Point(183, 74);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(137, 22);
            this.txtContrasena.TabIndex = 3;
            this.txtContrasena.Text = "admin";
            // 
            // cbMostrar
            // 
            this.cbMostrar.AutoSize = true;
            this.cbMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMostrar.ForeColor = System.Drawing.Color.Black;
            this.cbMostrar.Location = new System.Drawing.Point(252, 102);
            this.cbMostrar.Name = "cbMostrar";
            this.cbMostrar.Size = new System.Drawing.Size(68, 19);
            this.cbMostrar.TabIndex = 4;
            this.cbMostrar.Text = "Mostrar";
            this.cbMostrar.UseVisualStyleBackColor = true;
            this.cbMostrar.CheckedChanged += new System.EventHandler(this.cbMostrar_CheckedChanged);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.White;
            this.btnIngresar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIngresar.Font = new System.Drawing.Font("Verdana", 8F);
            this.btnIngresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnIngresar.Image = global::InventarioEmpresa.Properties.Resources.login;
            this.btnIngresar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIngresar.Location = new System.Drawing.Point(183, 153);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(137, 35);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Iniciar sesión";
            this.btnIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.White;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrar.Font = new System.Drawing.Font("Verdana", 8F);
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.Location = new System.Drawing.Point(30, 153);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(137, 35);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar aplicación";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.btnIngresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DimGray;
            this.CancelButton = this.btnCerrar;
            this.ClientSize = new System.Drawing.Size(350, 200);
            this.ControlBox = false;
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.cbMostrar);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de sesión";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.CheckBox cbMostrar;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnCerrar;
    }
}