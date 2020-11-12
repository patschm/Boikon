using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Boikon.Entities;
using Newtonsoft.Json;

namespace Boikon.ConsoleClient
{
    class Program
    {
        static HttpClient client = new HttpClient();

        static void Main(string[] args)
        {
            client.BaseAddress = new Uri("https://localhost:5001/person/");

            //ReadAll();
            Insert();
            ReadAll();
            Console.ReadLine();
        }

        private static async Task Insert()
        {
            //HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri("https://localhost:5001/person/");

            Person p = new Person { FirstName = "Pietje", LastName = "Bel", Age = 25 };
            string data = JsonConvert.SerializeObject(p);
            StringContent content = new StringContent(data);
            content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
            var result = await client.PostAsync("", content);

            if(result.IsSuccessStatusCode)
            {
                Console.WriteLine(result.Headers.Location);
            }
            //client.Dispose();
        }

        private static async Task ReadAll()
        {
            //HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri("https://localhost:5001/person/");

            HttpResponseMessage response = await client.GetAsync("all?page=1&size=100");
            Console.WriteLine(response.IsSuccessStatusCode);
            Console.WriteLine(response.StatusCode);

            string data = await response.Content.ReadAsStringAsync();
            List<Person> people =  JsonConvert.DeserializeObject<List<Person>>(data);
            
            foreach(Person p in people)
            {
                Console.WriteLine($"({p.ID}) {p.FirstName} {p.LastName}");
            }
            //client.Dispose();
        }
    }
}
