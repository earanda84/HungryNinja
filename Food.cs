using System.Diagnostics.Contracts;

class Food
{
    public string Name;
    public int Calories;
    public bool IsSpicy;
    public bool IsSweet;

    public Food(string name, int calories, bool isSpicy, bool isSweet)
    {
        Name = name;
        Calories = calories;
        IsSpicy = isSpicy;
        IsSweet = isSweet;
    }

}

class Buffet
{
    public List<Food> Menu;

    public Buffet()
    {
        Menu = new List<Food>() {
            new Food("Example", 1000, false, false),
            new Food("Fideos", 1200, false, false),
            new Food("Porotos", 1500, false, false),
            new Food("Pepino", 1000, false, false),
            new Food("Postre", 1000, false, true),
            new Food("Tacos", 1600, true, false),
            new Food("Shawarma", 1250, false, false),
            new Food("Pescado", 1500, false, false),
        };

    }

    public Food Serve()
    {
        Random rand = new Random();

        int randomFood = rand.Next(0, Menu.Count);

        return Menu[randomFood];

    }
}

class Ninja
{
    public int CalorieIntake { get; set; }
    public List<Food> FoodHistory;

    public Ninja(int calorieIntake = 0)
    {
        FoodHistory = new List<Food>();
        CalorieIntake = calorieIntake;
    }

    public bool IsFull()
    {

        if (CalorieIntake > 1200)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void Eat(Food item)
    {
        if (IsFull())
        {
            Console.WriteLine("El Ninja está lleno!");
            return;
        }
        else
        {

            // Añadir ingesta de calorías
            CalorieIntake += item.Calories;

            // Añadir comida al historial
            FoodHistory.Add(item);

            Console.WriteLine($"El nombre de la comida es: {item.Name}");

            if (item.IsSweet)
            {
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine($"La comida es dulce");
            }
            else if(item.IsSpicy)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                
                Console.WriteLine($"La comida es picante");
            }else{
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine($"La comida no es dulce, ni picante");
            }
        }
    }

}
