using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace MotoShopRacing
{
    public partial class Principal : MaterialForm
    {
        BD Sql = new BD();

        public Principal()
        {
            InitializeComponent();
            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            dgvPrincipal.BorderStyle = BorderStyle.None;
            dgvPrincipal.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvPrincipal.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPrincipal.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvPrincipal.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;

            dgvPrincipal.EnableHeadersVisualStyles = false;
            dgvPrincipal.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvPrincipal.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvPrincipal.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dgvPrincipal.DataSource = Sql.MostrarProductos();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            RegProductos frmRegProd = new RegProductos();
            this.Hide();
            frmRegProd.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarProd frmElinar = new EliminarProd();
            this.Hide();
            frmElinar.Show();
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin frmLog = new frmLogin();
            this.Hide();
            frmLog.Show();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvPrincipal.DataSource = Sql.Buscar(txtBuscar.Text);
        }
    }
}
