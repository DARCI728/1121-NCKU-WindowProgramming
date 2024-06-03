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
                if (selectDataTime.ToString("tt") == "�W��") {
                    if (hour == alarmhour && min == alarmMin) {
                        player.PlayLooping();
                        txtMsg.AppendText($"{year:D2}/{month:D2}/{day:D2} �W�� {hour:D2}:{min:D2}:{sec:D2}�G�x���T�a!" + Environment.NewLine);
                        msgBox = true;
                        MessageBox.Show("�ɶ���!�Ӱ_�ɤF��~");
                    }
                } else if (selectDataTime.ToString("tt") == "�U��") {
                    if ((alarmhour - 12) == hour && min == alarmMin) {
                        player.PlayLooping();
                        txtMsg.AppendText($"{year:D2}/{month:D2}/{day:D2} �U�� {hour:D2}:{min:D2}:{sec:D2}�G�x���T�a!" + Environment.NewLine);
                        msgBox = true;
                        MessageBox.Show("�ɶ���!�Ӱ_�ɤF��~");
                    }
                }
            }
        }

        private void btnSelectAlarm_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "�����ɮ� (*.mp3;*.wav)|*.mp3;*.wav|�Ҧ��ɮ� (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                string openFilePath = openFileDialog.FileName;
                lblFile.Text = openFilePath;
                player = new SoundPlayer(openFilePath);
                selectFile = true;

                GetTime();

                if (hour < 12) {
                    txtMsg.AppendText($"{year:D2}/{month:D2}/{day:D2} �W�� {hour:D2}:{min:D2}:{sec:D2}�G�w�]�w�x�a" + Environment.NewLine);
                } else {
                    txtMsg.AppendText($"{year - 12:D2}/{month:D2}/{day:D2} �U�� {hour - 12:D2}:{min:D2}:{sec:D2}�G�w�]�w�x�a" + Environment.NewLine);
                }
            }
        }

        private void lblPrint_Click(object sender, EventArgs e) {
            GetTime();

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "��r�� (*.txt)|*.txt|�Ҧ��ɮ� (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                string saveFilePath = saveFileDialog.FileName;
                File.WriteAllText(saveFilePath, txtMsg.Text);

                if (hour < 12) {
                    txtMsg.AppendText($"{year:D2}/{month:D2}/{day:D2} �W�� {hour:D2}:{min:D2}:{sec:D2}�G�w�ץX�O����" + Environment.NewLine);
                } else {
                    txtMsg.AppendText($"{year:D2}/{month:D2}/{day:D2} �U�� {hour - 12:D2}:{min:D2}:{sec:D2}�G�w�ץX�O����" + Environment.NewLine);
                }
            }
        }

        private void btnAct_Click(object sender, EventArgs e) {
            if (!alarmAct) {
                GetTime();

                if (!selectFile) {
                    MessageBox.Show("�Х��]�w�x�a!");

                    if (hour < 12) {
                        txtMsg.AppendText($"{year:D2}/{month:D2}/{day:D2} �W�� {hour:D2}:{min:D2}:{sec:D2}�G���~�T��!" + Environment.NewLine);
                    } else {
                        txtMsg.AppendText($"{year:D2}/{month:D2}/{day:D2} �U�� {hour - 12:D2}:{min:D2}:{sec:D2}�G���~�T��!" + Environment.NewLine);
                    }
                    return;
                }

                if (hour < 12) {
                    txtMsg.AppendText($"{year:D2}/{month:D2}/{day:D2} �W�� {hour:D2}:{min:D2}:{sec:D2}�G�w�]�w�x��" + Environment.NewLine);
                } else {
                    txtMsg.AppendText($"{year:D2}/{month:D2}/{day:D2} �U�� {hour - 12:D2}:{min:D2}:{sec:D2}�G�w�]�w�x��" + Environment.NewLine);
                }

                selectDataTime = dtp.Value;
                alarmhour = selectDataTime.Hour;
                alarmMin = selectDataTime.Minute;

                alarmAct = true;
                btnAct.Text = "����";
            } else if (alarmAct) {
                GetTime();

                if (hour < 12) {
                    txtMsg.AppendText($"{year:D2}/{month:D2}/{day:D2} �W�� {hour:D2}:{min:D2}:{sec:D2}�G�w�����x��" + Environment.NewLine);
                } else {
                    txtMsg.AppendText($"{year:D2}/{month:D2}/{day:D2} �U�� {hour - 12:D2}:{min:D2}:{sec:D2}�G�w�����x��" + Environment.NewLine);
                }

                player.Stop();
                msgBox = false;
                alarmAct = false;
                btnAct.Text = "�Ұ�";
            }
        }
    }
}