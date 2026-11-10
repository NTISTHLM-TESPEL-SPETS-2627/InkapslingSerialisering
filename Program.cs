using System.Text.Json;
using InkapslingSerialisering;

List<Hero> heroes = [
  new() {Name = "Micke"},
  new() {Name = "Martin"}
];

string json = JsonSerializer.Serialize(heroes);

Console.WriteLine(json);


// string content = File.ReadAllText("hero.json");
// Hero hero = JsonSerializer.Deserialize<Hero>(content);

// Console.WriteLine(hero.Name);


// Hero hero = new() {Hp = 100, Name = "Micke"};
// hero.Hp = 100;

// string json = JsonSerializer.Serialize(hero);

// File.WriteAllText("hero.json", json);

Console.ReadLine();