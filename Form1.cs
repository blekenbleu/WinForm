namespace WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int Write(string s)
        {
            textBox1.Text = s;
            return 0;
        }
    }
}