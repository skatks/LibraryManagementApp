using System;
using System.Windows.Forms;

namespace LibraryManagementApp
{
    public class MainForm : Form
    {
        private Button btnTest;

        public MainForm()
        {
            this.Text = "Library Management System";
            this.Width = 400;
            this.Height = 300;
               
            btnTest = new Button();
            btnTest.Text = "Test";
            btnTest.Top = 100;
            btnTest.Left = 150;
            btnTest.Click += BtnTest_Click;

            this.Controls.Add(btnTest);
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Library System is working!");
        }
    }
}