using System.IO;
using System.Linq.Expressions;

namespace Pga5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            try { 
            StreamReader file = new StreamReader("history.txt");
            while (file.Peek() != -1)
            {
                listBox1.Items.Add(file.ReadLine());
            }
            file.Close();
        }catch (FileNotFoundException ex)
            {
                MessageBox.Show("History file not found!");
            }
}
            

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(textBox1.Text);
                int b = Convert.ToInt32(textBox2.Text);
                double r = 0;
                string op = "";
                if (comboBox1.SelectedIndex == 0)
                {
                    r = a + b;
                    op = " + ";
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    r = a - b;
                    op = " - ";
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    r = a * b;
                    op = " * ";
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    r = a / b;
                    op = " / ";
                }

                label1.Text = a.ToString() + op + b.ToString() + " = " + r.ToString();
                listBox1.Items.Add(label1.Text);
                StreamWriter file = new StreamWriter("history.txt", true);
                file.WriteLine(label1.Text);
                file.Close();
            }catch (FormatException ex)
            {
                MessageBox.Show("Incorrect input data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }catch (DivideByZeroException ex) {
                MessageBox.Show("Cannot divide by zero!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}