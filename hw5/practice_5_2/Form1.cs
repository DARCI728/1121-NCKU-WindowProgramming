namespace practice_5_2 {
    public partial class Form1 : Form {
        private int time = 0, turn = 0;
        private int[] selectChar = { 0, 0, 0 };
        List<Servant> order = new List<Servant>();
        Button[] btn = new Button[3];

        class Servant {
            public string character;
            public int hp;
            public int charge;
            public int atk;
            public int speed;
            public int cooldown;
            public bool alive;

            public void Skill() { }
        }

        class Saber : Servant {
            public Saber() {
                character = "Saber";
                hp = 100;
                charge = 0;
                atk = 3;
                speed = 1;
                cooldown = 2;
                alive = true;
            }

            public override void Skill() {
                atk *= 2;
            }
        }

        class Caster : Servant {
            public Caster() {
                character = "Caster";
                hp = 100;
                charge = 0;
                atk = 2;
                speed = 2;
                cooldown = 2;
                alive = true;
            }

            public void Skill() {
                hp += 50;
            }
        }

        class Berserker : Servant {
            public Berserker() {
                character = "Berserker";
                hp = 100;
                charge = 0;
                atk = 4;
                speed = 4;
                cooldown = 2;
                alive = true;
            }

            public override void Skill() {
                atk *= 2;
                hp = hp - (hp / 2);
            }
        }

        class Beast : Servant {
            public Beast() {
                character = "Beast";
                hp = 500;
                charge = 0;
                atk = 2;
                speed = 3;
                cooldown = 3;
                alive = true;
            }

            public override void Skill() {
                atk += 2;
            }
        }

        Saber saber = new Saber();
        Caster caster = new Caster();
        Berserker berserker = new Berserker();
        Beast beast = new Beast();

        public Form1() {
            InitializeComponent();
        }

        private void InitializeSelectCharBtn() {
            string[] charName = { "Berserker", "Saber", "Caster" };

            for (int i = 0; i < 3; i++) {
                btn[i] = new Button();
                btn[i].SetBounds(250 + 100 * i, 200, 100, 40);
                btn[i].Text = charName[i];
                btn[i].Tag = i;
                btn[i].BackColor = Color.White;
                btn[i].Click += CharButton_Click;

                Controls.Add(btn[i]);
            }
        }

        private void CharButton_Click(object sender, EventArgs e) {
            Button clickedButton = sender as Button;

            if (clickedButton.BackColor == Color.White) {
                if (selectChar[0] + selectChar[1] + selectChar[2] == 2) {
                    MessageBox.Show("只能選擇兩個Servant!");
                } else {
                    clickedButton.BackColor = Color.LightGreen;
                    selectChar[(int)clickedButton.Tag] = 1;
                }
            } else {
                clickedButton.BackColor = Color.White;
                selectChar[(int)clickedButton.Tag] = 0;
            }
        }

        private void InitializeSkillBtn() {
            string[] skillName = { "普攻", "技能", "寶具" };

            for (int i = 0; i < 3; i++) {
                btn[i] = new Button();
                btn[i].SetBounds(250 + 100 * i, 200, 100, 40);
                btn[i].Text = skillName[i];
                btn[i].Tag = i;
                btn[i].BackColor = Color.White;
                btn[i].Click += SkillButton_Click;

                Controls.Add(btn[i]);
            }
        }

        private void SkillButton_Click(object sender, EventArgs e) {
            Button clickedButton = sender as Button;
            Random rnd = new Random();

            if ((int)clickedButton.Tag == 0) {
                if (rnd.Next(0, 100) < 50) {
                    beast.hp -= order[turn % 3].atk;
                    order[turn % 3].charge += rnd.Next(20, 26);
                    lblEnemyHP.Text = "HP: " + beast.hp.ToString();
                    lblCharCharge.Text = "Charge: " + order[turn % 3].charge.ToString();
                } else {
                    beast.hp -= order[turn % 3].atk * 2;
                    order[turn % 3].charge += 30;
                    lblEnemyHP.Text = "HP: " + beast.hp.ToString();
                    lblCharCharge.Text = "Charge: " + order[turn % 3].charge.ToString();
                    MessageBox.Show($"對Beast造成了{order[turn % 3].atk * 2}點爆擊傷害");
                }

                if (order[turn % 3].cooldown > 0) {
                    order[turn % 3].cooldown--;
                }
                turn++;
                NextRound();
            } else if ((int)clickedButton.Tag == 1) {
                if (order[turn % 3].cooldown == 0) {
                    order[turn % 3].Skill();
                    order[turn % 3].cooldown = 3;
                    lblCharHP.Text = "HP: " + order[turn % 3].hp.ToString();
                    lblCharAtk.Text = "Attack: " + order[turn % 3].atk.ToString();
                    MessageBox.Show($"{order[turn % 3].character}使用了技能");
                } else {
                    MessageBox.Show($"技能冷卻中(剩餘回合: {order[turn % 3].cooldown})");
                }
            } else if ((int)clickedButton.Tag == 2) {
                if (order[turn % 3].charge >= 100) {
                    order[turn % 3].charge -= 100;
                    if (order[turn % 3].character == "Saber") {
                        beast.hp -= saber.atk + 25;
                        saber.hp += 5;
                        lblEnemyHP.Text = "HP: " + beast.hp.ToString();
                        lblCharHP.Text = "HP: " + order[turn % 3].hp.ToString();
                        lblCharCharge.Text = "Charge: " + order[turn % 3].charge.ToString();
                        MessageBox.Show($"Saber使用了寶具\n對Beast造成{saber.atk + 25}點傷害並回復5點血量");
                    } else if (order[turn % 3].character == "Caster") {
                        saber.hp += 10;
                        saber.atk += 1;
                        caster.hp += 10;
                        caster.atk += 1;
                        berserker.hp += 10;
                        berserker.atk += 1;
                        lblCharHP.Text = "HP: " + order[turn % 3].hp.ToString();
                        lblCharAtk.Text = "Attack: " + order[turn % 3].atk.ToString();
                        lblCharCharge.Text = "Charge: " + order[turn % 3].charge.ToString();
                        MessageBox.Show($"Caster使用了寶具\n全體隊友加1點攻擊並回復10點血量");
                    } else if (order[turn % 3].character == "Berserker") {
                        beast.hp -= berserker.atk + 50;
                        lblEnemyHP.Text = "HP: " + beast.hp.ToString();
                        lblCharCharge.Text = "Charge: " + order[turn % 3].charge.ToString();
                        MessageBox.Show($"Berserker使用了寶具\n對Beast造成{berserker.atk + 50}點傷害");
                    }

                    if (order[turn % 3].cooldown > 0) {
                        order[turn % 3].cooldown--;
                    }
                    turn++;
                    NextRound();
                } else {
                    MessageBox.Show("充能不足，無法施放寶具!");
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e) {
            InitializeSelectCharBtn();

            btnStart.Visible = false;
            lblTime.Visible = true;
            lblTimer.Visible = true;

            time = 10;
            lblTimer.Text = time.ToString();
            tmrChooseChar.Enabled = true;
        }

        private void GameStart() {
            InitializeSkillBtn();

            if (selectChar[1] == 1) {
                order.Add(saber);
            }

            if (selectChar[2] == 1) {
                order.Add(caster);
            }

            order.Add(beast);

            if (selectChar[0] == 1) {
                order.Add(berserker);
            }

            lblCharName.Visible = true;
            lblCharHP.Visible = true;
            lblCharCharge.Visible = true;
            lblCharAtk.Visible = true;
            lblEnemyName.Visible = true;
            lblEnemyHP.Visible = true;
            lblEnemyCharge.Visible = true;
            lblEnemyAtk.Visible = true;
            lblTurn.Visible = true;

            NextRound();

            time = 0;
            lblTimer.Text = time.ToString();
            tmr.Enabled = true;
        }

        private void GameEnd() {
            btnStart.Visible = true;
            lblTime.Visible = false;
            lblTimer.Visible = false;
            lblCharName.Visible = false;
            lblCharHP.Visible = false;
            lblCharCharge.Visible = false;
            lblCharAtk.Visible = false;
            lblEnemyName.Visible = false;
            lblEnemyHP.Visible = false;
            lblEnemyCharge.Visible = false;
            lblEnemyAtk.Visible = false;
            lblTurn.Visible = false;

            time = 0;
            turn = 0;

            saber = new Saber();
            caster = new Caster();
            berserker = new Berserker();
            beast = new Beast();

            order.Clear();

            for (int i = 0; i < 3; i++) {
                selectChar[i] = 0;
                Controls.Remove(btn[i]);
            }
        }

        private void NextRound() {
            if (beast.hp <= 0) {
                tmr.Enabled = false;
                DialogResult = MessageBox.Show($"You Win!\n通關時間{time}");

                if (DialogResult == DialogResult.OK) {
                    GameEnd();
                    return;
                }
            }

            if (order[turn % 3].hp <= 0) {
                turn++;
                NextRound();
            }

            if (order[turn % 3].character == "Beast") {
                if (beast.cooldown == 0) {
                    beast.Skill();
                    beast.cooldown = 3;
                    MessageBox.Show($"Beast使用了技能\n當前ATK: {beast.atk}");
                }

                if (beast.charge == 100) {
                    order[(turn + 1) % 3].hp -= beast.atk * 2;
                    order[(turn + 2) % 3].hp -= beast.atk * 2;

                    beast.charge = 0;
                    lblCharHP.Text = "HP: " + order[(turn - 1) % 3].hp.ToString();
                    MessageBox.Show($"Beast使用了寶具\n對全體隊友造成{beast.atk * 2}點傷害");

                    if (order[(turn + 1) % 3].hp <= 0 && order[(turn + 1) % 3].alive == true) {
                        order[(turn + 1) % 3].alive = false;
                        MessageBox.Show($"{order[(turn + 1) % 3].character}倒下了!");
                    }

                    if (order[(turn + 2) % 3].hp <= 0 && order[(turn + 2) % 3].alive == true) {
                        order[(turn + 2) % 3].alive = false;
                        MessageBox.Show($"{order[(turn + 2) % 3].character}倒下了!");
                    }
                } else {
                    order[(turn + 1) % 3].hp -= beast.atk;
                    order[(turn + 2) % 3].hp -= beast.atk;
                    beast.charge += 20;
                    lblCharHP.Text = "HP: " + order[(turn - 1) % 3].hp.ToString();
                    MessageBox.Show($"Beast全體隊友造成{beast.atk}點傷害");

                    if (order[(turn + 1) % 3].hp <= 0 && order[(turn + 1) % 3].alive == true) {
                        order[(turn + 1) % 3].alive = false;
                        MessageBox.Show($"{order[(turn + 1) % 3].character}倒下了!");
                    }

                    if (order[(turn + 2) % 3].hp <= 0 && order[(turn + 2) % 3].alive == true) {
                        order[(turn + 2) % 3].alive = false;
                        MessageBox.Show($"{order[(turn + 2) % 3].character}倒下了!");
                    }
                }

                if (order[(turn + 1) % 3].hp <= 0 && order[(turn + 2) % 3].hp <= 0) {
                    tmr.Enabled = false;
                    DialogResult = MessageBox.Show($"You Lose!\n戰鬥時間{time}");

                    if (DialogResult == DialogResult.OK) {
                        GameEnd();
                        return;
                    }
                }

                beast.cooldown--;
                turn++;
                NextRound();
            }

            lblCharName.Text = order[turn % 3].character;
            lblCharHP.Text = "HP: " + order[turn % 3].hp.ToString();
            lblCharCharge.Text = "Charge: " + order[turn % 3].charge.ToString();
            lblCharAtk.Text = "Attack: " + order[turn % 3].atk.ToString();
            lblEnemyName.Text = "Beast";
            lblEnemyHP.Text = "HP: " + beast.hp.ToString();
            lblEnemyCharge.Text = "Charge: " + beast.charge.ToString();
            lblEnemyAtk.Text = "Attack: " + beast.atk.ToString();
            lblTurn.Text = order[turn % 3].character + " turn";
        }

        private void tmrChooseChar_Tick(object sender, EventArgs e) {
            if (time > 0) {
                time--;
                lblTimer.Text = time.ToString();
            } else {
                tmrChooseChar.Enabled = false;

                if (selectChar[0] + selectChar[1] + selectChar[2] == 0) {
                    selectChar[0] = 1;
                    selectChar[1] = 1;
                } else if (selectChar[0] + selectChar[1] + selectChar[2] == 1) {
                    for (int i = 0; i < 3; i++) {
                        if (selectChar[i] == 0) {
                            selectChar[i] = 1;
                            break;
                        }
                    }
                }

                for (int i = 0; i < 3; i++) {
                    Controls.Remove(btn[i]);
                }

                GameStart();
            }
        }

        private void tmr_Tick(object sender, EventArgs e) {
            time++;
            lblTimer.Text = time.ToString();
        }
    }
}