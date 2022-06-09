using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convert_Tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 参照ボタン押下時の処理
        /// ファイルパスをテキストボックスに表示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reference_btn_Click(object sender, EventArgs e)
        {
            path_textBox.Text = Utils.Selected_textfile();
        }

        /// <summary>
        /// ドラッグドロップの有効化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void path_textBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        /// <summary>
        /// ドラッグドロップされたファイルパスを受け取る
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void path_textBox_DragDrop(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.FileDrop)) return;

            // 渡されたファイルに対して処理を行う
            string[] dragFilePathArr = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            path_textBox.Text = dragFilePathArr[0];
        }

        /// <summary>
        /// CSV出力ボタンの処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void csv_output_btn_Click(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// テキストファイル出力ボタンの処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_output_btn_Click(object sender, EventArgs e)
        {
            if (isInputError()) return;
            convert_text();
        }

        /// <summary>
        /// 入力が正しいか判定
        /// </summary>
        /// <returns></returns>
        private Boolean isInputError()
        {
            if (string.IsNullOrEmpty(path_textBox.Text))
            {
                MessageBox.Show("ファイルが選択されていません。", "ロードエラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        /// <summary>
        /// ファイルを読み込み変換する
        /// </summary>
        private void convert_text()
        {
            StreamReader sr = new StreamReader(path_textBox.Text);
            string str = "";          
            int counter = 1;
            Regex reg = new Regex("([0-9]{2})([0-9]{2})([0-9]{2})([0-9]{2})");

            while (sr.EndOfStream == false)
            {
                str += counter + "\r\n";
                string[] number_str = sr.ReadLine().Split(' ');

                var lineStr = new List<string>() {};
                foreach (string numStr in number_str)
                {
                    Match match = reg.Match(numStr);
                    if (match.Success == true)
                    {
                        string timeStr = "";
                        timeStr += match.Groups[1].Value.Trim() + ":"
                            + match.Groups[2].Value.Trim() + ":"
                            + match.Groups[3].Value.Trim();
                        double num = Int32.Parse(match.Groups[4].Value.Trim());
                        num = Math.Round(num / 60, 3, MidpointRounding.AwayFromZero) % 1 * 1000;
                        timeStr += "," + num;
                        lineStr.Add(timeStr);
                    }
                }

                str += String.Join("->", lineStr);

                str += "\r\n" + "\r\n";
                counter++;
            }
            Result_Text.Text = str;
        }
    }
}
