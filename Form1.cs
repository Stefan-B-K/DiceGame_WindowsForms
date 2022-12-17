using System.ComponentModel;
using System.Timers;
using VSP_0463_imd_MyProject.Properties;
using Application = System.Windows.Forms.Application;

namespace VSP_0463_imd_MyProject
{
    internal enum PlayerTurn { User, Computer }

    internal enum Game { First, Max }

    public partial class FormDiceGame : Form
    {
        private int _diceCount = 1;
        private Color _colorTheme = Color.Black;
        private bool _playing = false;
        private bool _rolling = false;
        private int _valueDice1 = 6;
        private int _valueDice2 = 6;
        private PlayerTurn _player = PlayerTurn.User;
        private Label labelInstruction1 = new();
        private Label labelInstruction2 = new();
        private Game _gameType = Game.First;
        private int maxGoalValue = GameScore.MaxPoints1Dice;
        private int minGoalValue = GameScore.MinPoints;

        private int DiceCount
        {
            get { return _diceCount; }
            set
            {
                _diceCount = value;
                SetDiceLocation(value);
                SetDiceFace(ColorTheme, 6, 6);
                setGoalValueLimits();
                checkGoalValue(textBoxGoal);
            }
        }
        private Color ColorTheme
        {
            get { return _colorTheme; }
            set
            {
                _colorTheme = value;
                SetColorTheme(value);
            }
        }
        private int ValueDice1
        {
            get { return _valueDice1; }
            set
            {
                _valueDice1 = value;
                SetDiceFace(ColorTheme, value, _valueDice2);
            }
        }
        private int ValueDice2
        {
            get { return _valueDice2; }
            set
            {
                _valueDice2 = value;
                SetDiceFace(ColorTheme, _valueDice1, value);
            }
        }
        private bool Playing
        {
            get { return _playing; }
            set
            {
                _playing = value;
                configPlaying(value);
            }
        }
        private bool Rolling
        {
            get { return _rolling; }
            set
            {
                _rolling = value;
                SetDiceFace(ColorTheme, ValueDice1, ValueDice2);
                if (!value) 
                {
                    Task.Delay(1000).Wait();
                    Utils.SetEnabled(buttonRoll, !value);
                    SetRoundScore(Player, GameScore.Turn, ValueDice1 + (DiceCount == 2 ? ValueDice2 : 0));
                    Player = Player == PlayerTurn.User ? PlayerTurn.Computer : PlayerTurn.User;
                } else
                {
                    Utils.SetEnabled(buttonRoll, !value);
                }
           
            }
        }
        private PlayerTurn Player
        {
            get { return _player; }
            set
            {
                _player = value;
                Utils.SetText(labelRolling, value == PlayerTurn.User ? "Вие сте на ход" : "Компютърът е на ход");
                if (value == PlayerTurn.Computer && Playing) RollDice();
            }
        }
        private Game GameType
        {
            get { return _gameType; }
            set
            {
                _gameType = value;
                textBoxGoal.Text = value == Game.First ? "25" : "10";
                labelGoalUnit.Text = value == Game.First ? "точки" : "рунд" + (textBoxGoal.Text == "1" ? "" : "а");
                ChangeInstructionLabel();
                setGoalValueLimits();
                checkGoalValue(textBoxGoal);
            }
        }

        private Dictionary<string, Bitmap> colorProp = new()
            {
                {"Black.1", Black._1 },
                {"Black.2", Black._2 },
                {"Black.3", Black._3 },
                {"Black.4", Black._4 },
                {"Black.5", Black._5 },
                {"Black.6", Black._6 },
                {"Blue.1", Blue._1 },
                {"Blue.2", Blue._2 },
                {"Blue.3", Blue._3 },
                {"Blue.4", Blue._4 },
                {"Blue.5", Blue._5 },
                {"Blue.6", Blue._6 },
                {"Green.1", Green._1 },
                {"Green.2", Green._2 },
                {"Green.3", Green._3 },
                {"Green.4", Green._4 },
                {"Green.5", Green._5 },
                {"Green.6", Green._6 },
                {"Red.1", Red._1 },
                {"Red.2", Red._2 },
                {"Red.3", Red._3 },
                {"Red.4", Red._4 },
                {"Red.5", Red._5 },
                {"Red.6", Red._6 }
            };



