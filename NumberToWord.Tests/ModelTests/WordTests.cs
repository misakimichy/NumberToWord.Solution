using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using NumberToWord.Models;

namespace NumberToWord.Test
{
    [TestClass]
    public class WordTests
    {
        [TestMethod]
        public void Word_TranslateInWordMethodReturnsList_ListString()
        {
            List<string> returnWordList = new List<string>() {"one hundred twenty three"};
            Assert.AreEqual(returnWordList, Word.TranslateInWord());
        }
    }
}