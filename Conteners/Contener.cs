namespace Conteners
{
    public class Contener
    {
        public double loadedWeight { get; internal set; }
        public double high { get; internal set; }
        public double ownWeight { get; internal set; }
        public double deep { get; internal set; }
        public string id { get; internal set; }
        public float maxWeight { get; internal set; }

        public Contener(double loadedWeight, double high, double ownWeight, double deep, string id, float maxWeight)
        {
            this.loadedWeight = loadedWeight;
            this.high = high;
            this.ownWeight = ownWeight;
            this.deep = deep;
            this.id = id;
            this.maxWeight = maxWeight;
        }

        public static void empty(bool wantEmpty)
        {
            if (wantEmpty != false)
            {
                Console.WriteLine("Emptying");
            }

            Console.WriteLine("Dont want to empty");
        }

        public void load(double load)
        {
            if (loadedWeight > maxWeight)
            {
                throw new OverFillException("Overfill");
            }
            Console.WriteLine("Loaded Succsessfully");
        }
        public override string ToString()
        {
            return $"Contener ID: {id}, Loaded Weight: {loadedWeight}, Max Weight: {maxWeight}";
        }

        
    }
}