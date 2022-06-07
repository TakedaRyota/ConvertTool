
namespace Convert_Tool
{
    partial class Confirm_Tool
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.path_text = new System.Windows.Forms.TextBox();
            this.file_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.text_output = new System.Windows.Forms.Button();
            this.csv_output = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // path_text
            // 
            this.path_text.Location = new System.Drawing.Point(51, 31);
            this.path_text.Name = "path_text";
            this.path_text.Size = new System.Drawing.Size(500, 25);
            this.path_text.TabIndex = 0;
            this.path_text.DragDrop += new System.Windows.Forms.DragEventHandler(this.path_text_DragDrop);
            // 
            // file_btn
            // 
            this.file_btn.Location = new System.Drawing.Point(568, 26);
            this.file_btn.Name = "file_btn";
            this.file_btn.Size = new System.Drawing.Size(100, 34);
            this.file_btn.TabIndex = 1;
            this.file_btn.Text = "参照";
            this.file_btn.UseVisualStyleBackColor = true;
            this.file_btn.Click += new System.EventHandler(this.file_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.csv_output);
            this.groupBox1.Controls.Add(this.text_output);
            this.groupBox1.Location = new System.Drawing.Point(33, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 102);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "出力";
            // 
            // text_output
            // 
            this.text_output.Location = new System.Drawing.Point(38, 37);
            this.text_output.Name = "text_output";
            this.text_output.Size = new System.Drawing.Size(106, 47);
            this.text_output.TabIndex = 0;
            this.text_output.Text = ".txt";
            this.text_output.UseVisualStyleBackColor = true;
            this.text_output.Click += new System.EventHandler(this.text_output_Click);
            // 
            // csv_output
            // 
            this.csv_output.Location = new System.Drawing.Point(178, 37);
            this.csv_output.Name = "csv_output";
            this.csv_output.Size = new System.Drawing.Size(106, 47);
            this.csv_output.TabIndex = 1;
            this.csv_output.Text = ".csv";
            this.csv_output.UseVisualStyleBackColor = true;
            this.csv_output.Click += new System.EventHandler(this.csv_output_Click);
            // 
            // Confirm_Tool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 182);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.file_btn);
            this.Controls.Add(this.path_text);
            this.Name = "Confirm_Tool";
            this.Text = "数字変換ツール";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox path_text;
        private System.Windows.Forms.Button file_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button csv_output;
        private System.Windows.Forms.Button text_output;
    }
}

