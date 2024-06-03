using System.Media;
using System.Windows.Forms;

namespace practice_6_2 {
    public partial class Form1 : Form {
        public int year, month, day, hour, min, sec, alarmhour, alarmMin;
        public int[] arr;
        public bool alarmAct = false, selectFile = false, msgBox = false;
        public SoundPlayer player;
        public DateTime selectDataTime;
        public List<List<PictureBox>> pictureBoxes = new List<List<PictureBox>>();

        public Form1() {
            InitializeComponent();

            for (int i = 0; i < 6; i++) {
                List<PictureBox> innerList = new List<PictureBox>();
                pictureBoxes.Add(innerList);
            }

            InitializeDisplayBoard();
            lblDot1.SendToBack();
            lblDot2.SendToBack();
            tmrCatch.Enabled = true;
        }

        private void InitializeDisplayBoard() {
            for (int i = 0; i < 6; i++) {
                for (int j = 0; j < 7; j++) {
                    for (int k = 0; k < 5; k++) {
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.Location = new Point(40 + 250 * i + 40 * k + 2 * k, 40 + 40 * j + 2 * j);
                        pictureBox.Size = new Size(40, 40);
                        pictureBox.BackColor = Color.White;
                        pictureBoxes[i].Add(pictureBox);
                        Controls.Add(pictureBox);
                    }
                }
            }
        }

        private void GetTime() {
            DateTime currentTime = DateTime.Now;
            year = currentTime.Year;
            month = currentTime.Month;
            day = currentTime.Day;
            hour = currentTime.Hour;
            min = currentTime.Minute;
            sec = currentTime.Second;
        }

        private void ChangeNumber(List<PictureBox> pictureBox, int number) {
            int[] allNum = new int[] { 1, 2, 3, 5, 9, 10, 14, 16, 17, 18, 20, 24, 25, 29, 31, 32, 33 };
            switch (number) {
                case 0:
                    arr = new int[] { 1, 2, 3, 5, 9, 10, 14, 20, 24, 25, 29, 31, 32, 33 };
                    foreach (int i in arr) {
                        pictureBox[i].BackColor = Color.Blue;
                    }
                    break;
                case 1:
                    arr = new int[] { 9, 14, 24, 29 };
                    foreach (int i in arr) {
                        pictureBox[i].BackColor = Color.Blue;
                    }
                    break;
                case 2:
                    arr = new int[] { 1, 2, 3, 9, 14, 16, 17, 18, 20, 25, 31, 32, 33 };
                    foreach (int i in arr) {
                        pictureBox[i].BackColor = Color.Blue;
                    }
                    break;
                case 3:
                    arr = new int[] { 1, 2, 3, 9, 14, 16, 17, 18, 24, 29, 31, 32, 33 };
                    foreach (int i in arr) {
                        pictureBox[i].BackColor = Color.Blue;
                    }
                    break;
                case 4:
                    arr = new int[] { 5, 9, 10, 14, 16, 17, 18, 24, 29 };
                    foreach (int i in arr) {
                        pictureBox[i].BackColor = Color.Blue;
                    }
                    break;
                case 5:
                    arr = new int[] { 1, 2, 3, 5, 10, 16, 17, 18, 24, 29, 31, 32, 33 };
                    foreach (int i in arr) {
                        pictureBox[i].BackColor = Color.Blue;
                    }
                    break;
                case 6:
                    arr = new int[] { 1, 2, 3, 5, 10, 16, 17, 18, 20, 24, 25, 29, 31, 32, 33 };
                    foreach (int i in arr) {
                        pictureBox[i].BackColor = Color.Blue;
                    }
                    break;
                case 7:
                    arr = new int[] { 1, 2, 3, 9, 14, 24, 29 };
                    foreach (int i in arr) {
                        pictureBox[i].BackColor = Color.Blue;
                    }
                    break;
                case 8:
                    arr = new int[] { 1, 2, 3, 5, 9, 10, 14, 16, 17, 18, 20, 24, 25, 29, 31, 32, 33 };
                    foreach (int i in arr) {
                        pictureBox[i].BackColor = Color.Blue;
                    }
                    break;
                case 9:
                    arr = new int[] { 1, 2, 3, 5, 9, 10, 14, 16, 17, 18, 24, 29, 31, 32, 33 };
                    foreach (int i in arr) {
                        pictureBox[i].BackColor = Color.Blue;
                    }
                    break;
                default:
                    break;
            }

            foreach (int j in allNum) {
                if (!Array.Exists(arr, x => x == j)) {
                    pictureBox[j].BackColor = Color.White;
                }
            }
        }

