using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipelines;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace EnQ_Admin.API.Leaders
{
    public class LeadersService
    {
        public HttpClient Client { get; }

        public LeadersService(HttpClient client)
        {
            client.BaseAddress = new Uri("https://enq-server.herokuapp.com/leaders");
            Client = client;
        }

        public async Task<string> GetOneLeaders(string id)
        {
            var response = await Client.GetAsync($"/leaders/{id}");
            response.EnsureSuccessStatusCode();
            using var responseStream = await response.Content.ReadAsStreamAsync();
            Console.WriteLine(responseStream);
            return responseStream.ToString();
        }
    }
}