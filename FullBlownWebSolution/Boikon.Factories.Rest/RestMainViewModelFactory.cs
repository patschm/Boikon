using Boikon.Entities;
using Boikon.ViewModels;
using Boikon.ViewModels.Factories;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Boikon.Factories.Rest
{
    public class RestMainViewModelFactory : MainViewModelFactory
    {
        static HttpClient client = new HttpClient { BaseAddress = new Uri("https://localhost:5001/person/") };

        public override async Task<MainViewModel> CreateModelAsync(int page = 0, int size = 10)
        {
            HttpResponseMessage response = await client.GetAsync($"all?page={page}&size={size}");
            string data = await response.Content.ReadAsStringAsync();
            List<Person> people = JsonConvert.DeserializeObject<List<Person>>(data);

            return new MainViewModel { People = people };
        }
    }
}
