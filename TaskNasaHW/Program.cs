using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RapidAPISDK;

namespace TaskNasaHW
{
    class Program
    {
        static private Url _url = new Url(" https://NasaAPIdimasV1.p.rapidapi.com/getClosestAsteroids");
        private RapidAPI _rapidAPI = new RapidAPI("NasaAPIdimasV1.p.rapidapi.com", "cf1cde9414msh4548c14c6cc96c9p1fec47jsnae9f8761947c");
        static private List<Asteroid> _asteroids = new List<Asteroid>();

        static void Main(string[] args)
        {
            Console.WriteLine("Хотите узнать что-то новое");
            string answer = Console.ReadLine().ToString();

            switch (answer)
            {
                case "да":
                    var information = GetData();
                    information.Start();
                    break;
                case "нет":
                    Console.WriteLine("ну ладно");
                    break;
                default:

                    break;
            }
            
        }

        static Task GetData()
        {
            //using (var client = new We())
            //{
            //    var responseMessage = await client.GetAsync(new Uri("https://yobit.net/api/3/trades/ltc_btc-nmc_btc"));

            //    var response = await responseMessage.Content.ReadAsJsonAsync<Dictionary<string, List<Item>>>();

            //    Debugger.Break();
            //}

            //string json = "";

            //using (var client = new WebClient())
            //{
            //    using (Stream stream = client.OpenRead(_url.Value))
            //    {
            //        using (StreamReader reader = new StreamReader(stream))
            //        {
            //            string line = "";
            //            while ((line = reader.ReadLine()) != null)
            //            {
            //                json += line;
            //            }
            //        }
            //    }
            //}

            //_asteroids = JsonConvert.DeserializeObject<List<Asteroid>>(json);

            //foreach(var asteroid in _asteroids)
            //{
            //    Console.WriteLine($"Иеформация об астироиде/n" +
            //        $"Имя {asteroid.Name}" +
            //        $"Возраст {asteroid.Age}" +
            //        $"Местоположение {asteroid.Location}" +
            //        $"Ссылка на фото {asteroid.Photo}" +
            //        $"Дата {asteroid.}");
            //}

            //return Task.CompletedTask;

            WebRequest request = WebRequest.Create("https://nasaapidimasv1.p.rapidapi.com/getAsteroidStats");
            request.Headers.Add("X-RapidAPI-Host", "NasaAPIdimasV1.p.rapidapi.com");
            request.Headers.Add("X-RapidAPI-Key", "cf1cde9414msh4548c14c6cc96c9p1fec47jsnae9f8761947c");

            WebResponse response = request.GetResponse();

        }
    }
}
