using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

namespace Api_ovning
{
    public class Pokemon : ExtraStuff
    {
        public string name;
        public float height;
        public int weight;

        public List<string> pokemonInfo = new List<string>();

        public void PokemonMethod()
        {
            // Fyller på listan med alla värden
            name = UppercaseFirst(name);
            height = height / 10;
            pokemonInfo.Add("Name: " + name);
            pokemonInfo.Add("Height: " + height + "m");
            pokemonInfo.Add("Weight: " + weight + "kg");
            
            // Skriver ut alla värden
            System.Console.WriteLine();
            for (int i = 0; i < pokemonInfo.Count; i++)
            {
                System.Console.WriteLine(pokemonInfo[i]);
            }
        }
    }
}
