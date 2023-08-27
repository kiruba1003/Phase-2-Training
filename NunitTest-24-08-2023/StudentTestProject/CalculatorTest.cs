using ConsoleApp1;

namespace StudTestProject
{
    public class CalculatorTest
    {

        Calculator calculator = new Calculator();

        [SetUp]//commmon thing
        public void Setup()
        {
        }

        [Test]//test case
        public void Test1()
        {
            int ans=calculator.add(1, 2);
            Assert.AreEqual(3, ans);
        }
        [Test]
        public void Test2()
        {
            int ans = calculator.sub(2,1);
            Assert.AreEqual(1, ans);
        }
    }
}