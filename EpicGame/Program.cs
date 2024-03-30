string folderPath = @"C:\data\";
string heroFile = "heroes.txt";
string villianFile = "villains.txt";

string[] heroes = File.ReadAllLines(Path.Combine(folderPath, heroFile));
string[] villains = File.ReadAllLines(Path.Combine(folderPath, villianFile));
string[] weapon = {"The Master Sword", "Excalibur", "The Elder Wand", "Shield", "Lightsaber", "Web-shooters"};


string hero = GetRandomValuefromArray(heroes);
string heroWeapon = GetRandomValuefromArray(weapon);
int heroHP = GetCharacterHP(hero);
int heroStrikeStrenght = heroHP;
Console.WriteLine($"Today {hero} ({heroHP} HP) with {heroWeapon} saves the day!");

string villain = GetRandomValuefromArray(villains);
string villainWeapon = GetRandomValuefromArray(weapon);
int villianHP = GetCharacterHP(villain);
int villianStrikeStrenght = villianHP;
Console.WriteLine($"Today {villain} ({villianHP} HP) with  {villainWeapon} tries to take over the world!");

while(heroHP > 0 && villianHP > 0)
{
    heroHP = heroHP - Hit(villain, villianStrikeStrenght);
    villianHP = villianHP - Hit(hero, heroStrikeStrenght);
}

Console.WriteLine($"Hero {hero} HP: {heroHP}");
Console.WriteLine($"Villain {villain} HP: {villianHP}");

if (heroHP > 0)
{
    Console.WriteLine($"{hero} saves the day!");
}
else if(villianHP > 0)
{
    Console.WriteLine($"Dark side wins!");
}
else
{
    Console.WriteLine($"Draw!");
}

static string GetRandomValuefromArray(string[]someArray)
{
    Random rnd = new Random();
    int randomIndex = rnd.Next(0, someArray.Length);
    string randomStringFromArray = someArray[randomIndex];
    return randomStringFromArray;
}

static int GetCharacterHP(string characterName)
{
    if(characterName. Length < 10)
    {
        return 10;
    }
    else
    {
        return characterName.Length;
    }
}

static int Hit(string characterName, int charactherHP)
{
    Random rnd = new Random();
    int strike = rnd.Next(0, charactherHP);

    if(strike == 0)
    {
        Console.WriteLine($"{characterName}missed the target!");
    }
    else if(strike == charactherHP - 1)
    {
        Console.WriteLine($"{characterName} made a critical hit!");
    }
    else
    {
        Console.WriteLine($"{characterName} hit {strike}!");
    }

    return strike;
}
