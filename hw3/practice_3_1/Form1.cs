using System.Drawing;
using System.Xml.Linq;

namespace practice_3_1 {
    public partial class Form : System.Windows.Forms.Form {
        bool oracle_moment = false;
        public Form() {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            if (oracle_moment == false) {
                String[] analysis = new string[] { "桃花運大漲", "家庭遭逢變故", "事業平步青雲，有升官可能", "事業起伏大", "親人病情好轉", "被財神眷顧", "近期一帆風順" };

                String[] suggest = { "少做壞事，夜路走多了總匯三明治",
                     "保持謙虛，一山還有一山高，雞蛋還有雞蛋糕",
                     "善待他人，不要任意嘲笑別人，除非你忍不住",
                     "早點睡覺，不要仗著自己長得醜，就任意熬夜",
                     "小心小人，可謂浮雲能蔽日，輕舟已過萬重山",
                     "不要偷懶，你在睡覺的時候，美國人還在上班阿",
                     "健康第一，定期身體檢查並謹記醫生怎麼說，doctor!",
                     "穩定情緒，今天不開心沒關係，反正明天也不會開心"};

                var rand = new Random();
                int fortune = rand.Next(0, 7);
                int advice = rand.Next(0, 8);

                string name = txtName.Text;
                string gender = txtGender.Text;
                string birth = txtBirth.Text;
                string today = txtToday.Text;
                string prefer = txtPrefer.Text;
                bool error = false;

                if (name == "") {
                    lblNameError.Text = "此欄未填寫";
                    error = true;
                } else {
                    lblNameError.Text = "";
                }

                if (gender == "") {
                    lblGenderError.Text = "此欄未填寫";
                    error = true;
                } else if (!string.Equals(gender, "男") && !string.Equals(gender, "女")) {
                    lblGenderError.Text = "輸入應為男or女";
                    error = true;
                } else {
                    lblGenderError.Text = "";
                }

                if (birth == "") {
                    lblBirthError.Text = "此欄未填寫";
                    error = true;
                } else {
                    lblBirthError.Text = "";
                }

                if (today == "") {
                    lblTodayError.Text = "此欄未填寫";
                    error = true;
                } else {
                    lblTodayError.Text = "";
                }

                if (prefer == "") {
                    lblPreferError.Text = "此欄未填寫";
                    error = true;
                } else if (!string.Equals(prefer, "貓") && !string.Equals(prefer, "狗")) {
                    lblPreferError.Text = "輸入應為貓or狗";
                    error = true;
                } else {
                    lblPreferError.Text = "";
                }

                if (error == true) {
                    return;
                } else {
                    oracle_moment = true;

                    txtName.Visible = false;
                    txtGender.Visible = false;
                    txtBirth.Visible = false;
                    txtToday.Visible = false;
                    txtPrefer.Visible = false;
                    lblFortune.Visible = true;
                    lblAdvice.Visible = true;

                    lblName.Location = new Point(220, 60);
                    lblNameError.Location = new Point(220, 90);
                    lblNameError.Text = name;

                    lblGender.Location = new Point(510, 60);
                    lblGenderError.Location = new Point(510, 90);
                    lblGenderError.Text = gender;

                    lblBirth.Location = new Point(70, 120);
                    lblBirthError.Location = new Point(70, 150);
                    lblBirthError.Text = birth;

                    lblToday.Location = new Point(370, 120);
                    lblTodayError.Location = new Point(370, 150);
                    lblTodayError.Text = today;

                    lblPrefer.Location = new Point(640, 120);
                    lblPreferError.Location = new Point(640, 150);
                    lblPreferError.Text = prefer;

                    lblDataInput.Text = "神諭時刻";
                    lblFortune.Text = "運勢：" + analysis[fortune];
                    lblAdvice.Text = "建議：" + suggest[advice];
                    btn.Text = "來，下面一位~~";
                }
            } else {
                oracle_moment = false;

                txtName.Visible = true;
                txtGender.Visible = true;
                txtBirth.Visible = true;
                txtToday.Visible = true;
                txtPrefer.Visible = true;
                lblFortune.Visible = false;
                lblAdvice.Visible = false;

                lblName.Location = new Point(120, 80);
                lblNameError.Location = new Point(580, 80);
                lblNameError.Text = "";
                txtName.Text = "";

                lblGender.Location = new Point(120, 140);
                lblGenderError.Location = new Point(580, 140);
                lblGenderError.Text = "";
                txtGender.Text = "";

                lblBirth.Location = new Point(120, 200);
                lblBirthError.Location = new Point(580, 200);
                lblBirthError.Text = "";
                txtBirth.Text = "";

                lblToday.Location = new Point(120, 260);
                lblTodayError.Location = new Point(580, 260);
                lblTodayError.Text = "";
                txtToday.Text = "";

                lblPrefer.Location = new Point(120, 320);
                lblPreferError.Location = new Point(580, 320);
                lblPreferError.Text = "";
                txtPrefer.Text = "";

                lblDataInput.Text = "資料輸入";
                btn.Text = "AI大神請告訴我答案吧";
            }
        }
    }
}