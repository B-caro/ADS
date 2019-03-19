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
    public partial class RegProductos : MaterialForm
    {
        BD Sql = new BD();

        public RegProductos()
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
        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            try
            {
                Sql.Insertar(txtNProducto.Text, txtMarca.Text, (int)numCant.Value, double.Parse(txtPrecio.Text));
                MessageBox.Show("Registro completado con exito!");
                Reset();
            }
            catch
            {
                MessageBox.Show("El registro fallo, vuelve a intentarlo :c");
            }
        }

        public void Reset()
        {
            this.Controls.OfType<MaterialSingleLineTextField>().ToList().ForEach(o => o.Text = "");
            numCant.Value = 0;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Principal frmPrincipal = new Principal();
            this.Close();
            frmPrincipal.Show();
        }

        private void txtPrecio_Click(object sender, EventArgs e)
        {

        }
    }
}
