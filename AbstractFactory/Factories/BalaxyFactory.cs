using AbstractFactory.Devices;
using AbstractFactory.Devices.Balaxy;

namespace AbstractFactory.Factories;

public class BalaxyFactory : IDeviceFactory
{
    public Laptop CreateLaptop() => new BalaxyLaptop();
    public Netbook CreateNetbook() => new BalaxyNetbook();
    public EBook CreateEBook() => new BalaxyEBook();
    public Smartphone CreateSmartphone() => new BalaxySmartphone();
}