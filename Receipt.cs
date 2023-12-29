using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kiosk
{
    public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();
        }



        private void Receipt_Load(object sender, EventArgs e)
        {
            
            Payment pay = new Payment();
            Class2 aaa = new Class2();
            admin ad = new admin();
            Class1 cc = new Class1();
            Cart aaw = new Cart();
            label2.Text = "Order ID " + Payment.que;
            foreach (string apple in Class2.nickname)
            {
                label3.Text = "Name: " + apple; 
            }

            foreach (String item in Payment.retrieve)
            {

                label4.Text += (label1.Text == "" ? "\n" : "\n") + item;
            }

            foreach (int tots in Class2.TOTALRECEIPT)
            {
                label5.Text = "Total: " + tots.ToString(); 
            }


            Payment.que++;
            Class2.frmcart.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Class2.nickname.Clear();
            Class1.itemprice.Clear();
            Class1.itemName.Clear();
            Class1.itemSize.Clear();
            Class1.newItem.Clear();
            Class2.frmcart.Clear();

            NicknameForm nform = new NicknameForm();
            nform.Show();
            this.Hide();
        }
    }
}
