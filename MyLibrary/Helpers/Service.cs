using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MyLibrary.Models;


namespace MyLibrary.Helpers
{
    public static class Service
    {
        public static Uri ApiAddress = new Uri("https://localhost:44310");

        public static async Task<List<Header>> GetHeaders()
        {
            var client = new HttpClient();
            //client.BaseAddress = new Uri(ConfigurationManager.AppSettings["ApiAddress"]);
            client.BaseAddress = ApiAddress;
            var response = await client.GetAsync("api/Header/GetHeaders");
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var json = await response.Content.ReadAsStringAsync();
                var headers = JsonConvert.DeserializeObject<List<Header>>(json);
                return headers;
            }
            else throw new Exception();
        }

        public static async Task<Header> AddOrUpdateHeader(Header header)
        {
            var json = JsonConvert.SerializeObject(header);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var client = new HttpClient();
            //client.BaseAddress = new Uri(ConfigurationManager.AppSettings["ApiAddress"]);
            client.BaseAddress = ApiAddress;
            var response = await client.PostAsync("api/Header/AddOrUpdateHeader", content);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                json = await response.Content.ReadAsStringAsync();
                header = JsonConvert.DeserializeObject<Header>(json);
                return header;
            }
            else throw new Exception();
        }
    }
}
