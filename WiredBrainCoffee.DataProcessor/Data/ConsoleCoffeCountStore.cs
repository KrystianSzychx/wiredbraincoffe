using WiredBrainCoffee.DataProcessor.Model;

namespace WiredBrainCoffee.DataProcessor.Data
{
    public class ConsoleCoffeCountStore : ICoffeCountStore
    {
        private readonly TextWriter _testWriter;

        public ConsoleCoffeCountStore() : this(Console.Out) { }

        public ConsoleCoffeCountStore(TextWriter textWriter)
        {
            _testWriter = textWriter;
        }

        public void Save(CoffeCountItem item)
        {
            var line = $"{item.CoffeeType}:{item.Count}";
            _testWriter.WriteLine(line); ;
        }
    }
}
