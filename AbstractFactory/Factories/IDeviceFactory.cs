using AbstractFactory.Devices;

namespace AbstractFactory.Factories;

public interface IDeviceFactory
{
    Laptop CreateLaptop();
    Netbook CreateNetbook();
    EBook CreateEBook();
    Smartphone CreateSmartphone();
}