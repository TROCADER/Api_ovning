using System;
using Newtonsoft.Json;
using RestSharp;
using System.Threading;

namespace Api_ovning
{
    class Program
    {
        static void Main(string[] args)
        {
            RestClient client = new RestClient("https://pokeapi.co/api/v2/");

            while (true)
            {
                // Försöker nå alla Pokemons i api:et då numret som står på pokeapi.co/api/v2/pokemon/ (count) stämmer ej, manuellt kan jag bara nå 898 stycken utav de listade 1118 stycken
                int numberOfPokemonsReached = 1;
                RestRequest request = new RestRequest("pokemon/");
                IRestResponse response = client.Get(request);
                
                while (response.StatusCode != System.Net.HttpStatusCode.NotFound)
                {
                    request = new RestRequest("pokemon/" + numberOfPokemonsReached);
                    response = client.Get(request);

                    System.Console.WriteLine(response.StatusCode);

                    numberOfPokemonsReached++;
                }

                System.Console.WriteLine("Managed to reach a total of: " + numberOfPokemonsReached + " pokemons in the Pokeapi v2");
                System.Console.WriteLine("There might be more Pokemons than listed");
                System.Console.WriteLine("\nWhich pokeon do you want to see information about?");
                System.Console.WriteLine("Please enter a valid pokemon's name or ID");

                // Hämtar informationen från api:et
                string userPokemon = Console.ReadLine().Trim().ToLower();
                request = new RestRequest("pokemon/" + userPokemon);
                response = client.Get(request);

                // Kollar om Pokemonen existerar eller ej
                // --> samt att man inte bara klickar på enter då api:et tillåter det
                // Om Pokemonen inte existerar eller att användaren har klickat på enter så kommer hen bli tvungen att skriva in igenom
                while (userPokemon == "" || response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    System.Console.WriteLine("\nPlease enter a valid pokemon's name or ID");
                    userPokemon = Console.ReadLine().Trim().ToLower();
                    request = new RestRequest("pokemon/" + userPokemon);
                    response = client.Get(request);
                }

                Pokemon pokemon = JsonConvert.DeserializeObject<Pokemon>(response.Content);

                Console.Clear();
                pokemon.GetPokemon();

                System.Console.WriteLine("\n\nPress ESCAPE to quit\nOr any other key to continue");
                ConsoleKeyInfo keyboardKey = Console.ReadKey();

                if (keyboardKey.Key == ConsoleKey.Escape)
                {
                    break;
                }

                else
                {
                    Console.Clear();
                }
            }
        }
    }
}
