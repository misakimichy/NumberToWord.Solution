using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using NumberToWord.Models;

namespace NumberToWord.Test
{
    [TestClass]
    public class TranslatorTests : IDisposable
    {
        public void Disposable()
        {
            Translator.Output = "";
        }

        [TestMethod]
        public void CheckZero__ZeroToWord_Zero()
        {
            Translator tranlatorTest = new Translator(0);
            Assert.AreEqual(true, Translator.CheckZero(Translator.input));
        }

    }
}