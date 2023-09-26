namespace TemplateDesignPattern.Templates;

internal abstract class HotBeverageTemplate
{
    public void PrepareBeverage()
    {
        BoilWater();
        Brew();
        PourInCup();
        AddCondiments();
    }

    protected abstract void Brew();

    protected abstract void AddCondiments();

    private static void BoilWater()
    {
        Console.WriteLine("Boiling water");
    }

    private static void PourInCup()
    {
        Console.WriteLine("Pouring into cup");
    }
}
