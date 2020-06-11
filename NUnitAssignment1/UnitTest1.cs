using NUnit.Framework;
using QAAssignment1;

namespace NUnitAssignment1
{
    class UnitTest1
    {
        [Test]
        public void GetLength_IsTrue()
        {
            Rectangle rect = new Rectangle();
            Assert.AreEqual(1, rect.Length);
        }
        [Test]
        public void SetLength_IsTrue()
        {
            Rectangle rect = new Rectangle();
            Assert.AreEqual(5, rect.SetLength(5));
        }
        [Test]
        public void GetWidth_IsTrue()
        {
            Rectangle rect = new Rectangle();
            Assert.AreEqual(1, rect.Width);
        }
        [Test]
        public void SetWidth_IsTrue()
        {
            Rectangle rect = new Rectangle();
            Assert.AreEqual(10, rect.SetWidth(10));
        }
        [Test]
        public void FindPerimeter_IsTrue()
        {
            Rectangle rect = new Rectangle();
            rect.Length = 8;
            rect.Width = 8;
            Assert.AreEqual(32, rect.Getperimeter());
        }
        [Test]
        public void FindArea_IsTrue()
        {
            Rectangle rect = new Rectangle();
            rect.Length = 8;
            rect.Width = 8;
            Assert.AreEqual(64, rect.GetArea());
        }
        [Test]
        public void GetLength_IsFalse()
        {
            Rectangle rect = new Rectangle();
            Assert.AreEqual(1, rect.Length);
        }
        [Test]
        public void SetLength_IsFalse()
        {
            Rectangle rect = new Rectangle();
            Assert.AreEqual(5, rect.SetLength(5));
        }
        [Test]
        public void GetWidth_IsFalse()
        {
            Rectangle rect = new Rectangle();
            Assert.AreEqual(1, rect.Width);
        }
        [Test]
        public void SetWidth_IsFalse()
        {
            Rectangle rect = new Rectangle();
            Assert.AreEqual(5, rect.SetWidth(5));
        }
    }
}