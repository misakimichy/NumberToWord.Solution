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

        [TestMethod]
        public void Convert_SingleDigitNumberToWord_Three()
        {
            Translator.Input = 3;
            Assert.AreEqual("Three", Translator.Convert(Translator.Input));
        }

        [TestMethod]
        public void Convert_TeensToWord_Fifteen()
        {
            Translator.Input = 15;
            Assert.AreEqual("Fifteen", Translator.Convert(Translator.Input));
        }

        [TestMethod]
        public void Convert_10sToWord_Sixty()
        {
            Translator.Input = 60;
            Assert.AreEqual("Sixty", Translator.Convert(Translator.Input));
        }

        [TestMethod]
        public void Convert_LessThan100ToWord_SixtyEight()
        {
            Translator.Input = 68;
            Assert.AreEqual("Sixty Eight", Translator.Convert(Translator.Input));
        }

        [TestMethod]
        public void Convert_100sToWord_TwoHundred()
        {
            Translator.Input = 200;
            Assert.AreEqual("Two Hundred", Translator.Convert(Translator.Input));
        }

        [TestMethod]
        public void Convert_LessThan1000ToWord_TwoHundred()
        {
            Translator.Input = 123;
            Assert.AreEqual("One Hundred Twenty Three", Translator.Convert(Translator.Input));
        }

        [TestMethod]
        public void Convert_1000sToWord_FiveThousand()
        {
            Translator.Input = 5000;
            Assert.AreEqual("Five Thousand", Translator.Convert(Translator.Input));
        }

        [TestMethod]
        public void Convert_LessThan10000ToWord_FiveThousand()
        {
            Translator.Input = 5678;
            Assert.AreEqual("Five Thousand Six Hundred Seventy Eight", Translator.Convert(Translator.Input));
        }

        // [TestMethod]
        // public void Convert_10000sToWord_TenThousand()
        // {
        //     Translator.Input = 10000;
        //     Assert.AreEqual("Ten Thousand", Translator.Convert(Translator.Input));
        // }
    }
}