using System;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace kiosk
{
    public partial class Lemon : Form
    {
        public static string CLASSICLEMONFLAVOR, CUCUMBERLEMONFLAVOR, BLUEBERRYLEMONFLAVOR, KIWILEMONFLAVOR, GREENAPPLELEMONFLAVOR, LYCHEELEMONFLAVOR, addGREENAPPLELEMONFLAVOR, addCLASSICLEMONFLAVOR, addCUCUMBERLEMONFLAVOR, addBLUEBERRYLEMONFLAVOR, addKIWILEMONFLAVOR, addLYCHEELEMONFLAVOR;
        public static int PRICE16OZ, TOTAL, LemonPREPTIME, PREPTIME;
        private bool Clicked2 = false;
        private bool Clicked3 = false;
        private bool Clicked4 = false;
        private bool Clicked5 = false;
        private bool Clicked6 = false;
        private bool Clicked7 = false;
        private bool NEWITEMClicked = false;
        public static int lemontotal = 0; 
        public Lemon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu men = new Menu();
            men.Show();
            this.Hide();
        }


        private void Lemon_Load(object sender, EventArgs e)
        {

        }

        int classiccl = 0;
        private void button2_Click(object sender, EventArgs e)
        {

            if (classiccl == 0)
            {
                //change color once clicked
                CLASSIC.BackColor = Color.Salmon;
                classiccl++;

                Clicked2 = true;
                CLASSICLEMONFLAVOR = " CLASSIC LEMON" + "\t" + "\t" + "\t" + "\t" + "\t" + "\t";
                PRICE16OZ = 50;
                LemonPREPTIME = 10;

                //other button not clickable
                CUCU.Enabled = false;
                KIWI.Enabled = false;
                GREEN.Enabled = false;
                BLUE.Enabled = false;
                LYCHEE.Enabled = false;



            }
            else
            {
                //other button will be clickable
                CUCU.Enabled = true;
                KIWI.Enabled = true;
                GREEN.Enabled = true;
                BLUE.Enabled = true;
                LYCHEE.Enabled = true;

                //reset
                classiccl = 0;
                CLASSIC.BackColor = Color.White;
                CLASSICLEMONFLAVOR = "";
                PRICE16OZ = 0;
            }

        }

        int clem = 0;
        private void button3_Click(object sender, EventArgs e)
        {

            if (clem == 0)
            {
                CUCU.BackColor = Color.Salmon;
                clem++;

                Clicked3 = true;
                CUCUMBERLEMONFLAVOR = " CUCUMBER LEMON" + " \t" + "\t" + "\t" + "\t" + "\t";
                PRICE16OZ = 50;
                LemonPREPTIME = 10;

                KIWI.Enabled = false;
                BLUE.Enabled = false;
                LYCHEE.Enabled = false;
                GREEN.Enabled = false;
                CLASSIC.Enabled = false;
            }
            else
            {

                KIWI.Enabled = true;
                BLUE.Enabled = true;
                LYCHEE.Enabled = true;
                GREEN.Enabled = true;
                CLASSIC.Enabled = true;

                clem = 0;
                CUCU.BackColor = Color.White;
                CUCUMBERLEMONFLAVOR = "";
                PRICE16OZ = 0;
            }


        }
        int blemon = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            if (blemon == 0)
            {
                BLUE.BackColor = Color.Salmon;
                blemon++;

                Clicked4 = true;
                BLUEBERRYLEMONFLAVOR = " BLUEBERRY LEMON" + "\t" + "\t" + "\t" + "\t" + "\t";
                PRICE16OZ = 50;
                LemonPREPTIME = 10;

                KIWI.Enabled = false;
                CUCU.Enabled = false;
                LYCHEE.Enabled = false;
                GREEN.Enabled = false;
                CLASSIC.Enabled = false;
            }
            else
            {

                KIWI.Enabled = true;
                CUCU.Enabled = true;
                LYCHEE.Enabled = true;
                GREEN.Enabled = true;
                CLASSIC.Enabled = true;

                blemon = 0;
                BLUE.BackColor = Color.White;
                BLUEBERRYLEMONFLAVOR = "";
                PRICE16OZ = 0;

            }
        }


        int kiw = 0;
        private void button5_Click(object sender, EventArgs e)
        {

            if (kiw == 0)
            {
                KIWI.BackColor = Color.Salmon;
                kiw++;

                Clicked5 = true;
                KIWILEMONFLAVOR = " KIWI LEMON  " + "\t" + "\t" + "\t" + "\t" + "\t" + "\t";
                PRICE16OZ = 50;
                LemonPREPTIME = 10;

                BLUE.Enabled = false;
                CUCU.Enabled = false;
                LYCHEE.Enabled = false;
                GREEN.Enabled = false;
                CLASSIC.Enabled = false;
            }
            else
            {
                BLUE.Enabled = true;
                CUCU.Enabled = true;
                LYCHEE.Enabled = true;
                GREEN.Enabled = true;
                CLASSIC.Enabled = true;

                kiw = 0;
                KIWI.BackColor = Color.White;
                KIWILEMONFLAVOR = "";
                PRICE16OZ = 0;

            }



        }
        int lychl = 0;
        private void button6_Click(object sender, EventArgs e)
        {

            if (lychl == 0)
            {
                LYCHEE.BackColor = Color.Salmon;
                lychl++;

                Clicked6 = true;
                LYCHEELEMONFLAVOR = " LYCHEE LEMON" + "\t" + "\t" + "\t" + "\t" + "\t" + "\t";
                PRICE16OZ = 50;
                LemonPREPTIME = 10;

                BLUE.Enabled = false;
                CUCU.Enabled = false;
                KIWI.Enabled = false;
                GREEN.Enabled = false;
                CLASSIC.Enabled = false;


            }
            else
            {

                BLUE.Enabled = true;
                CUCU.Enabled = true;
                KIWI.Enabled = true;
                GREEN.Enabled = true;
                CLASSIC.Enabled = true;

                lychl = 0;
                LYCHEE.BackColor = Color.White;
                LYCHEELEMONFLAVOR = "";
                PRICE16OZ = 0;
            }
        }
        int greenap = 0;
        private void button7_Click(object sender, EventArgs e)
        {

            if (greenap == 0)
            {
                GREEN.BackColor = Color.Salmon;
                greenap++;

                Clicked7 = true;
                GREENAPPLELEMONFLAVOR = " GREEN APPLE LEMON" + "\t" + "\t" + "\t" + "\t" + "\t";
                PRICE16OZ = 50;
                LemonPREPTIME = 10;

                BLUE.Enabled = false;
                CUCU.Enabled = false;
                KIWI.Enabled = false;
                LYCHEE.Enabled = false;
                CLASSIC.Enabled = false;

            }
            else
            {
                BLUE.Enabled = true;
                CUCU.Enabled = true;
                KIWI.Enabled = true;
                LYCHEE.Enabled = true;
                CLASSIC.Enabled = true;

                greenap = 0;
                GREEN.BackColor = Color.White;
                GREENAPPLELEMONFLAVOR = "";
                PRICE16OZ = 0;
            }
            
        }
        private void Cart_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart();
            cart.Show();
            this.Hide();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            Cart cart = new Cart();

            try
            {
                if (SMALLSIZE.Checked && Clicked2 || SMALLSIZE.Checked && Clicked3 || SMALLSIZE.Checked && Clicked4
                         || SMALLSIZE.Checked && Clicked5 || SMALLSIZE.Checked && Clicked6 || SMALLSIZE.Checked && Clicked7)
                {

                    if (SMALLSIZE.Checked)
                    {

                        if (Clicked2.Equals(true))
                        {
                            addCLASSICLEMONFLAVOR = CLASSICLEMONFLAVOR + PRICE16OZ;
                            cart.receiveData(addCLASSICLEMONFLAVOR);
                            TOTAL = TOTAL + PRICE16OZ;
                            PREPTIME = PREPTIME + LemonPREPTIME;
                        }
                        else if (Clicked3.Equals(true))
                        {
                            addCUCUMBERLEMONFLAVOR = CUCUMBERLEMONFLAVOR + PRICE16OZ;
                            cart.receiveData(addCUCUMBERLEMONFLAVOR);
                            TOTAL = TOTAL + PRICE16OZ;
                            PREPTIME = PREPTIME + LemonPREPTIME;
                        }
                        else if (Clicked4.Equals(true))
                        {
                            addBLUEBERRYLEMONFLAVOR = BLUEBERRYLEMONFLAVOR + PRICE16OZ;
                            cart.receiveData(addBLUEBERRYLEMONFLAVOR);
                            TOTAL = TOTAL + PRICE16OZ;
                            PREPTIME = PREPTIME + LemonPREPTIME;
                        }
                        else if (Clicked5.Equals(true))
                        {
                            addKIWILEMONFLAVOR = KIWILEMONFLAVOR + PRICE16OZ;
                            cart.receiveData(addKIWILEMONFLAVOR);
                            TOTAL = TOTAL + PRICE16OZ;
                            PREPTIME = PREPTIME + LemonPREPTIME;
                        }
                        else if (Clicked6.Equals(true))
                        {
                            addLYCHEELEMONFLAVOR = LYCHEELEMONFLAVOR + PRICE16OZ;
                            cart.receiveData(addLYCHEELEMONFLAVOR);
                            TOTAL = TOTAL + PRICE16OZ;
                            PREPTIME = PREPTIME + LemonPREPTIME;
                        }
                        else if (Clicked7.Equals(true))
                        {
                            addGREENAPPLELEMONFLAVOR = GREENAPPLELEMONFLAVOR + PRICE16OZ;
                            cart.receiveData(addGREENAPPLELEMONFLAVOR);
                            TOTAL = TOTAL + PRICE16OZ;
                            PREPTIME = PREPTIME + LemonPREPTIME;
                        }
                        else { }

                        SMALLSIZE.Checked = false;
                        Clicked2 = false;
                        Clicked3 = false;
                        Clicked4 = false;
                        Clicked5 = false;
                        Clicked6 = false;
                        Clicked7 = false;
                        MessageBox.Show("Added to Cart", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        label1.Text = "";

                        KIWI.BackColor = Color.White;
                        kiw = 0;
                        KIWI.Enabled = true;

                        BLUE.BackColor = Color.White;
                        blemon = 0;
                        BLUE.Enabled = true;

                        LYCHEE.BackColor = Color.White;
                        lychl = 0;
                        LYCHEE.Enabled = true;

                        GREEN.BackColor = Color.White;
                        greenap = 0;
                        GREEN.Enabled = true;

                        CUCU.BackColor = Color.White;
                        clem = 0;
                        CUCU.Enabled = true;

                        CLASSIC.BackColor = Color.White;
                        classiccl = 0;
                        CLASSIC.Enabled = true;


                    }

                    // lemontotal= TOTAL;

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
}
}
