using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2_1Trim_Pablo_Miguel.DLL
{
    public class ProductoDLL
    {
        Conexion conexion;
        public ProductoDLL()
        {
            conexion = new Conexion();
        }

        public DataSet getProductos()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM producto");
            return conexion.EjecutarSentencia(sentencia);
        }

        public DataSet getProductosAsc()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM producto ORDER BY nombre");
            return conexion.EjecutarSentencia(sentencia);
        }

        public DataSet getProductosFab(Int32 codigo_fabricante)
        {
            SqlCommand sentencia = new SqlCommand($"SELECT * FROM producto WHERE codigo_fabricante={codigo_fabricante}");
            return conexion.EjecutarSentencia(sentencia);
        }

        public bool anadirProducto(string nombre, Double precio, Int32 codigo_fabricante) {
            return conexion.EjecutarComandoSinRetornarDatos($"INSERT INTO producto(nombre, precio, codigo_fabricante) VALUES ('{nombre}', '{precio}', {codigo_fabricante});"); 
        }

        public DataSet getMayMen()
        {
            SqlCommand sentencia = new SqlCommand($"SELECT * FROM producto WHERE precio=(SELECT MAX(precio) FROM producto) OR precio=(SELECT MIN(precio) FROM producto)");
            return conexion.EjecutarSentencia(sentencia);
        }
    }
}
