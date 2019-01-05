using NUnit.Framework;

namespace YuMi.NieRexper.Tests
{
    [TestFixture]
    public class ExperienceFactoryTests
    {
        [Test]
        public void ProvideLevel1_CorrectExpIsReturned_True()
        {
            Assert.AreEqual(0, ExperienceFactory.FromLevel((Level) 1).Points);
        }

        [Test]
        public void ProvideLevel10_CorrectExpIsReturned_True()
        {
            Assert.AreEqual(3184, ExperienceFactory.FromLevel((Level) 10).Points);
        }

        [Test]
        public void ProvideLevel25_CorrectExpIsReturned_True()
        {
            Assert.AreEqual(34493, ExperienceFactory.FromLevel((Level) 25).Points);
        }

        [Test]
        public void ProvideLevel50_CorrectExpIsReturned_True()
        {
            Assert.AreEqual(209127, ExperienceFactory.FromLevel((Level) 50).Points);
        }

        [Test]
        public void ProvideLevel75_CorrectExpIsReturned_True()
        {
            Assert.AreEqual(600135, ExperienceFactory.FromLevel((Level) 75).Points);
        }

        [Test]
        public void ProvideLevel99_CorrectExpIsReturned_True()
        {
            Assert.AreEqual(1235211, ExperienceFactory.FromLevel((Level) 99).Points);
        }
    }
}