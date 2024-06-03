namespace practice_5_2
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
            lblTime = new Label();
            lblTimer = new Label();
            lblCharName = new Label();
            label8 = new Label();
            label9 = new Label();
            lblCharHP = new Label();
            lblCharCharge = new Label();
            lblCharAtk = new Label();
            lblEnemyName = new Label();
            lblEnemyHP = new Label();
            lblEnemyCharge = new Label();
            lblEnemyAtk = new Label();
            lblTurn = new Label();
            tmrChooseChar = new System.Windows.Forms.Timer(components);
            tmr = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.AutoSize = true;
            btnStart.Font = new Font("新細明體", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnStart.Location = new Point(300, 300);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(200, 50);
            btnStart.TabIndex = 0;
            btnStart.Text = "開始遊戲";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // lblTime
            // 
            lblTime.Font = new Font("新細明體", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblTime.Location = new Point(300, 20);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(200, 50);
            lblTime.TabIndex = 1;
            lblTime.Text = "時間";
            lblTime.TextAlign = ContentAlignment.MiddleCenter;
            lblTime.Visible = false;
            // 
            // lblTimer
            // 
            lblTimer.Font = new Font("新細明體", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblTimer.Location = new Point(300, 80);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(200, 50);
            lblTimer.TabIndex = 2;
            lblTimer.Text = "10";
            lblTimer.TextAlign = ContentAlignment.MiddleCenter;
            lblTimer.Visible = false;
            // 
            // lblCharName
            // 
            lblCharName.Font = new Font("新細明體", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCharName.Location = new Point(50, 150);
            lblCharName.Name = "lblCharName";
            lblCharName.Size = new Size(150, 40);
            lblCharName.TabIndex = 3;
            lblCharName.Text = "label3";
            lblCharName.TextAlign = ContentAlignment.MiddleLeft;
            lblCharName.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(650, 159);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(645, 192);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 9;
            // 
            // lblCharHP
            // 
            lblCharHP.Font = new Font("新細明體", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCharHP.Location = new Point(50, 200);
            lblCharHP.Name = "lblCharHP";
            lblCharHP.Size = new Size(150, 40);
            lblCharHP.TabIndex = 10;
            lblCharHP.Text = "label3";
            lblCharHP.TextAlign = ContentAlignment.MiddleLeft;
            lblCharHP.Visible = false;
            // 
            // lblCharCharge
            // 
            lblCharCharge.Font = new Font("新細明體", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCharCharge.Location = new Point(50, 250);
            lblCharCharge.Name = "lblCharCharge";
            lblCharCharge.Size = new Size(150, 40);
            lblCharCharge.TabIndex = 11;
            lblCharCharge.Text = "label3";
            lblCharCharge.TextAlign = ContentAlignment.MiddleLeft;
            lblCharCharge.Visible = false;
            // 
            // lblCharAtk
            // 
            lblCharAtk.Font = new Font("新細明體", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCharAtk.Location = new Point(50, 300);
            lblCharAtk.Name = "lblCharAtk";
            lblCharAtk.Size = new Size(150, 40);
            lblCharAtk.TabIndex = 12;
            lblCharAtk.Text = "label3";
            lblCharAtk.TextAlign = ContentAlignment.MiddleLeft;
            lblCharAtk.Visible = false;
            // 
            // lblEnemyName
            // 
            lblEnemyName.Font = new Font("新細明體", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblEnemyName.Location = new Point(600, 150);
            lblEnemyName.Name = "lblEnemyName";
            lblEnemyName.Size = new Size(150, 40);
            lblEnemyName.TabIndex = 13;
            lblEnemyName.Text = "label3";
            lblEnemyName.TextAlign = ContentAlignment.MiddleLeft;
            lblEnemyName.Visible = false;
            // 
            // lblEnemyHP
            // 
            lblEnemyHP.Font = new Font("新細明體", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblEnemyHP.Location = new Point(600, 200);
            lblEnemyHP.Name = "lblEnemyHP";
            lblEnemyHP.Size = new Size(150, 40);
            lblEnemyHP.TabIndex = 14;
            lblEnemyHP.Text = "label3";
            lblEnemyHP.TextAlign = ContentAlignment.MiddleLeft;
            lblEnemyHP.Visible = false;
            // 
            // lblEnemyCharge
            // 
            lblEnemyCharge.Font = new Font("新細明體", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblEnemyCharge.Location = new Point(600, 250);
            lblEnemyCharge.Name = "lblEnemyCharge";
            lblEnemyCharge.Size = new Size(150, 40);
            lblEnemyCharge.TabIndex = 15;
            lblEnemyCharge.Text = "label3";
            lblEnemyCharge.TextAlign = ContentAlignment.MiddleLeft;
            lblEnemyCharge.Visible = false;
            // 
            // lblEnemyAtk
            // 
            lblEnemyAtk.Font = new Font("新細明體", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblEnemyAtk.Location = new Point(600, 300);
            lblEnemyAtk.Name = "lblEnemyAtk";
            lblEnemyAtk.Size = new Size(150, 40);
            lblEnemyAtk.TabIndex = 16;
            lblEnemyAtk.Text = "label3";
            lblEnemyAtk.TextAlign = ContentAlignment.MiddleLeft;
            lblEnemyAtk.Visible = false;
            // 
            // lblTurn
            // 
            lblTurn.Font = new Font("新細明體", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblTurn.Location = new Point(300, 400);
            lblTurn.Name = "lblTurn";
            lblTurn.Size = new Size(200, 50);
            lblTurn.TabIndex = 18;
            lblTurn.Text = "回合";
            lblTurn.TextAlign = ContentAlignment.MiddleCenter;
            lblTurn.Visible = false;
            // 
            // tmrChooseChar
            // 
            tmrChooseChar.Interval = 1000;
            tmrChooseChar.Tick += tmrChooseChar_Tick;
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
            ClientSize = new Size(784, 461);
            Controls.Add(lblTurn);
            Controls.Add(lblEnemyAtk);
            Controls.Add(lblEnemyCharge);
            Controls.Add(lblEnemyHP);
            Controls.Add(lblEnemyName);
            Controls.Add(lblCharAtk);
            Controls.Add(lblCharCharge);
            Controls.Add(lblCharHP);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(lblCharName);
            Controls.Add(lblTimer);
            Controls.Add(lblTime);
            Controls.Add(btnStart);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private Label lblTime;
        private Label lblTimer;
        private Label lblCharName;
        private Label label8;
        private Label label9;
        private Label lblCharHP;
        private Label lblCharCharge;
        private Label lblCharAtk;
        private Label lblEnemyName;
        private Label lblEnemyHP;
        private Label lblEnemyCharge;
        private Label lblEnemyAtk;
        private Label lblTurn;
        private System.Windows.Forms.Timer tmrChooseChar;
        private System.Windows.Forms.Timer tmr;
    }
}