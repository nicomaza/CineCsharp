using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportesCine.Cliente
{
     class ClienteSingleton
    {
        private static ClienteSingleton Instance;
        private HttpClient client;

        private ClienteSingleton()
        {
            client = new HttpClient();
        }
        public static ClienteSingleton getinstancia()
        {
            if(Instance == null)
                Instance = new ClienteSingleton();
            return Instance;
        }

        public async Task<string> GetAsync(string url)
        {
            var result = await client.GetAsync(url);
            var content = "";
            if (result.IsSuccessStatusCode)
                content = await result.Content.ReadAsStringAsync();
            return content;
        }

        public async Task<string> PostAsync(string url, string data)
        {
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            var result = await client.PostAsync(url, content);
            var response = "";
            if (result.IsSuccessStatusCode)
                response = await result.Content.ReadAsStringAsync();
            return response;
        }

        public async Task<string> PutAsync(string url, string data)
        {
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            var result = await client.PutAsync(url, content);
            var response = "";
            if (result.IsSuccessStatusCode)
                response = await result.Content.ReadAsStringAsync();
            return response;
        }

        public async Task<string> DeleteAsync(string url)
        {           
            var result = await client.DeleteAsync(url);
            var response = "";
            if (result.IsSuccessStatusCode)
                response = await result.Content.ReadAsStringAsync();
            return response;
        }

        public async Task<string> PatchAsync(string url, string data)
        {
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            var result = await client.PatchAsync(url, content);
            var response = "";
            if (result.IsSuccessStatusCode)
                response = await result.Content.ReadAsStringAsync();
            return response;
        }

    }


}
