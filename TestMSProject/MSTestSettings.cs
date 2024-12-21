[assembly: Parallelize(Scope = ExecutionScope.MethodLevel)]
namespace TestMSProject
{
    [TestClass]
    public class MSTestSettings
    {
        [TestMethod]
        public void TestMethodAdd()
        {
            int a = 1;
            int b = 2;
            int expected = 3;
            int result = CoreLib.BaceClass.Add(a, b);
            Assert.AreEqual(expected, result);
        }
    }
}

 
