namespace Conteners;

public class liquidConteners : Contener, IHazardNotifier
{
     public bool isDangerous{get;internal set;}
    

     public void Notify(string id)
     {
          Console.WriteLine($"[ALERT] Danger! Contener ID: {id}");
     }
     public liquidConteners(double loadedWeight, double high, double ownWeight, double deep, string id, float maxWeight, bool isDangerous)
          : base(loadedWeight, high, ownWeight, deep, id, maxWeight)
     {
          this.isDangerous = isDangerous;
     }


     public void loadingLiquidContener()
     {
          double maxLoad = 0.5 * maxWeight;
          double maxLoad2 = 0.9 * maxWeight;
          if (isDangerous)
          {
               if (loadedWeight > maxLoad)
               {
                    Notify(id + " is dangerous");
               }

               load(maxLoad);
               if (loadedWeight > maxLoad2)
               {
                    Notify(id + " is dangerous");
               }

               load(maxLoad2);
          }
     }

     public override string ToString()
     {
          return $"Liquid Contener ID: {id}, Loaded Weight: {loadedWeight}, Max Weight: {maxWeight}, Is Dangerous: {isDangerous}";
     }
}