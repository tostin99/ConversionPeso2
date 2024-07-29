using ConvertDAL.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace PesoPL.Helpers
{
    public static class ConsumeAPI
    {
        private static string apiBaseUrl = ConfigurationManager.AppSettings["APIBaseUrl"];
        
        public static async Task <PesoParametros> ConvertWeightAsync (PesoParametros parametros)
        {
            string json = JsonConvert.SerializeObject(parametros);

            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            using (HttpClient client  = new HttpClient ()) 
            {
                var response = await client.PostAsync($"{apiBaseUrl}/weight/Convert", content);
                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();

                    PesoParametros pesoContent = JsonConvert.DeserializeObject<PesoParametros> (responseContent);

                    return pesoContent;
                }
                else
                {
                    throw new HttpRequestException($"Error al obtener respuesta : {response.ReasonPhrase}");
                }


            }
        }

    
    }
}