namespace TP_MOD3_1302220131
{
    public partial class Form1 : Form
    {
        string input;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Hello, " + input;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            input = textBox1.Text;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
