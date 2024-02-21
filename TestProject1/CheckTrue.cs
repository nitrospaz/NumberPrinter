using ConsoleApp2;

namespace TestProject1
{
    [TestClass]
    public class CheckTrue
    {
        [TestMethod]
        public void TestMethod2()
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
                Assert.IsTrue(result.Contains("Walker"));
                Assert.IsTrue(result.Contains("Crystal"));
                Assert.IsTrue(result.Contains("Walker Crystal"));
                // check result has 100 lines
                var lines = result.Split(Environment.NewLine);
                Assert.AreEqual(100, lines.Length);
                // spot check
                // check line 3 is walker
                Assert.AreEqual("Walker", lines[2]);
                // check line 75 is Walker Crystal
                Assert.AreEqual("Walker Crystal", lines[74]);
                // check line 100 is Crystal
                Assert.AreEqual("Crystal", lines[99]);
                // check line 1 is 1
                Assert.AreEqual("1", lines[0]);
                // check line 16 is 16
                Assert.AreEqual("16", lines[15]);
            }
        }
    }
}