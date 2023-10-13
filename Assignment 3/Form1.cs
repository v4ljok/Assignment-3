namespace Assignment_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double weight, height, bmi;
            weight = double.Parse(textBox1.Text);
            height = double.Parse(textBox2.Text);
            bmi = Math.Round(weight / Math.Pow(height, 2) * 703, 2);

            if (bmi < 18.5)
            {
                label3.Text = "BMI: " + bmi + "\n" + "Status: underweight";
            }
            else if (bmi > 25)
            {
                label3.Text = "BMI: " + bmi + "\n" + "Status: overweight";
            }
            else if (bmi < 25 && bmi > 18.5)
            {
                label3.Text = "BMI: " + bmi + "\n" + "Status: optimal";
            }
        }
    }
}