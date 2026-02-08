using System;
using System.Collections.Generic;

namespace Prototype
{
    public class Virus(string name, string type, double weight, int age)
        : ICloneable
    {
        public double Weight { get; set; } = weight;
        public int Age { get; set; } = age;
        public string Name { get; set; } = name;
        public string Type { get; set; } = type;
        public List<Virus> Children { get; set; } = new();

        // Deep copy implementation
        public object Clone()
        {
            var clone = (Virus)MemberwiseClone();
            
            // Deep copy of children
            clone.Children = [];
            foreach (var child in Children)
            {
                clone.Children.Add((Virus)child.Clone());
            }

            return clone;
        }

        public override string ToString()
        {
            return $"Virus(Name={Name}, Type={Type}, Weight={Weight}, Age={Age}, ChildrenCount={Children.Count})";
        }
        
        public void PrintFamily(string indent = "")
        {
            Console.WriteLine($"{indent}{this}");
            foreach (var child in Children)
            {
                child.PrintFamily(indent + "  ");
            }
        }
    }
}