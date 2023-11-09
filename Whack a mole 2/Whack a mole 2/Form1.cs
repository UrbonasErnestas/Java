namespace Whack_a_mole_2
{
    public partial class Form1 : Form
    {
        int N;
        Label[] labels;
        int dydis = 50;
        int tarpas = 25;
        int active = -1;
        Random r = new Random();
        int taskai = 0;

        private void labels_click(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            if (label.BackColor == Color.Green)
            {
                taskai += Convert.ToInt32(label.Text);
                label1.Text = "Taskai: " + taskai.ToString();
                label.BackColor = BackColor;
                timer1.Interval /= 2;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            N = Convert.ToInt32(numericUpDown1.Value);
            N = N * N;
            labels = new Label[N];
            int top = 50;
            int left = tarpas;
            for (int i = 0; i < N; i++)
            {
                labels[i] = new Label();
                labels[i].Parent = this;
                labels[i].Width = labels[i].Height = 50;
                labels[i].BorderStyle = BorderStyle.FixedSingle;
                labels[i].Top = top;
                labels[i].Left = left;
                labels[i].TextAlign = ContentAlignment.MiddleCenter;
                left += dydis + tarpas;
                if (i > 0 && (i + 1) % Math.Sqrt(N) == 0)
                {
                    left = dydis;
                    top += dydis + tarpas;
                }
                labels[i].Click += new EventHandler(labels_click);
            }
            int rp = (Width - ClientSize.Width) / 2;
            int rs = Height - ClientSize.Height - rp;
            Width = labels[N - 1].Left + labels[N - 1].Width + tarpas + 2 + rp;
            Height = labels[N - 1].Top + labels[N - 1].Height + tarpas + rp + rs;
            button1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (active == -1)
            {
                active = r.Next(N);
                labels[active].BackColor = Color.Green;
                labels[active].Text = Convert.ToString(r.Next(10) - 4);

            }
            else
            {
                labels[active].BackColor = BackColor;
                labels[active].Text = "";
                active = -1;
            }
        }
    }
}