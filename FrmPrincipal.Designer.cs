﻿
namespace InventarioEmpresa
{
    partial class FrmPrincipal
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
            this.gbContenedor = new System.Windows.Forms.GroupBox();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.lblCantidadProducto = new System.Windows.Forms.Label();
            this.lblPrecioProducto = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.txtCantidadProducto = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbPanelBotones = new System.Windows.Forms.GroupBox();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnModificarProducto = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnCerrarBodega = new System.Windows.Forms.Button();
            this.gbContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbPanelBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbContenedor
            // 
            this.gbContenedor.Controls.Add(this.dataGridView1);
            this.gbContenedor.Controls.Add(this.pictureBox1);
            this.gbContenedor.Controls.Add(this.txtCantidadProducto);
            this.gbContenedor.Controls.Add(this.txtPrecioProducto);
            this.gbContenedor.Controls.Add(this.txtNombreProducto);
            this.gbContenedor.Controls.Add(this.lblPrecioProducto);
            this.gbContenedor.Controls.Add(this.lblCantidadProducto);
            this.gbContenedor.Controls.Add(this.lblNombreProducto);
            this.gbContenedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContenedor.Location = new System.Drawing.Point(12, 12);
            this.gbContenedor.Name = "gbContenedor";
            this.gbContenedor.Size = new System.Drawing.Size(523, 389);
            this.gbContenedor.TabIndex = 0;
            this.gbContenedor.TabStop = false;
            this.gbContenedor.Text = "Bodega";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.Location = new System.Drawing.Point(26, 52);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(65, 16);
            this.lblNombreProducto.TabIndex = 0;
            this.lblNombreProducto.Text = "Nombre:";
            // 
            // lblCantidadProducto
            // 
            this.lblCantidadProducto.AutoSize = true;
            this.lblCantidadProducto.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadProducto.Location = new System.Drawing.Point(26, 157);
            this.lblCantidadProducto.Name = "lblCantidadProducto";
            this.lblCantidadProducto.Size = new System.Drawing.Size(70, 16);
            this.lblCantidadProducto.TabIndex = 1;
            this.lblCantidadProducto.Text = "Cantidad:";
            // 
            // lblPrecioProducto
            // 
            this.lblPrecioProducto.AutoSize = true;
            this.lblPrecioProducto.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioProducto.Location = new System.Drawing.Point(26, 101);
            this.lblPrecioProducto.Name = "lblPrecioProducto";
            this.lblPrecioProducto.Size = new System.Drawing.Size(55, 16);
            this.lblPrecioProducto.TabIndex = 2;
            this.lblPrecioProducto.Text = "Precio:";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.BackColor = System.Drawing.Color.Linen;
            this.txtNombreProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreProducto.Location = new System.Drawing.Point(212, 46);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(121, 24);
            this.txtNombreProducto.TabIndex = 3;
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.BackColor = System.Drawing.Color.Linen;
            this.txtPrecioProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecioProducto.Location = new System.Drawing.Point(212, 95);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(121, 24);
            this.txtPrecioProducto.TabIndex = 4;
            // 
            // txtCantidadProducto
            // 
            this.txtCantidadProducto.BackColor = System.Drawing.Color.Linen;
            this.txtCantidadProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidadProducto.Location = new System.Drawing.Point(212, 151);
            this.txtCantidadProducto.Name = "txtCantidadProducto";
            this.txtCantidadProducto.Size = new System.Drawing.Size(121, 24);
            this.txtCantidadProducto.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(368, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 76);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 200);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(464, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // gbPanelBotones
            // 
            this.gbPanelBotones.Controls.Add(this.btnCerrarBodega);
            this.gbPanelBotones.Controls.Add(this.btnEliminarProducto);
            this.gbPanelBotones.Controls.Add(this.btnModificarProducto);
            this.gbPanelBotones.Controls.Add(this.btnAgregarProducto);
            this.gbPanelBotones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPanelBotones.Location = new System.Drawing.Point(541, 12);
            this.gbPanelBotones.Name = "gbPanelBotones";
            this.gbPanelBotones.Size = new System.Drawing.Size(170, 389);
            this.gbPanelBotones.TabIndex = 1;
            this.gbPanelBotones.TabStop = false;
            this.gbPanelBotones.Text = "Panel";
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(37, 44);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(100, 30);
            this.btnAgregarProducto.TabIndex = 0;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            // 
            // btnModificarProducto
            // 
            this.btnModificarProducto.Location = new System.Drawing.Point(37, 133);
            this.btnModificarProducto.Name = "btnModificarProducto";
            this.btnModificarProducto.Size = new System.Drawing.Size(100, 30);
            this.btnModificarProducto.TabIndex = 1;
            this.btnModificarProducto.Text = "Modificar";
            this.btnModificarProducto.UseVisualStyleBackColor = true;
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Location = new System.Drawing.Point(37, 221);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(100, 30);
            this.btnEliminarProducto.TabIndex = 2;
            this.btnEliminarProducto.Text = "Eliminar";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            // 
            // btnCerrarBodega
            // 
            this.btnCerrarBodega.Location = new System.Drawing.Point(37, 320);
            this.btnCerrarBodega.Name = "btnCerrarBodega";
            this.btnCerrarBodega.Size = new System.Drawing.Size(100, 30);
            this.btnCerrarBodega.TabIndex = 3;
            this.btnCerrarBodega.Text = "Cerrar";
            this.btnCerrarBodega.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 413);
            this.Controls.Add(this.gbPanelBotones);
            this.Controls.Add(this.gbContenedor);
            this.Name = "FrmPrincipal";
            this.Text = "Manejo de inventario";
            this.gbContenedor.ResumeLayout(false);
            this.gbContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbPanelBotones.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbPanelBotones;
        private System.Windows.Forms.Button btnCerrarBodega;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btnModificarProducto;
        private System.Windows.Forms.Button btnAgregarProducto;
    }
}
