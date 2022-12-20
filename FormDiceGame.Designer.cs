namespace VSP_0463_imd_MyProject
{
    partial class FormDiceGame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDiceGame));
            this.imageListButtons = new System.Windows.Forms.ImageList(this.components);
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.comboBoxColorTheme = new System.Windows.Forms.ComboBox();
            this.labelColorTheme = new System.Windows.Forms.Label();
            this.labelGameType = new System.Windows.Forms.Label();
            this.comboBoxGameType = new System.Windows.Forms.ComboBox();
            this.groupBoxOponent = new System.Windows.Forms.GroupBox();
            this.radioButtonPvE = new System.Windows.Forms.RadioButton();
            this.radioButtonPvP = new System.Windows.Forms.RadioButton();
            this.labelGoal = new System.Windows.Forms.Label();
            this.textBoxGoal = new System.Windows.Forms.TextBox();
            this.labelGoalUnit = new System.Windows.Forms.Label();
            this.checkBoxSecondDie = new System.Windows.Forms.CheckBox();
            this.panelPlaygound = new System.Windows.Forms.Panel();
            this.pictureBoxDice1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDice2 = new System.Windows.Forms.PictureBox();
            this.labelWins = new System.Windows.Forms.Label();
            this.labelWinsUser = new System.Windows.Forms.Label();
            this.labelWinsComp = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelComp = new System.Windows.Forms.Label();
            this.splitContainerScore = new System.Windows.Forms.SplitContainer();
            this.verticalSeparator = new System.Windows.Forms.Label();
            this.labelTotalComp = new System.Windows.Forms.Label();
            this.labelTotalUser = new System.Windows.Forms.Label();
            this.buttonRoll = new System.Windows.Forms.Button();
            this.labelRolling = new System.Windows.Forms.Label();
            this.horizontalSeparator = new System.Windows.Forms.Label();
            this.labelGoalError = new System.Windows.Forms.Label();
            this.buttonResetWins = new System.Windows.Forms.Button();
            this.groupBoxOponent.SuspendLayout();
            this.panelPlaygound.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerScore)).BeginInit();
            this.splitContainerScore.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageListButtons
            // 
            this.imageListButtons.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListButtons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListButtons.ImageStream")));
            this.imageListButtons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListButtons.Images.SetKeyName(0, "Screenshot 2022-12-14 at 0.00.51.png");
            this.imageListButtons.Images.SetKeyName(1, "22a.ico");
            this.imageListButtons.Images.SetKeyName(2, "Refresh_32x32.png");
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNewGame.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNewGame.ImageIndex = 0;
            this.buttonNewGame.ImageList = this.imageListButtons;
            this.buttonNewGame.Location = new System.Drawing.Point(12, 12);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(130, 40);
            this.buttonNewGame.TabIndex = 0;
            this.buttonNewGame.Text = "Нова игра";
            this.buttonNewGame.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonNewGame.UseVisualStyleBackColor = true;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExit.ImageIndex = 1;
            this.buttonExit.ImageList = this.imageListButtons;
            this.buttonExit.Location = new System.Drawing.Point(12, 70);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(130, 40);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Изход    ";
            this.buttonExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // comboBoxColorTheme
            // 
            this.comboBoxColorTheme.FormattingEnabled = true;
            this.comboBoxColorTheme.Items.AddRange(new object[] {
            "Стандартен",
            "Син",
            "Зелен",
            "Червен"});
            this.comboBoxColorTheme.Location = new System.Drawing.Point(12, 286);
            this.comboBoxColorTheme.Name = "comboBoxColorTheme";
            this.comboBoxColorTheme.Size = new System.Drawing.Size(121, 23);
            this.comboBoxColorTheme.TabIndex = 2;
            this.comboBoxColorTheme.SelectedIndexChanged += new System.EventHandler(this.comboBoxColorTheme_SelectedIndexChanged);
            // 
            // labelColorTheme
            // 
            this.labelColorTheme.AutoSize = true;
            this.labelColorTheme.Location = new System.Drawing.Point(12, 268);
            this.labelColorTheme.Name = "labelColorTheme";
            this.labelColorTheme.Size = new System.Drawing.Size(88, 15);
            this.labelColorTheme.TabIndex = 3;
            this.labelColorTheme.Text = "Цветова схема";
            // 
            // labelGameType
            // 
            this.labelGameType.AutoSize = true;
            this.labelGameType.Location = new System.Drawing.Point(12, 328);
            this.labelGameType.Name = "labelGameType";
            this.labelGameType.Size = new System.Drawing.Size(55, 15);
            this.labelGameType.TabIndex = 5;
            this.labelGameType.Text = "Вид игра";
            // 
            // comboBoxGameType
            // 
            this.comboBoxGameType.FormattingEnabled = true;
            this.comboBoxGameType.Items.AddRange(new object[] {
            "Който първи",
            "Който повече"});
            this.comboBoxGameType.Location = new System.Drawing.Point(12, 346);
            this.comboBoxGameType.Name = "comboBoxGameType";
            this.comboBoxGameType.Size = new System.Drawing.Size(121, 23);
            this.comboBoxGameType.TabIndex = 4;
            this.comboBoxGameType.SelectedIndexChanged += new System.EventHandler(this.comboBoxGameType_SelectedIndexChanged);
            // 
            // groupBoxOponent
            // 
            this.groupBoxOponent.Controls.Add(this.radioButtonPvE);
            this.groupBoxOponent.Controls.Add(this.radioButtonPvP);
            this.groupBoxOponent.Location = new System.Drawing.Point(12, 127);
            this.groupBoxOponent.Name = "groupBoxOponent";
            this.groupBoxOponent.Size = new System.Drawing.Size(130, 83);
            this.groupBoxOponent.TabIndex = 6;
            this.groupBoxOponent.TabStop = false;
            this.groupBoxOponent.Text = "Опонент";
            // 
            // radioButtonPvE
            // 
            this.radioButtonPvE.AutoSize = true;
            this.radioButtonPvE.Checked = true;
            this.radioButtonPvE.Location = new System.Drawing.Point(18, 50);
            this.radioButtonPvE.Name = "radioButtonPvE";
            this.radioButtonPvE.Size = new System.Drawing.Size(97, 19);
            this.radioButtonPvE.TabIndex = 1;
            this.radioButtonPvE.TabStop = true;
            this.radioButtonPvE.Text = "Компюътъра";
            this.radioButtonPvE.UseVisualStyleBackColor = true;
            // 
            // radioButtonPvP
            // 
            this.radioButtonPvP.AutoSize = true;
            this.radioButtonPvP.BackColor = System.Drawing.SystemColors.Control;
            this.radioButtonPvP.Enabled = false;
            this.radioButtonPvP.Location = new System.Drawing.Point(18, 24);
            this.radioButtonPvP.Name = "radioButtonPvP";
            this.radioButtonPvP.Size = new System.Drawing.Size(86, 19);
            this.radioButtonPvP.TabIndex = 0;
            this.radioButtonPvP.Text = "Друг играч";
            this.radioButtonPvP.UseVisualStyleBackColor = false;
            // 
            // labelGoal
            // 
            this.labelGoal.AutoSize = true;
            this.labelGoal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGoal.Location = new System.Drawing.Point(12, 395);
            this.labelGoal.Name = "labelGoal";
            this.labelGoal.Size = new System.Drawing.Size(36, 19);
            this.labelGoal.TabIndex = 7;
            this.labelGoal.Text = "Цел:";
            // 
            // textBoxGoal
            // 
            this.textBoxGoal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxGoal.Location = new System.Drawing.Point(50, 391);
            this.textBoxGoal.Name = "textBoxGoal";
            this.textBoxGoal.Size = new System.Drawing.Size(56, 25);
            this.textBoxGoal.TabIndex = 8;
            this.textBoxGoal.Text = "25";
            this.textBoxGoal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxGoal.TextChanged += new System.EventHandler(this.textBoxGoal_TextChanged);
            this.textBoxGoal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGoal_KeyPress);
            this.textBoxGoal.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxGoal_KeyUp);
            // 
            // labelGoalUnit
            // 
            this.labelGoalUnit.AutoSize = true;
            this.labelGoalUnit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGoalUnit.Location = new System.Drawing.Point(112, 395);
            this.labelGoalUnit.Name = "labelGoalUnit";
            this.labelGoalUnit.Size = new System.Drawing.Size(46, 19);
            this.labelGoalUnit.TabIndex = 9;
            this.labelGoalUnit.Text = "точки";
            // 
            // checkBoxSecondDie
            // 
            this.checkBoxSecondDie.AutoSize = true;
            this.checkBoxSecondDie.Location = new System.Drawing.Point(30, 230);
            this.checkBoxSecondDie.Name = "checkBoxSecondDie";
            this.checkBoxSecondDie.Size = new System.Drawing.Size(76, 19);
            this.checkBoxSecondDie.TabIndex = 10;
            this.checkBoxSecondDie.Text = " Два зара";
            this.checkBoxSecondDie.UseVisualStyleBackColor = true;
            this.checkBoxSecondDie.CheckedChanged += new System.EventHandler(this.checkBoxSecondDie_CheckedChanged);
            // 
            // panelPlaygound
            // 
            this.panelPlaygound.BackColor = System.Drawing.Color.White;
            this.panelPlaygound.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPlaygound.Controls.Add(this.pictureBoxDice1);
            this.panelPlaygound.Controls.Add(this.pictureBoxDice2);
            this.panelPlaygound.Location = new System.Drawing.Point(157, 12);
            this.panelPlaygound.Name = "panelPlaygound";
            this.panelPlaygound.Size = new System.Drawing.Size(400, 350);
            this.panelPlaygound.TabIndex = 11;
            // 
            // pictureBoxDice1
            // 
            this.pictureBoxDice1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxDice1.Image = global::VSP_0463_imd_MyProject.Properties.Black._6;
            this.pictureBoxDice1.InitialImage = null;
            this.pictureBoxDice1.Location = new System.Drawing.Point(70, 190);
            this.pictureBoxDice1.MaximumSize = new System.Drawing.Size(100, 100);
            this.pictureBoxDice1.MinimumSize = new System.Drawing.Size(100, 100);
            this.pictureBoxDice1.Name = "pictureBoxDice1";
            this.pictureBoxDice1.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxDice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDice1.TabIndex = 13;
            this.pictureBoxDice1.TabStop = false;
            // 
            // pictureBoxDice2
            // 
            this.pictureBoxDice2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxDice2.InitialImage = null;
            this.pictureBoxDice2.Location = new System.Drawing.Point(300, 0);
            this.pictureBoxDice2.MaximumSize = new System.Drawing.Size(100, 100);
            this.pictureBoxDice2.MinimumSize = new System.Drawing.Size(100, 100);
            this.pictureBoxDice2.Name = "pictureBoxDice2";
            this.pictureBoxDice2.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxDice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDice2.TabIndex = 12;
            this.pictureBoxDice2.TabStop = false;
            // 
            // labelWins
            // 
            this.labelWins.BackColor = System.Drawing.SystemColors.Control;
            this.labelWins.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelWins.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelWins.Location = new System.Drawing.Point(598, 380);
            this.labelWins.Name = "labelWins";
            this.labelWins.Size = new System.Drawing.Size(130, 20);
            this.labelWins.TabIndex = 12;
            this.labelWins.Text = "Спечелени игри";
            this.labelWins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWinsUser
            // 
            this.labelWinsUser.BackColor = System.Drawing.Color.Black;
            this.labelWinsUser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelWinsUser.ForeColor = System.Drawing.Color.White;
            this.labelWinsUser.Location = new System.Drawing.Point(555, 405);
            this.labelWinsUser.Name = "labelWinsUser";
            this.labelWinsUser.Size = new System.Drawing.Size(115, 20);
            this.labelWinsUser.TabIndex = 13;
            this.labelWinsUser.Text = "0";
            this.labelWinsUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWinsComp
            // 
            this.labelWinsComp.BackColor = System.Drawing.Color.Black;
            this.labelWinsComp.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelWinsComp.ForeColor = System.Drawing.Color.White;
            this.labelWinsComp.Location = new System.Drawing.Point(669, 405);
            this.labelWinsComp.Name = "labelWinsComp";
            this.labelWinsComp.Size = new System.Drawing.Size(115, 20);
            this.labelWinsComp.TabIndex = 14;
            this.labelWinsComp.Text = "0";
            this.labelWinsComp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUser
            // 
            this.labelUser.BackColor = System.Drawing.SystemColors.Control;
            this.labelUser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelUser.Location = new System.Drawing.Point(565, 12);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(105, 28);
            this.labelUser.TabIndex = 15;
            this.labelUser.Text = "Вие";
            this.labelUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelComp
            // 
            this.labelComp.BackColor = System.Drawing.SystemColors.Control;
            this.labelComp.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelComp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelComp.Location = new System.Drawing.Point(669, 12);
            this.labelComp.Name = "labelComp";
            this.labelComp.Size = new System.Drawing.Size(103, 28);
            this.labelComp.TabIndex = 16;
            this.labelComp.Text = " Компютър";
            this.labelComp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainerScore
            // 
            this.splitContainerScore.Location = new System.Drawing.Point(565, 35);
            this.splitContainerScore.Name = "splitContainerScore";
            // 
            // splitContainerScore.Panel1
            // 
            this.splitContainerScore.Panel1.AutoScroll = true;
            // 
            // splitContainerScore.Panel2
            // 
            this.splitContainerScore.Panel2.AutoScroll = true;
            this.splitContainerScore.Size = new System.Drawing.Size(207, 305);
            this.splitContainerScore.SplitterDistance = 103;
            this.splitContainerScore.TabIndex = 17;
            // 
            // verticalSeparator
            // 
            this.verticalSeparator.BackColor = System.Drawing.SystemColors.ControlText;
            this.verticalSeparator.ForeColor = System.Drawing.SystemColors.Control;
            this.verticalSeparator.Location = new System.Drawing.Point(669, 14);
            this.verticalSeparator.Name = "verticalSeparator";
            this.verticalSeparator.Size = new System.Drawing.Size(2, 325);
            this.verticalSeparator.TabIndex = 22;
            // 
            // labelTotalComp
            // 
            this.labelTotalComp.BackColor = System.Drawing.Color.Black;
            this.labelTotalComp.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTotalComp.ForeColor = System.Drawing.Color.White;
            this.labelTotalComp.Location = new System.Drawing.Point(669, 342);
            this.labelTotalComp.Name = "labelTotalComp";
            this.labelTotalComp.Size = new System.Drawing.Size(115, 20);
            this.labelTotalComp.TabIndex = 19;
            this.labelTotalComp.Text = "0";
            this.labelTotalComp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTotalUser
            // 
            this.labelTotalUser.BackColor = System.Drawing.Color.Black;
            this.labelTotalUser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTotalUser.ForeColor = System.Drawing.Color.White;
            this.labelTotalUser.Location = new System.Drawing.Point(555, 342);
            this.labelTotalUser.Name = "labelTotalUser";
            this.labelTotalUser.Size = new System.Drawing.Size(115, 20);
            this.labelTotalUser.TabIndex = 18;
            this.labelTotalUser.Text = "0";
            this.labelTotalUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonRoll
            // 
            this.buttonRoll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRoll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRoll.ImageIndex = 2;
            this.buttonRoll.ImageList = this.imageListButtons;
            this.buttonRoll.Location = new System.Drawing.Point(199, 382);
            this.buttonRoll.Name = "buttonRoll";
            this.buttonRoll.Size = new System.Drawing.Size(130, 40);
            this.buttonRoll.TabIndex = 20;
            this.buttonRoll.Text = "Хвърляне";
            this.buttonRoll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRoll.UseVisualStyleBackColor = true;
            this.buttonRoll.Visible = false;
            this.buttonRoll.Click += new System.EventHandler(this.buttonRoll_Click);
            // 
            // labelRolling
            // 
            this.labelRolling.BackColor = System.Drawing.SystemColors.Control;
            this.labelRolling.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRolling.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelRolling.Location = new System.Drawing.Point(340, 382);
            this.labelRolling.Name = "labelRolling";
            this.labelRolling.Size = new System.Drawing.Size(177, 40);
            this.labelRolling.TabIndex = 21;
            this.labelRolling.Text = " Компютърът е на ход";
            this.labelRolling.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelRolling.Visible = false;
            // 
            // horizontalSeparator
            // 
            this.horizontalSeparator.BackColor = System.Drawing.SystemColors.ControlText;
            this.horizontalSeparator.ForeColor = System.Drawing.SystemColors.Control;
            this.horizontalSeparator.Location = new System.Drawing.Point(565, 38);
            this.horizontalSeparator.Name = "horizontalSeparator";
            this.horizontalSeparator.Size = new System.Drawing.Size(206, 2);
            this.horizontalSeparator.TabIndex = 23;
            // 
            // labelGoalError
            // 
            this.labelGoalError.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGoalError.ForeColor = System.Drawing.Color.Red;
            this.labelGoalError.Location = new System.Drawing.Point(36, 419);
            this.labelGoalError.Name = "labelGoalError";
            this.labelGoalError.Size = new System.Drawing.Size(80, 14);
            this.labelGoalError.TabIndex = 24;
            this.labelGoalError.Text = "От 0 до 50";
            this.labelGoalError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelGoalError.Visible = false;
            // 
            // buttonResetWins
            // 
            this.buttonResetWins.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonResetWins.ForeColor = System.Drawing.Color.Maroon;
            this.buttonResetWins.Location = new System.Drawing.Point(728, 380);
            this.buttonResetWins.Name = "buttonResetWins";
            this.buttonResetWins.Size = new System.Drawing.Size(54, 22);
            this.buttonResetWins.TabIndex = 25;
            this.buttonResetWins.Text = "Занули";
            this.buttonResetWins.UseVisualStyleBackColor = true;
            this.buttonResetWins.Click += new System.EventHandler(this.buttonResetWins_Click);
            // 
            // FormDiceGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.ControlBox = false;
            this.Controls.Add(this.buttonResetWins);
            this.Controls.Add(this.labelGoalError);
            this.Controls.Add(this.horizontalSeparator);
            this.Controls.Add(this.verticalSeparator);
            this.Controls.Add(this.labelRolling);
            this.Controls.Add(this.buttonRoll);
            this.Controls.Add(this.labelTotalComp);
            this.Controls.Add(this.labelTotalUser);
            this.Controls.Add(this.splitContainerScore);
            this.Controls.Add(this.labelComp);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.labelWinsComp);
            this.Controls.Add(this.labelWinsUser);
            this.Controls.Add(this.labelWins);
            this.Controls.Add(this.panelPlaygound);
            this.Controls.Add(this.checkBoxSecondDie);
            this.Controls.Add(this.labelGoalUnit);
            this.Controls.Add(this.textBoxGoal);
            this.Controls.Add(this.labelGoal);
            this.Controls.Add(this.groupBoxOponent);
            this.Controls.Add(this.labelGameType);
            this.Controls.Add(this.comboBoxGameType);
            this.Controls.Add(this.labelColorTheme);
            this.Controls.Add(this.comboBoxColorTheme);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonNewGame);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 480);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 480);
            this.Name = "FormDiceGame";
            this.Text = "Хвърли зарчета";
            this.groupBoxOponent.ResumeLayout(false);
            this.groupBoxOponent.PerformLayout();
            this.panelPlaygound.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerScore)).EndInit();
            this.splitContainerScore.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ImageList imageListButtons;
        private Button buttonNewGame;
        private Button buttonExit;
        private ComboBox comboBoxColorTheme;
        private Label labelColorTheme;
        private Label labelGameType;
        private ComboBox comboBoxGameType;
        private GroupBox groupBoxOponent;
        private RadioButton radioButtonPvE;
        private RadioButton radioButtonPvP;
        private Label labelGoal;
        private TextBox textBoxGoal;
        private Label labelGoalUnit;
        private CheckBox checkBoxSecondDie;
        private Panel panelPlaygound;
        private PictureBox pictureBoxDice2;
        private PictureBox pictureBoxDice1;
        private Label labelWins;
        private Label labelWinsUser;
        private Label labelWinsComp;
        private Label labelUser;
        private Label labelComp;
        private SplitContainer splitContainerScore;
        private Label labelTotalComp;
        private Label labelTotalUser;
        private Button buttonRoll;
        private Label labelRolling;
        private Label verticalSeparator;
        private Label horizontalSeparator;
        private Label labelGoalError;
        private Button buttonResetWins;
    }
}