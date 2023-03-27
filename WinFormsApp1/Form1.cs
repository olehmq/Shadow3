namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Singleton.Instance.Log("Натиснув button4");

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Singleton.Instance.Log("Натиснув button1");

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Singleton.Instance.Log("Натиснув button2");

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Singleton.Instance.Log("Натиснув button3");

            
        }
    }
}