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
    public partial class EliminarProd : MaterialForm
    {
        BD Sql = new BD();
        public string ProdID = "";

        public EliminarProd()
        {
            InitializeComponent();
            // Create a material theme manager and add the form to manage(this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );
            dgvMantenimiento.DataSource = Sql.MostrarProductos();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Principal frmPrin = new Principal();
            this.Close();
            frmPrin.Show();
        }

        private void dgvMantenimiento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvMantenimiento.Rows[e.RowIndex];
            ProdID = Convert.ToString(fila.Cells[0].Value);
            txtNombre.Text = Convert.ToString(fila.Cells[1].Value);
            txtMarca.Text = Convert.ToString(fila.Cells[2].Value);
            numCant.Value = Convert.ToDecimal(fila.Cells[3].Value);
            txtPrecio.Text = Convert.ToString(fila.Cells[4].Value);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvMantenimiento.DataSource = Sql.Buscar(txtBuscar.Text);
        }

        private void EliminarProd_Load(object sender, EventArgs e)
        {
            dgvMantenimiento.BorderStyle = BorderStyle.None;
            dgvMantenimiento.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvMantenimiento.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMantenimiento.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvMantenimiento.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;

            dgvMantenimiento.EnableHeadersVisualStyles = false;
            dgvMantenimiento.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvMantenimiento.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvMantenimiento.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dgvMantenimiento.DataSource = Sql.MostrarProductos();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Sql.Actualizar(int.Parse(ProdID), txtNombre.Text, txtMarca.Text, (int)numCant.Value, int.Parse(txtPrecio.Text));
            MessageBox.Show("Registro actualizado con exito!");
            dgvMantenimiento.DataSource = Sql.MostrarProductos();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Sql.Eliminar(ProdID);
            MessageBox.Show("Registro eliminado con exito!");
            dgvMantenimiento.DataSource = Sql.MostrarProductos();
        }
    }
}
