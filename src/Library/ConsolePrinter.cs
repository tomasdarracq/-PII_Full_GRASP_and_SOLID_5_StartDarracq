using System;

namespace Full_GRASP_And_SOLID
{
    //Utilizo DIP e ISP para que ara que la clase ConsolePrinter no dependa de la clase Recipe
    public class ConsolePrinter : IPrinter
    {
        public void PrintRecipe(IRecipe recipe)
        {
            Console.WriteLine(recipe.GetTextToPrint());
        }
    }
}