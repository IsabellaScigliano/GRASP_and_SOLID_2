using System;
using System.Collections.Generic;

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter
    {
        public void PrintRecipe(Recipe recipe)
        {
            Console.WriteLine($"Receta de {recipe.FinalProduct.Description}:");
            foreach (Step step in recipe.GetSteps())
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
        }
    }
}
/*Expert:La responsabilidad de imprimir una receta se asigna a la clase ConsolePrinter. 
Esto es apropiado ya que la clase ConsolePrinter tiene acceso a la información necesaria de la receta y 
sabe cómo imprimirla en la consola.

SRP:La clase ConsolePrinter tiene la responsabilidad única de imprimir una receta en la consola. Si en 
el futuro cambia la forma en que se imprime una receta en la consola, solo la clase ConsolePrinter 
necesitará ser modificada, manteniendo así la cohesión y la modularidad del código.*/