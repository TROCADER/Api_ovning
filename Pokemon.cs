using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

namespace Api_ovning
{
    public class Pokemon
    {
        public string name;
        public float height;
        public int weight;

        public List<string> pokemonInfo = new List<string>();

        public void PokemonMethod()
        {
            name = UppercaseFirst(name);
            height = height/10;
            pokemonInfo.Add("Name: " + name);
            pokemonInfo.Add("Height: " + height + "m");
            pokemonInfo.Add("Weight: " + weight + "kg");

            System.Console.WriteLine();
            for (int i = 0; i < pokemonInfo.Count; i++)
            {
                System.Console.WriteLine(pokemonInfo[i]);
            }
        }

        static string UppercaseFirst(string s)
        {
            // Check for empty string.
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            // Return char and concat substring.
            return char.ToUpper(s[0]) + s.Substring(1);
        }
    }
}
