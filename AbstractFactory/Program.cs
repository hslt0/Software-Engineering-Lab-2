using AbstractFactory.Factories;

Console.WriteLine("Abstract Factory Pattern Example\n");

// Create devices for IProne
IDeviceFactory iProneFactory = new IProneFactory();
PrintDeviceDetails("IProne", iProneFactory);

// Create devices for Kiaomi
IDeviceFactory kiaomiFactory = new KiaomiFactory();
PrintDeviceDetails("Kiaomi", kiaomiFactory);

// Create devices for Balaxy
IDeviceFactory balaxyFactory = new BalaxyFactory();
PrintDeviceDetails("Balaxy", balaxyFactory);
return;

void PrintDeviceDetails(string brand, IDeviceFactory factory)
{
    Console.WriteLine($"--- {brand} Devices ---");
    
    var laptop = factory.CreateLaptop();
    Console.WriteLine($"Laptop: {laptop.GetModelName()}");
    
    var netbook = factory.CreateNetbook();
    Console.WriteLine($"Netbook: {netbook.GetModelName()}");
    
    var eBook = factory.CreateEBook();
    Console.WriteLine($"EBook: {eBook.GetModelName()}");
    
    var smartphone = factory.CreateSmartphone();
    Console.WriteLine($"Smartphone: {smartphone.GetModelName()}");
    
    Console.WriteLine();
}
    