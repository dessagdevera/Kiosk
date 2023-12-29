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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace kiosk
{
    public partial class Milk_Tea : Form
    {
        public static string WHITEBUNNYMILKTEAFLAVOR, REDVELVETMILKTEAFLAVOR, HAZELNUTMILKTEAFLAVOR, MATCHAMILKTEAFLAVOR, NUTELLAMILKTEAFLAVOR, OKINAWAMILKTEAFLAVOR,
             addWHITEBUNNYMILKTEAFLAVOR, addREDVELVETMILKTEAFLAVOR, addHAZELNUTMILKTEAFLAVOR, addMATCHAMILKTEAFLAVOR, addNUTELLAMILKTEAFLAVOR, addOKINAWAMILKTEAFLAVOR,
            addWHITEBUNNYMILKTEAFLAVOR2, addREDVELVETMILKTEAFLAVOR2, addHAZELNUTMILKTEAFLAVOR2, addMATCHAMILKTEAFLAVOR2, addNUTELLAMILKTEAFLAVOR2, addOKINAWAMILKTEAFLAVOR2;
        public static int PRICE16OZ, PRICE22OZ, TOTAL, MilkteaPREPTIME, PREPTIME;
        private bool Clicked2 = false;
        private bool Clicked3 = false;
        private bool Clicked4 = false;
        private bool Clicked5 = false;
        private bool Clicked6 = false;

        private void LARGESIZE_CheckedChanged(object sender, EventArgs e)
        {

        }

        private bool Clicked7 = false;
        private bool NEWITEMClicked = false;
        public static int milkteatotal = 0;
        public Milk_Tea()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu men = new Menu();
            men.Show();
            this.Hide();
        }

        private void Milk_Tea_Load(object sender, EventArgs e)
        {
           
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
        int hazel = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            if (hazel == 0)
            {
                //change color once clicked
                HAZELNUT.BackColor = Color.Salmon;
                hazel++;

                Clicked2 = true;
                HAZELNUTMILKTEAFLAVOR = " HAZELNUT " + "\t" + "\t" + "\t" + "\t" + "\t" + "\t";
                PRICE16OZ = 28;
                PRICE22OZ = 38;
                MilkteaPREPTIME = 10;
                //other button not clickable
                MATCHA.Enabled = false;
                OKINAWA.Enabled = false;
                REDVELVET.Enabled = false;
                NUTELLA.Enabled = false;
                BUNNY.Enabled = false;
            }
            else
            {
                //other button will be clickable
                MATCHA.Enabled = true;
                OKINAWA.Enabled = true;
                REDVELVET.Enabled = true;
                NUTELLA.Enabled = true;
                BUNNY.Enabled = true;
                //reset
                hazel = 0;
                HAZELNUT.BackColor = Color.White;
                HAZELNUTMILKTEAFLAVOR = "";
                PRICE16OZ = 0;
                PRICE22OZ = 0;
            }

        }
        int matc = 0;
        private void button3_Click(object sender, EventArgs e)
        {

            if (matc == 0)
            {
                MATCHA.BackColor = Color.Salmon;
                matc++;
                Clicked3 = true;
                MATCHAMILKTEAFLAVOR = " MATCHA" + "\t" + "\t" + "\t" + "\t" + "\t" + "\t";
                PRICE16OZ = 28;
                PRICE22OZ = 38;
                MilkteaPREPTIME = 10;

                HAZELNUT.Enabled = false;
                NUTELLA.Enabled = false;
                OKINAWA.Enabled = false;
                REDVELVET.Enabled = false;
                BUNNY.Enabled = false;
            }
            else
            {
                HAZELNUT.Enabled = true;
                NUTELLA.Enabled = true;
                OKINAWA.Enabled = true;
                REDVELVET.Enabled = true;
                BUNNY.Enabled = true;

                matc = 0;
                MATCHA.BackColor = Color.White;
                MATCHAMILKTEAFLAVOR = "";
                PRICE16OZ = 0;
                PRICE22OZ = 0;
            }

        }
        int nut = 0;
        private void button4_Click(object sender, EventArgs e)
        {

            if (nut == 0)
            {
                NUTELLA.BackColor = Color.Salmon;
                nut++;

                Clicked4 = true;
                NUTELLAMILKTEAFLAVOR = " NUTELLA " + "\t" + "\t" + "\t" + "\t" + "\t" + "\t";
                PRICE16OZ = 28;
                PRICE22OZ = 38;
                MilkteaPREPTIME = 10;

                HAZELNUT.Enabled = false;
                OKINAWA.Enabled = false;
                MATCHA.Enabled = false;
                REDVELVET.Enabled = false;
                BUNNY.Enabled = false;
            }
            else
            {
                HAZELNUT.Enabled = true;
                OKINAWA.Enabled = true;
                MATCHA.Enabled = true;
                REDVELVET.Enabled = true;
                BUNNY.Enabled = true;

                nut = 0;
                NUTELLA.BackColor = Color.White;
                NUTELLAMILKTEAFLAVOR = "";
                PRICE16OZ = 0;
                PRICE22OZ = 0;

            }

        }
        int oki = 0;
        private void button5_Click(object sender, EventArgs e)
        {

            if (oki == 0)
            {
                OKINAWA.BackColor = Color.Salmon;
                oki++;

                Clicked5 = true;
                OKINAWAMILKTEAFLAVOR = " OKINAWA" + "\t" + "\t" + "\t" + "\t" + "\t" + "\t";
                PRICE16OZ = 28;
                PRICE22OZ = 38;
                MilkteaPREPTIME = 10;

                HAZELNUT.Enabled = false;
                MATCHA.Enabled = false;
                NUTELLA.Enabled = false;
                REDVELVET.Enabled = false;
                BUNNY.Enabled = false;
            }

            else
            {
                HAZELNUT.Enabled = true;
                MATCHA.Enabled = true;
                NUTELLA.Enabled = true;
                REDVELVET.Enabled = true;
                BUNNY.Enabled = true;

                oki = 0;
                OKINAWA.BackColor = Color.White;
                OKINAWAMILKTEAFLAVOR = "";
                PRICE16OZ = 0;
                PRICE22OZ = 0;
            }

        }
        int redvel = 0;
        private void button6_Click(object sender, EventArgs e)
        {

            if (redvel == 0)
            {
                REDVELVET.BackColor = Color.Salmon;
                redvel++;

                Clicked6 = true;
                REDVELVETMILKTEAFLAVOR = " RED VELVET " + "\t" + "\t" + "\t" + "\t" + "\t" + "\t";
                PRICE16OZ = 28;
                PRICE22OZ = 38;
                MilkteaPREPTIME = 10;

                HAZELNUT.Enabled = false;
                MATCHA.Enabled = false;
                NUTELLA.Enabled = false;
                OKINAWA.Enabled = false;
                BUNNY.Enabled = false;
            }
            else
            {
                HAZELNUT.Enabled = true;
                MATCHA.Enabled = true;
                NUTELLA.Enabled = true;
                OKINAWA.Enabled = true;
                BUNNY.Enabled = true;

                redvel = 0;
                REDVELVET.BackColor = Color.White;
                REDVELVETMILKTEAFLAVOR = "";
                PRICE16OZ = 0;
                PRICE22OZ = 0;
            }

        }
        int whiteb = 0;
        private void button7_Click(object sender, EventArgs e)
        {

            if (whiteb == 0)
            {
                BUNNY.BackColor = Color.Salmon;
                whiteb++;

                Clicked7 = true;
                WHITEBUNNYMILKTEAFLAVOR = " WHITE BUNNY " + "\t" + "\t" + "\t" + "\t" + "\t" + "\t";
                PRICE16OZ = 28;
                PRICE22OZ = 38;
                MilkteaPREPTIME = 10;

                HAZELNUT.Enabled = false;
                OKINAWA.Enabled = false;
                MATCHA.Enabled = false;
                NUTELLA.Enabled = false;
                REDVELVET.Enabled = false;
            }
            else
            {
                HAZELNUT.Enabled = true;
                OKINAWA.Enabled = true;
                MATCHA.Enabled = true;
                NUTELLA.Enabled = true;
                REDVELVET.Enabled = true;

                whiteb = 0;

                BUNNY.BackColor = Color.White;
                WHITEBUNNYMILKTEAFLAVOR = "";
                PRICE16OZ = 0;
                PRICE22OZ = 0;
            }

        }

        private void Cart_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart();
            cart.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            Cart cart = new Cart();
            cart.totalcart = 0;
            try
            {
                if (SMALLSIZE.Checked && Clicked2 || LARGESIZE.Checked && Clicked2 || SMALLSIZE.Checked && Clicked3 || LARGESIZE.Checked && Clicked3 || SMALLSIZE.Checked && Clicked4 || LARGESIZE.Checked && Clicked4
                         || SMALLSIZE.Checked && Clicked5 || LARGESIZE.Checked && Clicked5 || SMALLSIZE.Checked && Clicked6 || LARGESIZE.Checked && Clicked6 || SMALLSIZE.Checked && Clicked7 || LARGESIZE.Checked && Clicked7)
                {

                    if (SMALLSIZE.Checked)
                    {




                        if (Clicked2.Equals(true))
                        {
                            addHAZELNUTMILKTEAFLAVOR = HAZELNUTMILKTEAFLAVOR + PRICE16OZ;
                            cart.receiveData(addHAZELNUTMILKTEAFLAVOR);
                            TOTAL = TOTAL + PRICE16OZ;
                            PREPTIME = PREPTIME + MilkteaPREPTIME;


                        }
                        else if (Clicked3.Equals(true))
                        {
                            addMATCHAMILKTEAFLAVOR = MATCHAMILKTEAFLAVOR + PRICE16OZ;
                            cart.receiveData(addMATCHAMILKTEAFLAVOR);
                            TOTAL = TOTAL + PRICE16OZ;
                            PREPTIME = PREPTIME + MilkteaPREPTIME;


                        }
                        else if (Clicked4.Equals(true))
                        {
                            addNUTELLAMILKTEAFLAVOR = NUTELLAMILKTEAFLAVOR + PRICE16OZ;
                            cart.receiveData(addNUTELLAMILKTEAFLAVOR);
                            TOTAL = TOTAL + PRICE16OZ;
                            PREPTIME = PREPTIME + MilkteaPREPTIME;


                        }
                        else if (Clicked5.Equals(true))
                        {
                            addOKINAWAMILKTEAFLAVOR = OKINAWAMILKTEAFLAVOR + PRICE16OZ;
                            cart.receiveData(addOKINAWAMILKTEAFLAVOR);
                            TOTAL = TOTAL + PRICE16OZ;
                            PREPTIME = PREPTIME + MilkteaPREPTIME;


                        }
                        else if (Clicked6.Equals(true))
                        {
                            addREDVELVETMILKTEAFLAVOR = REDVELVETMILKTEAFLAVOR + PRICE16OZ;
                            cart.receiveData(addREDVELVETMILKTEAFLAVOR);
                            TOTAL = TOTAL + PRICE16OZ;
                            PREPTIME = PREPTIME + MilkteaPREPTIME;


                        }
                        else if (Clicked7.Equals(true))
                        {
                            addWHITEBUNNYMILKTEAFLAVOR = WHITEBUNNYMILKTEAFLAVOR + PRICE16OZ;
                            cart.receiveData(addWHITEBUNNYMILKTEAFLAVOR);
                            TOTAL = TOTAL + PRICE16OZ;
                            PREPTIME = PREPTIME + MilkteaPREPTIME;

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


                        BUNNY.BackColor = Color.White;
                        whiteb = 0;
                        BUNNY.Enabled = true;

                        OKINAWA.BackColor = Color.White;
                        oki = 0;
                        OKINAWA.Enabled = true;

                        HAZELNUT.BackColor = Color.White;
                        hazel = 0;
                        HAZELNUT.Enabled = true;

                        REDVELVET.BackColor = Color.White;
                        redvel = 0;
                        REDVELVET.Enabled = true;

                        MATCHA.BackColor = Color.White;
                        matc = 0;
                        MATCHA.Enabled = true;

                        NUTELLA.BackColor = Color.White;
                        nut = 0;
                        NUTELLA.Enabled = true;


                    }
                    if (LARGESIZE.Checked)
                    {

                        TOTAL = TOTAL + PRICE22OZ;
                        PREPTIME = PREPTIME + MilkteaPREPTIME;

                        if (Clicked2.Equals(true))
                        {
                            addHAZELNUTMILKTEAFLAVOR2 = HAZELNUTMILKTEAFLAVOR + PRICE22OZ;
                            cart.receiveData(addHAZELNUTMILKTEAFLAVOR2);
                            TOTAL = TOTAL + PRICE22OZ;
                            PREPTIME = PREPTIME + MilkteaPREPTIME;
                        }
                        else if (Clicked3.Equals(true))
                        {
                            addMATCHAMILKTEAFLAVOR2 = MATCHAMILKTEAFLAVOR + PRICE22OZ;
                            cart.receiveData(addMATCHAMILKTEAFLAVOR2);
                            TOTAL = TOTAL + PRICE22OZ;
                            PREPTIME = PREPTIME + MilkteaPREPTIME;
                        }
                        else if (Clicked4.Equals(true))
                        {
                            addNUTELLAMILKTEAFLAVOR2 = NUTELLAMILKTEAFLAVOR + PRICE22OZ;
                            cart.receiveData(addNUTELLAMILKTEAFLAVOR2);
                            TOTAL = TOTAL + PRICE22OZ;
                            PREPTIME = PREPTIME + MilkteaPREPTIME;
                        }
                        else if (Clicked5.Equals(true))
                        {
                            addOKINAWAMILKTEAFLAVOR2 = OKINAWAMILKTEAFLAVOR + PRICE22OZ;
                            cart.receiveData(addOKINAWAMILKTEAFLAVOR2);
                            TOTAL = TOTAL + PRICE22OZ;
                            PREPTIME = PREPTIME + MilkteaPREPTIME;
                        }
                        else if (Clicked6.Equals(true))
                        {
                            addREDVELVETMILKTEAFLAVOR2 = REDVELVETMILKTEAFLAVOR + PRICE22OZ;
                            cart.receiveData(addREDVELVETMILKTEAFLAVOR2);
                            TOTAL = TOTAL + PRICE22OZ;
                            PREPTIME = PREPTIME + MilkteaPREPTIME;
                        }
                        else if (Clicked7.Equals(true))
                        {
                            addWHITEBUNNYMILKTEAFLAVOR2 = WHITEBUNNYMILKTEAFLAVOR + PRICE22OZ;
                            cart.receiveData(addWHITEBUNNYMILKTEAFLAVOR2);
                            TOTAL = TOTAL + PRICE22OZ;
                            PREPTIME = PREPTIME + MilkteaPREPTIME;
                        }
                        else
                        {

                        }

                        LARGESIZE.Checked = false;
                        Clicked2 = false;
                        Clicked3 = false;
                        Clicked4 = false;
                        Clicked5 = false;
                        Clicked6 = false;
                        Clicked7 = false;
                        MessageBox.Show("Added to Cart", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        label1.Text = "";


                        BUNNY.BackColor = Color.White;
                        whiteb = 0;
                        BUNNY.Enabled = true;

                        OKINAWA.BackColor = Color.White;
                        oki = 0;
                        OKINAWA.Enabled = true;

                        HAZELNUT.BackColor = Color.White;
                        hazel = 0;
                        HAZELNUT.Enabled = true;

                        REDVELVET.BackColor = Color.White;
                        redvel = 0;
                        REDVELVET.Enabled = true;

                        MATCHA.BackColor = Color.White;
                        matc = 0;
                        MATCHA.Enabled = true;

                        NUTELLA.BackColor = Color.White;
                        nut = 0;
                        NUTELLA.Enabled = true;

                    }

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
