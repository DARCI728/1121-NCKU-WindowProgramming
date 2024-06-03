namespace practice_7_2 {
    partial class SubForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            lblWord = new Label();
            btnShow = new Button();
            btnNext = new Button();
            chkCheak = new CheckBox();
            lblChinese = new Label();
            lblSpeech = new Label();
            SuspendLayout();
            // 
            // lblWord
            // 
            lblWord.AutoSize = true;
            lblWord.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblWord.Location = new Point(100, 100);
            lblWord.Name = "lblWord";
            lblWord.Size = new Size(45, 20);
            lblWord.TabIndex = 0;
            lblWord.Text = "單字:";
            lblWord.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnShow
            // 
            btnShow.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnShow.Location = new Point(650, 350);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(100, 30);
            btnShow.TabIndex = 1;
            btnShow.Text = "查看";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnNext
            // 
            btnNext.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNext.Location = new Point(650, 400);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(100, 30);
            btnNext.TabIndex = 2;
            btnNext.Text = "下一個";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // chkCheak
            // 
            chkCheak.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkCheak.Location = new Point(650, 300);
            chkCheak.Name = "chkCheak";
            chkCheak.Size = new Size(100, 30);
            chkCheak.TabIndex = 3;
            chkCheak.Text = "標記";
            chkCheak.UseVisualStyleBackColor = true;
            // 
            // lblChinese
            // 
            lblChinese.AutoSize = true;
            lblChinese.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblChinese.Location = new Point(100, 200);
            lblChinese.Name = "lblChinese";
            lblChinese.Size = new Size(45, 20);
            lblChinese.TabIndex = 4;
            lblChinese.Text = "中文:";
            lblChinese.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSpeech
            // 
            lblSpeech.AutoSize = true;
            lblSpeech.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSpeech.Location = new Point(100, 300);
            lblSpeech.Name = "lblSpeech";
            lblSpeech.Size = new Size(45, 20);
            lblSpeech.TabIndex = 5;
            lblSpeech.Text = "詞性:";
            lblSpeech.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SubForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(lblSpeech);
            Controls.Add(lblChinese);
            Controls.Add(chkCheak);
            Controls.Add(btnNext);
            Controls.Add(btnShow);
            Controls.Add(lblWord);
            Name = "SubForm";
            Text = "單字測驗";
            FormClosed += SubForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWord;
        private Button btnShow;
        private Button btnNext;
        private CheckBox chkCheak;
        private Label lblChinese;
        private Label lblSpeech;
    }
}