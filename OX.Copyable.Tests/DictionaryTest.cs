﻿using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OX.Copyable.Tests
{
    [TestClass]
    public class DictionaryTest
    {
        [TestMethod]
        public void DictionaryIsCopied()
        {
            Dictionary<int, Exception> dict = new Dictionary<int, Exception>
            {
                { 0, new Exception("Test") }
            };

            Dictionary<int, Exception> copy = (Dictionary<int, Exception>)dict.Copy();

            Assert.AreNotSame(copy[0], dict[0]);

            Assert.AreEqual(copy[0].Message, dict[0].Message);
        }
    }
}
