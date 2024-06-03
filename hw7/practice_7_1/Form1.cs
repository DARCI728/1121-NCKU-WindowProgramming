using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace practice_7_1 {
    public partial class Form1 : System.Windows.Forms.Form {
        bool fileOpen = false;
        bool addWord = false;
        bool searchWord = false;
        string openFilePath = "";
        string saveFilePath = "";

        private class Word {
            public string word = "";
            public string chinese = "";
            public string speech = "";
            public bool check = false;
        }

        List<Word> Words = new List<Word>();

        OpenFileDialog openFileDialog = new OpenFileDialog();
        SaveFileDialog saveFileDialog = new SaveFileDialog();

        public Form1() {
            InitializeComponent();
            txtWords.Size = new Size(760, 420);
        }

        private void Reset() {
            addWord = false;
            searchWord = false;

            menu新增單字.Text = "新增單字";
            menu搜尋單字.Text = "搜尋單字";

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

        private void menuFile_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            switch (e.ClickedItem.ToString()) {
                case "新增":
                    fileOpen = false;
                    txtWords.Clear();
                    Words.Clear();
                    Reset();
                    break;

                case "開啟舊檔":
                    txtWords.Clear();
                    Words.Clear();

                    openFileDialog = new OpenFileDialog();
                    openFileDialog.Filter = "Text File (*.txt)|*.txt|Todo File (*.todo)|*.todo|All File (*.*)|*.*";

                    if (openFileDialog.ShowDialog() == DialogResult.OK) {
                        fileOpen = true;
                        openFilePath = openFileDialog.FileName;
                        string[] lines = File.ReadAllLines(openFilePath);

                        for (int i = 0; i < lines.Length; i++) {
                            string[] words = lines[i].Split(' ');
                            Word word = new Word();
                            word.word = words[0];
                            word.chinese = words[1];
                            word.speech = words[2];
                            word.check = false;
                            Words.Add(word);
                            txtWords.AppendText(lines[i] + Environment.NewLine);
                        }
                    }
                    break;

                case "存檔":
                    if (fileOpen) {
                        File.WriteAllText(openFilePath, txtWords.Text);
                    } else {
                        saveFileDialog = new SaveFileDialog();
                        saveFileDialog.Filter = "文本檔 (*.txt)|*.txt|Todo 檔案 (*.todo)|*.todo|所有檔案 (*.*)|*.*";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                            saveFilePath = saveFileDialog.FileName;
                            File.WriteAllText(saveFilePath, txtWords.Text);
                        }
                    }

                    Reset();
                    break;

                case "另存新檔":
                    saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "文本檔 (*.txt)|*.txt|Todo 檔案 (*.todo)|*.todo|所有檔案 (*.*)|*.*";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                        saveFilePath = saveFileDialog.FileName;
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

        private void toolStripMenuItem2_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e) {
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

                        txtWords.Clear();

                        foreach (Word word in Words) {
                            txtWords.AppendText(word.word + " " + word.chinese + " " + word.speech + Environment.NewLine);
                        }
                    }
                    break;

                case "新增單字 (v)":
                    Reset();
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
                    break;

                default:
                    break;
            }
        }

        private void toolStripMenuItem3_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            switch (e.ClickedItem.ToString()) {
                case "字型大小":
                    if (fontDialog.ShowDialog() == DialogResult.OK) {
                        txtWords.Font = fontDialog.Font;
                    }
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
                Words.Add(word);

                txtWords.AppendText(txtWord.Text + " " + txtChinese.Text + " " + cboSpeech.Text + Environment.NewLine);
                txtWord.Clear();
                txtChinese.Clear();
                cboSpeech.SelectedIndex = -1;
            } else if (searchWord) {
                txtWords.Clear();

                for (int i = 0; i < Words.Count; i++) {
                    if (chkWord.Checked && chkChinese.Checked == false && chkSpeech.Checked == false) {
                        if (Words[i].word == txtWord.Text) {
                            txtWords.AppendText(Words[i].word + " " + Words[i].chinese + " " + Words[i].speech + Environment.NewLine);
                        }
                    } else if (chkWord.Checked == false && chkChinese.Checked && chkSpeech.Checked == false) {
                        if (Words[i].chinese == txtChinese.Text) {
                            txtWords.AppendText(Words[i].word + " " + Words[i].chinese + " " + Words[i].speech + Environment.NewLine);
                        }
                    } else if (chkWord.Checked == false && chkChinese.Checked == false && chkSpeech.Checked) {
                        if (Words[i].speech == cboSpeech.Text) {
                            txtWords.AppendText(Words[i].word + " " + Words[i].chinese + " " + Words[i].speech + Environment.NewLine);
                        }
                    } else if (chkWord.Checked && chkChinese.Checked && chkSpeech.Checked == false) {
                        if (Words[i].word == txtWord.Text && Words[i].chinese == txtChinese.Text) {
                            txtWords.AppendText(Words[i].word + " " + Words[i].chinese + " " + Words[i].speech + Environment.NewLine);
                        }
                    } else if (chkWord.Checked && chkChinese.Checked == false && chkSpeech.Checked) {
                        if (Words[i].word == txtWord.Text && Words[i].speech == cboSpeech.Text) {
                            txtWords.AppendText(Words[i].word + " " + Words[i].chinese + " " + Words[i].speech + Environment.NewLine);
                        }
                    } else if (chkWord.Checked == false && chkChinese.Checked && chkSpeech.Checked) {
                        if (Words[i].chinese == txtChinese.Text && Words[i].speech == cboSpeech.Text) {
                            txtWords.AppendText(Words[i].word + " " + Words[i].chinese + " " + Words[i].speech + Environment.NewLine);
                        }
                    } else if (chkWord.Checked && chkChinese.Checked && chkSpeech.Checked) {
                        if (Words[i].word == txtWord.Text && Words[i].chinese == txtChinese.Text && Words[i].speech == cboSpeech.Text) {
                            txtWords.AppendText(Words[i].word + " " + Words[i].chinese + " " + Words[i].speech + Environment.NewLine);
                        }
                    }
                }
            }
        }
    }
}