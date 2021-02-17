using System;
using Newtonsoft.Json;
using RestSharp;

namespace Api_ovning
{
    class Program
    {
        static void Main(string[] args)
        {
            RestClient client = new RestClient("https://pokeapi.co/api/v2/");

            RestRequest request = new RestRequest("pokemon/blastoise");

            IRestResponse response = client.Get(request);

            Pokemon blastoise = JsonConvert.DeserializeObject<Pokemon>(response.Content);

            blastoise.PokemonMethod();

            Console.ReadLine();
        }
    }
}
