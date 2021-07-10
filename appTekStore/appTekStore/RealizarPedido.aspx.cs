using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using appTekStore.ADO;
namespace appTekStore
{
    public partial class RealizarPedido : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
           ConexionBD conn_FAbarca = new ConexionBD();
            List<Producto> productos_FAbarca= conn_FAbarca.GetProductos_FAbarca();
            foreach (var p_FAbarca in productos_FAbarca) {
                string texto = 
                    p_FAbarca.id_Fabarca.ToString() +"  "+
                    p_FAbarca.nombre_Fabarca.ToString()+
                    ": $" + p_FAbarca.precio_Fabarca.ToString();
                if(ListBox1.Items.Count< productos_FAbarca.Count)
                ListBox1.Items.Add(texto);
            }
            

        }
        protected void Button1_Click1_FAbarca(object sender, EventArgs e)
        {
            ConexionBD conn = new ConexionBD();
            Pedido pedido_FAbarca = new Pedido();
            int err_FAbarca = 0;
 
            
           
           if (TextBox1.Text=="") {
                Label7.Text = "Debe ingresar un nombre";
            }
           else if (TextBox2.Text == "")
            {
                Label7.Text = "Debe ingresar un rut";
            }
            else if (TextBox3.Text == "")
            {
                Label7.Text = "Debe ingresar una dirección";
            }
            else if (TextBox4.Text == "")
            {
                Label7.Text = "Debe ingresar un teléfono";
            }
           
            else if (ListBox1.SelectedIndex==-1)
            {
                Label7.Text = "Seleccione un producto";
            }
            else if (TextBox6.Text =="")
            {
                Label7.Text = "Ingrese una cantidad";
            }
            else {
                Label7.Text = "";
                try {

                    pedido_FAbarca.nombre_Fabarca = TextBox1.Text;
                    pedido_FAbarca.rut_Fabarca = long.Parse( TextBox2.Text);
                    pedido_FAbarca.direccion_Fabarca = TextBox3.Text;
                    pedido_FAbarca.telefono_Fabarca = long.Parse(TextBox4.Text);

                    pedido_FAbarca.id_prod_Fabarca = long.Parse(ListBox1.SelectedItem.Text.Split(' ')[0]);
                    TextBox6.Text = ListBox1.SelectedItem.Text.Split(' ')[0];
                    pedido_FAbarca.cantidad_Fabarca = int.Parse(TextBox6.Text);
                    conn.Add_FAbarca(pedido_FAbarca);
                }
                catch(Exception ex) {
                    Label7.Text = "Valor numérico inválido";
                 
                }
                //  Response.Redirect("About");
            }
        }
    }
}