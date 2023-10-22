string folderPath = @"/ Users / merilimikku / projects/foods.txt";
string[] dataFromFile = File.ReadAllLines(folderPath);
foreach (string element in dataFromFile)
    (Console.WriteLine(element);

string[] heroes = { "Harry Potter", "Luke Skywalker", "Lara Croft", "Scooby-Doo" };
string[] villains = { "Voldemort", "Darth Vader", "Dracula", "Joker", "Sauron" };
string[] weapon= { "magic wand", "Plastic fork", "banana", "Wooden sword", "Lego brick"}; 


string hero = GetRandomValueFromArray(heroes);
string heroWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {hero} with {heroWeapon} saves the day!");

String villain = GetRandomValueFromArray(villains);
string VillainWeapon = GetRandomValueFromArray(weapon); 
Console.WriteLine($"Today {villain} with {VillainWeapon} tries to take over the world!");

static string GetRandomValueFromArray(string[] someArray)
{
    Random rnd = new Random();
    int randomIndex = rnd.Next(0, someArray.Length);
    string randomStringFromArray = someArray[randomIndex];
    return randomStringFromArray; 
}
