namespace WinAPP
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a5 = ("");
            string a1 = textBox2.Text;
            textBox1.Text = a1;
            textBox2.Text = a5;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a5 = ("");
            string a2 = textBox1.Text;
            textBox2.Text = a2;
            textBox1.Text = a5;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string a2 = textBox1.Text;
            string a3 = textBox2.Text;
            textBox1.Text = a3;
            textBox2.Text = a2;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string a5 = ("");
            textBox1.Text = a5;
            textBox2.Text = a5;
        }
    }
}


 
