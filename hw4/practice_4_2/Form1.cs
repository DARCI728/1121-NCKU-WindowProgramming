using Microsoft.VisualBasic;

namespace practice_4_2 {
    public partial class Form1 : Form {
        private List<Button> buttonList = new List<Button>();

        private int money = 100;
        private int seed = 5;
        private int fertilizer = 5;
        private int fruit = 0;

        private int[] watered = new int[12];
        private int[] fertilizered = new int[12];

        public Form1() {
            InitializeComponent();
            InitializeButtons(tabPage1);
            label1.Text = $"窥: {money}";
            label2.Text = $"局Τ: {seed}";
            label3.Text = $"局Τ: {fertilizer}";
            label4.Text = $"局Τ: {fruit}";
        }

        private void InitializeButtons(TabPage tabPage) {
            int buttonsPerRow = 3;

            for (int i = 0; i < 12; i++) {
                Button button = new Button();
                button.Size = new Size(100, 100);
                button.Location = new Point((i % buttonsPerRow) * 100, (i / buttonsPerRow) * 100);
                button.Tag = i;
                button.Text = "";
                button.ImageList = imageList1;
                button.ImageIndex = 0;
                button.Click += Button_Click;

                buttonList.Add(button);
                tabPage.Controls.Add(button);
            }
        }

        private void Button_Click(object sender, EventArgs e) {
            Button clickedButton = sender as Button;

            if (radioButton1.Checked && (clickedButton.ImageIndex == 1 || clickedButton.ImageIndex == 2)) {
                watered[(int)clickedButton.Tag] = 1;
                if (fertilizered[(int)clickedButton.Tag] == 1) {
                    clickedButton.ImageIndex += 1;
                    watered[(int)clickedButton.Tag] = 0;
                    fertilizered[(int)clickedButton.Tag] = 0;
                }
            } else if (radioButton2.Checked && clickedButton.ImageIndex == 0) {
                if (seed == 0) {
                    MessageBox.Show("贺ノЧ", "牡", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    clickedButton.ImageIndex += 1;
                    seed--;
                    label2.Text = $"局Τ: {seed}";
                }
            } else if (radioButton3.Checked && (clickedButton.ImageIndex == 1 || clickedButton.ImageIndex == 2)) {
                if (fertilizer == 0) {
                    MessageBox.Show("ノЧ", "牡", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    if (fertilizered[(int)clickedButton.Tag] == 0) {
                        fertilizered[(int)clickedButton.Tag] = 1;
                        fertilizer--;
                        label3.Text = $"局Τ: {fertilizer}";
                    }

                    if (watered[(int)clickedButton.Tag] == 1) {
                        clickedButton.ImageIndex += 1;
                        watered[(int)clickedButton.Tag] = 0;
                        fertilizered[(int)clickedButton.Tag] = 0;
                    }
                }
            } else if (radioButton4.Checked && clickedButton.ImageIndex == 3) {
                clickedButton.ImageIndex = 0;
                fruit++;
                label4.Text = $"局Τ: {fruit}";
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            if (checkBox3.Checked && fruit > 0) {
                money += 40;
                fruit--;
            }

            if (checkBox1.Checked && money >= 10) {
                money -= 10;
                seed++;
            }

            if (checkBox2.Checked && money >= 10) {
                money -= 10;
                fertilizer++;
            }

            label1.Text = $"窥: {money}";
            label2.Text = $"局Τ: {seed}";
            label3.Text = $"局Τ: {fertilizer}";
            label4.Text = $"局Τ: {fruit}";
        }
    }
}