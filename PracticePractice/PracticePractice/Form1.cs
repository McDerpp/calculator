using System.Data;
namespace PracticePractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string temp = "";

        private void testing_MouseClick(object sender, MouseEventArgs e)
        {
            int sum = Convert.ToInt32(txtTest.Text) + Convert.ToInt32(txtTest.Text);
        }


        private void labelTest_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            temp = temp + 1;
            txtTest.Text = temp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            temp = temp + 2;
            txtTest.Text = temp;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            temp = temp + 3;
            txtTest.Text = temp;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            temp = temp + 4;
            txtTest.Text = temp;

        }
        private void button5_Click(object sender, EventArgs e)
        {
            temp = temp + 5;
            txtTest.Text = temp;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            temp = temp + 6;
            txtTest.Text = temp;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            temp = temp + 7;
            txtTest.Text = temp;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            temp = temp + 8;
            txtTest.Text = temp;

        }


        private void button9_Click(object sender, EventArgs e)
        {
            temp = temp + 9;
            txtTest.Text = temp;

        }

        private void button0_Click(object sender, EventArgs e)
        {
            temp = temp + 0;
            txtTest.Text = temp;

        }

        private void add_Click(object sender, EventArgs e)
        {
            temp = temp + "+";
            txtTest.Text = temp;


        }

        private void subtract_Click(object sender, EventArgs e)
        {
            temp = temp + "-";
            txtTest.Text = temp;


        }

        private void divide_Click(object sender, EventArgs e)
        {
            temp = temp + "/";
            txtTest.Text = temp;


        }

        private void multiply_Click(object sender, EventArgs e)
        {
            temp = temp + "*";
            txtTest.Text = temp;

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            txtTest.Text = new DataTable().Compute(temp, "").ToString();
            temp = new DataTable().Compute(temp, "").ToString();

        }

        private void button17_Click(object sender, EventArgs e)
        {
            temp = "";
            txtTest.Text = temp;


        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (temp.Length != 0)
            {
                temp = temp.Remove(temp.Length - 1);
                txtTest.Text = temp;
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            temp = temp + ".";
            txtTest.Text = temp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            temp = temp + ")";
            txtTest.Text = temp;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            temp = temp + "(";
            txtTest.Text = temp;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTest_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
