
namespace Convert_Tool
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.path_textBox = new System.Windows.Forms.TextBox();
            this.reference_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.csv_output_btn = new System.Windows.Forms.Button();
            this.txt_output_btn = new System.Windows.Forms.Button();
            this.Result_Text = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // path_textBox
            // 
            this.path_textBox.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.path_textBox.Location = new System.Drawing.Point(37, 35);
            this.path_textBox.Name = "path_textBox";
            this.path_textBox.Size = new System.Drawing.Size(556, 27);
            this.path_textBox.TabIndex = 0;
            this.path_textBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.path_textBox_DragDrop);
            this.path_textBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.path_textBox_DragEnter);
            // 
            // reference_btn
            // 
            this.reference_btn.Location = new System.Drawing.Point(481, 72);
            this.reference_btn.Name = "reference_btn";
            this.reference_btn.Size = new System.Drawing.Size(112, 39);
            this.reference_btn.TabIndex = 1;
            this.reference_btn.Text = "参照";
            this.reference_btn.UseVisualStyleBackColor = true;
            this.reference_btn.Click += new System.EventHandler(this.reference_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_output_btn);
            this.groupBox1.Controls.Add(this.csv_output_btn);
            this.groupBox1.Location = new System.Drawing.Point(37, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 86);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "出力";
            // 
            // csv_output_btn
            // 
            this.csv_output_btn.Location = new System.Drawing.Point(73, 22);
            this.csv_output_btn.Name = "csv_output_btn";
            this.csv_output_btn.Size = new System.Drawing.Size(118, 45);
            this.csv_output_btn.TabIndex = 0;
            this.csv_output_btn.Text = "CSV";
            this.csv_output_btn.UseVisualStyleBackColor = true;
            this.csv_output_btn.Click += new System.EventHandler(this.csv_output_btn_Click);
            // 
            // txt_output_btn
            // 
            this.txt_output_btn.Location = new System.Drawing.Point(213, 22);
            this.txt_output_btn.Name = "txt_output_btn";
            this.txt_output_btn.Size = new System.Drawing.Size(117, 44);
            this.txt_output_btn.TabIndex = 1;
            this.txt_output_btn.Text = "TXT";
            this.txt_output_btn.UseVisualStyleBackColor = true;
            this.txt_output_btn.Click += new System.EventHandler(this.txt_output_btn_Click);
            // 
            // Result_Text
            // 
            this.Result_Text.HideSelection = false;
            this.Result_Text.Location = new System.Drawing.Point(37, 230);
            this.Result_Text.Multiline = true;
            this.Result_Text.Name = "Result_Text";
            this.Result_Text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Result_Text.Size = new System.Drawing.Size(556, 300);
            this.Result_Text.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 554);
            this.Controls.Add(this.Result_Text);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reference_btn);
            this.Controls.Add(this.path_textBox);
            this.Name = "Form1";
            this.Text = "数字変換ツール";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox path_textBox;
        private System.Windows.Forms.Button reference_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button txt_output_btn;
        private System.Windows.Forms.Button csv_output_btn;
        private System.Windows.Forms.TextBox Result_Text;
    }
}