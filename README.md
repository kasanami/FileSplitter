ファイルを分割するコンソールアプリ

引数
---
FileSplitter.exe <元のファイルのパス> <分割サイズ>

使用例
---
FileSplitter.exe Test.txt 4

Test.txtが11バイトのとき、同じフォルダに以下のファイルが作成される。
* Test.txt.part1 ・・・ 4バイト
* Test.txt.part2 ・・・ 4バイト
* Test.txt.part3 ・・・ 3バイト
