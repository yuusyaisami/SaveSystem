/* example code
 * 作成者 : Yuisami
 * 概要   : SaveSystemの例
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaveSystem;

namespace SaveSystem
{
    internal class Example
    {
        static void Main(string[] args)
        {
            /*----------------WriteLine関数とReadLine関数について----------------------------------------------------------------------------------------------------------*/
            DataStorage.WriteLine("hello.txt", "なに", "1"); //name : なに    data : 2 をテキストに保存する
            DataStorage.WriteLine("hello.txt", "この数値は保存されます!", "そうなんだ!"); //name : この数値は保存されます!    data : そうなんだ! をテキストに保存する
            string str = DataStorage.ReadLine("hello.txt", "なに"); //なにという名前を探し、その中のデータを呼び出す
            Console.WriteLine(str);
            str = DataStorage.ReadLine("hello.txt", "この数値は保存されます!"); //この数値は保存されます!という名前を探し、その中のデータを呼び出す
            Console.WriteLine(str);
            /*-------------------Delete関数とClear関数について---------------------------------------------------------------------------------------------------------*/
            DataStorage.WriteLine("hello.txt", "消される!", "やめて!"); //消される!を作る
            DataStorage.DeleteLine("hello.txt", "消される!"); //消される!をけす
            str = DataStorage.ReadLine("hello.txt", "消される!");
            Console.WriteLine(str);

            DataStorage.WriteLine("hello.txt", "こん", "1");
            DataStorage.WriteLine("hello.txt", "にち", "2");
            DataStorage.WriteLine("hello.txt", "わ!!", "3");
            DataStorage.ClearLine("hello.txt"); //すべての保存されたデータと名前を消す
            Console.WriteLine(DataStorage.ReadLine("hello.txt", "この") + DataStorage.ReadLine("hello.txt", "にち") + DataStorage.ReadLine("hello.txt", "わ!!"));//削除されているから何も表示されない
            Console.ReadKey(); //wait
        }
    }
}
