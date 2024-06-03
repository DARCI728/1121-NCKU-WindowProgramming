using System.Diagnostics.Tracing;
using static practice_7_2.MainForm;

namespace practice_7_2 {
    public partial class MainForm : Form {
        private bool fileOpen = false, addWord = false, searchWord = false, cheaked = false;
        private string openFilePath = "";
        private string saveFilePath = "";

        public MainForm() {
            InitializeComponent();
            txtWords.Size = new Size(760, 420);
        }

        private void Reset() {
            menu新增單字.Text = "新增單字";
            menu搜尋單字.Text = "搜尋單字";

            addWord = false;
            searchWord = false;

            chkWord.Checked = false;
            chkChinese.Checked = false;
            chkSpeech.Checked = false;

            lbl1.Visible = false;
            lbl2.Visible = false;
            lbl3.Visible = false;

            txtWord.Visible = false;
            txtChinese.Visible = false;
            cboSpeech.Visible = false;

            chkWord.Visible = false;
            chkChinese.Visible = false;
            chkSpeech.Visible = false;

            btn.Visible = false;

            txtWords.Size = new Size(760, 420);
        }

        private void renewtxtWords() {
            txtWords.Clear();

            if (searchWord && cheaked) {
                for (int i = 0; i < GlobalData.Words.Count; i++) {
                    if (chkWord.Checked && chkChinese.Checked == false && chkSpeech.Checked == false) {
                        if (GlobalData.Words[i].word == txtWord.Text && GlobalData.Words[i].check) {
                            txtWords.AppendText(GlobalData.Words[i].word + " " + GlobalData.Words[i].chinese + " " + GlobalData.Words[i].speech + Environment.NewLine);
                        }
                    } else if (chkWord.Checked == false && chkChinese.Checked && chkSpeech.Checked == false) {
                        if (GlobalData.Words[i].chinese == txtChinese.Text && GlobalData.Words[i].check) {
                            txtWords.AppendText(GlobalData.Words[i].word + " " + GlobalData.Words[i].chinese + " " + GlobalData.Words[i].speech + Environment.NewLine);
                        }
                    } else if (chkWord.Checked == false && chkChinese.Checked == false && chkSpeech.Checked) {
                        if (GlobalData.Words[i].speech == cboSpeech.Text && GlobalData.Words[i].check) {
                            txtWords.AppendText(GlobalData.Words[i].word + " " + GlobalData.Words[i].chinese + " " + GlobalData.Words[i].speech + Environment.NewLine);
                        }
                    } else if (chkWord.Checked && chkChinese.Checked && chkSpeech.Checked == false) {
                        if (GlobalData.Words[i].word == txtWord.Text && GlobalData.Words[i].chinese == txtChinese.Text && GlobalData.Words[i].check) {
                            txtWords.AppendText(GlobalData.Words[i].word + " " + GlobalData.Words[i].chinese + " " + GlobalData.Words[i].speech + Environment.NewLine);
                        }
                    } else if (chkWord.Checked && chkChinese.Checked == false && chkSpeech.Checked) {
                        if (GlobalData.Words[i].word == txtWord.Text && GlobalData.Words[i].speech == cboSpeech.Text && GlobalData.Words[i].check) {
                            txtWords.AppendText(GlobalData.Words[i].word + " " + GlobalData.Words[i].chinese + " " + GlobalData.Words[i].speech + Environment.NewLine);
                        }
                    } else if (chkWord.Checked == false && chkChinese.Checked && chkSpeech.Checked) {
                        if (GlobalData.Words[i].chinese == txtChinese.Text && GlobalData.Words[i].speech == cboSpeech.Text && GlobalData.Words[i].check) {
                            txtWords.AppendText(GlobalData.Words[i].word + " " + GlobalData.Words[i].chinese + " " + GlobalData.Words[i].speech + Environment.NewLine);
                        }
                    } else if (chkWord.Checked && chkChinese.Checked && chkSpeech.Checked) {
                        if (GlobalData.Words[i].word == txtWord.Text && GlobalData.Words[i].chinese == txtChinese.Text && GlobalData.Words[i].speech == cboSpeech.Text && GlobalData.Words[i].check) {
                            txtWords.AppendText(GlobalData.Words[i].word + " " + GlobalData.Words[i].chinese + " " + GlobalData.Words[i].speech + Environment.NewLine);
                        }
                    } else if (chkWord.Checked == false && chkChinese.Checked == false && chkSpeech.Checked == false) {
                        if (GlobalData.Words[i].check) {
                            txtWords.AppendText(GlobalData.Words[i].word + " " + GlobalData.Words[i].chinese + " " + GlobalData.Words[i].speech + Environment.NewLine);
                        }
                    }
                }
            } else if (searchWord && !cheaked) {
                for (int i = 0; i < GlobalData.Words.Count; i++) {
                    if (chkWord.Checked && chkChinese.Checked == false && chkSpeech.Checked == false) {
                        if (GlobalData.Words[i].word == txtWord.Text) {
                            txtWords.AppendText(GlobalData.Words[i].word + " " + GlobalData.Words[i].chinese + " " + GlobalData.Words[i].speech + Environment.NewLine);
                        }
                    } else if (chkWord.Checked == false && chkChinese.Checked && chkSpeech.Checked == false) {
                        if (GlobalData.Words[i].chinese == txtChinese.Text) {
                            txtWords.AppendText(GlobalData.Words[i].word + " " + GlobalData.Words[i].chinese + " " + GlobalData.Words[i].speech + Environment.NewLine);
                        }
                    } else if (chkWord.Checked == false && chkChinese.Checked == false && chkSpeech.Checked) {
                        if (GlobalData.Words[i].speech == cboSpeech.Text) {
                            txtWords.AppendText(GlobalData.Words[i].word + " " + GlobalData.Words[i].chinese + " " + GlobalData.Words[i].speech + Environment.NewLine);
                        }
                    } else if (chkWord.Checked && chkChinese.Checked && chkSpeech.Checked == false) {
                        if (GlobalData.Words[i].word == txtWord.Text && GlobalData.Words[i].chinese == txtChinese.Text) {
                            txtWords.AppendText(GlobalData.Words[i].word + " " + GlobalData.Words[i].chinese + " " + GlobalData.Words[i].speech + Environment.NewLine);
                        }
                    } else if (chkWord.Checked && chkChinese.Checked == false && chkSpeech.Checked) {
                        if (GlobalData.Words[i].word == txtWord.Text && GlobalData.Words[i].speech == cboSpeech.Text) {
                            txtWords.AppendText(GlobalData.Words[i].word + " " + GlobalData.Words[i].chinese + " " + GlobalData.Words[i].speech + Environment.NewLine);
                        }
                    } else if (chkWord.Checked == false && chkChinese.Checked && chkSpeech.Checked) {
                        if (GlobalData.Words[i].chinese == txtChinese.Text && GlobalData.Words[i].speech == cboSpeech.Text) {
                            txtWords.AppendText(GlobalData.Words[i].word + " " + GlobalData.Words[i].chinese + " " + GlobalData.Words[i].speech + Environment.NewLine);
                        }
                    } else if (chkWord.Checked && chkChinese.Checked && chkSpeech.Checked) {
                        if (GlobalData.Words[i].word == txtWord.Text && GlobalData.Words[i].chinese == txtChinese.Text && GlobalData.Words[i].speech == cboSpeech.Text) {
                            txtWords.AppendText(GlobalData.Words[i].word + " " + GlobalData.Words[i].chinese + " " + GlobalData.Words[i].speech + Environment.NewLine);
                        }
                    } else if (chkWord.Checked == false && chkChinese.Checked == false && chkSpeech.Checked == false) {
                        txtWords.AppendText(GlobalData.Words[i].word + " " + GlobalData.Words[i].chinese + " " + GlobalData.Words[i].speech + Environment.NewLine);
                    }
                }
            } else if (cheaked) {
                foreach (var word in GlobalData.Words) {
                    if (word.check) {
                        txtWords.AppendText(word.word + " " + word.chinese + " " + word.speech + Environment.NewLine);
                    }
                }
            } else {
                foreach (var word in GlobalData.Words) {
                    txtWords.AppendText(word.word + " " + word.chinese + " " + word.speech + Environment.NewLine);
                }
            }
        }

