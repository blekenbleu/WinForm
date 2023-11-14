using System.Windows.Forms;
namespace WinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            DialogResult dialogResult = MessageBox.Show("Dispose", "MessageBox");
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            textBox2 = new TextBox();
            label3 = new Label();
            button2 = new Button();
            notifyIcon1 = new NotifyIcon(components);
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(93, 57);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(495, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 16);
            label1.Name = "label1";
            label1.Size = new Size(201, 15);
            label1.TabIndex = 1;
            label1.Text = "Keyboard and Mouse event intercept";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 2;
            label2.Text = "Stroke event:";
            // 
            // button1
            // 
            button1.Location = new Point(317, 106);
            button1.Name = "button1";
            button1.Size = new Size(141, 23);
            button1.TabIndex = 3;
            button1.Text = "capture selected device";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(259, 151);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(32, 23);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(163, 154);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 5;
            label3.Text = "selected device:";
            // 
            // button2
            // 
            button2.Location = new Point(79, 106);
            button2.Name = "button2";
            button2.Size = new Size(152, 23);
            button2.TabIndex = 6;
            button2.Text = "select current device";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipText = "intercepted";
            notifyIcon1.BalloonTipTitle = "WinForm";
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "WinForm";
            notifyIcon1.MouseClick += notifyIcon1_MouseClick;
            notifyIcon1.ShowBalloonTip(1000);       // does this really do anything
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 207);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "WinForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox textBox2;
        private Label label3;
        private Button button2;
        private NotifyIcon notifyIcon1;
    }
}
