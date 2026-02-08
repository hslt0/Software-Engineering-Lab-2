namespace Builder
{
    public class EnemyBuilder : ICharacterBuilder
    {
        private Character _character = new Character();

        public EnemyBuilder()
        {
            _character.IsEvil = true;
        }

        public ICharacterBuilder SetName(string name)
        {
            _character.Name = name;
            return this;
        }

        public ICharacterBuilder SetHeight(double height)
        {
            _character.Height = height;
            return this;
        }

        public ICharacterBuilder SetBuild(string build)
        {
            _character.Build = build;
            return this;
        }

        public ICharacterBuilder SetHairColor(string color)
        {
            _character.HairColor = color;
            return this;
        }

        public ICharacterBuilder SetEyeColor(string color)
        {
            _character.EyeColor = color;
            return this;
        }

        public ICharacterBuilder SetClothing(string clothing)
        {
            _character.Clothing = clothing;
            return this;
        }

        public ICharacterBuilder AddInventoryItem(string item)
        {
            _character.Inventory.Add(item);
            return this;
        }

        // Specific method for Enemy
        public EnemyBuilder AddEvilDeed(string deed)
        {
            _character.Deeds.Add(deed);
            return this;
        }

        public Character Build()
        {
            return _character;
        }
        
        public void Reset()
        {
            _character = new Character { IsEvil = true };
        }
    }
}