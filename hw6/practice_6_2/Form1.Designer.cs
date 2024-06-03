namespace practice_6_2 {
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
            btnSelectAlarm = new Button();
            lblFile = new Label();
            btnAct = new Button();
            lbl1 = new Label();
            txtMsg = new TextBox();
            lblAMPM = new Label();
            lblPrint = new Button();
            lblDot1 = new Label();
            lblDot2 = new Label();
            tmrCatch = new System.Windows.Forms.Timer(components);
            dtp = new DateTimePicker();
            SuspendLayout();
            // 
            // btnSelectAlarm
            // 
            btnSelectAlarm.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSelectAlarm.Location = new Point(50, 400);
            btnSelectAlarm.Name = "btnSelectAlarm";
            btnSelectAlarm.Size = new Size(100, 30);
            btnSelectAlarm.TabIndex = 0;
            btnSelectAlarm.Text = "選擇鬧鈴";
            btnSelectAlarm.UseVisualStyleBackColor = true;
            btnSelectAlarm.Click += btnSelectAlarm_Click;
            // 
            // lblFile
            // 
            lblFile.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFile.Location = new Point(180, 400);
            lblFile.Name = "lblFile";
            lblFile.Size = new Size(800, 30);
            lblFile.TabIndex = 1;
            lblFile.Text = "尚未選擇檔案";
            lblFile.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnAct
            // 
            btnAct.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAct.Location = new Point(1400, 400);
            btnAct.Name = "btnAct";
            btnAct.Size = new Size(100, 30);
            btnAct.TabIndex = 3;
            btnAct.Text = "啟動";
            btnAct.UseVisualStyleBackColor = true;
            btnAct.Click += btnAct_Click;
            // 
            // lbl1
            // 
            lbl1.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl1.Location = new Point(940, 400);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(200, 30);
            lbl1.TabIndex = 4;
            lbl1.Text = "設定鬧鐘時間";
            lbl1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtMsg
            // 
            txtMsg.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMsg.Location = new Point(1600, 30);
            txtMsg.Multiline = true;
            txtMsg.Name = "txtMsg";
            txtMsg.ReadOnly = true;
            txtMsg.ScrollBars = ScrollBars.Vertical;
            txtMsg.Size = new Size(360, 400);
            txtMsg.TabIndex = 5;
            // 
            // lblAMPM
            // 
            lblAMPM.Font = new Font("微軟正黑體", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblAMPM.Location = new Point(1500, 290);
            lblAMPM.Name = "lblAMPM";
            lblAMPM.Size = new Size(90, 40);
            lblAMPM.TabIndex = 6;
            lblAMPM.Text = "AM";
            lblAMPM.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPrint
            // 
            lblPrint.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrint.Location = new Point(1600, 450);
            lblPrint.Name = "lblPrint";
            lblPrint.Size = new Size(100, 30);
            lblPrint.TabIndex = 7;
            lblPrint.Text = "匯出記錄檔";
            lblPrint.UseVisualStyleBackColor = true;
            lblPrint.Click += lblPrint_Click;
            // 
            // lblDot1
            // 
            lblDot1.Font = new Font("微軟正黑體", 72F, FontStyle.Regular, GraphicsUnit.Point);
            lblDot1.Location = new Point(465, 30);
            lblDot1.Name = "lblDot1";
            lblDot1.Size = new Size(120, 292);
            lblDot1.TabIndex = 8;
            lblDot1.Text = ":";
            lblDot1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDot2
            // 
            lblDot2.Font = new Font("微軟正黑體", 72F, FontStyle.Regular, GraphicsUnit.Point);
            lblDot2.Location = new Point(965, 30);
            lblDot2.Name = "lblDot2";
            lblDot2.Size = new Size(120, 292);
            lblDot2.TabIndex = 9;
            lblDot2.Text = ":";
            lblDot2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tmrCatch
            // 
            tmrCatch.Interval = 1000;
            tmrCatch.Tick += tmrCatch_Tick;
            // 
            // dtp
            // 
            dtp.CalendarFont = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtp.CustomFormat = "tt hh:mm";
            dtp.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.Location = new Point(1170, 400);
            dtp.Name = "dtp";
            dtp.ShowUpDown = true;
            dtp.Size = new Size(200, 29);
            dtp.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1984, 511);
            Controls.Add(dtp);
            Controls.Add(lblDot2);
            Controls.Add(lblPrint);
            Controls.Add(lblAMPM);
            Controls.Add(txtMsg);
            Controls.Add(lbl1);
            Controls.Add(btnAct);
            Controls.Add(lblFile);
            Controls.Add(btnSelectAlarm);
            Controls.Add(lblDot1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSelectAlarm;
        private Label lblFile;
        private Button btnAct;
        private Label lbl1;
        private TextBox txtMsg;
        private Label lblAMPM;
        private Button lblPrint;
        private Label lblDot1;
        private Label lblDot2;
        private System.Windows.Forms.Timer tmrCatch;
        private DateTimePicker dtp;
    }
}