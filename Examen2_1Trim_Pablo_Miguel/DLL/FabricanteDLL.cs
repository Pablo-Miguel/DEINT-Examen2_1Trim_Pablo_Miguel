using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2_1Trim_Pablo_Miguel.DLL
{
    public class FabricanteDLL
    {
        Conexion conexion;
        public FabricanteDLL()
        {
            conexion = new Conexion();
        }

        public DataSet getFabricantes() {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM fabricante");
            return conexion.EjecutarSentencia(sentencia);
        }

        public DataSet getFabProdSinPrecio()
        {
            SqlCommand sentencia = new SqlCommand("SELECT f.nombre FROM fabricante f JOIN producto p ON f.codigo = p.codigo_fabricante WHERE p.precio IS NULL");
            return conexion.EjecutarSentencia(sentencia);
        }

        public bool eliminarFab(Int32 codigo_fabricante)
        {
            return conexion.EjecutarComandoSinRetornarDatos($"DELETE FROM fabricante WHERE codigo={codigo_fabricante};");
        }

    }
}
