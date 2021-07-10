using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;
using appTekStore.ADO;
using Newtonsoft.Json;

namespace appTekStore
{
    public partial class Consumows : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        protected void ConsultarConRut_FAbarca(object sender, EventArgs e)
        {
            var url = $"http://localhost:62793/api/ClienteProductos/{TextBox1.Text}";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {

                             string responseBody = objReader.ReadToEnd();

                            List<ConWS> estados_FAbarca = JsonConvert.DeserializeObject<List<ConWS>>(responseBody);

                            foreach (var pr in estados_FAbarca)
                            {

                                ListBox1.Items.Add("Producto: " +pr.nombreP_Fabarca+
                                    "precio_Uni: "+pr.precio_Fabarca+
                                    "Dirección"+pr.direccion_Fabarca+
                                    "cantidad comprada" + pr.cantidad_Fabarca);

                            }
                            /* JObject json = JObject.Parse(responseBody);

                             foreach (var pr in json)
                            {

                                ListBox1.Items.Add(pr.ToString());

                            }

                            */


                        }
                    }
                }
            }
            catch (WebException ex)
            {
                // Handle error
            }
        }
    }
}