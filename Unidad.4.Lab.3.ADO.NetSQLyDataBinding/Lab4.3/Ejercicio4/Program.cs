using System;
using System.Data;
using System.Data.SqlClient;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable dtEmpresas = new DataTable();

            dtEmpresas.Columns.Add("CustomerID", typeof(string));
            dtEmpresas.Columns.Add("CompanyName", typeof(string));

            SqlConnection conn = new SqlConnection(
                "Data Source=localhost; Initial Catalog=Northwind; Integrated Security=true");

            /*//Ejercicio 4
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select CustomerID, CompanyName from Customers";
            cmd.Connection = conn;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd.CommandText, conn);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            dtEmpresas.Load(reader);

            conn.Close();//*/

            // Ejercicio 5
            SqlDataAdapter adapter = new SqlDataAdapter(
                "select CustomerID, CompanyName from Customers", conn);
            conn.Open();
            adapter.Fill(dtEmpresas);
            conn.Close();


            Console.WriteLine("Listado de empresas");
            foreach (DataRow rowE in dtEmpresas.Rows)
            {
                string idEmpresa = rowE["CustomerID"].ToString();
                string nombreEmpresa = rowE["CompanyName"].ToString();
                Console.WriteLine($"{idEmpresa} - {nombreEmpresa}");
            }

            Console.Write("Ingrese CustomerID que desea modificar: ");
            string custID = Console.ReadLine();

            DataRow[] rowEmpresas = dtEmpresas.Select($"CustomerID = '{custID}'");
            if (rowEmpresas.Length != 1)
            {
                Console.WriteLine("CustomerID no encontrado");
                return;
            }

            // Ejercicio 6
            DataRow rowEmpresa = rowEmpresas[0];
            string nombre = rowEmpresa["CompanyName"].ToString();
            Console.WriteLine($"Nombre de la empresa: {nombre}");
            Console.Write("Ingrese un nuevo nombre: ");
            nombre = Console.ReadLine();

            rowEmpresa.BeginEdit();
            rowEmpresa["CompanyName"] = nombre;
            rowEmpresa.EndEdit();

            SqlCommand cmdUpdate = new SqlCommand(
                "update Customers set CompanyName=@CompanyName where CustomerID=@CustomerID", conn);

            cmdUpdate.Parameters.Add("@CompanyName", SqlDbType.NVarChar, 50, "CompanyName");
            cmdUpdate.Parameters.Add("@CustomerID", SqlDbType.NVarChar, 5, "CustomerID");

            adapter.UpdateCommand = cmdUpdate;
            adapter.Update(dtEmpresas);
        }
    }
}
