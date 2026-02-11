using System.Text;

namespace Builder
{
    public class Character
    {
        public string Name { get; set; }
        public double Height { get; set; }
        public string Build { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public string Clothing { get; set; }
        public List<string> Inventory { get; set; } = new List<string>();
        public List<string> Deeds { get; set; } = new List<string>(); // Good or Evil deeds
        public bool IsEvil { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"--- Character: {Name} ({(IsEvil ? "Villain" : "Hero")}) ---");
            sb.AppendLine($"Height: {Height} cm");
            sb.AppendLine($"Build: {Build}");
            sb.AppendLine($"Hair: {HairColor}");
            sb.AppendLine($"Eyes: {EyeColor}");
            sb.AppendLine($"Clothing: {Clothing}");
            sb.AppendLine($"Inventory: {string.Join(", ", Inventory)}");
            sb.AppendLine($"Deeds: {string.Join(", ", Deeds)}");
            return sb.ToString();
        }
    }
}