namespace MotoShopRacing
{
    partial class empleados
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
            this.txtname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtsname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtapellidos = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cbrol = new System.Windows.Forms.ComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtpass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dgvempleados = new System.Windows.Forms.DataGridView();
            this.btneliminat = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtbuscarempleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnmenu = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvempleados)).BeginInit();
            this.SuspendLayout();
            // 
            // txtname
            // 
            this.txtname.Depth = 0;
            this.txtname.Hint = "Primer Nombre";
            this.txtname.Location = new System.Drawing.Point(44, 115);
            this.txtname.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtname.Name = "txtname";
            this.txtname.PasswordChar = '\0';
            this.txtname.SelectedText = "";
            this.txtname.SelectionLength = 0;
            this.txtname.SelectionStart = 0;
            this.txtname.Size = new System.Drawing.Size(257, 28);
            this.txtname.TabIndex = 0;
            this.txtname.UseSystemPasswordChar = false;
            this.txtname.Click += new System.EventHandler(this.materialSingleLineTextField1_Click);
            // 
            // txtsname
            // 
            this.txtsname.Depth = 0;
            this.txtsname.Hint = "Segundo Nombre";
            this.txtsname.Location = new System.Drawing.Point(41, 164);
            this.txtsname.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtsname.Name = "txtsname";
            this.txtsname.PasswordChar = '\0';
            this.txtsname.SelectedText = "";
            this.txtsname.SelectionLength = 0;
            this.txtsname.SelectionStart = 0;
            this.txtsname.Size = new System.Drawing.Size(257, 28);
            this.txtsname.TabIndex = 1;
            this.txtsname.UseSystemPasswordChar = false;
            // 
            // txtapellidos
            // 
            this.txtapellidos.Depth = 0;
            this.txtapellidos.Hint = "Apellidos";
            this.txtapellidos.Location = new System.Drawing.Point(41, 211);
            this.txtapellidos.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtapellidos.Name = "txtapellidos";
            this.txtapellidos.PasswordChar = '\0';
            this.txtapellidos.SelectedText = "";
            this.txtapellidos.SelectionLength = 0;
            this.txtapellidos.SelectionStart = 0;
            this.txtapellidos.Size = new System.Drawing.Size(257, 28);
            this.txtapellidos.TabIndex = 2;
            this.txtapellidos.UseSystemPasswordChar = false;
            // 
            // cbrol
            // 
            this.cbrol.FormattingEnabled = true;
            this.cbrol.Items.AddRange(new object[] {
            "Administrador",
            "Vendedor"});
            this.cbrol.Location = new System.Drawing.Point(130, 262);
            this.cbrol.Name = "cbrol";
            this.cbrol.Size = new System.Drawing.Size(168, 24);
            this.cbrol.TabIndex = 3;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(40, 262);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(38, 24);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Rol";
            // 
            // txtpass
            // 
            this.txtpass.Depth = 0;
            this.txtpass.Hint = "Constraseña";
            this.txtpass.Location = new System.Drawing.Point(41, 315);
            this.txtpass.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '\0';
            this.txtpass.SelectedText = "";
            this.txtpass.SelectionLength = 0;
            this.txtpass.SelectionStart = 0;
            this.txtpass.Size = new System.Drawing.Size(257, 28);
            this.txtpass.TabIndex = 5;
            this.txtpass.UseSystemPasswordChar = false;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(93, 361);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(135, 41);
            this.materialRaisedButton1.TabIndex = 6;
            this.materialRaisedButton1.Text = "Agregar";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // dgvempleados
            // 
            this.dgvempleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvempleados.Location = new System.Drawing.Point(379, 141);
            this.dgvempleados.Name = "dgvempleados";
            this.dgvempleados.RowTemplate.Height = 24;
            this.dgvempleados.Size = new System.Drawing.Size(580, 204);
            this.dgvempleados.TabIndex = 7;
            this.dgvempleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvempleados_CellClick);
            // 
            // btneliminat
            // 
            this.btneliminat.Depth = 0;
            this.btneliminat.Location = new System.Drawing.Point(379, 371);
            this.btneliminat.MouseState = MaterialSkin.MouseState.HOVER;
            this.btneliminat.Name = "btneliminat";
            this.btneliminat.Primary = true;
            this.btneliminat.Size = new System.Drawing.Size(135, 41);
            this.btneliminat.TabIndex = 8;
            this.btneliminat.Text = "Eliminar";
            this.btneliminat.UseVisualStyleBackColor = true;
            this.btneliminat.Click += new System.EventHandler(this.btneliminat_Click);
            // 
            // txtbuscarempleado
            // 
            this.txtbuscarempleado.Depth = 0;
            this.txtbuscarempleado.Hint = "Buscar Empleado";
            this.txtbuscarempleado.Location = new System.Drawing.Point(379, 107);
            this.txtbuscarempleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtbuscarempleado.Name = "txtbuscarempleado";
            this.txtbuscarempleado.PasswordChar = '\0';
            this.txtbuscarempleado.SelectedText = "";
            this.txtbuscarempleado.SelectionLength = 0;
            this.txtbuscarempleado.SelectionStart = 0;
            this.txtbuscarempleado.Size = new System.Drawing.Size(257, 28);
            this.txtbuscarempleado.TabIndex = 9;
            this.txtbuscarempleado.UseSystemPasswordChar = false;
            this.txtbuscarempleado.Click += new System.EventHandler(this.txtbuscarempleado_Click);
            this.txtbuscarempleado.TextChanged += new System.EventHandler(this.txtbuscarempleado_TextChanged);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(93, 424);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(135, 41);
            this.materialRaisedButton2.TabIndex = 11;
            this.materialRaisedButton2.Text = "Actualizar";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // btnmenu
            // 
            this.btnmenu.Depth = 0;
            this.btnmenu.Location = new System.Drawing.Point(851, 457);
            this.btnmenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Primary = true;
            this.btnmenu.Size = new System.Drawing.Size(135, 41);
            this.btnmenu.TabIndex = 12;
            this.btnmenu.Text = "Menu";
            this.btnmenu.UseVisualStyleBackColor = true;
            // 
            // empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 510);
            this.Controls.Add(this.btnmenu);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.txtbuscarempleado);
            this.Controls.Add(this.btneliminat);
            this.Controls.Add(this.dgvempleados);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.cbrol);
            this.Controls.Add(this.txtapellidos);
            this.Controls.Add(this.txtsname);
            this.Controls.Add(this.txtname);
            this.Name = "empleados";
            this.Text = "empleados";
            this.Load += new System.EventHandler(this.empleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvempleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtname;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtsname;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtapellidos;
        private System.Windows.Forms.ComboBox cbrol;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtpass;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private System.Windows.Forms.DataGridView dgvempleados;
        private MaterialSkin.Controls.MaterialRaisedButton btneliminat;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtbuscarempleado;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialRaisedButton btnmenu;

    }
}