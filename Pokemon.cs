using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

namespace Api_ovning
{
    public class Pokemon
    {
        public string name;
        public int height;
        public int weight;

        public List<int> ints = new List<int>();

        public void PokemonMethod()
        {
            ints.Add(height);
            ints.Add(weight);

            for (int i = 0; i < ints.Count; i++)
            {
                System.Console.WriteLine(ints[i]);
            }
        }
    }
}
