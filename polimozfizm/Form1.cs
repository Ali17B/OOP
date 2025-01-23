namespace polimozfizm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nokia nk = new();
            nk.soundplay();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Samsung sm = new();
            sm.soundplay();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            iphone ip = new();
            ip.soundplay();
        }
    }
}
