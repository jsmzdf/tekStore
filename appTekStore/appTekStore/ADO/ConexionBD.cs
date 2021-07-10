using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
namespace appTekStore.ADO
{
    public class ConexionBD
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
        List<Producto> productos_FAbarca = new List<Producto>();

        public bool GetConn_FAbarca() {
            try
            {
                SqlConnection conexion_Fabarca = new SqlConnection(conn_FAbarca);
                conexion_Fabarca.Open();
            }
            catch{

                return false;
            }

            return true;
        }


        public List<Producto> GetProductos_FAbarca() {
            //
            string query_Fabarca = "select id,nombre,Descr,Precio from Product";
            using (SqlConnection connection_Fabarca = new SqlConnection(conn_FAbarca)) {
                SqlCommand comamdo_FAbarca = new SqlCommand(query_Fabarca, connection_Fabarca);
               try {
                    connection_Fabarca.Open();
                    SqlDataReader leer_FAbarca = comamdo_FAbarca.ExecuteReader();
                    while (leer_FAbarca.Read()) {
                        Producto p_FAbarca = new Producto();
                        p_FAbarca.id_Fabarca = leer_FAbarca.GetInt64(0);
                        p_FAbarca.nombre_Fabarca= leer_FAbarca.GetString(1);
                        p_FAbarca.descr_Fabarca = leer_FAbarca.GetString(2);
                        p_FAbarca.precio_Fabarca= (float)leer_FAbarca.GetDecimal(3);
                        productos_FAbarca.Add(p_FAbarca);
                    }
                    leer_FAbarca.Close();
                    connection_Fabarca.Close(); 

               } catch(Exception ex) {
                    //throw new Exception("error: "+ ex.Message);
                }

            }

                return productos_FAbarca;
        }

        public void Add_FAbarca(Pedido pedido)
        {
            string query_Fabarca = "insert into" +
                " Pedido_hecho(Nombre,rut,direccion,Telefono,Cantidad,Id_product)" +
                "values(" +
                 "@nombre_Fabarca" +
                ",@rut_Fabarca" +
                ",@direccion_Fabarca" +
                ",@telefono_Fabarca" +
                ",@cantidad_Fabarca" +
                ",@id_prod_Fabarca" +
                ")";
            using (SqlConnection connection_Fabarca = new SqlConnection(conn_FAbarca))
            {
                SqlCommand comamdo_FAbarca = new SqlCommand(query_Fabarca, connection_Fabarca);
                //comamdo_FAbarca.Parameters.AddWithValue("@pedido.id_Fabarca", pedido.id_Fabarca);
                comamdo_FAbarca.Parameters.AddWithValue("@nombre_Fabarca", pedido.nombre_Fabarca);
                comamdo_FAbarca.Parameters.AddWithValue("@rut_Fabarca", pedido.rut_Fabarca);
                comamdo_FAbarca.Parameters.AddWithValue("@direccion_Fabarca", pedido.direccion_Fabarca);
                comamdo_FAbarca.Parameters.AddWithValue("@telefono_Fabarca", pedido.telefono_Fabarca);
                comamdo_FAbarca.Parameters.AddWithValue("@cantidad_Fabarca", pedido.cantidad_Fabarca);
                comamdo_FAbarca.Parameters.AddWithValue("@id_prod_Fabarca", pedido.id_prod_Fabarca);

                try
                {
                    connection_Fabarca.Open();
                    comamdo_FAbarca.ExecuteNonQuery();
                    connection_Fabarca.Close();

                }
                catch (Exception ex)
                {
                      throw new Exception("error: " + ex.Message);
                }
            }

        }
    }
}