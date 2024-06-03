using Microsoft.VisualBasic;

namespace practice_6_1 {
    public partial class Form1 : Form {
        int time = 0, step = 0;
        bool pushPic = false, gameStart = false;
        Image originalImage, resizedImage;

        public Form1() {
            InitializeComponent();
            btn00.Tag = 0;
            btn01.Tag = 1;
            btn02.Tag = 2;
            btn10.Tag = 3;
            btn11.Tag = 4;
            btn12.Tag = 5;
            btn20.Tag = 6;
            btn21.Tag = 7;
            btn22.Tag = 8;
        }

        private int CalculateInversions(int[] puzzle) {
            int inversionCount = 0;

            for (int i = 0; i < puzzle.Length - 1; i++) {
                for (int j = i + 1; j < puzzle.Length; j++) {
                    if (puzzle[i] > puzzle[j]) {
                        inversionCount++;
                    }
                }
            }

            return inversionCount;
        }

        private void btnChoosePic_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "圖像文件|*.jpg;*.png;*.bmp;|所有文件|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                string imagePath = openFileDialog.FileName;
                originalImage = Image.FromFile(imagePath);
                resizedImage = new Bitmap(originalImage, new Size(300, 300));
                picPuzzle.Image = resizedImage;
                picPuzzle.Visible = true;
                lblShow.Visible = true;
                lblNotShow.Visible = true;
                trbShow.Visible = true;
                pushPic = true;
            }
        }

        private void btnDraw_Click(object sender, EventArgs e) {
            imgPuzzle = new ImageList();
            imgPuzzle.ImageSize = new Size(100, 100);
            imgPuzzle.ColorDepth = ColorDepth.Depth32Bit;

            if (pushPic) {
                for (int i = 0; i < 3; i++) {
                    for (int j = 0; j < 3; j++) {
                        Bitmap dividedImage = new Bitmap(100, 100);
                        Graphics graphic = Graphics.FromImage(dividedImage);
                        graphic.DrawImage(resizedImage,
                                 new Rectangle(0, 0, 100, 100),
                                 new Rectangle(100 * j, 100 * i, 100, 100),
                                 GraphicsUnit.Pixel);
                        imgPuzzle.Images.Add(dividedImage);
                    }
                }

                tmr.Enabled = true;
            } else {
                MessageBox.Show("請先選擇圖片!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int k, inversionCount = 1;
            int[] arr = new int[8] { -1, -1, -1, -1, -1, -1, -1, -1 };
            Random random = new Random();

            while (inversionCount % 2 == 1) {
                k = -1;
                arr = new int[8] { -1, -1, -1, -1, -1, -1, -1, -1 };

                while (k < 7) {
                    int num = random.Next(0, 8);
                    if (Array.IndexOf(arr, num) == -1) {
                        arr[++k] = num;
                    }
                }

                inversionCount = CalculateInversions(arr);
            }

            btn00.ImageIndex = arr[0];
            btn01.ImageIndex = arr[1];
            btn02.ImageIndex = arr[2];
            btn10.ImageIndex = arr[3];
            btn11.ImageIndex = arr[4];
            btn12.ImageIndex = arr[5];
            btn20.ImageIndex = arr[6];
            btn21.ImageIndex = arr[7];

            btn00.ImageList = imgPuzzle;
            btn01.ImageList = imgPuzzle;
            btn02.ImageList = imgPuzzle;
            btn10.ImageList = imgPuzzle;
            btn11.ImageList = imgPuzzle;
            btn12.ImageList = imgPuzzle;
            btn20.ImageList = imgPuzzle;
            btn21.ImageList = imgPuzzle;
            btn22.ImageList = imgPuzzle;

            btn00.Enabled = true;
            btn01.Enabled = true;
            btn02.Enabled = true;
            btn10.Enabled = true;
            btn11.Enabled = true;
            btn12.Enabled = true;
            btn20.Enabled = true;
            btn21.Enabled = true;
            btn22.Enabled = true;

            btn00.Visible = true;
            btn01.Visible = true;
            btn02.Visible = true;
            btn10.Visible = true;
            btn11.Visible = true;
            btn12.Visible = true;
            btn20.Visible = true;
            btn21.Visible = true;
            btn22.Visible = false;

            time = 0;
            step = 0;
            lblTime.Text = $"time: {time / 60:D2}:{time % 60:D2}";
            lblStep.Text = "移動布數: " + step;

            gameEnd();
        }

        private void trbShow_Scroll(object sender, EventArgs e) {
            if (trbShow.Value == 0) {
                picPuzzle.Image = null;
                picPuzzle.BackColor = Color.Gray;
            } else {
                picPuzzle.Image = resizedImage;
            }
        }

        private void gameEnd() {
            if ((int)btn00.Tag == btn00.ImageIndex &&
                (int)btn01.Tag == btn01.ImageIndex &&
                (int)btn02.Tag == btn02.ImageIndex &&
                (int)btn10.Tag == btn10.ImageIndex &&
                (int)btn11.Tag == btn11.ImageIndex &&
                (int)btn12.Tag == btn12.ImageIndex &&
                (int)btn20.Tag == btn20.ImageIndex &&
                (int)btn21.Tag == btn21.ImageIndex &&
                btn22.Visible == false) {
                btn00.Enabled = false;
                btn01.Enabled = false;
                btn02.Enabled = false;
                btn10.Enabled = false;
                btn11.Enabled = false;
                btn12.Enabled = false;
                btn20.Enabled = false;
                btn21.Enabled = false;
                btn22.Enabled = false;
                tmr.Enabled = false;
                MessageBox.Show($"你獲勝了!\n完成時間: {time / 60:D2}:{time % 60:D2}\n移動步數: {step}");
            }
        }

        private void btn00_Click(object sender, EventArgs e) {
            if (btn01.Visible == false) {
                btn01.ImageIndex = btn00.ImageIndex;
                btn01.Visible = true;
                btn00.Visible = false;
            } else if (btn10.Visible == false) {
                btn10.ImageIndex = btn00.ImageIndex;
                btn10.Visible = true;
                btn00.Visible = false;
            }

            step++;
            lblStep.Text = "移動布數: " + step;
            gameEnd();
        }

        private void btn01_Click(object sender, EventArgs e) {
            if (btn00.Visible == false) {
                btn00.ImageIndex = btn01.ImageIndex;
                btn00.Visible = true;
                btn01.Visible = false;
            } else if (btn11.Visible == false) {
                btn11.ImageIndex = btn01.ImageIndex;
                btn11.Visible = true;
                btn01.Visible = false;
            } else if (btn02.Visible == false) {
                btn02.ImageIndex = btn01.ImageIndex;
                btn02.Visible = true;
                btn01.Visible = false;
            }

            step++;
            lblStep.Text = "移動布數: " + step;
            gameEnd();
        }

        private void btn02_Click(object sender, EventArgs e) {
            if (btn01.Visible == false) {
                btn01.ImageIndex = btn02.ImageIndex;
                btn01.Visible = true;
                btn02.Visible = false;
            } else if (btn12.Visible == false) {
                btn12.ImageIndex = btn02.ImageIndex;
                btn12.Visible = true;
                btn02.Visible = false;
            }

            step++;
            lblStep.Text = "移動布數: " + step;
            gameEnd();
        }

        private void btn10_Click(object sender, EventArgs e) {
            if (btn00.Visible == false) {
                btn00.ImageIndex = btn10.ImageIndex;
                btn00.Visible = true;
                btn10.Visible = false;
            } else if (btn11.Visible == false) {
                btn11.ImageIndex = btn10.ImageIndex;
                btn11.Visible = true;
                btn10.Visible = false;
            } else if (btn20.Visible == false) {
                btn20.ImageIndex = btn10.ImageIndex;
                btn20.Visible = true;
                btn10.Visible = false;
            }

            step++;
            lblStep.Text = "移動布數: " + step;
            gameEnd();
        }

        private void btn11_Click(object sender, EventArgs e) {
            if (btn01.Visible == false) {
                btn01.ImageIndex = btn11.ImageIndex;
                btn01.Visible = true;
                btn11.Visible = false;
            } else if (btn10.Visible == false) {
                btn10.ImageIndex = btn11.ImageIndex;
                btn10.Visible = true;
                btn11.Visible = false;
            } else if (btn12.Visible == false) {
                btn12.ImageIndex = btn11.ImageIndex;
                btn12.Visible = true;
                btn11.Visible = false;
            } else if (btn21.Visible == false) {
                btn21.ImageIndex = btn11.ImageIndex;
                btn21.Visible = true;
                btn11.Visible = false;
            }

            step++;
            lblStep.Text = "移動布數: " + step;
            gameEnd();
        }

        private void btn12_Click(object sender, EventArgs e) {
            if (btn02.Visible == false) {
                btn02.ImageIndex = btn12.ImageIndex;
                btn02.Visible = true;
                btn12.Visible = false;
            } else if (btn11.Visible == false) {
                btn11.ImageIndex = btn12.ImageIndex;
                btn11.Visible = true;
                btn12.Visible = false;
            } else if (btn22.Visible == false) {
                btn22.ImageIndex = btn12.ImageIndex;
                btn22.Visible = true;
                btn12.Visible = false;
            }

            step++;
            lblStep.Text = "移動布數: " + step;
            gameEnd();
        }

        private void btn20_Click(object sender, EventArgs e) {
            if (btn10.Visible == false) {
                btn10.ImageIndex = btn20.ImageIndex;
                btn10.Visible = true;
                btn20.Visible = false;
            } else if (btn21.Visible == false) {
                btn21.ImageIndex = btn20.ImageIndex;
                btn21.Visible = true;
                btn20.Visible = false;
            }

            step++;
            lblStep.Text = "移動布數: " + step;
            gameEnd();
        }

        private void btn21_Click(object sender, EventArgs e) {
            if (btn20.Visible == false) {
                btn20.ImageIndex = btn21.ImageIndex;
                btn20.Visible = true;
                btn21.Visible = false;
            } else if (btn11.Visible == false) {
                btn11.ImageIndex = btn21.ImageIndex;
                btn11.Visible = true;
                btn21.Visible = false;
            } else if (btn22.Visible == false) {
                btn22.ImageIndex = btn21.ImageIndex;
                btn22.Visible = true;
                btn21.Visible = false;
            }

            step++;
            lblStep.Text = "移動布數: " + step;
            gameEnd();
        }

        private void btn22_Click(object sender, EventArgs e) {
            if (btn21.Visible == false) {
                btn21.ImageIndex = btn22.ImageIndex;
                btn21.Visible = true;
                btn22.Visible = false;
            } else if (btn12.Visible == false) {
                btn12.ImageIndex = btn22.ImageIndex;
                btn12.Visible = true;
                btn22.Visible = false;
            }

            step++;
            lblStep.Text = "移動布數: " + step;
            gameEnd();
        }

        private void tmr_Tick(object sender, EventArgs e) {
            time++;
            lblTime.Text = $"time: {time / 60:D2}:{time % 60:D2}";
        }
    }
}