using CoreLib;

namespace TestMSProject;

[TestClass]
public sealed class MainTest
{
    [TestMethod]
    public void TestMethodRGB()//ex-1
    {
        var expected = (255, 0, 0);
        var actual = RGBClass.GetRgbValue("red");
        Assert.AreEqual(expected, actual);
    }
    
    [TestClass]
    public class BackpackTests//ex-2
    {

        [TestMethod]
        public void AddItem_ShouldThrowException_WhenCapacityIsExceeded()
        {
            // Arrange
            var backpack = new Backpack(5)
            {
                Color = "Blue",
                Brand = "Adventure",
                Manufacturer = "OutdoorGear",
                Fabric = "Nylon",
                Weight = 1.5,
                Capacity = 10 // Capacity in liters
            };
            backpack.AddItem(new Item("Sleeping Bag", 9.0));

            // Act and Assert
            Assert.ThrowsException<InvalidOperationException>(() => backpack.AddItem(new Item("Tent", 2.0)));
        }

        [TestMethod]
        public void AddItem_ShouldTriggerItemAddedEvent()
        {
            // Arrange
            var backpack = new Backpack(5)
            {
                Color = "Blue",
                Brand = "Adventure",
                Manufacturer = "OutdoorGear",
                Fabric = "Nylon",
                Weight = 1.5,
                Capacity = 25 // Capacity in liters
            };
            var item = new Item("Water Bottle", 1.0);
            bool eventTriggered = false;

            // Subscribe to the event
            backpack.ItemAdded += delegate (Item addedItem)
            {
                eventTriggered = true;
            };

            // Act
            backpack.AddItem(item);

            // Assert
            Assert.IsTrue(eventTriggered);
        }

        // Additional test to check the total volume calculation
        [TestMethod]
        public void GetTotalVolume_ShouldReturnCorrectVolume()
        {
            // Arrange
            var backpack = new Backpack(5)
            {
                Color = "Blue",
                Brand = "Adventure",
                Manufacturer = "OutdoorGear",
                Fabric = "Nylon",
                Weight = 1.5,
                Capacity = 25 // Capacity in liters
            };
            backpack.AddItem(new Item("Water Bottle", 1.0));
            backpack.AddItem(new Item("Sleeping Bag", 10.0));

            // Act
            double totalVolume = backpack.GetTotalVolume();

            // Assert
            Assert.AreEqual(11.0, totalVolume);
        }
    }
    
    [TestMethod]
    public void TestMethodMulpSeven()//ex-3
    {
        var numbers = new int[] { 7, 8,  14, 21, 22};
        var expected = 3;
        var actual = MultipleOfSevenClass.CountMultiplesOfSeven(numbers);
        Assert.AreEqual(expected, actual);
    }
    
    [TestMethod]
    public void TestMethodPositive()//ex-4
    {
        var numbers = new int[] { 1, -2, 2, 3, -5 };
        var expected = 3;
        var actual = NumPositiveClass.CountPositiveNumbers(numbers);
        Assert.AreEqual(expected, actual);
    }
    
    [TestMethod]
    public void TestMethodUnicNegat()//ex-5
    {
        var numbers = new int[] { 1, -2, 2, -3, 3, -5, -5 };
        var expected = 2;
        var actual = UnicNegatClass.UnicNegative(numbers);
        Assert.AreEqual(expected, actual);
    }
    
    [TestMethod]
    public void TestMethodWord()//ex-6
    {
        string text = "The quick brown fox jumps over the lazy dog.";
        string wordToFind = "fox";
        bool expected = true;
        var actual = WordInText.containsWord(text, wordToFind);
        Assert.AreEqual(expected, actual);
    }
}