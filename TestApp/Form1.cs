using System;
using System.Windows.Forms;
using exeio_api;

namespace TestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(apitokenTxt.Text) || String.IsNullOrEmpty(destinationTxt.Text))
            {
                MessageBox.Show("API Token or Destination cannot be empty!");
            }
            else
            {
                shortenUrl sh = new shortenUrl();
                shortenedTxt.Text = sh.Shorten(apitokenTxt.Text, destinationTxt.Text, customaliasTxt.Text);
            }
        }
    }
}
