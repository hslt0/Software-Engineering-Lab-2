using Builder;

Console.WriteLine("Builder Pattern Example (Hero vs Enemy)\n");

// Build Hero
var heroBuilder = new HeroBuilder();
var hero = Director.ConstructHero(heroBuilder);
Console.WriteLine(hero);

// Build Enemy
var enemyBuilder = new EnemyBuilder();
var enemy = Director.ConstructVillain(enemyBuilder);
Console.WriteLine(enemy);

// Manual Build Example
Console.WriteLine("--- Manually Built Character ---");
var manualBuilder = new HeroBuilder();
var manualChar = manualBuilder
    .AddGoodDeed("Helped a cat")
    .SetName("Adventurer")
    .SetHeight(170)
    .SetBuild("Slim")
    .SetClothing("Leather Armor")
    .AddInventoryItem("Map")
    .Build();
Console.WriteLine(manualChar);