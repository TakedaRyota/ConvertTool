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
        /// テキストファイル出力ボタンの処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_output_btn_Click(object sender, EventArgs e)
        {
            if (isInputError()) return;
            string resultText = convert_text();
            if (resultText == "") return;
            DateTime dateTime = DateTime.Now;
            using (SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                FileName = "convert_text_" + dateTime.ToString("yyyyMMddHHmm"),
                Filter = "テキストファイル(*.txt)|*.txt",
                Title = "保存先のファイルを選択してください。",
                RestoreDirectory = true,
                OverwritePrompt = true,
                CheckPathExists = true
            })
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName, false, Encoding.UTF8))
                    {
                        streamWriter.Write(resultText);
                    }
                    MessageBox.Show("変換データの出力が完了しました。", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
            else if (!Path.GetExtension(path_textBox.Text).Equals(".txt"))
            {
                MessageBox.Show("txtファイルを選択してください。", "ロードエラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        /// <summary>
        /// ファイルを読み込み変換する
        /// </summary>
        private string convert_text()
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
                    else
                    {
                        MessageBox.Show("テキストの形式が異なります。", "フォーマットエラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return "";
                    }
                }

                str += String.Join("->", lineStr) + "\r\n";

                str += "\r\n\r\n";
                counter++;
            }
            return str;
        }
    }
}
