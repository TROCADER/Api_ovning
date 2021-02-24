using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Api_ovning
{
    public class Pokemon : ExtraStuff
    {
        private string name;
        private float height;
        private int weight;

        private int baseExperience;

        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }

        public float Height
        {
            set
            {
                height = value;
            }
            get
            {
                return height;
            }
        }

        public int Weight
        {
            set
            {
                weight = value;
            }
            get
            {
                return weight;
            }
        }

        [JsonProperty("base_experience")]
        public int BaseExperience
        {
            set{
                baseExperience = value;
            }
            get{
                return baseExperience;
            }
        }

        // public string name {set; get;}
        // public float height {set; get;}
        // public int Weight {set; get;}

        public List<string> pokemonInfo = new List<string>();

        public void GetPokemon()
        {
            // Fyller på listan med alla värden
            name = UppercaseFirst(name);
            height = height / 10;
            pokemonInfo.Add("Name:            " + name);
            pokemonInfo.Add("Height:          " + height + "m");
            pokemonInfo.Add("Weight:          " + weight + "kg");
            pokemonInfo.Add("Base experience: " + baseExperience + "xp");

            // Skriver ut alla värden
            System.Console.WriteLine();
            for (int i = 0; i < pokemonInfo.Count; i++)
            {
                System.Console.WriteLine(pokemonInfo[i]);
            }
        }
    }
}
