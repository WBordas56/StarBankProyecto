using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StarBankProyecto.Controllers
{
    public class SitiosApiController
    {
        public async static Task<List<SitiosListModel>> ControllerObtenerListaSitios()
        {
            List<SitiosListModel> listasitios = new List<SitiosListModel>();

            using (HttpClient cliente = new HttpClient())
            {
                var respuesta = await cliente.GetAsync("https://dpstudent.000webhostapp.com/Examenparcial2/index.php");

                if (respuesta.IsSuccessStatusCode)
                {
                    string contenido = respuesta.Content.ReadAsStringAsync().Result.ToString();

                    dynamic dyn = JsonConvert.DeserializeObject(contenido);
                    byte[] newBytes = null;


                    if (contenido.Length > 28)
                    {

                        foreach (var item in dyn.items)
                        {
                            
                            
                            var stream = new MemoryStream(newBytes);

                            

                            listasitios.Add(new SitiosListModel(
                                            item.Id.ToString(), item.Descripcion.ToString(),
                                            item.Latitud.ToString(), item.Longitud.ToString()
                                            ));
                        }
                    }
                }
            }
            return listasitios;
        }



    }

    public class SitiosListModel
    {
        public SitiosListModel(dynamic dynamic1, dynamic dynamic2, dynamic dynamic3, dynamic dynamic4)
        {
        }
    }
}
