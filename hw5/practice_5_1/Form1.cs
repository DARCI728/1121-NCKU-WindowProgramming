using Microsoft.VisualBasic;

namespace practice_5_1 {
    public partial class Form1 : Form {
        private int remainingTime;
        private int[] randomNumbers = new int[3];
        private bool playerRound = false;
        Button[,] btn = new Button[3, 12];

        public Form1() {
            InitializeComponent();
        }

        public void InitializeBtn() {
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 12; j++) {
                    btn[i, j] = new Button();
                    btn[i, j].SetBounds(70 + 50 * j + 5 * j, 150 + 50 * i + 5 * i, 50, 50);

                    if (i == 0 && j < 10) {
                        btn[i, j].Text = ((char)(48 + j)).ToString();
                        btn[i, j].Tag = 48 + j;
                    } else if (i == 0 && j >= 10) {
                        btn[i, j].Text = ((char)(65 + j - 10)).ToString();
                        btn[i, j].Tag = 65 + j - 10;
                    } else {
                        btn[i, j].Text = ((char)(67 + j + 12 * (i - 1))).ToString();
                        btn[i, j].Tag = 67 + j + 12 * (i - 1);
                    }

                    Controls.Add(btn[i, j]);
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e) {
            InitializeBtn();
            playerRound = false;
            btnStart.Visible = false;
            lblTimer.Visible = true;
            lblStage.Visible = true;
            lblStage.Text = "準備階段";

            Random rnd = new Random();

            int i = 0;
            while (i < 3) {
                int num = rnd.Next(0, 36);
                if (!randomNumbers.Contains(num)) {
                    randomNumbers[i++] = num;
                }
            }

            for (i = 0; i < 3; i++) {
                btn[randomNumbers[i] / 12, randomNumbers[i] % 12].BackColor = Color.LightGreen;
            }

            remainingTime = 5;
            lblTimer.Text = remainingTime.ToString();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e) {
            if (remainingTime > 0) {
                remainingTime--;
                lblTimer.Text = remainingTime.ToString();
            } else {
                timer1.Stop();
                TimeEnd();
            }
        }

        private void TimeEnd() {
            if (playerRound == false) {
                playerRound = true;
                lblStage.Text = "玩家階段";

                for (int i = 0; i < 3; i++) {
                    btn[randomNumbers[i] / 12, randomNumbers[i] % 12].BackColor = Color.White;
                }

                remainingTime = 5;
                lblTimer.Text = remainingTime.ToString();
                timer1.Enabled = true;
            } else {
                timer1.Enabled = false;

                bool win = true;

                for (int i = 0; i < 3; i++) {
                    Button buttton = btn[randomNumbers[i] / 12, randomNumbers[i] % 12];

                    if (buttton.BackColor == Color.LightBlue) {
                        buttton.BackColor = Color.LightGreen;
                    } else {
                        buttton.BackColor = Color.Red;
                        win = false;
                    }
                }

                for (int i = 0; i < 3; i++) {
                    for (int j = 0; j < 12; j++) {
                        if (btn[i, j].BackColor == Color.LightBlue) {
                            btn[i, j].BackColor = Color.Red;
                            win = false;
                        }
                    }
                }

                DialogResult result;

                if (win == true) {
                    result = MessageBox.Show("You Win!");
                } else {
                    result = MessageBox.Show("You Lose!\nTry Again!");
                }

                if (result == DialogResult.OK) {
                    Reset();
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e) {
            if (playerRound == true) {
                for (int i = 0; i < 3; i++) {
                    for (int j = 0; j < 12; j++) {
                        if ((int)btn[i, j].Tag == e.KeyValue) {
                            btn[i, j].BackColor = Color.LightBlue;
                        }
                    }
                }
            }
        }

        private void Reset() {
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 12; j++) {
                    btn[i, j].Parent.Controls.Remove(btn[i, j]);
                }
            }

            playerRound = false;
            btnStart.Visible = true;
            lblTimer.Visible = false;
            lblStage.Visible = false;
            lblStage.Text = "準備階段";
        }
    }
}