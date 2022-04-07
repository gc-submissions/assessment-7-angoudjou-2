using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Assessment7.Models
{
  
    public class ZooClient
    {
        HttpClient client;
        public ZooClient(HttpClient _client)
        {
            client = _client;
        }

        public async Task<Annimal[]> GetAnimalsAsync()
        {
            HttpResponseMessage response = await client.GetAsync("animals.json");
            // if (response.StatusCode == System.Net.HttpStatusCode. )
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                var planet = JsonSerializer.Deserialize<ZooResponse>(content);

                return planet.results;
            }

            return new Annimal[0];
        }

        public async Task< SpecieResponse> GetSpecieAsync(string name)
        {
            HttpResponseMessage response = await client.GetAsync($"species/{name}.json");
            // if (response.StatusCode == System.Net.HttpStatusCode. )
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                var planet = JsonSerializer.Deserialize<SpecieResponse>(content);

                return planet;
            }

            return null;
        }
    }
}
