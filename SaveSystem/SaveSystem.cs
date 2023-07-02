using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveSystem
{
    public static class Filec
    {
        private static string[] save_data = new string[2048];
        /// <summary>
        /// ファイル内のラインを読み取る
        /// </summary>
        /// <param name="file_path">ファイルパス</param>
        /// <param name="line_index">読み取るラインの行を入力 0～2048</param>
        /// <returns></returns>
        public static string ReadLine(string file_path, int line_index)
        {

            if (File.Exists(file_path) == false)
            {
                using (FileStream fs = File.Create(file_path)) ;
            }
            int Readline = 0;
            string str = null;
            StreamReader sr = new StreamReader(file_path, Encoding.GetEncoding("UTF-8"));
            while (sr.Peek() != -1)
            {
                str = sr.ReadLine();
                if(Readline == line_index)
                {
                    break;
                }
                Readline++;
            }
            sr.Close();

            return str;
        }

        public static void WriteLine(string file_path, string writing_data, int line_index)
        {
            for(int i = 0; i < 2048; i++)
            {
                save_data[i] = "";
            }
            if (File.Exists(file_path) == false)
            {
                File.Create(file_path).Close();
            }
            int Readline = 0;
            StreamReader sr = new StreamReader(file_path, Encoding.GetEncoding("UTF-8"));
            while (sr.Peek() != -1)
            {
                save_data[Readline] = sr.ReadLine(); //ファイルの中身をsave_data配列にしまう
                Readline++;
            }
            sr.Close();

            save_data[line_index] = writing_data; //新しく書き入れるデータを入れる
            File.Delete(file_path); //ファイルの中身を消すために一度削除する
            File.Create(file_path).Close(); //再び作成

            StreamWriter sw = new StreamWriter(file_path);
            if(line_index > Readline)
            {
                Readline = line_index;
            }
            for (int i = 0; i < Readline + 1 ; i++)
            {
                sw.Write(save_data[i] + "\n");
            }
            sw.Close(); // StreamWriter を閉じる
        }
    }
}
