// Създаваме нов автомобил
        Vehicle car = new Vehicle("Toyota", "Corolla", 120, "Червен");

        // Показваме информацията
        car.DisplayInfo();

        Console.WriteLine("\n-- След тунинг --");

        // Правим тунинг - променяме модел, скорост и цвят
        car.Tune("Supra", 250, "Черен");

        // Показваме отново информацията
        car.DisplayInfo();

internal class Vehicle
{
    private string _name;
    private string _model;
    private int _speed;
    private string _color;

    public string Name
    { get; set; }

    public string Model
    { get; set; }

    public int Speed
    { get { return _speed; }
        set {
            if (value > 0)
            {
                _speed = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("The Speed must be a positive number");
            }
        }
    }

    public string Color
    { get; set; }

    public Vehicle() 
    {
        _name = "";
        _model = "";
        _color = "";
        _speed = 0;
    }

    public Vehicle(string name, string model, int speed, string color)
    {
        _name = name;
        _model = model;
        _speed = speed;
        _color = color;
    }

    public void VehicleInfo()
    {
        Console.WriteLine("--Vehicle Info--\n");
        Console.WriteLine($"Vehicle name: {_name}");
        Console.WriteLine($"Vehicle model: {_model}");
        Console.WriteLine($"Vehicle speed: {_speed}");
        Console.WriteLine($"Vehicle color: {_color}");
    }

    
        public void Tune(string newModel, int newSpeed, string newColor)
    {
        _model = newModel;
        _speed = newSpeed;
        _color = newColor;
    }

}
