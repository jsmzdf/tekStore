using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WSinfoPedido.ADO
{
    public class Conexion
    {
        private string conn_FAbarca = "Data Source=LENOVO-PC;" +
              "Initial Catalog=BDStore;" +
              "User ID=AdminStore;" +
              "Password=123abc;" +
              "Connect Timeout=30;" +
              "Encrypt=False;" +
              "TrustServerCertificate=False;" +
              "ApplicationIntent=ReadWrite;" +
              "MultiSubnetFailover=False";


        List<consulta> respuesta = new List<consulta>();
        //[WebMethod]
        public List<consulta>  GetProductos_FAbarca(long rut)
        {
            //
            string query_Fabarca = "select p.nombre," +
                " ph.cantidad," +
                "p.precio," +
                "ph.direccion " +
                "from Pedido_hecho ph,Product p" +
                " where ph.Id_product=p.Id and ph.rut=" +
                rut +
                ";";
            using (SqlConnection connection_Fabarca = new SqlConnection(conn_FAbarca))
            {
                SqlCommand comamdo_FAbarca = new SqlCommand(query_Fabarca, connection_Fabarca);


                connection_Fabarca.Open();
                SqlDataReader leer_FAbarca = comamdo_FAbarca.ExecuteReader();
                var i = 0;
                while (leer_FAbarca.Read())
                {
                    consulta consul_FAbarca = new consulta();

                    consul_FAbarca.nombreP_Fabarca = leer_FAbarca.GetString(0);
                    consul_FAbarca.cantidad_Fabarca = (int)leer_FAbarca.GetDecimal(1);
                    consul_FAbarca.precio_Fabarca = (float)leer_FAbarca.GetDecimal(2);
                    consul_FAbarca.direccion_Fabarca = leer_FAbarca.GetString(3);
                    respuesta.Add(consul_FAbarca);
                    i++;
                }
                leer_FAbarca.Close();
                connection_Fabarca.Close();





                try
                {
                   

                }
                catch (Exception ex)
                {
                   // throw new Exception("error: "+ ex.Message);
                }

            }

            return respuesta;
        }
    }
    [Serializable]
    public class consulta{
        public string nombreP_Fabarca { get; set; }
        public int cantidad_Fabarca { get; set; }

        public float precio_Fabarca { get; set; }

        public string direccion_Fabarca { get; set; }

    }
}
