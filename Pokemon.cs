using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

namespace Api_ovning
{
    public class Pokemon : ExtraStuff
    {
        // private string name;
        // private float height;
        // private int weight;

        // public string Name
        // {
        //     set
        //     {
        //         name = value;
        //     }
        //     get
        //     {
        //         return name;
        //     }
        // }

        // public float Height
        // {
        //     set
        //     {
        //         height = value;
        //     }
        //     get
        //     {
        //         return height;
        //     }
        // }

        // public int Weight
        // {
        //     set
        //     {
        //         weight = value;
        //     }
        //     get
        //     {
        //         return weight;
        //     }
        // }

        public string Name {set; get;}
        public float Height {set; get;}
        public int Weight {set; get;}

        public List<string> pokemonInfo = new List<string>();

        public void GetPokemon()
        {
            // Fyller på listan med alla värden
            Name = UppercaseFirst(Name);
            Height = Height / 10;
            pokemonInfo.Add("Name: " + Name);
            pokemonInfo.Add("Height: " + Height + "m");
            pokemonInfo.Add("Weight: " + Weight + "kg");

            // Skriver ut alla värden
            System.Console.WriteLine();
            for (int i = 0; i < pokemonInfo.Count; i++)
            {
                System.Console.WriteLine(pokemonInfo[i]);
            }
        }
    }
}
