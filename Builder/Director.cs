namespace Builder
{
    public static class Director
    {
        public static Character ConstructHero(HeroBuilder builder)
        {
            return builder
                .AddGoodDeed("Saved the village")
                .AddGoodDeed("Defeated the dragon")
                .SetName("Arthur")
                .SetHeight(185)
                .SetBuild("Athletic")
                .SetHairColor("Blonde")
                .SetEyeColor("Blue")
                .SetClothing("Shining Armor")
                .AddInventoryItem("Excalibur")
                .AddInventoryItem("Shield of Valor")
                .Build();
        }

        public static Character ConstructVillain(EnemyBuilder builder)
        {
            return builder
                .AddEvilDeed("Burned the forest")
                .AddEvilDeed("Stole the crown")
                .SetName("Malagar")
                .SetHeight(190)
                .SetBuild("Muscular")
                .SetHairColor("Black")
                .SetEyeColor("Red")
                .SetClothing("Dark Robes")
                .AddInventoryItem("Cursed Dagger")
                .AddInventoryItem("Poison Vial")
                .Build();
        }
    }
}