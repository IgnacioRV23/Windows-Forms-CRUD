
namespace InventarioEmpresa
{
    partial class FrmBodega
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBodega));
            this.gbContenedor = new System.Windows.Forms.GroupBox();
            this.dgvBodega = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCantidadProducto = new System.Windows.Forms.TextBox();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.lblPrecioProducto = new System.Windows.Forms.Label();
            this.lblCantidadProducto = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.gbPanelBotones = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnRegresarBodega = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnModificarProducto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBodega)).BeginInit();
            this.gbPanelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbContenedor
            // 
            this.gbContenedor.Controls.Add(this.dgvBodega);
            this.gbContenedor.Controls.Add(this.pictureBox1);
            this.gbContenedor.Controls.Add(this.txtCantidadProducto);
            this.gbContenedor.Controls.Add(this.txtPrecioProducto);
            this.gbContenedor.Controls.Add(this.txtNombreProducto);
            this.gbContenedor.Controls.Add(this.lblPrecioProducto);
            this.gbContenedor.Controls.Add(this.lblCantidadProducto);
            this.gbContenedor.Controls.Add(this.lblNombreProducto);
            this.gbContenedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.gbContenedor.Location = new System.Drawing.Point(12, 12);
            this.gbContenedor.Name = "gbContenedor";
            this.gbContenedor.Size = new System.Drawing.Size(523, 389);
            this.gbContenedor.TabIndex = 0;
            this.gbContenedor.TabStop = false;
            this.gbContenedor.Text = "Bodega";
            // 
            // dgvBodega
            // 
            this.dgvBodega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBodega.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Precio,
            this.Cantidad});
            this.dgvBodega.Location = new System.Drawing.Point(29, 200);
            this.dgvBodega.Name = "dgvBodega";
            this.dgvBodega.Size = new System.Drawing.Size(464, 150);
            this.dgvBodega.TabIndex = 7;
            this.dgvBodega.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBodega_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID.Width = 75;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre Producto";
            this.Nombre.Name = "Nombre";
            this.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nombre.Width = 145;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 75;
            this.Precio.Name = "Precio";
            this.Precio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // txtCantidadProducto
            // 
            this.txtCantidadProducto.BackColor = System.Drawing.Color.Linen;
            this.txtCantidadProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidadProducto.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txtCantidadProducto.Location = new System.Drawing.Point(164, 151);
            this.txtCantidadProducto.Name = "txtCantidadProducto";
            this.txtCantidadProducto.Size = new System.Drawing.Size(182, 21);
            this.txtCantidadProducto.TabIndex = 5;
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.BackColor = System.Drawing.Color.Linen;
            this.txtPrecioProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecioProducto.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txtPrecioProducto.Location = new System.Drawing.Point(164, 95);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(182, 21);
            this.txtPrecioProducto.TabIndex = 4;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.BackColor = System.Drawing.Color.Linen;
            this.txtNombreProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreProducto.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txtNombreProducto.Location = new System.Drawing.Point(164, 46);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(182, 21);
            this.txtNombreProducto.TabIndex = 3;
            // 
            // lblPrecioProducto
            // 
            this.lblPrecioProducto.AutoSize = true;
            this.lblPrecioProducto.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblPrecioProducto.Location = new System.Drawing.Point(26, 101);
            this.lblPrecioProducto.Name = "lblPrecioProducto";
            this.lblPrecioProducto.Size = new System.Drawing.Size(50, 14);
            this.lblPrecioProducto.TabIndex = 2;
            this.lblPrecioProducto.Text = "Precio:";
            // 
            // lblCantidadProducto
            // 
            this.lblCantidadProducto.AutoSize = true;
            this.lblCantidadProducto.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblCantidadProducto.Location = new System.Drawing.Point(26, 157);
            this.lblCantidadProducto.Name = "lblCantidadProducto";
            this.lblCantidadProducto.Size = new System.Drawing.Size(69, 14);
            this.lblCantidadProducto.TabIndex = 1;
            this.lblCantidadProducto.Text = "Cantidad:";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblNombreProducto.Location = new System.Drawing.Point(26, 52);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(61, 14);
            this.lblNombreProducto.TabIndex = 0;
            this.lblNombreProducto.Text = "Nombre:";
            // 
            // gbPanelBotones
            // 
            this.gbPanelBotones.Controls.Add(this.btnLimpiar);
            this.gbPanelBotones.Controls.Add(this.btnRegresarBodega);
            this.gbPanelBotones.Controls.Add(this.btnEliminarProducto);
            this.gbPanelBotones.Controls.Add(this.btnModificarProducto);
            this.gbPanelBotones.Controls.Add(this.btnAgregarProducto);
            this.gbPanelBotones.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.gbPanelBotones.Location = new System.Drawing.Point(541, 12);
            this.gbPanelBotones.Name = "gbPanelBotones";
            this.gbPanelBotones.Size = new System.Drawing.Size(170, 389);
            this.gbPanelBotones.TabIndex = 1;
            this.gbPanelBotones.TabStop = false;
            this.gbPanelBotones.Text = "Panel";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.Image = global::InventarioEmpresa.Properties.Resources.broom;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.Location = new System.Drawing.Point(29, 247);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(115, 30);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnRegresarBodega
            // 
            this.btnRegresarBodega.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRegresarBodega.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegresarBodega.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarBodega.ForeColor = System.Drawing.Color.Black;
            this.btnRegresarBodega.Image = global::InventarioEmpresa.Properties.Resources.regresar;
            this.btnRegresarBodega.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegresarBodega.Location = new System.Drawing.Point(29, 317);
            this.btnRegresarBodega.Name = "btnRegresarBodega";
            this.btnRegresarBodega.Size = new System.Drawing.Size(115, 30);
            this.btnRegresarBodega.TabIndex = 4;
            this.btnRegresarBodega.Text = "Regresar";
            this.btnRegresarBodega.UseVisualStyleBackColor = false;
            this.btnRegresarBodega.Click += new System.EventHandler(this.btnCerrarBodega_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarProducto.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProducto.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarProducto.Image = global::InventarioEmpresa.Properties.Resources.delete;
            this.btnEliminarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarProducto.Location = new System.Drawing.Point(29, 176);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(115, 30);
            this.btnEliminarProducto.TabIndex = 2;
            this.btnEliminarProducto.Text = "Eliminar";
            this.btnEliminarProducto.UseVisualStyleBackColor = false;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarProducto.Image = global::InventarioEmpresa.Properties.Resources.create;
            this.btnAgregarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarProducto.Location = new System.Drawing.Point(29, 39);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(115, 30);
            this.btnAgregarProducto.TabIndex = 0;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnModificarProducto
            // 
            this.btnModificarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnModificarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificarProducto.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarProducto.ForeColor = System.Drawing.Color.Black;
            this.btnModificarProducto.Image = global::InventarioEmpresa.Properties.Resources.update;
            this.btnModificarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarProducto.Location = new System.Drawing.Point(29, 107);
            this.btnModificarProducto.Name = "btnModificarProducto";
            this.btnModificarProducto.Size = new System.Drawing.Size(115, 30);
            this.btnModificarProducto.TabIndex = 1;
            this.btnModificarProducto.Text = "Modificar";
            this.btnModificarProducto.UseVisualStyleBackColor = false;
            this.btnModificarProducto.Click += new System.EventHandler(this.btnModificarProducto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::InventarioEmpresa.Properties.Resources.bodega;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(368, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 129);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FrmBodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(723, 413);
            this.Controls.Add(this.gbPanelBotones);
            this.Controls.Add(this.gbContenedor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBodega";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manejo de inventario";
            this.Load += new System.EventHandler(this.FrmBodega_Load);
            this.gbContenedor.ResumeLayout(false);
            this.gbContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBodega)).EndInit();
            this.gbPanelBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbContenedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtCantidadProducto;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label lblPrecioProducto;
        private System.Windows.Forms.Label lblCantidadProducto;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.DataGridView dgvBodega;
        private System.Windows.Forms.GroupBox gbPanelBotones;
        private System.Windows.Forms.Button btnRegresarBodega;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btnModificarProducto;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
    }
}

