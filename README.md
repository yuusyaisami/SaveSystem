# SaveSystem  
日本語の説明でごめんなさい  
C#での変数の値を、PC内に保存したいとき、セーブするシステムが必要です。  
単純に値を保存したいときは、textファイルに書き込むのが一般だと知られていますが、それがとてもめんどうなことも知られています。  
このSaveSystemでは変数の値を簡単にテキストファイルへ読み書きできるようにします。  
# 使い方  
SaveSystem/SaveSystem.csの中には二つのクラスがあります。閲覧してください  
DataStorageとFilecの二つありますこれはセーブの仕方が違います。  
DataStorageは私の推奨するセーブシステムです。  
DataStorageは保存する値に名前を付けることができ、敵の名前 : "Tanaka" このような保存方法をとります  
一方Filecは保存する値にインデックス(行番号)をなずけます。1 : "Tanaka" このような保存方法をとります  
DataStorageの中には関数があり、使えるのは WriteLine ReadLine DeleteLine ClearLineです  
### 関数  
WriteLine  :  データの書き込みを行う関数です  
ReadLine   :  データの読み取りを行う関数です  
DeleteLine :  データの削除を行う関数です  
ClearLine  :  テキストファイル内の、すべてのデータを削除する関数です  
# 最後に  
なにか問題があればmacaronkunkun@gmail.comまで  