        private void tmrCatch_Tick(object sender, EventArgs e) {
            GetTime();

            if (hour < 12) {
                lblAMPM.Text = "AM";
            } else {
                lblAMPM.Text = "PM";
                hour -= 12;
            }

            ChangeNumber(pictureBoxes[0], hour / 10);
            ChangeNumber(pictureBoxes[1], hour % 10);
            ChangeNumber(pictureBoxes[2], min / 10);
            ChangeNumber(pictureBoxes[3], min % 10);
            ChangeNumber(pictureBoxes[4], sec / 10);
            ChangeNumber(pictureBoxes[5], sec % 10);

            if (alarmAct && msgBox == false) {
                if (selectDataTime.ToString("tt") == "上午") {
                    if (hour == alarmhour && min == alarmMin) {
                        player.PlayLooping();
                        txtMsg.AppendText($"{year:D2}/{month:D2}/{day:D2} 上午 {hour:D2}:{min:D2}:{sec:D2}：鬧鐘響鈴!" + Environment.NewLine);
                        msgBox = true;
                        MessageBox.Show("時間到!該起床了喔~");
                    }
                } else if (selectDataTime.ToString("tt") == "下午") {
                    if ((alarmhour - 12) == hour && min == alarmMin) {
                        player.PlayLooping();
                        txtMsg.AppendText($"{year:D2}/{month:D2}/{day:D2} 下午 {hour:D2}:{min:D2}:{sec:D2}：鬧鐘響鈴!" + Environment.NewLine);
                        msgBox = true;
                        MessageBox.Show("時間到!該起床了喔~");
                    }
                }
            }
        }

        private void btnSelectAlarm_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "音樂檔案 (*.mp3;*.wav)|*.mp3;*.wav|所有檔案 (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                string openFilePath = openFileDialog.FileName;
                lblFile.Text = openFilePath;
                player = new SoundPlayer(openFilePath);
                selectFile = true;

                GetTime();

                if (hour < 12) {
                    txtMsg.AppendText($"{year:D2}/{month:D2}/{day:D2} 上午 {hour:D2}:{min:D2}:{sec:D2}：已設定鬧鈴" + Environment.NewLine);
                } else {
                    txtMsg.AppendText($"{year - 12:D2}/{month:D2}/{day:D2} 下午 {hour - 12:D2}:{min:D2}:{sec:D2}：已設定鬧鈴" + Environment.NewLine);
                }
            }
        }

        private void lblPrint_Click(object sender, EventArgs e) {
            GetTime();

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "文字檔 (*.txt)|*.txt|所有檔案 (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                string saveFilePath = saveFileDialog.FileName;
                File.WriteAllText(saveFilePath, txtMsg.Text);

                if (hour < 12) {
                    txtMsg.AppendText($"{year:D2}/{month:D2}/{day:D2} 上午 {hour:D2}:{min:D2}:{sec:D2}：已匯出記錄檔" + Environment.NewLine);
                } else {
                    txtMsg.AppendText($"{year:D2}/{month:D2}/{day:D2} 下午 {hour - 12:D2}:{min:D2}:{sec:D2}：已匯出記錄檔" + Environment.NewLine);
                }
            }
        }

        private void btnAct_Click(object sender, EventArgs e) {
            if (!alarmAct) {
                GetTime();

                if (!selectFile) {
                    MessageBox.Show("請先設定鬧鈴!");

                    if (hour < 12) {
                        txtMsg.AppendText($"{year:D2}/{month:D2}/{day:D2} 上午 {hour:D2}:{min:D2}:{sec:D2}：錯誤訊息!" + Environment.NewLine);
                    } else {
                        txtMsg.AppendText($"{year:D2}/{month:D2}/{day:D2} 下午 {hour - 12:D2}:{min:D2}:{sec:D2}：錯誤訊息!" + Environment.NewLine);
                    }
                    return;
                }

                if (hour < 12) {
                    txtMsg.AppendText($"{year:D2}/{month:D2}/{day:D2} 上午 {hour:D2}:{min:D2}:{sec:D2}：已設定鬧鐘" + Environment.NewLine);
                } else {
                    txtMsg.AppendText($"{year:D2}/{month:D2}/{day:D2} 下午 {hour - 12:D2}:{min:D2}:{sec:D2}：已設定鬧鐘" + Environment.NewLine);
                }

                selectDataTime = dtp.Value;
                alarmhour = selectDataTime.Hour;
                alarmMin = selectDataTime.Minute;

                alarmAct = true;
                btnAct.Text = "停止";
            } else if (alarmAct) {
                GetTime();

                if (hour < 12) {
                    txtMsg.AppendText($"{year:D2}/{month:D2}/{day:D2} 上午 {hour:D2}:{min:D2}:{sec:D2}：已關閉鬧鐘" + Environment.NewLine);
                } else {
                    txtMsg.AppendText($"{year:D2}/{month:D2}/{day:D2} 下午 {hour - 12:D2}:{min:D2}:{sec:D2}：已關閉鬧鐘" + Environment.NewLine);
                }

                player.Stop();
                msgBox = false;
                alarmAct = false;
                btnAct.Text = "啟動";
            }
        }
    }
}