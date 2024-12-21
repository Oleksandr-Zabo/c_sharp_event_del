namespace TestMSProject;

[TestClass]
public sealed class MainTest
{
    [TestMethod]//ex-1
    public void TestMethodEven()
    {
        int number = 2;
        bool expected = true;
        bool result = CoreLib.Even_method.IsEven(number);
        Assert.AreEqual(expected, result);
    }
    
    [TestMethod]//ex-2
    public void TestMethodSquare()
    {
        int number = 3;
        int expected = 9;
        int result = CoreLib.Square_method.Square(number);
        Assert.AreEqual(expected, result);
    }
    
    [TestMethod]//ex-3
    public void TestMethodCube()
    {
        int number = 3;
        int expected = 27;
        int result = CoreLib.CubeClass.Cube(number);
        Assert.AreEqual(expected, result);
    }
    
    [TestMethod]//ex-4
    public void TestMethodProgrammer_day()
    {
        DateTime date = new DateTime(2023, 9, 13);
        bool expected = true;
        bool result = CoreLib.Programmer_day.isDayOfYear256(date);
        Assert.AreEqual(expected, result);
    }
    
    [TestMethod]//ex-5
    public void TestMethodFindMax()
    {
        int[] numbers = new int[] { 1, 2, 5, 4, 3 };
        int expected = 5;
        int result = CoreLib.FindMaxArrClass.FindMax(numbers);
        Assert.AreEqual(expected, result);
    }
    
    [TestMethod]//ex-6
    public void TestMethodFindMin()
    {
        int[] numbers = new int[] { 2, 1, 5, 4, 3 };
        int expected = 1;
        int result = CoreLib.FindMinArrClass.FindMin(numbers);
        Assert.AreEqual(expected, result);
    }
    
    [TestMethod]//ex-7
    public void TestMethodFindOdd()
    {
        int[] numbers = new int[] { 2, 1, 5, 4, 3 };
        int[] expected = new int[] {1, 5, 3 };
        int[] result = CoreLib.FindOddArrClass.findOddNumbers(numbers);
        CollectionAssert.AreEqual(expected, result);//CollectionAssert.AreEqual- compares two collections for equivalence
    }
    
    [TestMethod]//test-neg
    public void TestMethodFindNeg()
    {
        int[] numbers = new int[] { 2, 1, -5, -4, 3 };
        int[] expected = new int[] {-5, -4 };
        int[] result = CoreLib.FindNegateArrClass.FindNegate(numbers);
        CollectionAssert.AreEqual(expected, result);//CollectionAssert.AreEqual- compares two collections for equivalence
    }
}