using Newtonsoft.Json;
using PracticaN06_IS_Cliente_Razor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
// NOMBRE APELLIDOS: MARIO ANDRÉS VACA MORA
// PARALELO: 3228
// SI – INTEGRACIÓN DE SISTEMAS 
// FECHA: 04/05/2024
// PRÁCTICA No. # 06

namespace PracticaN06_IS_Cliente_Razor.Controllers
{
    public class StoreProcedureController : Controller
    {
        // Método para obtener los detalles de la factura
        public async Task<ActionResult> ObtenerDetalleFactura(int? id)
        {
            //id = 1;
            try
            {
                if (id.HasValue)
                {
                    // URL del servicio web API para obtener los detalles de la factura
                    string apiUrl = $"http://localhost:50438/api/StoreProcedure/{id}";

                    // Realizar solicitud HTTP GET al servicio web API
                    using (HttpClient client = new HttpClient())
                    {
                        HttpResponseMessage response = await client.GetAsync(apiUrl);

                        if (response.IsSuccessStatusCode)
                        {
                            // Leer el contenido de la respuesta y deserializarlo en una lista de objetos StoreProcedure
                            string responseData = await response.Content.ReadAsStringAsync();
                            List<StoreProcedure> detallesFactura = JsonConvert.DeserializeObject<List<StoreProcedure>>(responseData);

                            // Pasar los detalles de la factura a la vista
                            return View(detallesFactura);
                        }
                        else
                        {
                            // Si la solicitud no fue exitosa, manejar el error de alguna manera
                            ViewBag.ErrorMessage = $"Error al obtener los detalles de la factura: {response.StatusCode}";
                            return View();
                        }
                    }
                }
                else
                {
                    ViewBag.ErrorMessage = "No se proporcionó un ID válido para la factura.";
                    return View();
                }
            }
            catch (Exception ex)
            {
                // Manejar el error de alguna manera, como mostrar un mensaje de error en la vista
                ViewBag.ErrorMessage = "Error al obtener los detalles de la factura: " + ex.Message;
                return View();
            }
        }
    }
}
