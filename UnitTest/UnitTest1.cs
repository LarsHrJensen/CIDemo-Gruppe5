namespace UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Calculator.Calculator TestCalculator = new ();


            Assert.Equal(4, TestCalculator.Add(2, 2));
            Assert.Equal(5, TestCalculator.Multiply(1, 5));
            Assert.Equal(2, TestCalculator.Divide(12, 6));
            Assert.Equal(3, TestCalculator.Subtract(5, 2));
            Assert.Null(TestCalculator.Divide(1, 0));


        }



    }
}
