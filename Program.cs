// Singleton
public class DeviceSingleton
{
    private static Dictionary<string, DeviceSingleton> _instances = new Dictionary<string, DeviceSingleton>();

    protected DeviceSingleton() { }

    public static DeviceSingleton GetInstance(string deviceType)
    {
        if (!_instances.ContainsKey(deviceType))
            _instances[deviceType] = new DeviceSingleton();

        return _instances[deviceType];
    }
}

// Bridge
public class Device
{
    protected IDeviceImplementation _implementation;

    public Device(IDeviceImplementation implementation)
    {
        _implementation = implementation;
    }

    public virtual void On()
    {
        _implementation.On();
    }

    public virtual void Off()
    {
        _implementation.Off();
    }
}
public interface IDeviceImplementation
{
    void On();
    void Off();
}

// State
public class DeviceState
{
    private IDeviceState _state;

    public DeviceState()
    {
        _state = new OffState();
    }

    public void SetState(IDeviceState state)
    {
        _state = state;
    }

    public void On()
    {
        _state.On(this);
    }

    public void Off()
    {
        _state.Off(this);
    }
}
public interface IDeviceState
{
    void On(DeviceState deviceState);
    void Off(DeviceState deviceState);
}

public class OffState : IDeviceState
{
    public void On(DeviceState deviceState)
    {
        deviceState.SetState(new OnState());
        Console.WriteLine("Device turned on");
    }

    public void Off(DeviceState deviceState)
    {
        Console.WriteLine("Device is already off");
    }
}

public class OnState : IDeviceState
{
    public void On(DeviceState deviceState)
    {
        Console.WriteLine("Device is already on");
    }

    public void Off(DeviceState deviceState)
    {
        deviceState.SetState(new OffState());
        Console.WriteLine("Device turned off");
    }
}

public class LightImplementation : IDeviceImplementation
{
    private string _name;

    public LightImplementation(string name)
    {
        _name = name;
    }

    public void On()
    {
        Console.WriteLine($"{_name} turned on");
    }

    public void Off()
    {
        Console.WriteLine($"{_name} turned off");
    }
}
public class Program
{
    public static void Main()
    {
        Device light1 = new Device(new LightImplementation("Living Room Light"));
        Device light2 = new Device(new LightImplementation("Kitchen Light"));

        DeviceSingleton light3 = DeviceSingleton.GetInstance("Light");
        DeviceSingleton light4 = DeviceSingleton.GetInstance("Light");

        DeviceState light3State = new DeviceState();
        light3State.SetState(new OffState());

        DeviceState light4State = new DeviceState();
        light4State.SetState(new OnState());

        light3State.On();
        light3State.Off();

        light4State.On();
        light4State.Off();

        light1.On();
        light1.Off();

        light2.On();
        light2.Off();
    }
}