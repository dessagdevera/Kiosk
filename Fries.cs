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
    public partial class Fries : Form
    {
        public static string addWAFFLESNACKS, WAFFLESNACKS, addCLASSICDGSBURGERSNACKS, CLASSICDGSBURGERSNACKS,addTAPSIBURGERSNACKS, TAPSIBURGERSNACKS, addBLUEBERRYSNACKS, BLUEBERRYSNACKS, addHAMCHEESESNACKS, HAMCHEESESNACKS, addVEGANBURGERSNACKS, VEGANBURGERSNACKS, addPIZZASNACKS, PIZZASNACKS, addADOBOBURGERSNACKS, ADOBOBURGERSNACKS;
        public static int  PRICE, PRICE2, PRICE3, PRICE4, PRICE5, PRICE6, PRICE7, PRICE8, TOTAL, FriesPREPTIME, PREPTIME;
        private bool Clicked3 = false;
        private bool Clicked4 = false;
        private bool Clicked8 = false;
        private bool Clicked9 = false;
        private bool Clicked10 = false;
        private bool Clicked12= false;
        private bool Clicked13 = false;
        private bool Clicked14 = false;
        private bool FRIESClicked = false;
        private bool NEWITEMClicked = false;
        public static int snackstotal = 0;
        public Fries()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu men = new Menu();
            men.Show();
            this.Hide();
        }

        private void Fries_Load(object sender, EventArgs e)
        {
          
        }

        //add to cart button
        private void button2_Click(object sender, EventArgs e)
        {

            Cart cart = new Cart();
           
            try
            {

                if (Clicked3||Clicked4||Clicked8||Clicked9|Clicked10|Clicked12|Clicked13|Clicked14)
                {
                    TOTAL = TOTAL + PRICE;
                    PREPTIME = PREPTIME + FriesPREPTIME;
                    //add3 = SNACKS + " \t" + "PHP" + PRICE;
                    //cart.receiveData(add3);
                    if (Clicked3.Equals(true))
                    {
                        addWAFFLESNACKS = WAFFLESNACKS + PRICE;
                        cart.receiveData(addWAFFLESNACKS);
                    }
                    
                    else if (Clicked4.Equals(true))
                    {
                        addCLASSICDGSBURGERSNACKS = CLASSICDGSBURGERSNACKS + PRICE;
                        cart.receiveData(addCLASSICDGSBURGERSNACKS);
                    }
                    else if (Clicked8.Equals(true))
                    {
                        addTAPSIBURGERSNACKS = TAPSIBURGERSNACKS + PRICE;
                        cart.receiveData(addTAPSIBURGERSNACKS);
                    }
                    else if (Clicked9.Equals(true))
                    {
                        addBLUEBERRYSNACKS = BLUEBERRYSNACKS + PRICE;
                        cart.receiveData(addBLUEBERRYSNACKS);
                    }
                    else if (Clicked10.Equals(true))
                    {
                        addHAMCHEESESNACKS = HAMCHEESESNACKS + PRICE;
                        cart.receiveData(addHAMCHEESESNACKS);
                    }
                    else if (Clicked12.Equals(true))
                    {
                        addVEGANBURGERSNACKS = VEGANBURGERSNACKS + PRICE; 
                        cart.receiveData(addVEGANBURGERSNACKS);
                    }
                    else if (Clicked13.Equals(true))
                    {
                        addPIZZASNACKS = PIZZASNACKS + PRICE;
                        cart.receiveData(addPIZZASNACKS);
                    }
                    else if (Clicked14.Equals(true))
                    {
                        addADOBOBURGERSNACKS = ADOBOBURGERSNACKS + PRICE;
                        cart.receiveData(addADOBOBURGERSNACKS);
                    }
                    else { }
                    Clicked3 = false;
                    MessageBox.Show("Added to Cart", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    label2.Hide();
                    label3.Hide();
                    // label4.Hide();
                }               
                else
                {
                    MessageBox.Show("Choose your snack", "Error Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                snackstotal = TOTAL;
            
             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           }
        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox7.Show();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            pictureBox5.Hide();
            pictureBox6.Hide();
            pictureBox8.Hide();
            pictureBox9.Hide();          
            label3.Hide();
            groupBox1.Hide();
            label1.Visible = false;
            REGULAR.Visible = false;
            LARGE.Visible = false;
            Clicked3 = true;
            WAFFLESNACKS = " WAFFLE" + "\t" + "\t" + " \t" + " \t" + "(NUTELLA)" + "\t";
            PRICE = 40;
            FriesPREPTIME = 15;
            label4.Text = "                            For only ₱40";

        }
        private void button4_Click(object sender, EventArgs e)
        {
            groupBox1.Hide(); pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            pictureBox5.Show();
            pictureBox6.Hide();
            pictureBox7.Hide();
            pictureBox8.Hide();
            pictureBox9.Hide();
            
            label3.Hide();
            label1.Visible = false;
            REGULAR.Visible = false;
            LARGE.Visible = false;        
            Clicked4 = true;
            CLASSICDGSBURGERSNACKS = " BURGER" + "\t" + "\t" + "\t" + "(CLASSIC DGS BURGER)";
            PRICE = 40;
            FriesPREPTIME = 15;
            label4.Visible = true;
            label4.Text = "         Your favorite classic burger made" + '\n'+ "        with fresh meat and vegetables, for ₱40";
        }
       
      

        private void button8_Click(object sender, EventArgs e)
        {
            groupBox1.Hide(); 
            pictureBox2.Hide();
            pictureBox3.Show();
            pictureBox4.Hide();
            pictureBox5.Hide();
            pictureBox6.Hide();
            pictureBox7.Hide();
            pictureBox8.Hide();
            pictureBox9.Hide();
           
           label3.Hide();
            label1.Visible = false;
            REGULAR.Visible = false;
            LARGE.Visible = false;
           // label4.Visible = true;
            Clicked8 = true;
            TAPSIBURGERSNACKS = " BURGER" + "\t" + " \t" + " \t" + "(TAPSI BURGER)" + "\t";
            PRICE = 60;
            FriesPREPTIME = 15;
            label4.Visible=true;
            label4.Text = "Sumptuous tapa burger with bacon and tapa" + '\n' + "patty added with fresh lettuce, for ₱60";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            groupBox1.Hide(); 
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            pictureBox5.Hide();
            pictureBox6.Hide();
            pictureBox7.Hide();
            pictureBox8.Hide();
            pictureBox9.Show();
       
            label3.Hide();
            label1.Visible = false;
            REGULAR.Visible = false;
            LARGE.Visible = false;
            Clicked9 = true;
            BLUEBERRYSNACKS = " WAFFLE" + "\t" + "\t" + " \t" + " \t" + "(BLUEBERRY)" + "\t";
            PRICE = 40;
            FriesPREPTIME = 15;
            label4.Text = "                            For only ₱40";

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (REGULAR.Checked)
            {
                LARGE.Enabled = false;
            }
            else
            {
                LARGE.Enabled = true;
            }
        }

        private void LARGE_CheckedChanged(object sender, EventArgs e)
        {
            if (LARGE.Checked)
            {
                REGULAR.Enabled = false;
            }
            else
            {
                REGULAR.Enabled = true;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            groupBox1.Hide(); 
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            pictureBox5.Hide();
            pictureBox6.Show();
            pictureBox7.Hide();
            pictureBox8.Hide();
            pictureBox9.Hide();
            
            label3.Hide();
            label1.Visible = false;
            REGULAR.Visible = false;
            LARGE.Visible = false;
            Clicked10 = true;
            HAMCHEESESNACKS = " WAFFLE" + "\t" + "\t" + " \t" + " \t" + "(HAM & CHEESE)" + "\t";
            PRICE = 50;
            FriesPREPTIME = 15;
            label4.Text = "                            For only ₱60";
        }
       

        private void button12_Click(object sender, EventArgs e)
        {
            groupBox1.Hide(); 
            pictureBox2.Show();
            pictureBox3.Hide();
            pictureBox4.Hide();
            pictureBox5.Hide();
            pictureBox6.Hide();
            pictureBox7.Hide();
            pictureBox8.Hide();
            pictureBox9.Hide();
         
            label3.Hide();
            label1.Visible = false;
            REGULAR.Visible = false;
            LARGE.Visible = false;
          //  label4.Visible = true;
            Clicked12 = true;
            VEGANBURGERSNACKS = " BURGER" + "\t" + " \t" + " \t" + "(VEGAN BURGER)" + "\t";
            PRICE = 60;
            FriesPREPTIME = 15;
            label4.Visible = true;
            label4.Text = ("Your new favorite gluten-free vegan burger" + '\n' + "with fresh tomato,avocado and lettuce, for ₱60");
        }
        private void button13_Click(object sender, EventArgs e)
        {
            groupBox1.Hide(); 
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            pictureBox5.Hide();
            pictureBox6.Hide();
            pictureBox7.Hide();
            pictureBox8.Show();
            pictureBox9.Hide();
           
            label3.Hide();
            label1.Visible = false;
            REGULAR.Visible = false;
            LARGE.Visible = false;
            Clicked13 = true;
            PIZZASNACKS = " WAFFLE" + "\t" + "\t" + " \t" + " \t" + "(PIZZA)" + "\t" + "\t";
            PRICE = 70;
            FriesPREPTIME = 15;
            label4.Text = "                            For only ₱70";
        }
        private void button14_Click(object sender, EventArgs e)
        {
            groupBox1.Hide(); 
            pictureBox4.Show();
            pictureBox3.Hide();
            pictureBox2.Hide();
            pictureBox5.Hide();
            pictureBox6.Hide();
            pictureBox7.Hide();
            pictureBox8.Hide();
            pictureBox9.Hide(); 


            label3.Hide();
            label1.Visible = false;
            REGULAR.Visible = false;
            LARGE.Visible = false;
            label4.Visible = true;
            Clicked14 = true;
            ADOBOBURGERSNACKS = " BURGER" + "\t" + " \t" + " \t" + "(ADOBO BURGER)" + "\t";
            PRICE = 60;
            FriesPREPTIME = 15;
            label4.Text = " The iconic Filipino cruisine serve as" + '\n'+ "  burger with fresh lettuce and tomato, for ₱60";
        }


        private void Cart_Click(object sender, EventArgs e)
        {

            Cart cart = new Cart();
            cart.Show();
            this.Hide();
        }
       

       
    }
}
