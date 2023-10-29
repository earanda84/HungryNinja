using System.ComponentModel.Design;

Console.WriteLine("**************************");

// Crear un nuevo Food
Food arepas = new Food("Arepa", 1500, false, false);
Console.WriteLine(arepas.Name);

//Instancia Clase Buffet
Buffet buffet = new Buffet();

// Instancia metodo Serve randome foodde la clase Buffet
Food food = buffet.Serve();
Console.WriteLine(food.Name);

foreach (Food menu in buffet.Menu)
{
    Console.WriteLine(menu.Name);
}

// Instancia a un nuevo Ninja
Ninja ninja1 = new Ninja();

// Instancia Food para entregar una comida.
Food menuNinja1 = new Food("Helado de Piña",1500, false, true);

ninja1.Eat(menuNinja1);
