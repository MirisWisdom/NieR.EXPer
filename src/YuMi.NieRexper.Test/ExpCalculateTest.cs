using Microsoft.VisualStudio.TestTools.UnitTesting;
using YuMi.NieRexper.Calculation;

namespace YuMi.NieRexper.Test
{
    [TestClass]
    public class ExpCalculateTest
    {
        [TestMethod]
        public void ProvideLevel1_CorrectExpIsReturned_True()
        {
            Assert.IsTrue(new ExpCalculator().Calculate(1) == 0);
        }

        [TestMethod]
        public void ProvideLevel10_CorrectExpIsReturned_True()
        {
            Assert.IsTrue(new ExpCalculator().Calculate(10) == 3184);
        }

        [TestMethod]
        public void ProvideLevel25_CorrectExpIsReturned_True()
        {
            Assert.IsTrue(new ExpCalculator().Calculate(25) == 34493);
        }

        [TestMethod]
        public void ProvideLevel50_CorrectExpIsReturned_True()
        {
            Assert.IsTrue(new ExpCalculator().Calculate(50) == 209127);
        }

        [TestMethod]
        public void ProvideLevel75_CorrectExpIsReturned_True()
        {
            Assert.IsTrue(new ExpCalculator().Calculate(75) == 600135);
        }

        [TestMethod]
        public void ProvideLevel99_CorrectExpIsReturned_True()
        {
            Assert.IsTrue(new ExpCalculator().Calculate(99) == 1235211);
        }
    }
}
