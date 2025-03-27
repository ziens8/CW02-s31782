namespace Conteners;

public class Kontenerowiec
{
    public  List<Contener> conteners { get; internal set; } = new List<Contener>();
    public double maxSpeed{get;internal set;}
    public int maxConteners{get;internal set;}
    public double maxWeightofConteners{get;internal set;}

    public Kontenerowiec(double maxSpeed, int maxConteners, double maxWeightofConteners)
    {
        this.maxSpeed = maxSpeed;
        this.maxConteners = maxConteners;
        this.maxWeightofConteners = maxWeightofConteners;
    }

    public double getTotalWeightofConteners()
    {
        double sum = 0;
        foreach (var contener in conteners)
        {
            sum += contener.loadedWeight;
        }
        return sum;
    }

    public void addContener(Contener contener)
    {
        if (conteners.Count > maxConteners)
        {
            throw new OverFillException("Too many Conteners");
        }

        double totalWeight = getTotalWeightofConteners();
        if (totalWeight > maxWeightofConteners)
        {
            throw new OverFillException("Too many WeightofConteners");
        }
    }

    public void removeContener(Contener contener)
    {
        conteners.Remove(contener);
    }

    public void changeContener(string Id, Contener newContener)
    {
        var oldContener = conteners.FirstOrDefault(c => c.id == Id);
        if (oldContener == null)
        {
            throw new KeyNotFoundException("Contener not found");
        }
        conteners.Remove(oldContener);
        conteners.Add(newContener);
        Console.WriteLine($"replace kontener {Id} by {newContener.id}.");
    }

    public void transferContener(string Id,Kontenerowiec from,Kontenerowiec to)
    {
        var contener = from.conteners.FirstOrDefault(c => c.id == Id);
        if (contener == null)
        {
            throw new KeyNotFoundException("Contener not found");
        }
        from.conteners.Remove(contener);
        to.conteners.Add(contener);
        Console.WriteLine($"Transfer contener {Id} from ship A do ship B.");
    }
    
    public override string ToString()
    {
        return "Kontenerowiec: " + maxSpeed + " węzlów " + maxConteners + " maksymalnych kontenerów , maksymalna waga " +
               "wszystkich kontenerów" + maxWeightofConteners + "ton , typy kontenerów na statku" + conteners ;
    }

}