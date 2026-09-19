using System;
namespace SmartHome;

public interface ISmartDevice
{
    string Name { get; }
    void OnClimateChanged(ClimateData climate);
}