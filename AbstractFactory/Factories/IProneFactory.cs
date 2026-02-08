using AbstractFactory.Devices;
using AbstractFactory.Devices.IProne;

namespace AbstractFactory.Factories;

public class IProneFactory : IDeviceFactory
{
    public Laptop CreateLaptop() => new IProneLaptop();
    public Netbook CreateNetbook() => new IProneNetbook();
    public EBook CreateEBook() => new IProneEBook();
    public Smartphone CreateSmartphone() => new IProneSmartphone();
}