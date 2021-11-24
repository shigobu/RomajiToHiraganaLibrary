using System;

namespace RomajiToHiraganaLibrary
{
    class RomajiHiraganaPair
    {
        /// <summary>
        /// ローマ字とそれに対応するひらがなを指定して、オブジェクトを初期化します。
        /// </summary>
        /// <param name="romaji">ローマ字</param>
        /// <param name="hiragana">ひらがな</param>
        public RomajiHiraganaPair(string romaji, string hiragana)
        {
            Romaji = romaji ?? throw new ArgumentNullException(nameof(romaji));
            Hiragana = hiragana ?? throw new ArgumentNullException(nameof(hiragana));
        }

        /// <summary>
        /// ローマ字を取得、設定します。
        /// </summary>
        internal string Romaji { get; set; } = "";

        /// <summary>
        /// ひらがなを取得、設定します。
        /// </summary>
        internal string Hiragana { get; set; } = "";
    }
}
