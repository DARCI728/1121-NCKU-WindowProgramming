namespace practice_6_1 {
    partial class Form1 {
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
            components = new System.ComponentModel.Container();
            btnChoosePic = new Button();
            picPuzzle = new PictureBox();
            trbShow = new TrackBar();
            lblNotShow = new Label();
            lblShow = new Label();
            lblTime = new Label();
            lblStep = new Label();
            btn00 = new Button();
            btn01 = new Button();
            btn02 = new Button();
            btn10 = new Button();
            btn11 = new Button();
            btn12 = new Button();
            btn20 = new Button();
            btn21 = new Button();
            btn22 = new Button();
            btnDraw = new Button();
            imgPuzzle = new ImageList(components);
            tmr = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)picPuzzle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trbShow).BeginInit();
            SuspendLayout();
            // 
            // btnChoosePic
            // 
            btnChoosePic.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnChoosePic.Location = new Point(600, 400);
            btnChoosePic.Name = "btnChoosePic";
            btnChoosePic.Size = new Size(200, 30);
            btnChoosePic.TabIndex = 0;
            btnChoosePic.Text = "選擇圖片";
            btnChoosePic.UseVisualStyleBackColor = true;
            btnChoosePic.Click += btnChoosePic_Click;
            // 
            // picPuzzle
            // 
            picPuzzle.Location = new Point(550, 30);
            picPuzzle.Name = "picPuzzle";
            picPuzzle.Size = new Size(300, 300);
            picPuzzle.TabIndex = 1;
            picPuzzle.TabStop = false;
            picPuzzle.Visible = false;
            // 
            // trbShow
            // 
            trbShow.Location = new Point(610, 350);
            trbShow.Maximum = 1;
            trbShow.Name = "trbShow";
            trbShow.Size = new Size(180, 45);
            trbShow.TabIndex = 2;
            trbShow.Value = 1;
            trbShow.Visible = false;
            trbShow.Scroll += trbShow_Scroll;
            // 
            // lblNotShow
            // 
            lblNotShow.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNotShow.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lblNotShow.Location = new Point(550, 350);
            lblNotShow.Name = "lblNotShow";
            lblNotShow.Size = new Size(60, 45);
            lblNotShow.TabIndex = 3;
            lblNotShow.Text = "不顯示";
            lblNotShow.TextAlign = ContentAlignment.MiddleRight;
            lblNotShow.Visible = false;
            // 
            // lblShow
            // 
            lblShow.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblShow.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lblShow.Location = new Point(790, 350);
            lblShow.Name = "lblShow";
            lblShow.Size = new Size(60, 45);
            lblShow.TabIndex = 4;
            lblShow.Text = "顯示";
            lblShow.TextAlign = ContentAlignment.MiddleLeft;
            lblShow.Visible = false;
            // 
            // lblTime
            // 
            lblTime.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTime.Location = new Point(375, 100);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(150, 30);
            lblTime.TabIndex = 6;
            lblTime.Text = "Time: 00:00";
            lblTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStep
            // 
            lblStep.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStep.Location = new Point(375, 150);
            lblStep.Name = "lblStep";
            lblStep.Size = new Size(150, 30);
            lblStep.TabIndex = 7;
            lblStep.Text = "移動步數: 0";
            lblStep.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn00
            // 
            btn00.Enabled = false;
            btn00.Location = new Point(50, 30);
            btn00.Name = "btn00";
            btn00.Size = new Size(100, 100);
            btn00.TabIndex = 8;
            btn00.Tag = "";
            btn00.UseVisualStyleBackColor = true;
            btn00.Click += btn00_Click;
            // 
            // btn01
            // 
            btn01.Enabled = false;
            btn01.Location = new Point(150, 30);
            btn01.Name = "btn01";
            btn01.Size = new Size(100, 100);
            btn01.TabIndex = 9;
            btn01.Tag = "";
            btn01.UseVisualStyleBackColor = true;
            btn01.Click += btn01_Click;
            // 
            // btn02
            // 
            btn02.Enabled = false;
            btn02.Location = new Point(250, 30);
            btn02.Name = "btn02";
            btn02.Size = new Size(100, 100);
            btn02.TabIndex = 10;
            btn02.Tag = "";
            btn02.UseVisualStyleBackColor = true;
            btn02.Click += btn02_Click;
            // 
            // btn10
            // 
            btn10.Enabled = false;
            btn10.Location = new Point(50, 130);
            btn10.Name = "btn10";
            btn10.Size = new Size(100, 100);
            btn10.TabIndex = 11;
            btn10.Tag = "";
            btn10.UseVisualStyleBackColor = true;
            btn10.Click += btn10_Click;
            // 
            // btn11
            // 
            btn11.Enabled = false;
            btn11.Location = new Point(150, 130);
            btn11.Name = "btn11";
            btn11.Size = new Size(100, 100);
            btn11.TabIndex = 12;
            btn11.Tag = "";
            btn11.UseVisualStyleBackColor = true;
            btn11.Click += btn11_Click;
            // 
            // btn12
            // 
            btn12.Enabled = false;
            btn12.Location = new Point(250, 130);
            btn12.Name = "btn12";
            btn12.Size = new Size(100, 100);
            btn12.TabIndex = 13;
            btn12.Tag = "";
            btn12.UseVisualStyleBackColor = true;
            btn12.Click += btn12_Click;
            // 
            // btn20
            // 
            btn20.Enabled = false;
            btn20.Location = new Point(50, 230);
            btn20.Name = "btn20";
            btn20.Size = new Size(100, 100);
            btn20.TabIndex = 14;
            btn20.Tag = "";
            btn20.UseVisualStyleBackColor = true;
            btn20.Click += btn20_Click;
            // 
            // btn21
            // 
            btn21.Enabled = false;
            btn21.Location = new Point(150, 230);
            btn21.Name = "btn21";
            btn21.Size = new Size(100, 100);
            btn21.TabIndex = 15;
            btn21.Tag = "";
            btn21.UseVisualStyleBackColor = true;
            btn21.Click += btn21_Click;
            // 
            // btn22
            // 
            btn22.Enabled = false;
            btn22.Location = new Point(250, 230);
            btn22.Name = "btn22";
            btn22.Size = new Size(100, 100);
            btn22.TabIndex = 16;
            btn22.Tag = "";
            btn22.UseVisualStyleBackColor = true;
            btn22.Visible = false;
            btn22.Click += btn22_Click;
            // 
            // btnDraw
            // 
            btnDraw.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDraw.Location = new Point(85, 400);
            btnDraw.Name = "btnDraw";
            btnDraw.Size = new Size(200, 30);
            btnDraw.TabIndex = 17;
            btnDraw.Text = "繪製拼圖板";
            btnDraw.UseVisualStyleBackColor = true;
            btnDraw.Click += btnDraw_Click;
            // 
            // imgPuzzle
            // 
            imgPuzzle.ColorDepth = ColorDepth.Depth8Bit;
            imgPuzzle.ImageSize = new Size(100, 100);
            imgPuzzle.TransparentColor = Color.Transparent;
            // 
            // tmr
            // 
            tmr.Interval = 1000;
            tmr.Tick += tmr_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 461);
            Controls.Add(btnDraw);
            Controls.Add(btn22);
            Controls.Add(btn21);
            Controls.Add(btn20);
            Controls.Add(btn12);
            Controls.Add(btn11);
            Controls.Add(btn10);
            Controls.Add(btn02);
            Controls.Add(btn01);
            Controls.Add(btn00);
            Controls.Add(lblStep);
            Controls.Add(lblTime);
            Controls.Add(lblShow);
            Controls.Add(lblNotShow);
            Controls.Add(trbShow);
            Controls.Add(picPuzzle);
            Controls.Add(btnChoosePic);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picPuzzle).EndInit();
            ((System.ComponentModel.ISupportInitialize)trbShow).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnChoosePic;
        private PictureBox picPuzzle;
        private TrackBar trbShow;
        private Label lblNotShow;
        private Label lblShow;
        private Label lblTime;
        private Label lblStep;
        private Button btn00;
        private Button btn01;
        private Button btn02;
        private Button btn10;
        private Button btn11;
        private Button btn12;
        private Button btn20;
        private Button btn21;
        private Button btn22;
        private Button btnDraw;
        private ImageList imgPuzzle;
        private System.Windows.Forms.Timer tmr;
    }
}