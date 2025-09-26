namespace Flappybird
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            flappyBird = new PictureBox();
            BoruAlt = new PictureBox();
            BoruUst = new PictureBox();
            zemin = new PictureBox();
            scoreText = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)flappyBird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BoruAlt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BoruUst).BeginInit();
            ((System.ComponentModel.ISupportInitialize)zemin).BeginInit();
            SuspendLayout();
            // 
            // flappyBird
            // 
            flappyBird.Image = (Image)resources.GetObject("flappyBird.Image");
            flappyBird.Location = new Point(3, 225);
            flappyBird.Name = "flappyBird";
            flappyBird.Size = new Size(125, 62);
            flappyBird.SizeMode = PictureBoxSizeMode.StretchImage;
            flappyBird.TabIndex = 0;
            flappyBird.TabStop = false;
            // 
            // BoruAlt
            // 
            BoruAlt.Image = (Image)resources.GetObject("BoruAlt.Image");
            BoruAlt.Location = new Point(634, 393);
            BoruAlt.Name = "BoruAlt";
            BoruAlt.Size = new Size(125, 162);
            BoruAlt.SizeMode = PictureBoxSizeMode.StretchImage;
            BoruAlt.TabIndex = 1;
            BoruAlt.TabStop = false;
            // 
            // BoruUst
            // 
            BoruUst.Image = (Image)resources.GetObject("BoruUst.Image");
            BoruUst.Location = new Point(591, -11);
            BoruUst.Name = "BoruUst";
            BoruUst.Size = new Size(125, 164);
            BoruUst.SizeMode = PictureBoxSizeMode.StretchImage;
            BoruUst.TabIndex = 2;
            BoruUst.TabStop = false;
            // 
            // zemin
            // 
            zemin.Image = (Image)resources.GetObject("zemin.Image");
            zemin.Location = new Point(3, 544);
            zemin.Name = "zemin";
            zemin.Size = new Size(797, 85);
            zemin.SizeMode = PictureBoxSizeMode.StretchImage;
            zemin.TabIndex = 3;
            zemin.TabStop = false;
            // 
            // scoreText
            // 
            scoreText.AutoSize = true;
            scoreText.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            scoreText.Location = new Point(12, 9);
            scoreText.Name = "scoreText";
            scoreText.Size = new Size(133, 46);
            scoreText.TabIndex = 4;
            scoreText.Text = "score:0";
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += gameTimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(800, 629);
            Controls.Add(flappyBird);
            Controls.Add(scoreText);
            Controls.Add(zemin);
            Controls.Add(BoruUst);
            Controls.Add(BoruAlt);
            Name = "Form1";
            Text = " ";
            KeyDown += gamekeyisdown;
            KeyUp += gamekeyisup;
            ((System.ComponentModel.ISupportInitialize)flappyBird).EndInit();
            ((System.ComponentModel.ISupportInitialize)BoruAlt).EndInit();
            ((System.ComponentModel.ISupportInitialize)BoruUst).EndInit();
            ((System.ComponentModel.ISupportInitialize)zemin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox flappyBird;
        private PictureBox BoruAlt;
        private PictureBox BoruUst;
        private PictureBox zemin;
        private Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
    }
}
