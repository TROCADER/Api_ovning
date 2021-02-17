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

            // Hämtar informationen från api:et
            string userPokemon = Console.ReadLine().Trim().ToLower();
            RestRequest request = new RestRequest("pokemon/" + userPokemon);
            IRestResponse response = client.Get(request);

            // Kollar om Pokemonen existerar eller ej
            // --> samt att man inte bara klickar på enter då api:et tillåter det
            // Om Pokemonen inte existerar eller att användaren har klickat på enter så kommer hen bli tvungen att skriva in igenom
            while (userPokemon == "" || (int)response.StatusCode != 200)
            {
                System.Console.WriteLine("\nPlease enter a valid pokemon's name or ID");
                userPokemon = Console.ReadLine().Trim().ToLower();
                request = new RestRequest("pokemon/" + userPokemon);
                response = client.Get(request);
            }

            Pokemon pokemon = JsonConvert.DeserializeObject<Pokemon>(response.Content);

            pokemon.PokemonMethod();

            Console.ReadLine();
        }
    }
}
