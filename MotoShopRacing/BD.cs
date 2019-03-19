using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MotoShopRacing
{
    class BD
    {
        //private SqlConnection conexion = new SqlConnection("workstation id=MotoShopRacing.mssql.somee.com;packet size=4096;user id=Bucaro;pwd=gamesalada1;data source=MotoShopRacing.mssql.somee.com;persist security info=False;initial catalog=MotoShopRacing");
        private SqlConnection conexion = new SqlConnection("Data Source = BÚCARO; database = MotoShopRacing; Integrated Security = true; user = sa; password = root");

        private DataSet ds;        

        public void Abrir()
        {
            conexion.Open();
        }

        public void Cerrar()
        {
            conexion.Close();
        }

        public Boolean iniciarSesion(string user, string pass)
        {            
            bool tipoUsuario = false;
            conexion.Open();
            SqlParameter parUser = new SqlParameter("@user", user);
            SqlParameter parPass = new SqlParameter("@pass", pass);
            SqlCommand Comando = new SqlCommand("select userID, pass, userRole from users where userID = @user and pass collate latin1_general_cs_as = @pass", conexion);
            Comando.Parameters.Add(parUser);
            Comando.Parameters.Add(parPass);
            SqlDataReader lector = Comando.ExecuteReader();
            while (lector.Read())
            {
                tipoUsuario = lector.GetBoolean(2);
            }
            lector.Close();
            conexion.Close();
            if (tipoUsuario == false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool Insertar(string PNombre, string Marca, int Cantidad, double Precio)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("INSERT INTO products VALUES ('{0}', '{1}', {2}, {3})", PNombre, Marca, Cantidad, Precio), conexion);
            int FilasModificadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (FilasModificadas > 0) return true;
            else return false;
        }

        public DataTable Buscar(string NProduct)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("select productID As 'ID Producto', productName As 'Nombre Producto', brand As 'Marca', quantity As 'Cantidad', price As 'Precio' from products where productName like '%{0}%'", NProduct), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "Tabla");
            conexion.Close();
            return ds.Tables["Tabla"];
        }

        public DataTable MostrarProductos()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("select productID As 'ID Producto', productName As 'Nombre Producto', brand As 'Marca', quantity As 'Cantidad', price As 'Precio' from products", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "Tabla");
            conexion.Close();
            return ds.Tables["Tabla"];
        }

        public bool Actualizar(int ID, string nombre, string marca, int cantidad, decimal precio)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("Update products set productName = '{1}', brand = '{2}', quantity = {3}, price = {4} where productID = '{0}'", ID, nombre, marca, cantidad, precio),  conexion);
            int FilasModificadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (FilasModificadas > 0) return true;
            else return false;
        }

        public bool Eliminar(string ID)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("Delete from products where productID ='{0}'", ID), conexion);
            int FilasModificadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (FilasModificadas > 0) return true;
            else return false;
        }

        public DataTable BuscarProductos(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("select productID As 'ID Producto', productName As 'Nombre Producto', brand As 'Marca', quantity As 'Cantidad', price As 'Precio' from products where productName like '%" + nombre + "%'", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "Tablas");
            conexion.Close();
            return ds.Tables["Tablas"];
        }
    }
}
