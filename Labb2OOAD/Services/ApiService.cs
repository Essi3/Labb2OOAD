using System;
using System.Collections.Generic;
using System.Net.Http;
using Labb2OOAD.Data.Repository;
using Labb2OOAD.Domain.Entity;
using Labb2OOAD.Domain.Repository;
using Newtonsoft.Json;

namespace Labb2OOAD.Services
{
    public class ApiService : IRepository
    {
        public List<Astronaut> GetAstronauts()
        {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = httpClient.GetAsync("http://api.open-notify.org/astros.json").Result;

            if (response.IsSuccessStatusCode)
            {
                string result = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine("Api called");
                return JsonConvert.DeserializeObject<TodaysAstronauts>(result).People;
            }

            return null;
        }
    }
}
    