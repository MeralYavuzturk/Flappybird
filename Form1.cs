namespace Flappybird
{
    public partial class Form1 : Form
    {
        int boruHýzý = 8;
        int gravity = 10;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
            gameTimer.Start();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {

            flappyBird.Top += gravity;
            BoruAlt.Left -= boruHýzý;
            BoruUst.Left -= boruHýzý;
            scoreText.Text = "Score: " + score;
            if (BoruAlt.Left < -150)
            {
                BoruAlt.Left = 800;
                score++;
            }
            if (BoruUst.Left < -180)
            {
                BoruUst.Left = 950;
                score++;
            }
            if (flappyBird.Bounds.IntersectsWith(BoruAlt.Bounds) || flappyBird.Bounds.IntersectsWith(BoruUst.Bounds) || flappyBird.Bounds.IntersectsWith(zemin.Bounds))
            {
                endGame();
            }
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }

        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }


        }
        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text = "Game Over!!! ";
        }

    } 
}
