using AbstractFactory.Devices;
using AbstractFactory.Devices.Kiaomi;

namespace AbstractFactory.Factories;

public class KiaomiFactory : IDeviceFactory
{
    public Laptop CreateLaptop() => new KiaomiLaptop();
    public Netbook CreateNetbook() => new KiaomiNetbook();
    public EBook CreateEBook() => new KiaomiEBook();
    public Smartphone CreateSmartphone() => new KiaomiSmartphone();
}