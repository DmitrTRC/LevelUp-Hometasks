using Lesson3.Models;
using Lesson3.Models.EquipmentDepartment;
using Lesson3.Models.FoodDepartment;
using Lesson3.Models.WearDepartment;


Console.WriteLine("Lesson3 - Interfaces");

// List of ShopStock
List<ShopStoreItem> shopStock = new List<ShopStoreItem>();

// Create a new Gym
Gym gym = new Gym
{
    Name = "Disc",
    Price = 100,
    Weight = 100,
    Description = "A disc for gym",
    Brand = "Holts",
};

// Create a new Cardio
Cardio cardio = new Cardio
{
    Name = "Treadmill",
    Price = 1000,
    MaxSpeed = 20,
    MaxIncline = 10,
    Description = "A treadmill for cardio",
    Brand = "Matrix",
};

Cardio cardio2 = new Cardio
{
    Name = "Ellipsoid",
    Price = 2800,
    MaxSpeed = 20,
    MaxIncline = 10,
    Description = "A ellipsoid for cardio",
    Brand = "Matrix",
};

//Create a new Protein
Protein protein = new Protein
{
    Name = "Whey",
    Price = 100,
    ContainsPercent = 80,
    Description = "A protein for gym",
    Brand = "Optimum Nutrition",
};

//Create a new Shoes
Shoes shoes = new Shoes
{
    Name = "Running shoes",
    Price = 100,
    Size = "42",
    Description = "A shoes for running",
    Brand = "Nike",
};

// Add items to the shop stock
shopStock.Add(gym);
shopStock.Add(cardio);
shopStock.Add(cardio2);
shopStock.Add(protein);
shopStock.Add(shoes);

// Print the shop stock
Console.WriteLine("Shop stock:");

foreach (var item in shopStock)
{
    Console.WriteLine(item);
}