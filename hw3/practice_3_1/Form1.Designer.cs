namespace practice_3_1
{
    partial class Form
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
            lblDataInput = new Label();
            lblName = new Label();
            txtName = new TextBox();
            lblGender = new Label();
            lblBirth = new Label();
            lblToday = new Label();
            lblPrefer = new Label();
            txtGender = new TextBox();
            txtBirth = new TextBox();
            txtToday = new TextBox();
            txtPrefer = new TextBox();
            btn = new Button();
            lblNameError = new Label();
            lblGenderError = new Label();
            lblBirthError = new Label();
            lblTodayError = new Label();
            lblPreferError = new Label();
            lblFortune = new Label();
            lblAdvice = new Label();
            SuspendLayout();
            // 
            // lblDataInput
            // 
            lblDataInput.AutoSize = true;
            lblDataInput.Font = new Font("新細明體", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDataInput.Location = new Point(340, 10);
            lblDataInput.Name = "lblDataInput";
            lblDataInput.Size = new Size(120, 27);
            lblDataInput.TabIndex = 0;
            lblDataInput.Text = "資料輸入";
            lblDataInput.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            lblName.Font = new Font("新細明體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(120, 80);
            lblName.Name = "lblName";
            lblName.Size = new Size(120, 30);
            lblName.TabIndex = 1;
            lblName.Text = "姓名";
            lblName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            txtName.Font = new Font("新細明體", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(250, 80);
            txtName.Name = "txtName";
            txtName.Size = new Size(300, 30);
            txtName.TabIndex = 2;
            // 
            // lblGender
            // 
            lblGender.Font = new Font("新細明體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblGender.Location = new Point(120, 140);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(120, 30);
            lblGender.TabIndex = 3;
            lblGender.Text = "性別";
            lblGender.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBirth
            // 
            lblBirth.Font = new Font("新細明體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBirth.Location = new Point(120, 200);
            lblBirth.Name = "lblBirth";
            lblBirth.Size = new Size(120, 30);
            lblBirth.TabIndex = 4;
            lblBirth.Text = "出生年月日";
            lblBirth.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblToday
            // 
            lblToday.Font = new Font("新細明體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblToday.Location = new Point(120, 260);
            lblToday.Name = "lblToday";
            lblToday.Size = new Size(120, 30);
            lblToday.TabIndex = 5;
            lblToday.Text = "今日日期";
            lblToday.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPrefer
            // 
            lblPrefer.Font = new Font("新細明體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrefer.Location = new Point(120, 320);
            lblPrefer.Name = "lblPrefer";
            lblPrefer.Size = new Size(120, 30);
            lblPrefer.TabIndex = 6;
            lblPrefer.Text = "貓派or狗派";
            lblPrefer.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtGender
            // 
            txtGender.Font = new Font("新細明體", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtGender.Location = new Point(250, 140);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(300, 30);
            txtGender.TabIndex = 7;
            // 
            // txtBirth
            // 
            txtBirth.Font = new Font("新細明體", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBirth.Location = new Point(250, 200);
            txtBirth.Name = "txtBirth";
            txtBirth.Size = new Size(300, 30);
            txtBirth.TabIndex = 8;
            // 
            // txtToday
            // 
            txtToday.Font = new Font("新細明體", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtToday.Location = new Point(250, 260);
            txtToday.Name = "txtToday";
            txtToday.Size = new Size(300, 30);
            txtToday.TabIndex = 9;
            // 
            // txtPrefer
            // 
            txtPrefer.Font = new Font("新細明體", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrefer.Location = new Point(250, 320);
            txtPrefer.Name = "txtPrefer";
            txtPrefer.Size = new Size(300, 30);
            txtPrefer.TabIndex = 10;
            // 
            // btn
            // 
            btn.Font = new Font("新細明體", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn.Location = new Point(250, 420);
            btn.Name = "btn";
            btn.Size = new Size(300, 30);
            btn.TabIndex = 11;
            btn.Text = "AI大神請告訴我答案吧";
            btn.UseVisualStyleBackColor = true;
            btn.Click += button1_Click;
            // 
            // lblNameError
            // 
            lblNameError.Font = new Font("新細明體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNameError.Location = new Point(580, 80);
            lblNameError.Name = "lblNameError";
            lblNameError.Size = new Size(120, 30);
            lblNameError.TabIndex = 12;
            lblNameError.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblGenderError
            // 
            lblGenderError.Font = new Font("新細明體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblGenderError.Location = new Point(580, 140);
            lblGenderError.Name = "lblGenderError";
            lblGenderError.Size = new Size(120, 30);
            lblGenderError.TabIndex = 13;
            lblGenderError.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBirthError
            // 
            lblBirthError.Font = new Font("新細明體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBirthError.Location = new Point(580, 200);
            lblBirthError.Name = "lblBirthError";
            lblBirthError.Size = new Size(120, 30);
            lblBirthError.TabIndex = 14;
            lblBirthError.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTodayError
            // 
            lblTodayError.Font = new Font("新細明體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTodayError.Location = new Point(580, 260);
            lblTodayError.Name = "lblTodayError";
            lblTodayError.Size = new Size(120, 30);
            lblTodayError.TabIndex = 15;
            lblTodayError.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPreferError
            // 
            lblPreferError.Font = new Font("新細明體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPreferError.Location = new Point(580, 320);
            lblPreferError.Name = "lblPreferError";
            lblPreferError.Size = new Size(120, 30);
            lblPreferError.TabIndex = 16;
            lblPreferError.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblFortune
            // 
            lblFortune.Font = new Font("新細明體", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblFortune.Location = new Point(100, 260);
            lblFortune.Name = "lblFortune";
            lblFortune.Size = new Size(700, 30);
            lblFortune.TabIndex = 17;
            lblFortune.TextAlign = ContentAlignment.MiddleLeft;
            lblFortune.Visible = false;
            // 
            // lblAdvice
            // 
            lblAdvice.Font = new Font("新細明體", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblAdvice.Location = new Point(100, 320);
            lblAdvice.Name = "lblAdvice";
            lblAdvice.Size = new Size(700, 30);
            lblAdvice.TabIndex = 18;
            lblAdvice.TextAlign = ContentAlignment.MiddleLeft;
            lblAdvice.Visible = false;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(lblPreferError);
            Controls.Add(lblTodayError);
            Controls.Add(lblBirthError);
            Controls.Add(lblGenderError);
            Controls.Add(lblNameError);
            Controls.Add(btn);
            Controls.Add(txtPrefer);
            Controls.Add(txtToday);
            Controls.Add(txtBirth);
            Controls.Add(txtGender);
            Controls.Add(lblPrefer);
            Controls.Add(lblToday);
            Controls.Add(lblBirth);
            Controls.Add(lblGender);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(lblDataInput);
            Controls.Add(lblFortune);
            Controls.Add(lblAdvice);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(2);
            Name = "Form";
            Text = "AI算命系統";
            Load += Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDataInput;
        private Label lblName;
        private TextBox txtName;
        private Label lblGender;
        private Label lblBirth;
        private Label lblToday;
        private Label lblPrefer;
        private TextBox txtGender;
        private TextBox txtBirth;
        private TextBox txtToday;
        private TextBox txtPrefer;
        private Button btn;
        private Label lblNameError;
        private Label lblGenderError;
        private Label lblBirthError;
        private Label lblTodayError;
        private Label lblPreferError;
        private Label lblFortune;
        private Label lblAdvice;
    }
}