namespace TP_MODUL3_103022400125
{
    public partial class Form1 : Form
    {
        int angka1;
        int angka2; 
        string operasi;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            angka1 = Convert.ToInt32(label1.Text);
            operasi = "+";
            label1.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text += "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            angka2 = Convert.ToInt32(label1.Text);
            double hasil = 0;

            if (operasi == "+")
            {
                hasil = angka1 + angka2;
            }

            label1.Text = hasil.ToString();
        }
    }
}
