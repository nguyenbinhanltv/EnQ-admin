using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace EnQ_Admin.API.Leaders
{
    public class LeadersService
    {
        public async Task<LeadersModel> GetOneLeadersAsync(HttpClient http, string path)
        {
            var response = await http.GetAsync($"https://enq-server.herokuapp.com/leaders/{path}");
            if (response.IsSuccessStatusCode)
            {
                LeadersModel data = JsonConvert.DeserializeObject<LeadersModel>(await response.Content.ReadAsStringAsync());
                return data;
            }

            return null;
        }

        public async Task<LeadersModel[]> GetLeadersAsync(HttpClient http)
        {
            var response = await http.GetAsync("https://enq-server.herokuapp.com/leaders");
            if (response.IsSuccessStatusCode)
            {
                LeadersModel[] data = JsonConvert.DeserializeObject<LeadersModel[]>(await response.Content.ReadAsStringAsync());
                return data;
            }

            return null;
        }

        public async Task<Boolean> UpdateOneLeadersAsync(HttpClient http, string path, HttpContent data)
        {
            var response = await http.PatchAsync($"https://enq-server.herokuapp.com/leaders/{path}", data);
            if (response.IsSuccessStatusCode)
            {
                return true;
            }

            return false;
        }
    }
}