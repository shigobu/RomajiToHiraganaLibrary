[![NuGet version (RomajiToHiraganaLibrary)](https://img.shields.io/nuget/v/RomajiToHiraganaLibrary.svg?style=flat-square)](https://www.nuget.org/packages/RomajiToHiraganaLibrary/)

# RomajiToHiraganaLibrary
与えられた文字列に含まれるローマ字をひらがなに置換します

## 使い方
```
string hoge = "shigobu";
hoge = RomajiToHiragana.Convert(hoge);
Console.WriteLine(hoge);    //出力:しごぶ
```

