//factory method
/*public interface Car
{
    void DisplayInfo();
}

public class BMW3Series : Car
{
    private double engineVolume;
    private string driveType;

    public BMW3Series(double engineVolume, string driveType)
    {
        this.engineVolume = engineVolume;
        this.driveType = driveType;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"BMW 3 Series - executive car. Engine volume: {engineVolume}L, Drive type: {driveType}.");
    }
}

public class BMW5Series : Car
{
    private double engineVolume;
    private string driveType;

    public BMW5Series(double engineVolume, string driveType)
    {
        this.engineVolume = engineVolume;
        this.driveType = driveType;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"BMW 5 Series - mid-sized luxury car. Engine volume: {engineVolume}L, Drive type: {driveType}.");
    }
}

public class BMW7Series : Car
{
    private double engineVolume;
    private string driveType;

    public BMW7Series(double engineVolume, string driveType)
    {
        this.engineVolume = engineVolume;
        this.driveType = driveType;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"BMW 7 Series - full-sized luxury sedan. Engine volume: {engineVolume}L, Drive type: {driveType}.");
    }
}

public abstract class CarFactory
{
    public abstract Car CreateCar();
}

public class BMW3SeriesFactory : CarFactory
{
    private double engineVolume;
    private string driveType;

    public BMW3SeriesFactory(double engineVolume, string driveType)
    {
        this.engineVolume = engineVolume;
        this.driveType = driveType;
    }

    public override Car CreateCar()
    {
        return new BMW3Series(engineVolume, driveType);
    }
}

public class BMW5SeriesFactory : CarFactory
{
    private double engineVolume;
    private string driveType;

    public BMW5SeriesFactory(double engineVolume, string driveType)
    {
        this.engineVolume = engineVolume;
        this.driveType = driveType;
    }

    public override Car CreateCar()
    {
        return new BMW5Series(engineVolume, driveType);
    }
}

public class BMW7SeriesFactory : CarFactory
{
    private double engineVolume;
    private string driveType;

    public BMW7SeriesFactory(double engineVolume, string driveType)
    {
        this.engineVolume = engineVolume;
        this.driveType = driveType;
    }

    public override Car CreateCar()
    {
        return new BMW7Series(engineVolume, driveType);
    }
}
class Program
{
    static void Main(string[] args)
    {
        CarFactory factory = new BMW3SeriesFactory(2.0, "RWD");
        Car car3Series = factory.CreateCar();
        car3Series.DisplayInfo();

        factory = new BMW5SeriesFactory(3.0, "AWD");
        Car car5Series = factory.CreateCar();
        car5Series.DisplayInfo();

        factory = new BMW7SeriesFactory(4.4, "AWD");
        Car car7Series = factory.CreateCar();
        car7Series.DisplayInfo();
    }
}*/

//composite
public interface UniversityComponent
{
    void DisplayInformation();
}

public class Faculty : UniversityComponent
{
    private List<UniversityComponent> components = new List<UniversityComponent>();
    public string Name { get; }

    public Faculty(string name)
    {
        Name = name;
    }

    public void AddComponent(UniversityComponent component)
    {
        components.Add(component);
    }

    public void RemoveComponent(UniversityComponent component)
    {
        components.Remove(component);
    }

    public void DisplayInformation()
    {
        Console.WriteLine("Faculty: " + Name);
        foreach (var component in components)
        {
            component.DisplayInformation();
        }
    }
}

public class Teacher : UniversityComponent
{
    public string Name { get; }
    public string Title { get; }

    public Teacher(string name, string title)
    {
        Name = name;
        Title = title;
    }

    public void DisplayInformation()
    {
        Console.WriteLine($"Teacher: {Name}, Title: {Title}");
    }
}