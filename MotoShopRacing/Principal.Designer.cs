namespace MotoShopRacing
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.dgvPrincipal = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnRegVenta = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnRegistar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDeudas = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnempleados = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPrincipal
            // 
            this.dgvPrincipal.AllowUserToAddRows = false;
            this.dgvPrincipal.AllowUserToDeleteRows = false;
            this.dgvPrincipal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrincipal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dgvPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrincipal.Location = new System.Drawing.Point(17, 294);
            this.dgvPrincipal.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPrincipal.Name = "dgvPrincipal";
            this.dgvPrincipal.ReadOnly = true;
            this.dgvPrincipal.Size = new System.Drawing.Size(943, 320);
            this.dgvPrincipal.TabIndex = 0;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Depth = 0;
            this.txtBuscar.Hint = "Buscar producto";
            this.txtBuscar.Location = new System.Drawing.Point(19, 258);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.SelectionLength = 0;
            this.txtBuscar.SelectionStart = 0;
            this.txtBuscar.Size = new System.Drawing.Size(941, 28);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.UseSystemPasswordChar = false;
            this.txtBuscar.Click += new System.EventHandler(this.txtBuscar_Click);
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // btnRegVenta
            // 
            this.btnRegVenta.Depth = 0;
            this.btnRegVenta.Location = new System.Drawing.Point(656, 164);
            this.btnRegVenta.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegVenta.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegVenta.Name = "btnRegVenta";
            this.btnRegVenta.Primary = true;
            this.btnRegVenta.Size = new System.Drawing.Size(213, 47);
            this.btnRegVenta.TabIndex = 2;
            this.btnRegVenta.Text = "Registrar venta";
            this.btnRegVenta.UseVisualStyleBackColor = true;
            this.btnRegVenta.Click += new System.EventHandler(this.btnRegVenta_Click);
            // 
            // btnRegistar
            // 
            this.btnRegistar.Depth = 0;
            this.btnRegistar.Location = new System.Drawing.Point(284, 188);
            this.btnRegistar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegistar.Name = "btnRegistar";
            this.btnRegistar.Primary = true;
            this.btnRegistar.Size = new System.Drawing.Size(213, 47);
            this.btnRegistar.TabIndex = 3;
            this.btnRegistar.Text = "Registrar producto";
            this.btnRegistar.UseVisualStyleBackColor = true;
            this.btnRegistar.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Depth = 0;
            this.btnEliminar.Location = new System.Drawing.Point(19, 188);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Primary = true;
            this.btnEliminar.Size = new System.Drawing.Size(213, 47);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Mantenimeinto productos";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 80);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(516, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnDeudas
            // 
            this.btnDeudas.Depth = 0;
            this.btnDeudas.Location = new System.Drawing.Point(656, 100);
            this.btnDeudas.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeudas.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeudas.Name = "btnDeudas";
            this.btnDeudas.Primary = true;
            this.btnDeudas.Size = new System.Drawing.Size(213, 47);
            this.btnDeudas.TabIndex = 6;
            this.btnDeudas.Text = "Fiado ";
            this.btnDeudas.UseVisualStyleBackColor = true;
            this.btnDeudas.Click += new System.EventHandler(this.btnDeudas_Click);
            // 
            // btnempleados
            // 
            this.btnempleados.Depth = 0;
            this.btnempleados.Location = new System.Drawing.Point(656, 219);
            this.btnempleados.Margin = new System.Windows.Forms.Padding(4);
            this.btnempleados.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnempleados.Name = "btnempleados";
            this.btnempleados.Primary = true;
            this.btnempleados.Size = new System.Drawing.Size(213, 47);
            this.btnempleados.TabIndex = 7;
            this.btnempleados.Text = "Empleados";
            this.btnempleados.UseVisualStyleBackColor = true;
            this.btnempleados.Click += new System.EventHandler(this.btnempleados_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 629);
            this.Controls.Add(this.btnempleados);
            this.Controls.Add(this.btnDeudas);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnRegistar);
            this.Controls.Add(this.btnRegVenta);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dgvPrincipal);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Principal_FormClosed);
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrincipal;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscar;
        private MaterialSkin.Controls.MaterialRaisedButton btnRegVenta;
        private MaterialSkin.Controls.MaterialRaisedButton btnRegistar;
        private MaterialSkin.Controls.MaterialRaisedButton btnEliminar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialRaisedButton btnDeudas;
        private MaterialSkin.Controls.MaterialRaisedButton btnempleados;
    }
}