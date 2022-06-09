using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convert_Tool
{
    public static class Utils
    {
        public static string Selected_textfile()
        {
            // OpenFileDialogクラスのインスタンスを生成
            using (OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                FileName = "",
                Filter = "textファイル(*.txt)|*.txt",
                Title = "開くファイルを選択してください",
                RestoreDirectory = true
            })
            {
                // ダイアログを表示する
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    return openFileDialog.FileName;
                }
            }
            return "";
        }
    }
}
