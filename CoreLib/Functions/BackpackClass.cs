namespace CoreLib;

public class Backpack(int maxItems)
    {
        // Characteristics of the backpack
        public string Color { get; set; }
        public string Brand { get; set; }
        public string Manufacturer { get; set; }
        public string Fabric { get; set; }
        public double Weight { get; set; }
        public double Capacity { get; set; }
        private Item[] contents = new Item[maxItems];
        private int itemCount = 0;

        // Event for adding an item
        public event Action<Item> ItemAdded;

        // Method to add an item to the backpack
        public void AddItem(Item item)
        {
            if (GetTotalVolume() + item.Volume > Capacity)
            {
                throw new InvalidOperationException("Adding this item would exceed the backpack's capacity.");
            }

            if (itemCount >= contents.Length)
            {
                throw new InvalidOperationException("Backpack is full.");
            }

            contents[itemCount] = item;
            itemCount++;
            ItemAdded?.Invoke(item);
        }

        // Method to get the total volume of items in the backpack
        public double GetTotalVolume()
        {
            double totalVolume = 0;
            for (int i = 0; i < itemCount; i++)
            {
                totalVolume += contents[i].Volume;
            }
            return totalVolume;
        }

        public override string ToString()
        {
            return $"Backpack (Color: {Color}, Brand: {Brand}, Manufacturer: {Manufacturer}, Fabric: {Fabric}, Weight: {Weight}kg, Capacity: {Capacity}L, Contents: {itemCount} items)";
        }
    }

    public class Item
    {
        public string Name { get; set; }
        public double Volume { get; set; } // Volume in liters

        public Item(string name, double volume)
        {
            Name = name;
            Volume = volume;
        }

        public override string ToString()
        {
            return $"{Name} ({Volume}L)";
        }
    }