        private void menuFile_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            switch (e.ClickedItem.ToString()) {
                case "新增":
                    fileOpen = false;
                    txtWords.Clear();
                    GlobalData.Words.Clear();
                    Reset();
                    break;

                case "開啟舊檔":
                    GlobalData.Words.Clear();
                    txtWords.Clear();

                    OpenFileDialog openFileDialog = new OpenFileDialog();
                    openFileDialog.Filter = "Text File (*.txt)|*.txt|Todo File (*.todo)|*.todo|All File (*.*)|*.*";

                    if (openFileDialog.ShowDialog() == DialogResult.OK) {
                        fileOpen = true;
                        openFilePath = openFileDialog.FileName;

                        string[] lines = File.ReadAllLines(openFilePath);

                        foreach (var line in lines) {
                            string[] words = line.Split(' ');

                            Word word = new Word();
                            word.word = words[0];
                            word.chinese = words[1];
                            word.speech = words[2];

                            GlobalData.Words.Add(word);
                            txtWords.AppendText(line + Environment.NewLine);
                        }
                    }
                    break;

                case "存檔":
                    if (cheaked) {
                        MessageBox.Show("目前只會存取被標記的單字喔!", "通知", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    if (fileOpen) {
                        File.WriteAllText(openFilePath, txtWords.Text);
                    } else {
                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        saveFileDialog.Filter = "文本檔 (*.txt)|*.txt|Todo 檔案 (*.todo)|*.todo|所有檔案 (*.*)|*.*";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                            saveFilePath = saveFileDialog.FileName;
                            File.WriteAllText(saveFilePath, txtWords.Text);
                        }
                    }

                    Reset();
                    break;

                case "另存新檔":
                    if (cheaked) {
                        MessageBox.Show("目前只會存取被標記的單字喔!", "通知", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    SaveFileDialog saveAsFileDialog = new SaveFileDialog();
                    saveAsFileDialog.Filter = "文本檔 (*.txt)|*.txt|Todo 檔案 (*.todo)|*.todo|所有檔案 (*.*)|*.*";

                    if (saveAsFileDialog.ShowDialog() == DialogResult.OK) {
                        saveFilePath = saveAsFileDialog.FileName;
                        File.WriteAllText(saveFilePath, txtWords.Text);
                    }

                    Reset();
                    break;

                case "離開":
                    Application.Exit();
                    break;

                default:
                    break;
            }
        }

        private void menuFunc_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            switch (e.ClickedItem.ToString()) {
                case "新增單字":
                    if (!addWord) {
                        Reset();
                        addWord = true;

                        menu新增單字.Text = "新增單字 (v)";
                        btn.Text = "新增";

                        lbl1.Visible = true;
                        lbl2.Visible = true;
                        lbl3.Visible = true;
                        txtWord.Visible = true;
                        txtChinese.Visible = true;
                        cboSpeech.Visible = true;
                        btn.Visible = true;

                        txtWords.Size = new Size(500, 420);

                        renewtxtWords();
                    }
                    break;

                case "新增單字 (v)":
                    Reset();
                    renewtxtWords();
                    break;

                case "搜尋單字":
                    if (!searchWord) {
                        Reset();
                        searchWord = true;

                        menu搜尋單字.Text = "搜尋單字 (v)";
                        btn.Text = "搜尋";

                        lbl1.Visible = true;
                        lbl2.Visible = true;
                        lbl3.Visible = true;
                        txtWord.Visible = true;
                        txtChinese.Visible = true;
                        cboSpeech.Visible = true;
                        chkWord.Visible = true;
                        chkChinese.Visible = true;
                        chkSpeech.Visible = true;
                        btn.Visible = true;

                        txtWords.Size = new Size(500, 420);
                    } else {
                        Reset();
                    }
                    break;

                case "搜尋單字 (v)":
                    Reset();
                    renewtxtWords();
                    break;

                case "單字測驗":
                    GlobalData.fontDialog.Font = txtWords.Font;
                    SubForm subForm = new SubForm(this);
                    subForm.Show();
                    this.Hide();
                    break;

                default:
                    break;
            }
        }

        private void menuView_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            switch (e.ClickedItem.ToString()) {
                case "字型大小":
                    if (GlobalData.fontDialog.ShowDialog() == DialogResult.OK) {
                        txtWords.Font = GlobalData.fontDialog.Font;
                    }
                    break;

                case "只顯示標記單字":
                    menu只顯示標記單字.Text = "只顯示標記單字 (v)";
                    cheaked = true;
                    renewtxtWords();
                    break;

                case "只顯示標記單字 (v)":
                    menu只顯示標記單字.Text = "只顯示標記單字";
                    cheaked = false;
                    renewtxtWords();
                    break;

                case "清除標記":
                    foreach (var word in GlobalData.Words) {
                        if (word.check) {
                            word.check = false;
                        }
                    }

                    renewtxtWords();
                    break;

                default:
                    break;
            }
        }

        private void btn_Click(object sender, EventArgs e) {
            if (addWord && txtWord.Text != "" && txtChinese.Text != "" && cboSpeech.Text != "") {
                Word word = new Word();
                word.word = txtWord.Text;
                word.chinese = txtChinese.Text;
                word.speech = cboSpeech.Text;
                word.check = false;
                GlobalData.Words.Add(word);

                txtWord.Clear();
                txtChinese.Clear();
                cboSpeech.SelectedIndex = -1;

                renewtxtWords();
            } else if (searchWord) {
                renewtxtWords();
            }
        }
    }

    public class Word {
        public string word = "";
        public string chinese = "";
        public string speech = "";
        public bool check = false;
    }

    public static class GlobalData {
        public static FontDialog fontDialog = new FontDialog();
        public static List<Word> Words { get; set; } = new List<Word>();
    }
}