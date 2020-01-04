using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NumberToWord.Models;

namespace NumberToWord.Test
{
    [TestClass]
    public class TranslatorTests : IDisposable
    {
        public void Dispose()
        {
            Translator.Output = "";
        }

        [TestMethod]
        public void CheckZero_ZeroToWord_Zero()
        {
            Translator.Input = 0;
            Assert.AreEqual(true, Translator.CheckZero(Translator.Input));
        }

    }
}