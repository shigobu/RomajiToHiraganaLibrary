using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string temp = RomajiToHiraganaLibrary.RomajiToHiragana.Convert("shigobu");
            Assert.AreNotSame(temp, "しごぶ", "ローマ字置換失敗");
        }
    }
}