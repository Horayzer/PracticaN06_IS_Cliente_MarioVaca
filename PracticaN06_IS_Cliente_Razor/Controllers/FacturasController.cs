// NOMBRE APELLIDOS: MARIO ANDRÉS VACA MORA
// PARALELO: 3228
// SI – INTEGRACIÓN DE SISTEMAS 
// FECHA: 04/05/2024
// PRÁCTICA No. # 06

using Newtonsoft.Json;
using PracticaN06_IS_Cliente_Razor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace PracticaN06_IS_Cliente_Razor.Controllers
{
    public class FacturasController : Controller
    {
        private List<Factura> Deserializar()
        {
            string url = "http://localhost:50438/api/Facturas";
            WebClient client = new WebClient();
            string getData = client.DownloadString(new Uri(url));

            List<Factura> listaDes = JsonConvert.DeserializeObject<List<Factura>>(getData);

            return listaDes;
        }

        private void Serializar(Factura item)
        {
            string url = "http://localhost:50438/api/Facturas";
            string verb = "POST";
            WebClient client = new WebClient();

            string JsonData = JsonConvert.SerializeObject(item);
            UTF8Encoding encoding = new UTF8Encoding();
            Byte[] byteArray = encoding.GetBytes(JsonData);
            client.Headers.Add("content-type", "application/json");
            client.UploadData(url, verb, byteArray);
        }

        // GET: Facturas
        public ActionResult Index()
        {
            return View(Deserializar());
        }

        // GET: Facturas/Details/5
        public ActionResult Details(int numero)
        {
            try
            {
                string url = $"http://localhost:50438/api/Facturas/{numero}"; // URL del producto específico
                WebClient client = new WebClient();
                string jsonData = client.DownloadString(url); // Realizamos una solicitud GET para obtener los detalles del producto

                Factura item = JsonConvert.DeserializeObject<Factura>(jsonData); // Deserializamos los datos JSON en un objeto Producto

                return View(item);
            }
            catch (Exception ex)
            {
                // Aquí puedes manejar el error de alguna manera, como mostrar un mensaje de error en la vista
                ViewBag.ErrorMessage = "Error al obtener los detalles del producto: " + ex.Message;
                return View();
            }
        }

        // GET: Facturas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Facturas/Create
        [HttpPost]
        public ActionResult Create(Factura item)
        {
            try
            {
                Serializar(item);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Facturas/Edit/5
        public ActionResult Edit(int numero)
        {
            return View();
        }

        // POST: Facturas/Edit/5
        [HttpPost]
        public ActionResult Edit(int numero, Factura item)
        {
            try
            {
                string url = $"http://localhost:50438/api/Facturas/{numero}"; // URL del producto específico a editar
                string verb = "PUT"; // Usamos el verbo PUT para actualizar el producto
                WebClient client = new WebClient();

                string JsonData = JsonConvert.SerializeObject(item);
                UTF8Encoding encoding = new UTF8Encoding();
                Byte[] byteArray = encoding.GetBytes(JsonData);
                client.Headers.Add("content-type", "application/json");
                client.UploadData(url, verb, byteArray); // Enviamos la solicitud PUT al servidor

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Facturas/Delete/5
        public ActionResult Delete(int numero)
        {
            return View();
        }

        // POST: Facturas/Delete/5
        [HttpPost]
        public ActionResult Delete(int numero, Factura item)
        {
            try
            {
                string url = $"http://localhost:50438/api/Facturas/{numero}"; // URL del producto específico a eliminar
                string verb = "DELETE"; // Usamos el verbo DELETE para eliminar el producto
                WebClient client = new WebClient();
                client.UploadData(url, verb, new byte[0]); // Enviamos la solicitud DELETE al servidor

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
