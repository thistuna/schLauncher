# schLauncher

schLauncherは，同じ.sch拡張子をつけているEagleとKiCad EEschemaのランチャーです．
このランチャーを介してschファイルを開くことで，自動でEagleかKiCad EEschemaのどちらかを呼び出します．

# 使い方

schLauncher.exeをダブルクリックで起動します．
すると，設定画面が出るので，KiCadのeeschema.exeとEagleのeagle.exeのパスを設定してOKボタンを押してください．

![SchLauncherSetting](https://user-images.githubusercontent.com/20456614/78452103-4adebb80-76c4-11ea-8f6c-f5996cca615d.png)

あとは，schLauncher.exeをschに関連付けるなり，コマンドラインからschLauncher.exe (回路図のファイル名)で起動するなり，
schLauncher.exeに回路図ファイルをドラッグ・アンド・ドロップすれば起動します．

# ダウンロード

<a href="https://github.com/thistuna/schLauncher/releases">Release</a>からどうぞ．

# 開発環境

Microsoft Visual Studio 2019 Community
