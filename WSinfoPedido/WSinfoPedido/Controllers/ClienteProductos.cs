using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSinfoPedido.ADO;
using Newtonsoft.Json.Linq;
namespace WSinfoPedido.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ClienteProductos : Controller
    {

    

        [HttpGet("{Id}")]
        public IActionResult Get(long Id)
        {
            Respuesta_FAbarca r_FAbarca = new Respuesta_FAbarca();
            Conexion conn_FAbarca = new Conexion();

            List<consulta> consultas_FAbarca = new List<consulta>();
            try {
               
                consultas_FAbarca = conn_FAbarca.GetProductos_FAbarca(Id);

            } catch(Exception ex) {
                r_FAbarca.datos_Fabarca = "error";
                throw new Exception("error: " + ex.Message);
                return Ok(r_FAbarca);
            }
         
           
            return Ok(consultas_FAbarca);
        }
    }
}
