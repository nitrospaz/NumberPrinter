using ConsoleApp2;

namespace TestProject1
{
    [TestClass]
    public class CheckFalse
    {
        [TestMethod]
        public void TestMethod1()
        {
            var numberWordPairs = new Dictionary<int, string>
            {
                { 3, "Walker" },
                { 5, "Crystal" }
            };

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                NumberPrinter.PrintNumbers(100, numberWordPairs);

                var result = sw.ToString().Trim();
                // check result does not contain 15, 100, 45 or 33
                Assert.IsFalse(result.Contains("15"));
                Assert.IsFalse(result.Contains("100"));
                Assert.IsFalse(result.Contains("45"));
                Assert.IsFalse(result.Contains("33"));
            }
        }
    }
}