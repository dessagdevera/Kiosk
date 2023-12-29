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
    public partial class Fruit : Form
    {
        public static string BLUEBERRYTEAFRUITFLAVOR, BLUEBUTTERFLYFRUITFLAVOR, BLUEBERRYLEMONFRUITFLAVOR, KIWILEMONFRUITFLAVOR, addBLUEBERRYTEAFRUITFLAVOR, addBLUEBUTTERFLYFRUITFLAVOR, addBLUEBERRYLEMONFRUITFLAVOR, addKIWILEMONFRUITFLAVOR
            , addBLUEBERRYTEAFRUITFLAVOR2, addBLUEBUTTERFLYFRUITFLAVOR2, addBLUEBERRYLEMONFRUITFLAVOR2, addKIWILEMONFRUITFLAVOR2;
        public static int PRICE16OZ, PRICE22OZ, TOTAL, FruitPREPTIME, PREPTIME;
        private bool Clicked2 = false;
        private bool Clicked3 = false;
        private bool Clicked4 = false;
        private bool Clicked5 = false;
        private bool NEWITEMClicked = false;
        public static int fruittotal = 0;
        public Fruit()
        {
            InitializeComponent();
        }


        int blue = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            if (blue == 0)
            {
                //change color once clicked
                TEA.BackColor = Color.Salmon;
                blue++;
                Clicked2 = true;
                BLUEBERRYTEAFRUITFLAVOR = " BLUEBERRY TEA  " + "\t" + "\t" + "\t" + "\t" + "\t";
                PRICE16OZ = 48;
                PRICE22OZ = 68;
                FruitPREPTIME = 10;
                //other button not clickable
                BUTTERFLY.Enabled = false;
                BERRY.Enabled = false;
                KIWI.Enabled = false;
            }
            else
            {

                //other button will be clickable
                BUTTERFLY.Enabled = true;
                BERRY.Enabled = true;
                KIWI.Enabled = true;

                //reset

                blue = 0;
                TEA.BackColor = Color.White;
                BLUEBERRYTEAFRUITFLAVOR = "";
                PRICE16OZ = 0;
                PRICE22OZ = 0;

            }
        }
        int butterf = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            if (butterf == 0)
            {
                BUTTERFLY.BackColor = Color.Salmon;
                butterf++;
                Clicked3 = true;
                BLUEBUTTERFLYFRUITFLAVOR = " BLUE BUTTERFLY  " + "\t" + "\t" + "\t" + "\t" + "\t";
                PRICE16OZ = 48;
                PRICE22OZ = 68;
                FruitPREPTIME = 10;

                TEA.Enabled = false;
                BERRY.Enabled = false;
                KIWI.Enabled = false;


            }
            else
            {

                TEA.Enabled = true;
                BERRY.Enabled = true;
                KIWI.Enabled = true;
                butterf = 0;
                BUTTERFLY.BackColor = Color.White;
                BLUEBUTTERFLYFRUITFLAVOR = "";
                PRICE16OZ = 0;
                PRICE22OZ = 0;
            }
        }
        int lemon = 0;
        private void button4_Click(object sender, EventArgs e)
        {

            if (lemon == 0)
            {
                BERRY.BackColor = Color.Salmon;
                lemon++;
                Clicked4 = true;
                BLUEBERRYLEMONFRUITFLAVOR = " BLUEBERRY LEMON " + "\t" + "\t" + "\t" + "\t" + "\t";
                PRICE16OZ = 48;
                PRICE22OZ = 68;
                FruitPREPTIME = 10;

                TEA.Enabled = false;
                BUTTERFLY.Enabled = false;
                KIWI.Enabled = false;
            }
            else
            {
                TEA.Enabled = true;
                BUTTERFLY.Enabled = true;
                KIWI.Enabled = true;

                lemon = 0;
                BERRY.BackColor = Color.White;
                BLUEBERRYLEMONFRUITFLAVOR = "";
                PRICE16OZ = 0;
                PRICE22OZ = 0;
            }
        }

        private void Fruit_Load(object sender, EventArgs e)
        {
            
        }

        int kiwi = 0;
        private void button5_Click(object sender, EventArgs e)
        {

            if (kiwi == 0)
            {
                KIWI.BackColor = Color.Salmon;
                kiwi++;

                Clicked5 = true;
                KIWILEMONFRUITFLAVOR = " KIWI LEMON    " + "\t" + "\t" + "\t" + "\t" + "\t" + "\t";
                PRICE16OZ = 48;
                PRICE22OZ = 68;
                FruitPREPTIME = 10;

                TEA.Enabled = false;
                BUTTERFLY.Enabled = false;
                BERRY.Enabled = false;
            }
            else
            {
                TEA.Enabled = true;
                BUTTERFLY.Enabled = true;
                BERRY.Enabled = true;

                kiwi = 0;
                KIWI.BackColor = Color.White;
                KIWILEMONFRUITFLAVOR = "";
                PRICE16OZ = 0;
                PRICE22OZ = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu men = new Menu();
            men.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart();
            cart.totalcart = 0;

            try
            {

                if (SMALLSIZE.Checked && Clicked2 || LARGESIZE.Checked && Clicked2 || SMALLSIZE.Checked && Clicked3 || LARGESIZE.Checked && Clicked3 || SMALLSIZE.Checked && Clicked4 || LARGESIZE.Checked && Clicked4
                    || SMALLSIZE.Checked && Clicked5 || LARGESIZE.Checked && Clicked5)
                {

                    if (SMALLSIZE.Checked)
                    {

                        if (Clicked2.Equals(true))
                        {
                            addBLUEBERRYTEAFRUITFLAVOR = BLUEBERRYTEAFRUITFLAVOR + PRICE16OZ;
                            cart.receiveData(addBLUEBERRYTEAFRUITFLAVOR);
                            TOTAL = TOTAL + PRICE16OZ;
                            PREPTIME = PREPTIME + FruitPREPTIME;
                        }
                        else if (Clicked3.Equals(true))
                        {
                            addBLUEBUTTERFLYFRUITFLAVOR = BLUEBUTTERFLYFRUITFLAVOR + PRICE16OZ;
                            cart.receiveData(addBLUEBUTTERFLYFRUITFLAVOR);
                            TOTAL = TOTAL + PRICE16OZ;
                            PREPTIME = PREPTIME + FruitPREPTIME;
                        }
                        else if (Clicked4.Equals(true))
                        {
                            addBLUEBERRYLEMONFRUITFLAVOR = BLUEBERRYLEMONFRUITFLAVOR + PRICE16OZ;
                            cart.receiveData(addBLUEBERRYLEMONFRUITFLAVOR);
                            TOTAL = TOTAL + PRICE16OZ;
                            PREPTIME = PREPTIME + FruitPREPTIME;
                        }
                        else if (Clicked5.Equals(true))
                        {
                            addKIWILEMONFRUITFLAVOR = KIWILEMONFRUITFLAVOR + PRICE16OZ;
                            cart.receiveData(addKIWILEMONFRUITFLAVOR);
                            TOTAL = TOTAL + PRICE16OZ;
                            PREPTIME = PREPTIME + FruitPREPTIME;
                        }

                        else { }

                        SMALLSIZE.Checked = false;
                        Clicked2 = false;
                        Clicked3 = false;
                        Clicked4 = false;
                        Clicked5 = false;

                        MessageBox.Show("Added to Cart", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        label1.Text = "";


                        TEA.BackColor = Color.White;
                        blue = 0;
                        TEA.Enabled = true;

                        BUTTERFLY.BackColor = Color.White;
                        butterf = 0;
                        BUTTERFLY.Enabled = true;

                        BERRY.BackColor = Color.White;
                        lemon = 0;
                        BERRY.Enabled = true;

                        KIWI.BackColor = Color.White;
                        kiwi = 0;
                        KIWI.Enabled = true;

                    }
                    if (LARGESIZE.Checked)
                    {

                      

                        if (Clicked2.Equals(true))
                        {
                            addBLUEBERRYTEAFRUITFLAVOR2 = BLUEBERRYTEAFRUITFLAVOR + PRICE22OZ;
                            cart.receiveData(addBLUEBERRYTEAFRUITFLAVOR2);
                            TOTAL = TOTAL + PRICE22OZ;
                            PREPTIME = PREPTIME + FruitPREPTIME;
                        }
                        else if (Clicked3.Equals(true))
                        {
                            addBLUEBUTTERFLYFRUITFLAVOR2 = BLUEBUTTERFLYFRUITFLAVOR + PRICE22OZ;
                            cart.receiveData(addBLUEBUTTERFLYFRUITFLAVOR2);
                            TOTAL = TOTAL + PRICE22OZ;
                            PREPTIME = PREPTIME + FruitPREPTIME;
                        }
                        else if (Clicked4.Equals(true))
                        {
                            addBLUEBERRYLEMONFRUITFLAVOR2 = BLUEBERRYLEMONFRUITFLAVOR + PRICE22OZ;
                            cart.receiveData(addBLUEBERRYLEMONFRUITFLAVOR2);
                            TOTAL = TOTAL + PRICE22OZ;
                            PREPTIME = PREPTIME + FruitPREPTIME;
                        }
                        else if (Clicked5.Equals(true))
                        {
                            addKIWILEMONFRUITFLAVOR2 = KIWILEMONFRUITFLAVOR + PRICE22OZ;
                            cart.receiveData(addKIWILEMONFRUITFLAVOR2);
                            TOTAL = TOTAL + PRICE22OZ;
                            PREPTIME = PREPTIME + FruitPREPTIME;
                        }

                        else { }

                        LARGESIZE.Checked = false;
                        Clicked2 = false;
                        Clicked3 = false;
                        Clicked4 = false;
                        Clicked5 = false;

                        MessageBox.Show("Added to Cart", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        label1.Text = "";

                        TEA.BackColor = Color.White;
                        blue = 0;
                        TEA.Enabled = true;

                        BUTTERFLY.BackColor = Color.White;
                        butterf = 0;
                        BUTTERFLY.Enabled = true;

                        BERRY.BackColor = Color.White;
                        lemon = 0;
                        BERRY.Enabled = true;

                        KIWI.BackColor = Color.White;
                        kiwi = 0;
                        KIWI.Enabled = true;

                    }
                    //  fruittotal = TOTAL;

                }
                else
                {
                    label1.Text = ("Please select your preferred drink/size");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Cart_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart();
            cart.Show();
            this.Hide();
        }
    }
}
