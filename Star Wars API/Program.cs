using Newtonsoft.Json;
using RestSharp;
using Star_Wars_API.Models;
using System;

namespace Star_Wars_API {
    class Program {
        static void Main(string[] args) {
            displayWelcome();

            RestSharp.IRestResponse apiResponse = getResponse("https://swapi.dev/api/people/");

            StarWarsResponse apiJSON = JsonConvert.DeserializeObject<StarWarsResponse>( apiResponse.Content );
            
            foreach(var personaje in apiJSON.Results) {
                RestSharp.IRestResponse planetResponse = getResponse(personaje.Homeworld);
                Homeworld planetJSON = JsonConvert.DeserializeObject<Homeworld>( planetResponse.Content );
                
                Console.WriteLine("Nombre: " + personaje.Name);
                Console.WriteLine("Altura: " + personaje.Height);
                Console.WriteLine("Masa: " + personaje.Mass);
                Console.WriteLine("Planeta: " + planetJSON.name);
                Console.WriteLine("------------------");
            }
        }

        private static void displayWelcome() {
            Console.WriteLine("Hello World!");
        }

        public static RestSharp.IRestResponse getResponse(string url) {
            RestClient clientApp = new RestClient(url);
            RestRequest request = new RestRequest(Method.GET);
            RestSharp.IRestResponse requestResult = clientApp.Execute(request);

            return requestResult;
        }
    }
}