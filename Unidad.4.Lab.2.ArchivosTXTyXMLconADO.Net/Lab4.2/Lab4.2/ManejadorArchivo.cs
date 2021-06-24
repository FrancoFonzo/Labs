using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Lab4._2
{
    class ManejadorArchivo
    {

        protected DataTable misContactos;

        public ManejadorArchivo()
        {
            this.misContactos = this.getTabla();
        }

        public virtual DataTable getTabla()
        {
            return new DataTable();
        }

        public virtual void aplicaCambios() { }

        public void listar()
        {
            Console.Clear();
            foreach (DataRow fila in misContactos.Rows)
            {
                if (fila.RowState != DataRowState.Deleted)
                {
                    foreach (DataColumn columna in misContactos.Columns)
                    {
                        Console.WriteLine($"{columna.ColumnName}: {fila[columna]}");
                    }
                    Console.WriteLine();
                }
            }
        }

        public void nuevaFila()
        {
            DataRow fila = this.misContactos.NewRow();
            foreach (DataColumn col in misContactos.Columns)
            {
                Console.Write($"Ingrese {col.ColumnName}: ");
                fila[col] = Console.ReadLine();
            }
            this.misContactos.Rows.Add(fila);
        }
        
        public void editarFila()
        {
            Console.Write("Ingrese el numero de fila a editar: ");
            int nroFila = int.Parse(Console.ReadLine());

            DataRow fila = misContactos.Rows[nroFila-1];

            for (int nroCol = 1; nroCol < misContactos.Columns.Count; nroCol++)
            {
                DataColumn col = misContactos.Columns[nroCol];
                Console.Write($"Ingrese {col.ColumnName}: ");
                fila[col] = Console.ReadLine();
            }
        }

        public void eliminarFila()
        {
            Console.Write("Ingrese el numero de fila a eliminar: ");
            int nroFila = int.Parse(Console.ReadLine());
            this.misContactos.Rows[nroFila - 1].Delete();
        }

    }
}
