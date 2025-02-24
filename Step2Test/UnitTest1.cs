using NUnit.Framework;

public class GameLevelCalculatorTests
{
    [TestFixture]
    public class CalculateActualLevelTests
    {
        [Test]
        public void CalculateActualLevel_DisplayedLevelIs350_Returns350()
        {
            Assert.That(GameLevelCalculator.CalculateActualLevel(350), Is.EqualTo(350));
        }

        [Test]
        public void CalculateActualLevel_DisplayedLevelIs351_Returns100()
        {
            Assert.That(GameLevelCalculator.CalculateActualLevel(351), Is.EqualTo(100));
        }

        [Test]
        public void CalculateActualLevel_DisplayedLevelIs352_Returns101()
        {
            Assert.That(GameLevelCalculator.CalculateActualLevel(352), Is.EqualTo(101));
        }

        [Test]
        public void CalculateActualLevel_DisplayedLevelIs400_Returns149()
        {
            Assert.That(GameLevelCalculator.CalculateActualLevel(400), Is.EqualTo(149));
        }

        [Test]
        public void CalculateActualLevel_DisplayedLevelIs150_Returns150()
        {
            Assert.That(GameLevelCalculator.CalculateActualLevel(150), Is.EqualTo(150));
        }

        [Test]
        public void CalculateActualLevel_DisplayedLevelIs1000351_Returns116()
        {
            Assert.That(GameLevelCalculator.CalculateActualLevel(1000351), Is.EqualTo(116));
        }

        [Test]
        public void CalculateActualLevel_DisplayedLevelIs1000352_Returns117()
        {
            Assert.That(GameLevelCalculator.CalculateActualLevel(1000352), Is.EqualTo(117));
        }

        [Test]
        public void CalculateActualLevel_DisplayedLevelIs1000601_Returns115()
        {
            Assert.That(GameLevelCalculator.CalculateActualLevel(1000601), Is.EqualTo(115));
        }
    }
}