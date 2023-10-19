namespace Skaiciu_spejimas
{
    public partial class Form1 : Form
    {
        Random randomSkaicius = new Random();
        int n = 0; //numeris
        int s = 0; //spejimai
        public Form1()
        {
            InitializeComponent();
            klausimas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(textBox1.Text);
            s += 1;
            label2.Text = "Kiek kartu bandei atspeti " + s;

            if (i == n)
            {
                MessageBox.Show("Atspejai, bandyk dar karta");
                klausimas();
                textBox1.Text = "";
                s = 0;
                label2.Text = "Kiek kartu bandei atspeti " + s;
            }
            else if (i < n)
            {
                MessageBox.Show("Auksciau");
            }
            else
            {
                MessageBox.Show("Zemiau");
            }
        }
    private void klausimas()
        {
            n = randomSkaicius.Next(1, 100);
            label1.Text = "Atspek skaiciu nuo 1 iki 100 ";
        }
    }
}