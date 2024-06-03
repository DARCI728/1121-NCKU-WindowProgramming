using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace practice_4_1 {
    public partial class Form1 : Form {
        private static Random rand = new Random();
        private int key = rand.Next(0, 10000);

        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            button1.ImageIndex = (button1.ImageIndex + 1) % 10;
        }

        private void button2_Click(object sender, EventArgs e) {
            button2.ImageIndex = (button2.ImageIndex + 1) % 10;
        }

        private void button3_Click(object sender, EventArgs e) {
            button3.ImageIndex = (button3.ImageIndex + 1) % 10;
        }

        private void button4_Click(object sender, EventArgs e) {
            button4.ImageIndex = (button4.ImageIndex + 1) % 10;
        }

        private void btn_unlock_Click(object sender, EventArgs e) {
            if (button1.ImageIndex * 1000 + button2.ImageIndex * 100 + button3.ImageIndex * 10 + button4.ImageIndex == key) {
                label1.Text = "";
                label2.Text = "";
                label3.Text = "";
                label4.Text = "";

                MessageBox.Show("解鎖成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            } else {
                int guess = 0;

                if (key / 1000 == button1.ImageIndex) {
                    label1.Text = "對";
                    guess++;
                } else {
                    label1.Text = "錯";
                }

                if (key / 100 % 10 == button2.ImageIndex) {
                    label2.Text = "對";
                    guess++;
                } else {
                    label2.Text = "錯";
                }

                if (key / 10 % 10 == button3.ImageIndex) {
                    label3.Text = "對";
                    guess++;
                } else {
                    label3.Text = "錯";
                }

                if (key % 10 == button4.ImageIndex) {
                    label4.Text = "對";
                    guess++;
                } else {
                    label4.Text = "錯";
                }

                DialogResult result = MessageBox.Show($"猜對{guess}個位置", "失敗", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Cancel) {
                    MessageBox.Show($"答案是{key}", "", MessageBoxButtons.OK);
                }
            }
        }
    }
}
