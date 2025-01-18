namespace WinSiparis
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new();
            form2.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            Form2 form2 = new();
            form2.MdiParent = this;
            form2.Show();
        }
    }
}
