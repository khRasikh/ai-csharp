public class Computer
{
    // Properties with access modifiers
    public string Brand { get; private set; }      // read-only outside class
    public string Processor { get; private set; }  // read-only outside class
    protected int RAM { get; set; }                // accessible in derived classes

    // Constructor
    public Computer(string brand, string processor, int ram)
    {
        Brand = brand;
        Processor = processor;
        RAM = ram;
    }

    // Method to display basic info
    public string GetSpecs()
    {
        return $"{Brand} with {Processor} processor and {RAM}GB RAM";
    }

    // String representation
    public override string ToString()
    {
        return GetSpecs();
    }
}

// Derived class (Inheritance)
public class Laptop : Computer
{
    public double Weight { get; set; } // weight in kg

    // Constructor calling base class constructor
    public Laptop(string brand, string processor, int ram, double weight)
        : base(brand, processor, ram)
    {
        Weight = weight;
    }

    // Override ToString method
    public override string ToString()
    {
        return $"{base.ToString()}, Weight: {Weight}kg";
    }
}

// Another derived class
public class Desktop : Computer
{
    public bool HasDedicatedGPU { get; set; }

    public Desktop(string brand, string processor, int ram, bool hasDedicatedGPU)
        : base(brand, processor, ram)
    {
        HasDedicatedGPU = hasDedicatedGPU;
    }

    public override string ToString()
    {
        string gpuInfo = HasDedicatedGPU ? "with dedicated GPU" : "without dedicated GPU";
        return $"{base.ToString()}, {gpuInfo}";
    }
}
