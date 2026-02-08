using Prototype;

Console.WriteLine("Prototype Pattern Example (Virus)\n");

// 1. Create a family of viruses (3 generations)
// Generation 1 (Grandparent)
var grandParent = new Virus("GrandParent", "Corona", 1.5, 5);

// Generation 2 (Parents)
var parent1 = new Virus("Parent1", "Corona", 1.2, 3); 
var parent2 = new Virus("Parent2", "Corona", 1.3, 3); 
grandParent.Children.Add(parent1);
grandParent.Children.Add(parent2);

// Generation 3 (Children)
var child1 = new Virus("Child1", "Corona", 0.5, 1);
var child2 = new Virus("Child2", "Corona", 0.6, 1);
parent1.Children.Add(child1);
parent2.Children.Add(child2);

Console.WriteLine("Original Virus Family:");
grandParent.PrintFamily();

// 2. Clone the grandparent
Console.WriteLine("\nCloning GrandParent...");
var clonedGrandParent = (Virus)grandParent.Clone();

// 3. Modify the clone to prove it's a deep copy
Console.WriteLine("\nModifying Clone (Changing name and adding a new child to Parent1's clone)...");
clonedGrandParent.Name = "ClonedGrandParent";
clonedGrandParent.Children[0].Name = "ClonedParent1";
clonedGrandParent.Children[0].Children.Add(new Virus("NewChildOfClone", "Corona", 0.1, 0));

Console.WriteLine("\nOriginal Virus Family (Should remain unchanged):");
grandParent.PrintFamily();
Console.WriteLine("\nCloned Virus Family (Should reflect changes):");
clonedGrandParent.PrintFamily();