            //  =========================      init     =========================
        public FormDiceGame()
        {
            InitializeComponent();
            comboBoxColorTheme.SelectedIndex = 0;
            comboBoxGameType.SelectedIndex = 0;
            SetDiceLocation(DiceCount);
            labelWinsUser.Text = Properties.Settings.Default.userWins.ToString();
            labelWinsComp.Text = Properties.Settings.Default.compWins.ToString();
            ConfigInstructionLabels();
            horizontalSeparator.BringToFront();
            textBoxGoal.Tag = true;

            this.textBoxGoal.Validating += new CancelEventHandler(textBoxGoalEmpty!);
            this.textBoxGoal.Validating += new CancelEventHandler(textBoxGoalValue!);
        }   //  =========================      init     =========================



        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            GameScore.ClearScores();
            splitContainerScore.Panel1.Controls.Clear();
            splitContainerScore.Panel2.Controls.Clear();
            labelTotalUser.Text = "";
            labelTotalComp.Text = "";
            Playing = true; 

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (Playing)
            {
                Properties.Settings.Default.compWins += 1;
                Properties.Settings.Default.Save();
                if (MessageBox.Show("Ще бъде записана служебна победа за компютъра!\nСигурни ли сте?",
                    "Изход по време на игра",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    Application.Exit();
                };
            } 
            else { Application.Exit(); }
        }

        private void checkBoxSecondDie_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chb = (CheckBox)sender;
            DiceCount = chb.Checked ? 2 : 1;
        }

        private void comboBoxColorTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox cbx = (System.Windows.Forms.ComboBox)sender;

