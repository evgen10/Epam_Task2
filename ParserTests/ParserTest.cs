using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;                 
using Task2Library;    


namespace ParserTests
{
    [TestClass]
    public class ParserTest
    {           
        

        [TestMethod]
        public void WhenParse12345Expect12345()
        {
            //arange
            Parser parser = new Parser();
            string str = "12345";
            int expected = 12345;

            //act
            int actual = parser.ParseStringToInt(str);

            //assert 
            Assert.AreEqual(expected, actual);



        }

        [TestMethod]
        public void WhenParse__12345Expect12345()
        {
            //arange
            Parser parser = new Parser();
            string str = "  12345";
            int expected = 12345;

            //act
            int actual = parser.ParseStringToInt(str);

            //assert 
            Assert.AreEqual(expected, actual);



        }


        [TestMethod]
        public void WhenParse12345__Expect12345()
        {
            //arange
            Parser parser = new Parser();
            string str = "12345  ";
            int expected = 12345;

            //act
            int actual = parser.ParseStringToInt(str);

            //assert 
            Assert.AreEqual(expected, actual);



        }


        [TestMethod]   
        public void WhenParse__12345__Expect12345()
        {
            //arange
            Parser parser = new Parser();
            string str = "  12345  ";
            int expected = 12345;

            //act
            int actual = parser.ParseStringToInt(str);

            //assert 
            Assert.AreEqual(expected, actual);
            


        }
   

        [TestMethod]     
        public void WhenParse_012345_Expect12345()
        {
            //arange
            Parser parser = new Parser();
            string str = "012345";
            int expected = 12345;

            //act
            int actual = parser.ParseStringToInt(str);

            //assert 
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void WhenParse1_7ExpectExpectedException()
        {
            //arange
            Parser parser = new Parser();
            string str = "1 7";

            //act
            parser.ParseStringToInt(str);

            //assert exception           
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void WhenParse_ExpectExpectedException()
        {
            //arange
            Parser parser = new Parser();
            string str = "";

            //act
            parser.ParseStringToInt(str);

            //assert exception           
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void WhenParse____ExpectExpectedException()
        {
            //arange
            Parser parser = new Parser();
            string str = "    ";

            //act
            parser.ParseStringToInt(str);

            //assert exception           
        }


        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void WhenParse_25_f_ExpectExpectedException()
        {
            //arange
            Parser parser = new Parser();
            string str = "25 f";

            //act
            parser.ParseStringToInt(str);

            //assert exception           
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void WhenParse_k25_ExpectExpectedException()
        {
            //arange
            Parser parser = new Parser();
            string str = "k25";

            //act
            parser.ParseStringToInt(str);

            //assert exception           
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void WhenParse_25ff_ExpectExpectedException()
        {
            //arange
            Parser parser = new Parser();
            string str = "25ff";

            //act
            parser.ParseStringToInt(str);

            //assert exception           
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void WhenParse_555555555555555_ExpectExpectedException()
        {
            //arange
            Parser parser = new Parser();
            string str = "555555555555555";

            //act
            parser.ParseStringToInt(str);

            //assert exception           
        }



    }
}
