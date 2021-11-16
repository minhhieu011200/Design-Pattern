using System;
using System.Collections.Generic;
using System.Text;

namespace Bai5
{
    class Sourdough: Bread
    {
        public override void MixIngredients()
        {
            Console.WriteLine("Gathering Ingredients for Sourdough Bread.");
        }
        public override void Bake()
        {
            Console.WriteLine("Baking the Sourdough Bread. (20 minutes)");
        }

    }
}