            switch (cbx.SelectedItem.ToString())
            {
                case "Стандартен": ColorTheme = Color.Black; break;
                case "Син": ColorTheme = Color.Blue; break;
                case "Зелен": ColorTheme = Color.Green; break;
                case "Червен": ColorTheme = Color.Red; break;
                default: ColorTheme = Color.Black; break;
            }
        }

        private void comboBoxGameType_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox cbx = (System.Windows.Forms.ComboBox)sender;
            if (cbx.SelectedItem.ToString() == "Който първи") GameType = Game.First;
            if (cbx.SelectedItem.ToString() == "Който повече") GameType = Game.Max;
        }

        private void buttonRoll_Click(object sender, EventArgs e)
        {
            RollDice();
        }




        // =============================== HELPER METHODS ===============================

        //  ==================  config UI ==================

        private void setGoalValueLimits()
        {
            maxGoalValue = GameType == Game.Max ?
              GameScore.MaxRounds :
              (DiceCount == 1 ? GameScore.MaxPoints1Dice : GameScore.MaxPoints2Dice);
            minGoalValue = GameType == Game.Max ? GameScore.MinRounds : GameScore.MinPoints;
        }
        private void ConfigInstructionLabels()
        {
            labelInstruction1.Text = "Игра 'Кой първи':";
            labelInstruction2.Text = $"Печели този, който първи събере { textBoxGoal.Text } точки.";
            labelInstruction1.AutoSize = false;
            labelInstruction2.AutoSize = false;
            labelInstruction1.Size = new(120, 32);
            labelInstruction2.Size = new(260, 32);
            labelInstruction1.Location = new Point(170, 380);
            labelInstruction2.Location = new Point(286, 380);
            labelInstruction1.Font = new Font(labelInstruction1.Font, FontStyle.Bold);
            this.Controls.Add(labelInstruction1);
            this.Controls.Add(labelInstruction2);
            labelInstruction1.BringToFront();
            labelInstruction2.BringToFront();
        }

        private void ChangeInstructionLabel()
        {
                labelInstruction1.Text = GameType == Game.First ? 
                    "Игра 'Кой първи':" : 
                    "Игра 'Кой повече':";

                labelInstruction2.Text = GameType == Game.First ? 
                    $"Печели този, който първи събере {textBoxGoal.Text} точки." :
                    $"Печели този, който има повече точки след {textBoxGoal.Text} рунд{(textBoxGoal.Text == "1" ? "" : "а")}.";
        }

        private void configPlaying(bool value)
        {
            Utils.SetEnabled(buttonNewGame, !value);

            Utils.SetVisible(groupBoxOponent, !value);
            Utils.SetVisible(checkBoxSecondDie, !value);
            Utils.SetVisible(labelGameType, !value);
            Utils.SetVisible(comboBoxGameType, !value);
            Utils.SetVisible(labelGoal, !value);
            Utils.SetVisible(textBoxGoal, !value);
            Utils.SetVisible(labelGoalUnit, !value);
            Utils.SetVisible(buttonRoll, value);
            Utils.SetVisible(labelRolling, value);

            Player = new Random().NextDouble() > 0.5 ? PlayerTurn.User : PlayerTurn.Computer;

            Color backColorInstructions = Playing ? SystemColors.Window : Utils.BackColor(ColorTheme);
            Utils.SetLocation(labelInstruction1, new Point(170, Playing ? 324 : 390));
            Utils.SetLocation(labelInstruction2, new Point(286, Playing ? 324 : 390));
            Utils.SetBackColor(labelInstruction1, backColorInstructions);
            Utils.SetBackColor(labelInstruction2, backColorInstructions);

            string endGameMessage;
            if (GameType == Game.Max)
            {
               
            }
        }

        private void SetDiceFace(Color color, int value1, int value2)
        {
            Utils.SetImage(pictureBoxDice1, colorProp[color.Name + "." + value1.ToString()]);
            Utils.SetImage(pictureBoxDice2, DiceCount == 2 ? colorProp[color.Name + "." + value2.ToString()] : null);
        }

        private void SetDiceLocation(int count)
        {
            pictureBoxDice1.Location = DiceCount == 1 ? new Point(150, 125) : new Point(70, 170);
            pictureBoxDice2.Location = DiceCount == 2 ? new Point(230, 40) : new Point(300, 0);
        }

        private void SetColorTheme(Color color)
        {
            string[] controlsInverted = { "labelTotalUser", "labelTotalComp", "labelWinsUser", "labelWinsComp", "verticalSeparator", "horizontalSeparator" };
            
            base.BackColor = Utils.BackColor(color);

            foreach (Control control in this.Controls)
            {
                if (!controlsInverted.Contains(control.Name) &&
                    control.Name != "radioButtonPvP" && control.Name != "labelGoalError")
                {
                    control.BackColor = Utils.BackColor(color); ;
                    control.ForeColor = Utils.ForeColor(color); ;
                }
            }

            splitContainerScore.Panel1.BackColor = Utils.BackColor(color);
            splitContainerScore.Panel2.BackColor = Utils.BackColor(color);

            foreach (Control control in this.Controls)
            {
                if (controlsInverted.Contains(control.Name))
                {
                    control.BackColor = Utils.ForeColor(color); ;
                    control.ForeColor = Utils.BackColor(color); ;
                }
            }

            if (Playing) labelInstruction1.BackColor = labelInstruction2.BackColor = SystemColors.Window;

            panelPlaygound.BackColor = Color.White;
            textBoxGoal.BackColor = SystemColors.Window;

            SetDiceFace(color, ValueDice1, ValueDice2);
        }


        //  ==================  Validation of goal score/rounds ==================

        private void textBoxGoalEmpty(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (tb.Text.Trim().Length == 0)
            {
                tb.Text = "";
                tb.BackColor = Utils.LightRed;
                tb.Tag = false;
                labelGoalError.Text = $"От 0 { minGoalValue } до { maxGoalValue }";
                labelGoalError.Visible= true;
            }
            else
            {
                tb.BackColor = SystemColors.Window;
                tb.Tag = true;
                labelGoalError.Visible = false;
            }
            ValidateOK();
        }

        private void textBoxGoalValue(object sender, CancelEventArgs e)
        {
            checkGoalValue(sender);
        }

        private void textBoxGoal_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            // Leading 0 not allowed
            // chars outside of (0...9) not allowed
            // backspace allowed /char key 8/
            if (((tb.Text.Length == 0) && (e.KeyChar == 48)) ||
            ((e.KeyChar < 48 || e.KeyChar > 57) &&
            e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void textBoxGoal_KeyUp(object sender, KeyEventArgs e)
        {
            checkGoalValue(sender);
        }

        private void checkGoalValue(object sender)
        {
            TextBox tb = (TextBox)sender;
            

            if (tb.Text.Length > 0)
            {
                if (Int16.Parse(tb.Text.ToString()) < minGoalValue || 
                    Int16.Parse(tb.Text.ToString()) > maxGoalValue)
                {
                    tb.Tag = false;
                    tb.BackColor = Utils.LightRed;
                    labelGoalError.Text = $"От { minGoalValue } до { maxGoalValue }";
                    labelGoalError.Visible = true;
                }
                else
                {
                    tb.Tag = true;
                    tb.BackColor = SystemColors.Window;
                    labelGoalError.Visible = false;
                }
            }
            else
            {
                tb.Tag = false;
                tb.BackColor = Utils.LightRed;
                labelGoalError.Text = $"От { minGoalValue } до { maxGoalValue }";
                labelGoalError.Visible = true;
            }
            ValidateOK();
        }

        private void textBoxGoal_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.BackColor == Utils.LightRed)
                tb.BackColor = SystemColors.Window;
            else if (tb.Text.Trim().Length == 0 || tb.Text.Trim() == "0")
            {
                tb.Text = "";
                tb.BackColor = Utils.LightRed;
                tb.Tag = false;
                labelGoalError.Text = $"От { minGoalValue } до { maxGoalValue }";
                labelGoalError.Visible = true;
            }
            else
            {
                tb.BackColor = SystemColors.Window;
                tb.Tag = true;
                labelGoalError.Visible = false;
            }
            ValidateOK();
            ChangeInstructionLabel();
            if (GameType == Game.Max) labelGoalUnit.Text = "рунд" + (textBoxGoal.Text == "1" ? "" : "а");
        }

        private void ValidateOK()
        {
            buttonNewGame.Enabled = (bool)textBoxGoal.Tag;
        }


        // =========================    Roll dice and scores UI   =========================

        private void RollDice()
        {
            Rolling = true;
            int shuffle = 1;
            var rnd = new Random();

            System.Timers.Timer aTimer = new(100);
            System.Timers.Timer bTimer = new(2000);
            aTimer.Elapsed += randomDiceValues!;
            bTimer.Elapsed += stopTimers!;
            aTimer.Enabled = true;
            bTimer.Enabled = true;
          
            void randomDiceValues(Object _, ElapsedEventArgs __)
            {
                ValueDice1 = (int)(rnd.NextDouble() * 5 + 1);
                if (DiceCount == 2) ValueDice2 = (int)(rnd.NextDouble() * 5 + 1);

                Color backLabel = Color.FromArgb((shuffle++ * 20) % 100, Color.Yellow);
                if (Player == PlayerTurn.User) 
                   labelUser.BackColor = splitContainerScore.Panel1.BackColor = backLabel;
                else 
                  labelComp.BackColor = splitContainerScore.Panel2.BackColor = backLabel;
            }

            void stopTimers(Object _, ElapsedEventArgs __)
            {

                aTimer.Enabled = false;
                bTimer.Enabled = false;

                Rolling = false;
                labelUser.BackColor = labelComp.BackColor = splitContainerScore.Panel1.BackColor = 
                    splitContainerScore.Panel2.BackColor = Utils.BackColor(ColorTheme);
                GameScore.Turn++;
            }
        }

        private void SetRoundScore(PlayerTurn player, int turn, int score)
        {
            GameScore.AddScore(player, score);

            int scoreRow = turn == 1 ? 1 : (turn % 2 == 0 ? turn / 2 : (turn + 1) / 2);
            GameScore.Round = scoreRow;

            Label labelScore = new()
            {
                Text = score.ToString(),
                AutoSize = false,
                Size = new(30, 18),
                Location = new Point(40, 10 + 20 * (scoreRow - 1)),
                TextAlign = ContentAlignment.MiddleRight
            };
            labelScore.Font = new Font(labelScore.Font.FontFamily, 12);

            if (GameType == Game.Max && turn % 2 != 0)
            {
                Label labelRound = new()
                {
                    Text = scoreRow.ToString(),
                    AutoSize = false,
                    Size = new(30, 18),
                    Location = new Point(0, 13 + 20 * (scoreRow - 1)),
                    TextAlign = ContentAlignment.MiddleLeft
                };
                labelRound.Font = new Font(labelRound.Font.FontFamily, 8);
                labelRound.Font = new Font(labelRound.Font, FontStyle.Italic);

                Utils.AddControl(splitContainerScore.Panel1, labelRound);
            }

            if (player == PlayerTurn.User)
            {
                Utils.AddControl(splitContainerScore.Panel1, labelScore);
                Utils.SetText(labelTotalUser, GameScore.TotalScore(player).ToString());
            }
            else
            {
                Utils.AddControl(splitContainerScore.Panel2, labelScore);
                Utils.SetText(labelTotalComp, GameScore.TotalScore(player).ToString());
            }

            if (GameType == Game.Max && GameScore.Round == int.Parse(textBoxGoal.Text) && turn % 2 == 0)
            {
                Playing = false;
            }

            if (GameType == Game.First &&
                 (GameScore.TotalScore(PlayerTurn.User) >= int.Parse(textBoxGoal.Text) ||
                 GameScore.TotalScore(PlayerTurn.Computer) >= int.Parse(textBoxGoal.Text)))
            {
                Playing = false;
            }
        }

    }
}