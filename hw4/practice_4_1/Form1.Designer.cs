namespace practice_4_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            imageList = new ImageList(components);
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            btn_unlock = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // imageList
            // 
            imageList.ColorDepth = ColorDepth.Depth8Bit;
            imageList.ImageStream = (ImageListStreamer)resources.GetObject("imageList.ImageStream");
            imageList.TransparentColor = Color.Transparent;
            imageList.Images.SetKeyName(0, "0.jpg");
            imageList.Images.SetKeyName(1, "1.jpg");
            imageList.Images.SetKeyName(2, "2.jpg");
            imageList.Images.SetKeyName(3, "3.jpg");
            imageList.Images.SetKeyName(4, "4.jpg");
            imageList.Images.SetKeyName(5, "5.jpg");
            imageList.Images.SetKeyName(6, "6.jpg");
            imageList.Images.SetKeyName(7, "7.jpg");
            imageList.Images.SetKeyName(8, "8.jpg");
            imageList.Images.SetKeyName(9, "9.jpg");
            // 
            // button1
            // 
            button1.ImageIndex = 0;
            button1.ImageList = imageList;
            button1.Location = new Point(125, 100);
            button1.Name = "button1";
            button1.Size = new Size(100, 150);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.ImageIndex = 0;
            button2.ImageList = imageList;
            button2.Location = new Point(275, 100);
            button2.Name = "button2";
            button2.Size = new Size(100, 150);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.ImageIndex = 0;
            button3.ImageList = imageList;
            button3.Location = new Point(425, 100);
            button3.Name = "button3";
            button3.Size = new Size(100, 150);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.ImageIndex = 0;
            button4.ImageList = imageList;
            button4.Location = new Point(575, 100);
            button4.Name = "button4";
            button4.Size = new Size(100, 150);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // btn_unlock
            // 
            btn_unlock.Font = new Font("新細明體", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_unlock.Location = new Point(350, 350);
            btn_unlock.Name = "btn_unlock";
            btn_unlock.Size = new Size(100, 40);
            btn_unlock.TabIndex = 4;
            btn_unlock.Text = "解鎖";
            btn_unlock.UseVisualStyleBackColor = true;
            btn_unlock.Click += btn_unlock_Click;
            // 
            // label1
            // 
            label1.Font = new Font("新細明體", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(125, 30);
            label1.Name = "label1";
            label1.Size = new Size(100, 50);
            label1.TabIndex = 5;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("新細明體", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(275, 30);
            label2.Name = "label2";
            label2.Size = new Size(100, 50);
            label2.TabIndex = 6;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("新細明體", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(425, 30);
            label3.Name = "label3";
            label3.Size = new Size(100, 50);
            label3.TabIndex = 7;
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("新細明體", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(575, 30);
            label4.Name = "label4";
            label4.Size = new Size(100, 50);
            label4.TabIndex = 8;
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_unlock);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private ImageList imageList;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button btn_unlock;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}