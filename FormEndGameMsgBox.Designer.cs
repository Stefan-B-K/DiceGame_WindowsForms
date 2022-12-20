namespace VSP_0463_imd_MyProject
{
    partial class FormEndGameMsgBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEndGameMsgBox));
            this.buttonОК = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.labelImage = new System.Windows.Forms.Label();
            this.imageListEndGame = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // buttonОК
            // 
            this.buttonОК.Location = new System.Drawing.Point(80, 152);
            this.buttonОК.Name = "buttonОК";
            this.buttonОК.Size = new System.Drawing.Size(66, 28);
            this.buttonОК.TabIndex = 0;
            this.buttonОК.Text = "Добре";
            this.buttonОК.UseVisualStyleBackColor = true;
            this.buttonОК.Click += new System.EventHandler(this.buttonОК_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMessage.Location = new System.Drawing.Point(14, 78);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(198, 63);
            this.labelMessage.TabIndex = 1;
            this.labelMessage.Text = "Равенство! По точка за всеки.";
            this.labelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelImage
            // 
            this.labelImage.ImageIndex = 0;
            this.labelImage.ImageList = this.imageListEndGame;
            this.labelImage.Location = new System.Drawing.Point(60, 6);
            this.labelImage.Name = "labelImage";
            this.labelImage.Size = new System.Drawing.Size(100, 78);
            this.labelImage.TabIndex = 2;
            // 
            // imageListEndGame
            // 
            this.imageListEndGame.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListEndGame.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListEndGame.ImageStream")));
            this.imageListEndGame.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListEndGame.Images.SetKeyName(0, "ThumbsUp.png");
            this.imageListEndGame.Images.SetKeyName(1, "ThumbDown.png");
            this.imageListEndGame.Images.SetKeyName(2, "TwoDice.png");
            // 
            // FormEndGameMsgBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 191);
            this.ControlBox = false;
            this.Controls.Add(this.labelImage);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.buttonОК);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(240, 230);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(240, 230);
            this.Name = "FormEndGameMsgBox";
            this.Text = "Край на играта";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonОК;
        private Label labelMessage;
        private Label labelImage;
        private ImageList imageListEndGame;
    }
}