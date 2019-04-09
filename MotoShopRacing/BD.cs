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
//<<<<<<< HEAD
        //private SqlConnection conexion = new SqlConnection("workstation id=MotoShopRacing.mssql.somee.com;packet size=4096;user id=Bucaro;pwd=gamesalada1;data source=MotoShopRacing.mssql.somee.com;persist security info=False;initial catalog=MotoShopRacing");
        private SqlConnection conexion = new SqlConnection("server=DESKTOP-PUJ90H7\\SQLEXPRESS; database=MotoShopRacing ; integrated security = true");
//=======

        //SqlConnection("server=DIEGO-PC\\SQLEXPRESS ; database=base1 ; integrated security = true");
        //private SqlConnection conexion = new SqlConnection("workstation id=MotoShopRacing.mssql.somee.com;packet size=4096;" +
        //    "user id=Bucaro;pwd=gamesalada1;data source=MotoShopRacing.mssql.somee.com;persist security info=False;initial catalog=MotoShopRacing");
        //private SqlConnection conexion = new SqlConnection("Data Source = BÚCARO; database = MotoShopRacing; Integrated Security = true; user = sa; password = root");
//>>>>>>> MotoShopRacing

        private DataSet ds;
        private DataSet ds1;

        public void Abrir() { conexion.Open(); }
        public void Cerrar() { conexion.Close(); }
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
            while (lector.Read()) tipoUsuario = lector.GetBoolean(2);
            lector.Close();
            conexion.Close();
            if (tipoUsuario == false) return false;
            else return true;
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



        //---------------------------------empleados-------------------------------//
        public bool Insertar_Empleado(string pnombre, string snombre, string apellidos, int rol, string pass) 
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("INSERT INTO users VALUES ('{0}','{1}','{2}',{3},'{4}')",pnombre,snombre,apellidos,rol,pass),conexion);
            int FilasModificadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (FilasModificadas > 0) return true;
            else return false;

        }

        public DataTable MostrarEmpleados() 
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("select userID As 'ID Empleado', userFirstName As 'Nombre Empleado', userSecondName As 'Segundo Nombre', userLastNames As 'Apellidos', userRole As 'Rol', pass As 'Constraseña' from users", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds1 = new DataSet();
            ad.Fill(ds1, "Tabla");
            conexion.Close();
            return ds1.Tables["Tabla"];
        
        }


        public DataTable buscarEmpleados(string nombre) 
        {

            conexion.Open();
            SqlCommand cmd = new SqlCommand("select userID As 'ID empleado', userFirstName As 'Primer Nombre', userSecondName As 'Segundo Nombre', userLastName As 'Apellidos', userRole As 'Rola' from users where userFirstName like '%" + nombre + "%'", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds1 = new DataSet();
            ad.Fill(ds1, "Tablas");
            conexion.Close();
            return ds1.Tables["Tablas"];
        
        
        }


        public bool Eliminar_empleados(string ID)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("Delete from users where userID ='{0}'", ID), conexion);
            int FilasModificadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (FilasModificadas > 0) return true;
            else return false;
        }


        public bool Actualizar_empleados(int ID, string nombre, string segundo, string apellido, int rol, string pass)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("Update users set userFirstName= '{1}', userSecondName = '{2}', userLastNames = '{3}', userRole = {4}, pass = '{5}' where userID = '{0}'", ID, nombre, segundo, apellido, rol, pass), conexion);
            int FilasModificadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (FilasModificadas > 0) return true;
            else return false;
        }




        //-----------------------TERMINA MANTENIMIENTO DE EMPLEADOS----------------------------------------//



        //public DataTable Buscar(string NProduct)
        //{
        //    conexion.Open();
        //    SqlCommand cmd = new SqlCommand(string.Format("select productID As 'ID Producto', productName As 'Nombre Producto', brand As 'Marca', quantity As 'Cantidad', price As 'Precio' from products where productName like '%{0}%'", NProduct), conexion);
        //    SqlDataAdapter ad = new SqlDataAdapter(cmd);
        //    ds = new DataSet();
        //    ad.Fill(ds, "Tabla");
        //    conexion.Close();
        //    return ds.Tables["Tabla"];
        //}

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
