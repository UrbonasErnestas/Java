using System.Windows.Forms.DataVisualization.Charting;
namespace pamoka12_14
{



    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            Series grafikas = new Series();
            grafikas.Name = textBox1.Text;

            int n = Convert.ToInt32(numericUpDown1.Value);
            int min = Convert.ToInt32(numericUpDown2.Value);
            int max = Convert.ToInt32(numericUpDown3.Value);
            for (int i = 0; i < n; i++)
            {
                grafikas.Points.AddXY(i, r.Next(min, max + 1));

            }
            // grafiko stilius
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    grafikas.ChartType = SeriesChartType.Column; break;
                case 1:
                    grafikas.ChartType = SeriesChartType.Line; break;
                case 2:
                    grafikas.ChartType = SeriesChartType.Point; break;

            }
            grafikas.Color = panel1.BackColor;
            try
            {
                if (grafikas.Name == "")
                {
                    textBox1.BackColor = Color.Red;
                    throw new FormatException();
                }
                chart1.Series.Add(grafikas);
                textBox1.Text = "";
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Name already exists!");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("No name provided!");
            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            colorDialog1.Color = panel1.BackColor;
            if (DialogResult.OK == colorDialog1.ShowDialog())
            {
                panel1.BackColor = colorDialog1.Color;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {   
            if(textBox1.Text == "")
            {
                textBox1.BackColor = Color.Red;
            }
            else
            {
                textBox1.BackColor = Color.White;
            }
            
        }
    }
}