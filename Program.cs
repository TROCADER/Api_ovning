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
            
            System.Console.WriteLine("Which pokeon do you want to see information about?");
            System.Console.WriteLine("Please enter a valid pokemon's name or ID");
            
            string userPokemon = Console.ReadLine().Trim();
            RestRequest request = new RestRequest("pokemon/" + userPokemon);
            IRestResponse response = client.Get(request);
            
            while (userPokemon == "" || (int)response.StatusCode != 200)
            {
                System.Console.WriteLine("\nPlease enter a valid pokemon's name or ID");
                userPokemon = Console.ReadLine().Trim();
                request = new RestRequest("pokemon/" + userPokemon);
                response = client.Get(request);
            }

            Pokemon pokemon = JsonConvert.DeserializeObject<Pokemon>(response.Content);

            pokemon.PokemonMethod();

            Console.ReadLine();
        }
    }
}
