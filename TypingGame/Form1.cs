namespace TypingGame
{
    public partial class Form1 : Form
    {
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Location = GetPoint();
            label2.Text = GetRandChar().ToString();
            timer1.Start();
            button1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Top += 5;
            if (label2.Top >= panel1.Height)
            {
                label2.Location = GetPoint();
            }
        }
        Random xlocation = new Random();
        private Point GetPoint()
        {
            int x = xlocation.Next(0, panel1.Width - label2.Width);
            return new Point(x, 0);
        }
        Random randChar = new Random();
        private char GetRandChar()
        {
            return (Char)randChar.Next(97, 123);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char userPress = e.KeyChar;
            if (label2.Text == userPress.ToString())
            {
                score += 1;
                label1.Text = "Taskai " + score;
                label2.Location = GetPoint();
                label2.Text = GetRandChar().ToString();
            }
            else
            {
                score -= 1;
                label1.Text = "Taskai " + score;
            }
            if (score < 0)
            {
                this.Close();

            }
        }

      
    }
}