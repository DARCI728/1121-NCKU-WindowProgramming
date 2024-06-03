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
                String[] analysis = new string[] { "���B�j��", "�a�x�D�{�ܬG", "�Ʒ~���B�C���A���ɩx�i��", "�Ʒ~�_��j", "�ˤH�f���n��", "�Q�]�����U", "����@�|����" };

                String[] suggest = { "�ְ��a�ơA�]�����h�F�`�פT���v",
                     "�O������A�@�s�٦��@�s���A���J�٦����J�|",
                     "���ݥL�H�A���n���N�J���O�H�A���D�A�Ԥ���",
                     "���I��ı�A���n�M�ۦۤv���o��A�N���N���]",
                     "�p�ߤp�H�A�i�ׯB���ཪ��A����w�L�U���s",
                     "���n���i�A�A�b��ı���ɭԡA����H�٦b�W�Z��",
                     "���d�Ĥ@�A�w�������ˬd���԰O��ͫ�򻡡Adoctor!",
                     "í�w�����A���Ѥ��}�ߨS���Y�A�ϥ����Ѥ]���|�}��"};

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
                    lblNameError.Text = "���楼��g";
                    error = true;
                } else {
                    lblNameError.Text = "";
                }

                if (gender == "") {
                    lblGenderError.Text = "���楼��g";
                    error = true;
                } else if (!string.Equals(gender, "�k") && !string.Equals(gender, "�k")) {
                    lblGenderError.Text = "��J�����kor�k";
                    error = true;
                } else {
                    lblGenderError.Text = "";
                }

                if (birth == "") {
                    lblBirthError.Text = "���楼��g";
                    error = true;
                } else {
                    lblBirthError.Text = "";
                }

                if (today == "") {
                    lblTodayError.Text = "���楼��g";
                    error = true;
                } else {
                    lblTodayError.Text = "";
                }

                if (prefer == "") {
                    lblPreferError.Text = "���楼��g";
                    error = true;
                } else if (!string.Equals(prefer, "��") && !string.Equals(prefer, "��")) {
                    lblPreferError.Text = "��J������or��";
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

                    lblDataInput.Text = "���ٮɨ�";
                    lblFortune.Text = "�B�աG" + analysis[fortune];
                    lblAdvice.Text = "��ĳ�G" + suggest[advice];
                    btn.Text = "�ӡA�U���@��~~";
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

                lblDataInput.Text = "��ƿ�J";
                btn.Text = "AI�j���Чi�D�ڵ��קa";
            }
        }
    }
}