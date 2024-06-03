namespace practice_5_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnStart = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            lblStage = new Label();
            lblTimer = new Label();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Font = new Font("新細明體", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnStart.Location = new Point(300, 350);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(200, 30);
            btnStart.TabIndex = 0;
            btnStart.Text = "開始遊戲";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // lblStage
            // 
            lblStage.Font = new Font("新細明體", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblStage.Location = new Point(350, 50);
            lblStage.Name = "lblStage";
            lblStage.Size = new Size(100, 30);
            lblStage.TabIndex = 1;
            lblStage.Text = "準備階段";
            lblStage.TextAlign = ContentAlignment.MiddleCenter;
            lblStage.Visible = false;
            // 
            // lblTimer
            // 
            lblTimer.Location = new Point(350, 100);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(100, 30);
            lblTimer.TabIndex = 2;
            lblTimer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(lblTimer);
            Controls.Add(lblStage);
            Controls.Add(btnStart);
            KeyPreview = true;
            Name = "Form1";
            Text = "記憶小遊戲";
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
        }

        #endregion

        private Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private Label lblStage;
        private Label lblTimer;
    }
}