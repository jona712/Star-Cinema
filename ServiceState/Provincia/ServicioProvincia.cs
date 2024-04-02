using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServicioProvincia
{
    public class ServicioProvincia
    {
        /// <summary>
        /// Obtiene todas la provincias
        /// </summary>
        /// <returns></returns>
        public static List<ProvinciaJSON> GetAllProvince()
        {
            HttpClient client = new HttpClient();
            string path = "";
            string json = "";
            try
            {
                List<ProvinciaJSON> provincia = new List<ProvinciaJSON>();

                
                path = @"https://api.pruebayerror.com/locaciones/v1/provincias";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(path);
                request.Method = "GET";
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader sr = new StreamReader(response.GetResponseStream());
                json = sr.ReadToEnd();

                RootProvincia root = JSONGenericObject<RootProvincia>.JSonToObject(json);

                foreach (var item in root.Data)
                {
                    provincia.Add(item);
                }
                return provincia;

            }
            catch (Exception er)
            {

                MessageBox.Show("Error al obtener las provincias: " + er.Message);
                throw;
            }
        }

    }
}
