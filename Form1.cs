using System.Windows.Forms;

namespace WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.SizeChanged += new EventHandler(Form1_Resize);
        }
        public int Write(string s)
        {
            textBox1.Text = s;
            return 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //          this.Close();
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "12";
        }

        // changed Form1.Designer.cs to `notifyIcon1.MouseClick += notifyIcon1_MouseClick`
        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        // https://www.c-sharpcorner.com/UploadFile/f9f215/how-to-minimize-your-application-to-system-tray-in-C-Sharp/
        public void Form1_Resize(object? sender, EventArgs e)   // question mark is crucial(?!)
        {
            // hide minimized form from the task bar; show NotifyIcon in notification area
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
            }
        }
        
    }
}
