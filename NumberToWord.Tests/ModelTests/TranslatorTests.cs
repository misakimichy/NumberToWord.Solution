using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using NumberToWord.Models;

namespace NumberToWord.Test
{
    [TestClass]
    public class TranslatorTests
    {
        [TestMethod]
        public void Word_TranslateInWordMethodReturnsString_String()
        {
            Assert.AreEqual("", Translator.TranslateInWord(123));
        }
    }
}