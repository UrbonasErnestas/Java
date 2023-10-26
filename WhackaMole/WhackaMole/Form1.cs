namespace WhackaMole
{
    public partial class Form1 : Form
    {

        const int N = 3;
        Label[] kurmis;
        int active = -1;
        Random random = new Random();
        int taskai = 0;
        int laikas = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void kurmis_click(object sender, EventArgs e)
        {
            Label kurmis = (Label)sender;
            if (laikas > 0)
            {
                if (kurmis.BackColor == Color.Red)
                {
                    taskai++;
                    label4.Text = "Taskai: " + taskai.ToString();
                    laikas += 3;
                    label5.Text = laikas.ToString();
                    kurmis.BackColor = BackColor;
                }
                else
                {
                    laikas -= 2;
                    if (laikas >= 0)
                    {
                        label5.Text = laikas.ToString();
                    }
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            kurmis = new Label[N];
            kurmis[0] = label1;
            kurmis[1] = label2;
            kurmis[2] = label3;

            for (int i = 0; i < N; i++)
            {

                kurmis[i].AutoSize = false;
                kurmis[i].BorderStyle = BorderStyle.FixedSingle;
                kurmis[i].Width = kurmis[i].Height = 50;
                kurmis[i].Left = 50 + (kurmis[i].Width + 50) * i;
                kurmis[i].Top = 50;
                kurmis[i].Text = "";
                kurmis[i].Click += new EventHandler(kurmis_click);

            }
            this.Width = kurmis[N - 1].Left + kurmis[N - 1].Width + 66;
            Height = kurmis[0].Top + kurmis[0].Height + 50 + 38 + 8;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (active == -1)
            {
                active = random.Next(3);
                kurmis[active].BackColor = Color.Red;
                timer1.Interval = 1000;
            }
            else
            {
                kurmis[active].BackColor = BackColor;
                active = -1;
                timer1.Interval = 1000;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            laikas = laikas - 1;
            if (laikas >= 0)
            {
label5.Text = laikas.ToString();
            }
            
            if (laikas <= 0)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                MessageBox.Show("zaza");
            }
        }
    }
}