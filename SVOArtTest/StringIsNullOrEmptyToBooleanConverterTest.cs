using Microsoft.VisualStudio.TestTools.UnitTesting;
using SVOArt;

namespace SVOArtTest
{
    [TestClass]
    public class StringIsNullOrEmptyToBooleanConverterTest
    {
        StringIsNullOrEmptyToBooleanConverter _converter = new StringIsNullOrEmptyToBooleanConverter();

        [TestMethod]
        public void ConvertNullExpectsTrue()
        {
            Assert.IsTrue((bool)_converter.Convert(null, null, null, null));
        }

        [TestMethod]
        public void ConvertEmptyStringExpectsTrue()
        {
            Assert.IsTrue((bool)_converter.Convert(string.Empty, null, null, null));
        }

        [TestMethod]
        public void ConvertNotEmptyStringExpectsFalse()
        {
            Assert.IsFalse((bool)_converter.Convert("notEmpty", null, null, null));
        }
    }
}
