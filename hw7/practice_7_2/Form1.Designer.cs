namespace practice_7_2 {
    partial class MainForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            menuStrip = new MenuStrip();
            menuFile = new ToolStripMenuItem();
            menu新增 = new ToolStripMenuItem();
            menu開啟舊檔 = new ToolStripMenuItem();
            menu存檔 = new ToolStripMenuItem();
            menu另存新檔 = new ToolStripMenuItem();
            menuExit = new ToolStripMenuItem();
            menuFunc = new ToolStripMenuItem();
            menu新增單字 = new ToolStripMenuItem();
            menu搜尋單字 = new ToolStripMenuItem();
            單字測驗ToolStripMenuItem = new ToolStripMenuItem();
            menuView = new ToolStripMenuItem();
            字型大小ToolStripMenuItem = new ToolStripMenuItem();
            menu只顯示標記單字 = new ToolStripMenuItem();
            txtWords = new TextBox();
            lbl1 = new Label();
            txtWord = new TextBox();
            lbl2 = new Label();
            txtChinese = new TextBox();
            lbl3 = new Label();
            cboSpeech = new ComboBox();
            chkWord = new CheckBox();
            chkChinese = new CheckBox();
            chkSpeech = new CheckBox();
            btn = new Button();
            清除標記ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { menuFile, menuFunc, menuView });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(784, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // menuFile
            // 
            menuFile.DropDownItems.AddRange(new ToolStripItem[] { menu新增, menu開啟舊檔, menu存檔, menu另存新檔, menuExit });
            menuFile.Name = "menuFile";
            menuFile.Size = new Size(43, 20);
            menuFile.Text = "檔案";
            menuFile.DropDownItemClicked += menuFile_DropDownItemClicked;
            // 
            // menu新增
            // 
            menu新增.Name = "menu新增";
            menu新增.Size = new Size(122, 22);
            menu新增.Text = "新增";
            // 
            // menu開啟舊檔
            // 
            menu開啟舊檔.Name = "menu開啟舊檔";
            menu開啟舊檔.Size = new Size(122, 22);
            menu開啟舊檔.Text = "開啟舊檔";
            // 
            // menu存檔
            // 
            menu存檔.Name = "menu存檔";
            menu存檔.Size = new Size(122, 22);
            menu存檔.Text = "存檔";
            // 
            // menu另存新檔
            // 
            menu另存新檔.Name = "menu另存新檔";
            menu另存新檔.Size = new Size(122, 22);
            menu另存新檔.Text = "另存新檔";
            // 
            // menuExit
            // 
            menuExit.Name = "menuExit";
            menuExit.Size = new Size(122, 22);
            menuExit.Text = "離開";
            // 
            // menuFunc
            // 
            menuFunc.DropDownItems.AddRange(new ToolStripItem[] { menu新增單字, menu搜尋單字, 單字測驗ToolStripMenuItem });
            menuFunc.Name = "menuFunc";
            menuFunc.Size = new Size(43, 20);
            menuFunc.Text = "功能";
            menuFunc.DropDownItemClicked += menuFunc_DropDownItemClicked;
            // 
            // menu新增單字
            // 
            menu新增單字.Name = "menu新增單字";
            menu新增單字.Size = new Size(122, 22);
            menu新增單字.Text = "新增單字";
            // 
            // menu搜尋單字
            // 
            menu搜尋單字.Name = "menu搜尋單字";
            menu搜尋單字.Size = new Size(122, 22);
            menu搜尋單字.Text = "搜尋單字";
            // 
            // 單字測驗ToolStripMenuItem
            // 
            單字測驗ToolStripMenuItem.Name = "單字測驗ToolStripMenuItem";
            單字測驗ToolStripMenuItem.Size = new Size(122, 22);
            單字測驗ToolStripMenuItem.Text = "單字測驗";
            // 
            // menuView
            // 
            menuView.DropDownItems.AddRange(new ToolStripItem[] { 字型大小ToolStripMenuItem, menu只顯示標記單字, 清除標記ToolStripMenuItem });
            menuView.Name = "menuView";
            menuView.Size = new Size(43, 20);
            menuView.Text = "檢視";
            menuView.DropDownItemClicked += menuView_DropDownItemClicked;
            // 
            // 字型大小ToolStripMenuItem
            // 
            字型大小ToolStripMenuItem.Name = "字型大小ToolStripMenuItem";
            字型大小ToolStripMenuItem.Size = new Size(180, 22);
            字型大小ToolStripMenuItem.Text = "字型大小";
            // 
            // menu只顯示標記單字
            // 
            menu只顯示標記單字.Name = "menu只顯示標記單字";
            menu只顯示標記單字.Size = new Size(180, 22);
            menu只顯示標記單字.Text = "只顯示標記單字";
            // 
            // txtWords
            // 
            txtWords.Location = new Point(10, 30);
            txtWords.Multiline = true;
            txtWords.Name = "txtWords";
            txtWords.ReadOnly = true;
            txtWords.ScrollBars = ScrollBars.Both;
            txtWords.Size = new Size(500, 420);
            txtWords.TabIndex = 1;
            txtWords.WordWrap = false;
            // 
            // lbl1
            // 
            lbl1.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl1.Location = new Point(600, 100);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(150, 30);
            lbl1.TabIndex = 2;
            lbl1.Text = "單字";
            lbl1.TextAlign = ContentAlignment.MiddleLeft;
            lbl1.Visible = false;
            // 
            // txtWord
            // 
            txtWord.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtWord.Location = new Point(600, 131);
            txtWord.Name = "txtWord";
            txtWord.Size = new Size(150, 29);
            txtWord.TabIndex = 3;
            txtWord.Visible = false;
            // 
            // lbl2
            // 
            lbl2.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl2.Location = new Point(600, 200);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(150, 30);
            lbl2.TabIndex = 4;
            lbl2.Text = "中文";
            lbl2.TextAlign = ContentAlignment.MiddleLeft;
            lbl2.Visible = false;
            // 
            // txtChinese
            // 
            txtChinese.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtChinese.Location = new Point(600, 231);
            txtChinese.Name = "txtChinese";
            txtChinese.Size = new Size(150, 29);
            txtChinese.TabIndex = 5;
            txtChinese.Visible = false;
            // 
            // lbl3
            // 
            lbl3.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl3.Location = new Point(600, 300);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(150, 30);
            lbl3.TabIndex = 6;
            lbl3.Text = "詞性";
            lbl3.TextAlign = ContentAlignment.MiddleLeft;
            lbl3.Visible = false;
            // 
            // cboSpeech
            // 
            cboSpeech.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSpeech.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboSpeech.FormattingEnabled = true;
            cboSpeech.Items.AddRange(new object[] { "n.", "v.", "adj.", "adv.", "prep.", "conj.", "phr.", "abbr.", "pron.", "other." });
            cboSpeech.Location = new Point(600, 332);
            cboSpeech.Name = "cboSpeech";
            cboSpeech.Size = new Size(150, 28);
            cboSpeech.TabIndex = 7;
            cboSpeech.Visible = false;
            // 
            // chkWord
            // 
            chkWord.Location = new Point(580, 130);
            chkWord.Name = "chkWord";
            chkWord.Size = new Size(20, 30);
            chkWord.TabIndex = 8;
            chkWord.UseVisualStyleBackColor = true;
            chkWord.Visible = false;
            // 
            // chkChinese
            // 
            chkChinese.Location = new Point(580, 230);
            chkChinese.Name = "chkChinese";
            chkChinese.Size = new Size(20, 30);
            chkChinese.TabIndex = 9;
            chkChinese.UseVisualStyleBackColor = true;
            chkChinese.Visible = false;
            // 
            // chkSpeech
            // 
            chkSpeech.Location = new Point(580, 330);
            chkSpeech.Name = "chkSpeech";
            chkSpeech.Size = new Size(20, 30);
            chkSpeech.TabIndex = 10;
            chkSpeech.UseVisualStyleBackColor = true;
            chkSpeech.Visible = false;
            // 
            // btn
            // 
            btn.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn.Location = new Point(670, 420);
            btn.Name = "btn";
            btn.Size = new Size(100, 30);
            btn.TabIndex = 11;
            btn.Text = "新增";
            btn.UseVisualStyleBackColor = true;
            btn.Visible = false;
            btn.Click += btn_Click;
            // 
            // 清除標記ToolStripMenuItem
            // 
            清除標記ToolStripMenuItem.Name = "清除標記ToolStripMenuItem";
            清除標記ToolStripMenuItem.Size = new Size(180, 22);
            清除標記ToolStripMenuItem.Text = "清除標記";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(btn);
            Controls.Add(chkSpeech);
            Controls.Add(chkChinese);
            Controls.Add(chkWord);
            Controls.Add(cboSpeech);
            Controls.Add(lbl3);
            Controls.Add(txtChinese);
            Controls.Add(lbl2);
            Controls.Add(txtWord);
            Controls.Add(lbl1);
            Controls.Add(txtWords);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "MainForm";
            Text = "單字卡";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem menuFile;
        private ToolStripMenuItem menu新增;
        private ToolStripMenuItem menu開啟舊檔;
        private ToolStripMenuItem menu存檔;
        private ToolStripMenuItem menu另存新檔;
        private ToolStripMenuItem menuExit;
        private ToolStripMenuItem menuFunc;
        private ToolStripMenuItem menuView;
        private ToolStripMenuItem menu新增單字;
        private ToolStripMenuItem menu搜尋單字;
        private ToolStripMenuItem 字型大小ToolStripMenuItem;
        private TextBox txtWords;
        private Label lbl1;
        private TextBox txtWord;
        private Label lbl2;
        private TextBox txtChinese;
        private Label lbl3;
        private ComboBox cboSpeech;
        private CheckBox chkWord;
        private CheckBox chkChinese;
        private CheckBox chkSpeech;
        private Button btn;
        private ToolStripMenuItem 單字測驗ToolStripMenuItem;
        private ToolStripMenuItem menu只顯示標記單字;
        private ToolStripMenuItem 清除標記ToolStripMenuItem;
    }
}