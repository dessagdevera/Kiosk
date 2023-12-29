using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace kiosk
{
    public partial class LogIn : Form
    {
        
        public LogIn()
        {
            InitializeComponent();
        }

        
        public string name,password;
        public int trial = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                name = textBox1.Text;
                password = textBox2.Text;

                string user = "1";
                string pass = "1";

                if (user == textBox1.Text && pass == textBox2.Text)
                {
                    admin open = new admin();
                    open.Show();
                    this.Hide();
                }

                else if (textBox1.Text == "")
                {
                    label1.Text = "This is a required field";
                }
                else if (textBox2.Text == "")
                {
                    label2.Text = "This is a required field";
                }
                else if (textBox1.Text == "" || textBox2.Text == "")
                {
                    label1.Text = "This is a required field";
                    label2.Text = "This is a required field";
                }

                else
                {
                    MessageBox.Show("Incorrect username and/or password. Please try again.");
                    trial++;
                    textBox1.Clear();
                    textBox2.Clear();
                    label1.Text = "";
                    label2.Text = "";

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 


        
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
           
        }   

        private void button3_Click(object sender, EventArgs e)
        {
            NicknameForm nicknameForm = new NicknameForm();
            nicknameForm.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //show password
            if (checkBox1.Checked == true)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
                textBox2.UseSystemPasswordChar = true;
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
    }
}
