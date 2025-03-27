namespace Conteners;

public class coldContener : Contener
{
    public string productType{get; internal set;}
    public double temperature{get;internal  set;}
    public double productTemperature{get;internal  set;}
    
    public coldContener(double loadedWeight, double high, double ownWeight, double deep, string id, float maxWeight, double temperature, string productType)
        : base(loadedWeight, high, ownWeight, deep, id, maxWeight)
    {
        this.temperature = temperature;
        this.productType = productType;
    }


    public static Dictionary<string, double> prodcuts = new Dictionary<string, double>
    {
        { "Bananas", 13.3 },
        { "Chocolate", 18 },
        { "Fish", 2 },
        { "Meat", -15 },
        { "Ice cream", -18 },
        { "Frozen pizza", -30 },
        { "Cheese", 7.2 },
        { "Sausages", 5 },
        { "Butter", 20.5 },
        { "Eggs", 19 }
    };

    public void refContner(double temperature)
    {
        this.temperature = temperature;
    }

    public void loadProduct(string product, double loadWeight)
    {
        if (!prodcuts.ContainsKey(product))
        {
            throw new KeyNotFoundException("Product not found");
        }
        double reqTemp = prodcuts[product];
        if (temperature < reqTemp)
        {
            throw new Exception("Temperature out of range");
        }

        if (productType != null && productType != product)
        {
            throw new Exception("Contener can only have one product");
        }

        if (loadWeight > maxWeight)
        {
            throw new OverFillException("Overfill");
        }
        Console.WriteLine($"Loaded {loadWeight} kg of product: {product}.");
        
    }
    public override string ToString()
    {
        return $"Refrigerated Contener ID: {id}, Product: {productType}, Temp: {temperature}°C, Loaded Weight: {loadedWeight}, Max Weight: {maxWeight}";
    }
    
}