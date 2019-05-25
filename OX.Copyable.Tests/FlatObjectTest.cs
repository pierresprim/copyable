namespace OX.Copyable.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    class JustNumbersDefault
    {
        public JustNumbersDefault()
        {
            TheA = 0;
            TheB = 0.0f;
        }

        public int TheA { get; set; }

        public float TheB { get; set; }
    }

    class JustNumbers
    {
        public JustNumbers(int a, float b)
        {
            TheA = a;
            TheB = b;
        }

        public int TheA { get; }

        public float TheB { get; }
    }

    class CopyableNumbers : Copyable
    {
        public CopyableNumbers(int a, float b)
            : base(a, b)
        {
            TheA = a;
            TheB = b;
        }

        public int TheA { get; }

        public float TheB { get; }
    }

    [TestClass]
    public class FlatObjectTest
    {
        [TestMethod]
        public void CopyableFlatObjectIsCopied()
        {
            CopyableNumbers n = new CopyableNumbers(3, 4.0f);
            CopyableNumbers c = (CopyableNumbers)n.Copy();
            Assert.AreNotSame(n, c);
            Assert.AreEqual(n.TheA, c.TheA);
            Assert.AreEqual(n.TheB, c.TheB);
        }

        [TestMethod]
        public void RegularObjectWithoutDefaultConstructorIsCopied()
        {
            JustNumbers n = new JustNumbers(3, 4.0f);
            JustNumbers c = (JustNumbers)n.Copy(new JustNumbers(0, 0));
            Assert.AreNotSame(n, c);
            Assert.AreEqual(n.TheA, c.TheA);
            Assert.AreEqual(n.TheB, c.TheB);
        }

        [TestMethod]
        public void RegularObjectWithDefaultConstructorIsCopied()
        {
            JustNumbersDefault n = new JustNumbersDefault();
            n.TheA = 3;
            n.TheB = 4.0f;
            JustNumbersDefault c = (JustNumbersDefault)n.Copy(new JustNumbersDefault());
            Assert.AreNotSame(n, c);
            Assert.AreEqual(n.TheA, c.TheA);
            Assert.AreEqual(n.TheB, c.TheB);
        }
    }
}
