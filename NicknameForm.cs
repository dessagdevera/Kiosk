using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kiosk
{
    public partial class NicknameForm : Form
    {
        public NicknameForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                Menu men = new Menu();

                if (textBox1.Text == "")
                {
                    label2.Text = "This is a required field";
                    textBox1.Focus();
                }

                else
                {

                    Class2.nickname.Add(textBox1.Text);
                    men.Show();
                    this.Hide();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Hide();
        }

        private void NicknameForm_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
    }
}
