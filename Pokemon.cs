using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

namespace Api_ovning
{
    public class Pokemon
    {
        public string name;
        public string height;
        public string weight;

        public List<string> pokemonInfo = new List<string>();

        public void PokemonMethod()
        {
            pokemonInfo.Add("Name: " + name);
            pokemonInfo.Add("Height: " + weight);
            pokemonInfo.Add("Weight: " + weight);
            
            System.Console.WriteLine();
            for (int i = 0; i < pokemonInfo.Count; i++)
            {
                System.Console.WriteLine(pokemonInfo[i]);
            }
        }
    }
}
