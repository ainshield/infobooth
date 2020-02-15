using System;
using System.Drawing;
using System.Windows.Forms;

namespace infobooth
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
            if (coursesearch.Text == "")
            {
                coursesearch.Text = "enter keywords here";
                coursesearch.ForeColor = Color.Gray;
            }
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Coursesearch_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            coursesearch.Text = "";
            coursesearch.ForeColor = Color.Black;
        }

        private void TabPage7_Click(object sender, EventArgs e)
        {

        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            if (usernamebox.Text == "username" && passwordbox.Text == "password")
            {
                adminform formshow = new adminform();

                formshow.Show();
                this.Hide();

            }
            else if (usernamebox.Text != "username" && passwordbox.Text != "password")
            {
                MessageBox.Show("wrong username or password!", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {

            }
 
        }
    }
}
