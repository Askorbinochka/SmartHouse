using System;
namespace SmartHome;

public interface IClimateController
{
    //підключення пристрою
    void Connect(ISmartDevice device);
    //відключення пристрою
    void Disconnect(ISmartDevice device);
    //розсилати сповіщення
    void NotifyDevices();
}