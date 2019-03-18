namespace MotoShopRacing
{
    partial class RegProductos
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
            this.txtNProducto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtMarca = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.numCant = new System.Windows.Forms.NumericUpDown();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtPrecio = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnRegistar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnRegresar = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.numCant)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNProducto
            // 
            this.txtNProducto.Depth = 0;
            this.txtNProducto.Hint = "Nombre del producto";
            this.txtNProducto.Location = new System.Drawing.Point(12, 84);
            this.txtNProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNProducto.Name = "txtNProducto";
            this.txtNProducto.PasswordChar = '\0';
            this.txtNProducto.SelectedText = "";
            this.txtNProducto.SelectionLength = 0;
            this.txtNProducto.SelectionStart = 0;
            this.txtNProducto.Size = new System.Drawing.Size(293, 23);
            this.txtNProducto.TabIndex = 0;
            this.txtNProducto.UseSystemPasswordChar = false;
            // 
            // txtMarca
            // 
            this.txtMarca.Depth = 0;
            this.txtMarca.Hint = "Marca";
            this.txtMarca.Location = new System.Drawing.Point(12, 135);
            this.txtMarca.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.PasswordChar = '\0';
            this.txtMarca.SelectedText = "";
            this.txtMarca.SelectionLength = 0;
            this.txtMarca.SelectionStart = 0;
            this.txtMarca.Size = new System.Drawing.Size(293, 23);
            this.txtMarca.TabIndex = 1;
            this.txtMarca.UseSystemPasswordChar = false;
            // 
            // numCant
            // 
            this.numCant.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.numCant.Location = new System.Drawing.Point(133, 186);
            this.numCant.Name = "numCant";
            this.numCant.Size = new System.Drawing.Size(172, 20);
            this.numCant.TabIndex = 2;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(8, 187);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(72, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Cantidad:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Depth = 0;
            this.txtPrecio.Hint = "Precio";
            this.txtPrecio.Location = new System.Drawing.Point(12, 238);
            this.txtPrecio.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.PasswordChar = '\0';
            this.txtPrecio.SelectedText = "";
            this.txtPrecio.SelectionLength = 0;
            this.txtPrecio.SelectionStart = 0;
            this.txtPrecio.Size = new System.Drawing.Size(293, 23);
            this.txtPrecio.TabIndex = 4;
            this.txtPrecio.UseSystemPasswordChar = false;
            // 
            // btnRegistar
            // 
            this.btnRegistar.Depth = 0;
            this.btnRegistar.Location = new System.Drawing.Point(12, 277);
            this.btnRegistar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegistar.Name = "btnRegistar";
            this.btnRegistar.Primary = true;
            this.btnRegistar.Size = new System.Drawing.Size(293, 23);
            this.btnRegistar.TabIndex = 5;
            this.btnRegistar.Text = "Registrar Producto";
            this.btnRegistar.UseVisualStyleBackColor = true;
            this.btnRegistar.Click += new System.EventHandler(this.btnRegistar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Depth = 0;
            this.btnRegresar.Location = new System.Drawing.Point(13, 322);
            this.btnRegresar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Primary = true;
            this.btnRegresar.Size = new System.Drawing.Size(293, 23);
            this.btnRegresar.TabIndex = 6;
            this.btnRegresar.Text = "Regresar al menu";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // RegProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 366);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnRegistar);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.numCant);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtNProducto);
            this.Name = "RegProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Productos";
            ((System.ComponentModel.ISupportInitialize)(this.numCant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtNProducto;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMarca;
        private System.Windows.Forms.NumericUpDown numCant;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPrecio;
        private MaterialSkin.Controls.MaterialRaisedButton btnRegistar;
        private MaterialSkin.Controls.MaterialRaisedButton btnRegresar;
    }
}