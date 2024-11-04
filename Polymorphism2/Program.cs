Main();
static void Main()
{
    ElectronicDevice eletronicDevice = new ElectronicDevice();
    TV tv = new TV();
    Radio radio = new Radio();
    Phone phone = new Phone();

    eletronicDevice.TurnOn();
    eletronicDevice.TurnOff();
    tv.TurnOn();
    tv.TurnOff();
    radio.TurnOn();
    radio.TurnOff();
    phone.TurnOn();
    phone.TurnOff();
}
class ElectronicDevice
{
    public virtual void TurnOn()
    {
        Console.WriteLine("Turning on the device...");
    }
    public virtual void TurnOff()
    {
        Console.WriteLine("Turning off the device...");
    }
}
class TV : ElectronicDevice
{
    public override void TurnOn()
    {
        Console.WriteLine("Turning on the Tv...");
    }
    public override void TurnOff() {
        Console.WriteLine("Turning off the Tv...");
    }
}
class Radio : ElectronicDevice
{
    public override void TurnOn()
    {
        Console.WriteLine("Turning on the Radio...");
    }
    public override void TurnOff()
    {
        Console.WriteLine("Turning off the Radio...");
    }
}
class Phone : ElectronicDevice
{
    public override void TurnOn()
    {
        Console.WriteLine("Turning on the Phone...");
    }
    public override void TurnOff()
    {
        Console.WriteLine("Turning off the Phone...");
    }
}