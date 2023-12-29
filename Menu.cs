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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cart n = new Cart();
            n.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Coffee cof = new Coffee();
            cof.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Milk_Tea milk = new Milk_Tea();
            milk.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lemon lemon= new Lemon();
            lemon.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Fruit fr = new Fruit();
            fr.Show();
            this.Hide();
        }

       

        private void button20_Click_1(object sender, EventArgs e)
        {
            Frappe frappe = new Frappe();
            frappe.Show();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void Cart_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart(); 
            cart.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LogIn open = new LogIn();
            open.Show();
            this.Hide();
        }
    }
}