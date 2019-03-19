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
    public partial class frmLogin : MaterialForm
    {
        BD Sql = new BD();

        public frmLogin()
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

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtUser.Text) && !String.IsNullOrEmpty(txtPass.Text))
            {
                try
                {
                    Boolean res = Sql.iniciarSesion(txtUser.Text, txtPass.Text);
                    if (res)
                    {
                        Principal p = new Principal();
                        this.Hide();
                        p.Show();
                        Reset();
                    }
                    else
                    {
                        MessageBox.Show("Usuario no registrado...");
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }
            }
            else
            {
                MessageBox.Show("Complete los datos");
                txtUser.Focus();
            }
        }

        public void Reset()
        {
            this.Controls.OfType<MaterialSingleLineTextField>().ToList().ForEach(o => o.Text = "");
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cbRecordarme_CheckedChanged(object sender, EventArgs e)
        {
            Principal frmPrincipal = new Principal();
            this.Hide();
            frmPrincipal.Show();
        }
    }
}
