using System;
public abstract class ChrstTree
{
    public virtual string Decorate()
    {
        return "Ялинка в тiльтi";
    }
}

// Конкретний компонент
public class ChristmasTree : ChrstTree
{
    public override string Decorate()
    {
        return base.Decorate(); // повертає "Christmas tree"
    }
}

// Абстрактний декоратор
public abstract class TreeDecorator : ChrstTree
{
    protected ChrstTree tree;

    public TreeDecorator(ChrstTree tree)
    {
        this.tree = tree;
    }

    public override string Decorate()
    {
        // Делегування операції до об'єкта, який ми декоруємо
        return tree.Decorate();
    }
}

// Конкретний декоратор для прикрас
public class BallsDecorator : TreeDecorator
{
    public BallsDecorator(ChrstTree tree) : base(tree)
    {
    }

    public override string Decorate()
    {
        // Додавання нової поведінки
        return base.Decorate() + DecorateWithTinsel();
    }

    private string DecorateWithTinsel()
    {
        return " ,вже не в тiльтi, вона тепер крута з iграшками";
    }
}

// Конкретний декоратор для гірлянд
public class LightsDecorator : TreeDecorator
{
    public LightsDecorator(ChrstTree tree) : base(tree)
    {
    }

    public override string Decorate()
    {
        // Додавання нової поведінки
        return base.Decorate() + DecorateWithLights();
    }

    private string DecorateWithLights()
    {
        return " та ще й з гiрляндами";
    }
}
class Program
{
    static void Main()
    {
        ChrstTree tree = new ChristmasTree();
        Console.WriteLine(tree.Decorate());

        // Додавання прикрас на ялинку
        tree = new BallsDecorator(tree);
        Console.WriteLine(tree.Decorate());

        // Додавання гірлянд на ялинку
        tree = new LightsDecorator(tree);
        Console.WriteLine(tree.Decorate());
    }
}