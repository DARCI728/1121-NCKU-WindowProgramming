using System.Windows.Forms;
using static practice_7_2.MainForm;

namespace practice_7_2 {
    public partial class SubForm : Form {
        private MainForm mainForm;
        private Random random = new Random();

        private int num;

        public SubForm(MainForm mainForm) {
            InitializeComponent();
            this.mainForm = mainForm;

            num = random.Next(0, GlobalData.Words.Count);
            lblWord.Text = "單字: " + GlobalData.Words[num].word;
            lblChinese.Text = "中文: " + GlobalData.Words[num].chinese;
            lblSpeech.Text = "詞性: " + GlobalData.Words[num].speech;
            lblChinese.Visible = false;
            lblSpeech.Visible = false;
            lblWord.Font = GlobalData.fontDialog.Font;
            lblChinese.Font = GlobalData.fontDialog.Font;
            lblSpeech.Font = GlobalData.fontDialog.Font;

            if (GlobalData.Words[num].check) {
                chkCheak.Checked = true;
            }
        }

        private void SubForm_FormClosed(object sender, FormClosedEventArgs e) {
            mainForm.Show();
        }

        private void btnShow_Click(object sender, EventArgs e) {
            lblChinese.Visible = true;
            lblSpeech.Visible = true;
        }

        private void btnNext_Click(object sender, EventArgs e) {
            if (chkCheak.Checked) {
                GlobalData.Words[num].check = true;
            }

            num = random.Next(0, GlobalData.Words.Count);
            lblWord.Text = "單字: " + GlobalData.Words[num].word;
            lblChinese.Text = "中文: " + GlobalData.Words[num].chinese;
            lblSpeech.Text = "詞性: " + GlobalData.Words[num].speech;
            lblChinese.Visible = false;
            lblSpeech.Visible = false;
            lblWord.Font = GlobalData.fontDialog.Font;
            lblChinese.Font = GlobalData.fontDialog.Font;
            lblSpeech.Font = GlobalData.fontDialog.Font;

            if (GlobalData.Words[num].check) {
                chkCheak.Checked = true;
            } else {
                chkCheak.Checked = false;
            }
        }
    }
}
