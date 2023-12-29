using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;
using System.Reflection.Emit;
using System.Xml.Linq;
using System.Collections;
using System.Data.OleDb;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kiosk
{
    public partial class Payment : Form
    {

       
        public Payment()
        {
            InitializeComponent();         
        }

        public string nick { get; set; } // get nickname
        public int total { get; set; } //get total from cart
        public string orders { get; set; }
        public static List<string> frmcart = new List<string>();    
        public static BindingSource retrieve = new BindingSource();     //retrieve orders from cart
        public string getnickname, newtext;
        public static int que = 1;  // order number
        public string date;
        public bool click1 = false;
        public bool click2 = false;

        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "Ql07FR3YmFXtH5Yq9SemfO43ZyQgdiEB7pJeNCHz",
            BasePath = "https://systemdatabase-29086-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;

        private void button1_Click(object sender, EventArgs e) 
        {
            Class2.frmcart.Clear();
            Cart men = new Cart();
            men.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            button4.Visible = true;
            button5.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible=false;
            button4.Visible = false;
        }


        private void Payment_Activated(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
        string cash;
        private void button5_Click_1(object sender, EventArgs e)
        {
            try
            {
                Class2 db = new Class2()
                {
                    Date = Fordadate.Text,
                    Data = label6.Text,
                    CustomerName = label3.Text,
                    Total = label1.Text,

                };
               
                var setter = client.Push("Customer Information/", db);
              
       
                string pop = "Order Successful!\nOrder Number: " + que + "\n" + "Please pay ₱" + total + " to cashier for order confirmation and payment";
                MessageBox.Show(pop, "DGS Cafe", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                //Payment.que++; //increment queing number every sucessful order
                Class2.TOTALRECEIPT.Add(total);



                //reset
                Cart cart = new Cart();
                Class1.newItem.Clear();
                Frappe.frappetotal = Frappe.TOTAL = 0;
                Coffee.coffeetotal = Coffee.TOTAL = 0;
                Fruit.fruittotal = Fruit.TOTAL = 0;
                Lemon.lemontotal = Lemon.TOTAL = 0;

                Milk_Tea.milkteatotal = Milk_Tea.TOTAL = 0;
                cart.updatedtotalcart = Frappe.TOTAL + Coffee.TOTAL + Fruit.TOTAL + Lemon.TOTAL + Milk_Tea.TOTAL;
                cart.totalcart = cart.updatedtotalcart;
                Frappe.frappetotal = 0;
                Coffee.coffeetotal = 0;
                Fruit.fruittotal = 0;
                Lemon.lemontotal = 0;
                Milk_Tea.milkteatotal = 0;

                cart.updatedtotalcart = 0;
                cart.totalcart = 0;
                //////////////////
                ///paymentlistbnox clear
              

                 Receipt rep = new Receipt();
                rep.Show();
                this.Hide();

              //  Class2.MODEOFPAYMENT.Add(cash);
               

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Payment_Load(object sender, EventArgs e)
        {
            try
            {

                label3.Hide();
                label6.Hide();
                label10.Hide();
                label8.Text = que.ToString();

                retrieve.DataSource = Class2.frmcart;
                listBox1.DataSource = retrieve;
                button5.Enabled = false;
                DateTime time = DateTime.Now;

                date = time.ToShortDateString();

                Fordadate.Text = date;
                Fordadate.Hide();

                foreach (String item in retrieve)
                {

                    label6.Text += (label10.Text == "" ? "\n" : "\n") + item;
                }

                try
                {
                    client = new FireSharp.FirebaseClient(fcon);
                    label3.Text = nick; // get nickname from cart form
                    label1.Text = "₱" + Convert.ToString(total); // get data of total from cart

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {             
                button5.Enabled = true;
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
