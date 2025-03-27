using System.Xml;

namespace Conteners;

public class gasContener : Contener, IHazardNotifier
{
    public int pressure{get; internal set;}
    public gasContener(double loadedWeight, double high, double ownWeight, double deep, string id, float maxWeight, int pressure)
        : base(loadedWeight, high, ownWeight, deep, id, maxWeight)
    {
        this.pressure = pressure;
    }

    public void Notify(string id)
    {
        Console.WriteLine($"[ALERT] Danger! Contener ID: {id}");
    }

    public void emptyingGasContener()
    {
        double leftGas = 0.05 * loadedWeight;
        Console.WriteLine($"[ALERT] Gas! Left Gas: {leftGas} %");
    }

    public void loadingGasContener()
    {
        if (loadedWeight > maxWeight)
        {
            Notify($"[ALERT] Danger! Contener ID: {id}");
            throw new OverflowException("Overfill");
        }
        Console.WriteLine($"Loaded Gas: {loadedWeight} %");
    }
    public override string ToString()
    {
        return $"Gas Contener ID: {id}, Loaded Weight: {loadedWeight}, Max Weight: {maxWeight}, Humidity: {pressure}";
    }

}

