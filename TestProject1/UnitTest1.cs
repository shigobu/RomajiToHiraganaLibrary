using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("Shigobu", "しごぶ")]
        [DataRow("konnnitiwa", "こんにちわ")]
        [DataRow("しごぶShigobu", "しごぶしごぶ")]
        [DataRow("こんにちわkonnnitiwa", "こんにちわこんにちわ")]
        [DataRow("やゆよ", "やゆよ")]
        public void TestMethod1(string romaji, string hiragana)
        {
            string temp = RomajiToHiraganaLibrary.RomajiToHiragana.Convert(romaji);
            Assert.AreEqual(temp, hiragana, "ローマ字置換失敗");
        }
    }
}