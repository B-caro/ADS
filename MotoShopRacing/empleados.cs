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
    public partial class empleados : MaterialForm
    {
        BD Sql = new BD();

        public string userID = "";

        int rol = 0;

       public bool role;

        public empleados()
        {
            InitializeComponent();
               MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE);
        }

        private void empleados_Load(object sender, EventArgs e)
        {
            dgvempleados.BorderStyle = BorderStyle.None;
            dgvempleados.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvempleados.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvempleados.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvempleados.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;

            dgvempleados.EnableHeadersVisualStyles = false;
            dgvempleados.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvempleados.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvempleados.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dgvempleados.DataSource = Sql.MostrarEmpleados();
        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }

            public void Reset()
        {
            this.Controls.OfType<MaterialSingleLineTextField>().ToList().ForEach(o => o.Text = "");
            
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {

            
                if (cbrol.Text =="Administrador") 
                {
                    rol = 1;

                     try
                        {
                            Sql.Insertar_Empleado(txtname.Text,txtsname.Text,txtapellidos.Text,1,txtpass.Text);
                            MessageBox.Show("Registro completado con exito!");
                            Reset();
                            dgvempleados.DataSource = Sql.MostrarEmpleados();
                           
                        }
                        catch
                        {
                            MessageBox.Show("El registro fallo, vuelve a intentarlo :c");
                        }
                }

                        else if (cbrol.Text == "Vendedor") 
                            {
                                rol = 2;
                               

                               try
                               {
                                   Sql.Insertar_Empleado(txtname.Text, txtsname.Text, txtapellidos.Text, rol, txtpass.Text);
                                   MessageBox.Show("Registro completado con exito!");
                                   Reset();
                               }
                               catch
                               {
                                   MessageBox.Show("El registro fallo, vuelve a intentarlo :c");
                               }


                            }


                }

        private void txtbuscarempleado_Click(object sender, EventArgs e)
        {
           
        }

        private void txtbuscarempleado_TextChanged(object sender, EventArgs e)
        {
            string name = txtbuscarempleado.Text;
            if (txtbuscarempleado.Text != "") dgvempleados.DataSource = Sql.buscarEmpleados(name);
            else dgvempleados.DataSource = Sql.MostrarEmpleados();
        }

        private void btneliminat_Click(object sender, EventArgs e)
        {

            

            if (role== true)
            {
                MessageBox.Show("El administrador no se puede eliminar");

            }

            else
            {

                
                MessageBox.Show("Registro eliminado con exito!");
                dgvempleados.DataSource = Sql.MostrarEmpleados();

                txtname.Clear();
                txtsname.Clear();
                txtapellidos.Clear();
                cbrol.Text = "";
                txtpass.Clear();
            }
        }

        private void dgvempleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
    
            DataGridViewRow fila = dgvempleados.Rows[e.RowIndex];
            userID = Convert.ToString(fila.Cells[0].Value);
            txtname.Text = Convert.ToString( fila.Cells[1].Value);
            txtsname.Text = Convert.ToString(fila.Cells[2].Value);
            txtapellidos.Text = Convert.ToString(fila.Cells[3].Value);
            role = Convert.ToBoolean(fila.Cells[4].Value);

            if (role == true)
            {
                cbrol.Text = "Administrador";
            }

            else 
            {
                cbrol.Text = "Vendedor";
            }

            txtpass.Text = Convert.ToString(fila.Cells[5].Value);

        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {


            if (cbrol.Text == "Administrador")
            {
                rol = 1;
                Sql.Actualizar_empleados(int.Parse(userID), txtname.Text, txtsname.Text, txtapellidos.Text, rol, txtpass.Text);
                MessageBox.Show("Registro actualizado con exito!");
                dgvempleados.DataSource = Sql.MostrarEmpleados();
               

            }

            else if (cbrol.Text == "Vendedor") 
            {
                rol = 2;
                Sql.Actualizar_empleados(int.Parse(userID), txtname.Text, txtsname.Text, txtapellidos.Text, rol, txtpass.Text);
                MessageBox.Show("Registro actualizado con exito!");
                dgvempleados.DataSource = Sql.MostrarEmpleados();
            }

        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            Principal frmprincial = new Principal();
            frmprincial.Show();
            this.Close();
        }




                



            }


          
        }
    

