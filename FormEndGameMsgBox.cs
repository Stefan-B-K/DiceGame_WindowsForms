using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VSP_0463_imd_MyProject
{
    public partial class FormEndGameMsgBox : Form
    {
        private bool shouldCloseTheApp = false;
        private Button buttonCancel;

        private static FormEndGameMsgBox? _instance;

        private FormEndGameMsgBox()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            buttonCancel = new()
            {
                Text = "Back",
                Size = new Size(66, 28),
                Location = new Point(120, 152),
            };
            Controls.Add(buttonCancel);
            CancelButton = buttonCancel;
            buttonCancel.Click += new EventHandler(removeButtonCancel!);
        }

        public static FormEndGameMsgBox GetInstance()
        {
            if (_instance == null) _instance = new FormEndGameMsgBox();
            return _instance;
        }

        private void buttonОК_Click(object sender, EventArgs e)
        {
            this.Close();
            if (shouldCloseTheApp) {
                Properties.Settings.Default.compWins += 1;
                Properties.Settings.Default.Save();
                Application.Exit();
            } 
        }

        public void setMessage(string message, int imageIndex, bool cancelButton = false)
        {
            if (labelMessage.InvokeRequired)
            {
                labelMessage.Invoke(new Action(() => labelMessage.Text = message));
                labelMessage.Invoke(new Action(() => labelImage.ImageIndex = imageIndex));
            }
            else
            {
                labelMessage.Text = message;
                labelImage.ImageIndex = imageIndex;
            }

            if (cancelButton)
            {
                buttonCancel.Visible = true;
                shouldCloseTheApp = true;
                buttonОК.Text = "Quit";
                buttonОК.Location = new Point(40, 152);
            }
            else
            {
                CancelButton = null;
                shouldCloseTheApp = false;
                if (buttonCancel.InvokeRequired)
                    buttonCancel.Invoke(new Action(() => buttonCancel.Visible = false));
                else
                    buttonCancel.Visible = false;

                if (buttonОК.InvokeRequired)
                    buttonОК.Invoke(new Action(() => {
                        buttonОК.Text = "OK";
                        buttonОК.Location = new Point(80, 152);
                        }
                    ));
                else
                {
                    buttonОК.Text = "OK";
                    buttonОК.Location = new Point(80, 152);
                };
            }
        }
        private void removeButtonCancel(object sender, EventArgs e)
        {
            Button btnCance = (Button)sender;
            CancelButton = null;
            shouldCloseTheApp = false;
            buttonОК.Text = "OK";
            buttonОК.Location = new Point(80, 152);
            btnCance.Visible = false;
        }
    }
}

