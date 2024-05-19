namespace cs0517
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kenitikun.Left = Kenitikun.Left + 10;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kenitikun.Top = Kenitikun.Top + 10;
        }

        private void Up_Click(object sender, EventArgs e)
        {
            Kenitikun.Top = Kenitikun.Top - 10;
        }

        private void Left_Click(object sender, EventArgs e)
        {
            Kenitikun.Left = Kenitikun.Left - 10;
        }

        private void Sirasu_Click(object sender, EventArgs e)
        {

        }

        private void Sirasu_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("‚±‚ñ‚É‚¿‚Í");
            MessageBox.Show(100.ToString());
            MessageBox.Show($"{100}");
            MessageBox.Show($"Kenitikun.Top={Kenitikun.Top}");

            MessageBox.Show(3.14f.ToString());
            MessageBox.Show($"{3.14f}");

            MessageBox.Show(1 + 1.ToString());       //11
            MessageBox.Show((1 + 1).ToString());     // 2
            MessageBox.Show($"{1 + 1}");             // 2

            MessageBox.Show((1.23f * 2.34f).ToString());
            MessageBox.Show($"{1.23f * 2.34f}");

            MessageBox.Show("1" + "1");              //11
        }
    }
}