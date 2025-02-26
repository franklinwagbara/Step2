using System;
using NUnit.Framework;

public class LevelCalculatorTests
{
    [TestFixture]
    public class CalculateActualLevelTests
    {
        [Test]
        public void CalculateActualLevel_Level350_Returns350()
        {
            Assert.That(LevelCalculator.CalculateActualLevel(350), Is.EqualTo(350));
        }

        [Test]
        public void CalculateActualLevel_Level351_Returns100()
        {
            Assert.That(LevelCalculator.CalculateActualLevel(351), Is.EqualTo(100));
        }

        [Test]
        public void CalculateActualLevel_Level352_Returns101()
        {
            Assert.That(LevelCalculator.CalculateActualLevel(352), Is.EqualTo(101));
        }

        [Test]
        public void CalculateActualLevel_Level400_Returns149()
        {
            Assert.That(LevelCalculator.CalculateActualLevel(400), Is.EqualTo(149));
        }

        [Test]
        public void CalculateActualLevel_Level150_Returns150()
        {
            Assert.That(LevelCalculator.CalculateActualLevel(150), Is.EqualTo(150));
        }

        [Test]
        public void CalculateActualLevel_Level1000351_Returns100()
        {
            Assert.That(LevelCalculator.CalculateActualLevel(1000351), Is.EqualTo(100));
        }

        [Test]
        public void CalculateActualLevel_Level1000352_Returns101()
        {
            Assert.That(LevelCalculator.CalculateActualLevel(1000352), Is.EqualTo(101));
        }

        [Test]
        public void CalculateActualLevel_Level1000601_Returns115()
        {
            Assert.That(LevelCalculator.CalculateActualLevel(1000601), Is.EqualTo(115));
        }

        [Test]
        public void CalculateActualLevel_NegativeLevel_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => LevelCalculator.CalculateActualLevel(-1));
        }

        [Test]
        public void CalculateActualLevel_Level601_Returns115()
        {
            Assert.That(LevelCalculator.CalculateActualLevel(601), Is.EqualTo(115));
        }

        [Test]
        public void CalculateActualLevel_Level360_Returns109()
        {
            Assert.That(LevelCalculator.CalculateActualLevel(360), Is.EqualTo(109));
        }
    }
}