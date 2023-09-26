using TemplateDesignPattern.Templates;

HotBeverageTemplate tea = new Tea();
HotBeverageTemplate coffee = new Coffee();

Console.WriteLine("Making tea:");
tea.PrepareBeverage();

Console.WriteLine("\nMaking coffee:");
coffee.PrepareBeverage();

Console.ReadKey();