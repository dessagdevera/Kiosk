using System;
using System.Drawing;
using System.Windows.Forms;

namespace kiosk
{
    public partial class Coffee : Form
    {
        public static string COFFEE, addcoffee, AMERICANOCOFFEE, SALTEDCARAMELCOFFEE, CAPPUCINOCOFFEE, HAZELNUTLATTECOFFEE, SPANISHLATTECOFFEE, VANILLALATTECOFFEE
            , addAMERICANOCOFFEE, addSALTEDCARAMELCOFFEE, addCAPPUCINOCOFFEE, addHAZELNUTLATTECOFFEE, addSPANISHLATTECOFFEE, addVANILLALATTECOFFEE
            , addAMERICANOCOFFEE2, addSALTEDCARAMELCOFFEE2, addCAPPUCINOCOFFEE2, addHAZELNUTLATTECOFFEE2, addSPANISHLATTECOFFEE2, addVANILLALATTECOFFEE2;
        public static int PRICE16OZ, PRICE22OZ, TOTAL, CoffeePREPTIME, PREPTIME;
        private bool Clicked2 = false;
        private bool Clicked3 = false;
        private bool Clicked4 = false;
        private bool Clicked5 = false;
        private bool Clicked6 = false;
        private bool Clicked7 = false;
        private bool NEWITEMClicked = false;
        public static int coffeetotal = 0;
        public Coffee()
        {

            InitializeComponent();
        }

        private void Coffee_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu men = new Menu();
            men.Show();
            this.Hide();
        }
        int ameri = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            if (ameri == 0)
            {
                //change color once clicked
                AMERICANO.BackColor = Color.Salmon;
                ameri++;
                Clicked2 = true;
                AMERICANOCOFFEE = " AMERICANO" + "\t" + "\t" + "\t" + "\t" + "\t";
                PRICE16OZ = 50;
                PRICE22OZ = 70;
                CoffeePREPTIME = 15;
                //other button not clickable
                CARAMEL.Enabled = false;
                VANILATTE.Enabled = false;
                CAPPU.Enabled = false;
                SPANISH.Enabled = false;
                HAZLATTE.Enabled = false;
                
            }
            else

            {
                //other button will be clickable
                CARAMEL.Enabled = true;
                VANILATTE.Enabled = true;
                CAPPU.Enabled = true;
                SPANISH.Enabled = true;
                HAZLATTE.Enabled = true;

                //reset

                ameri= 0;
                AMERICANO.BackColor = Color.White;
                AMERICANOCOFFEE = "";
                PRICE16OZ = 0;
                PRICE22OZ = 0;

            }
        }

        int salt = 0;
        private void button5_Click(object sender, EventArgs e)
        {
            if(salt == 0)
            {
                CARAMEL.BackColor = Color.Salmon;
                salt++;
            
                
                Clicked3 = true;
                SALTEDCARAMELCOFFEE = " SALTED CARAMEL" + " \t" + "\t" + "\t" + "\t";
                PRICE16OZ = 50;
                PRICE22OZ = 70;
                CoffeePREPTIME = 15;

                AMERICANO.Enabled = false;
                VANILATTE.Enabled = false;
                CAPPU.Enabled = false;
                SPANISH.Enabled = false;
                HAZLATTE.Enabled = false;
            }
            else
            {
                AMERICANO.Enabled = true;
                VANILATTE.Enabled = true;
                CAPPU.Enabled = true;
                SPANISH.Enabled = true;
                HAZLATTE.Enabled = true;


                salt = 0;
                CARAMEL.BackColor = Color.White;
                SALTEDCARAMELCOFFEE = "";
                PRICE16OZ = 0;
                PRICE22OZ = 0;

            }
            

        }

        int cap = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            if (cap ==0)
            {

                CAPPU.BackColor= Color.Salmon;
                cap++;

                Clicked4= true;
                CAPPUCINOCOFFEE = " CAPPUCINO" + "\t" + "\t" + "\t" + "\t" + "\t";
                PRICE16OZ = 50;
                PRICE22OZ = 70;
                CoffeePREPTIME = 15;

                AMERICANO.Enabled = false;
                VANILATTE.Enabled = false;
                CARAMEL.Enabled = false;
                SPANISH.Enabled = false;
                HAZLATTE.Enabled = false;

            }
            else
            {
                AMERICANO.Enabled = true;
                VANILATTE.Enabled = true;
                CARAMEL.Enabled = true;
                SPANISH.Enabled = true;
                HAZLATTE.Enabled = true;

                cap = 0;
                CAPPU.BackColor = Color.White;
                CAPPUCINOCOFFEE = "";
                PRICE16OZ = 0;
                PRICE22OZ = 0;
            }
         
        }
        int hazl = 0;
        private void button4_Click(object sender, EventArgs e)
        {

            if (hazl ==0)
            {

               HAZLATTE.BackColor= Color.Salmon;
                hazl++;
                Clicked5 = true;
                HAZELNUTLATTECOFFEE = " HAZELNUT LATTE" + "\t" + "\t" + "\t" + "\t" + "\t";
                PRICE16OZ = 50;
                PRICE22OZ = 70;
                CoffeePREPTIME = 15;

                AMERICANO.Enabled = false;
                VANILATTE.Enabled = false;
                CAPPU.Enabled = false;
                SPANISH.Enabled = false;
                CARAMEL.Enabled = false;

            }
            else
            {


                AMERICANO.Enabled = true;
                VANILATTE.Enabled = true;
                CAPPU.Enabled = true;
                SPANISH.Enabled = true;
                CARAMEL.Enabled = true;

                hazl = 0;
                HAZLATTE.BackColor = Color.White;
                HAZELNUTLATTECOFFEE = "";
                PRICE16OZ = 0;
                PRICE22OZ = 0;



            }

        }

        int spash = 0;
        private void button6_Click(object sender, EventArgs e)
        {
            if (spash == 0)
            {


                SPANISH.BackColor = Color.Salmon;
                spash++;
                Clicked6 = true;
                SPANISHLATTECOFFEE = " SPANISH LATTE" + "\t" + "\t" + "\t" + "\t" + "\t";
                PRICE16OZ = 50;
                PRICE22OZ = 70;
                CoffeePREPTIME = 15;

                AMERICANO.Enabled = false;
                VANILATTE.Enabled = false;
                CAPPU.Enabled = false;
                HAZLATTE.Enabled = false;
                CARAMEL.Enabled = false;
            }

            else
            {
                AMERICANO.Enabled = true;
                VANILATTE.Enabled = true;
                CAPPU.Enabled = true;
                HAZLATTE.Enabled = true;
                CARAMEL.Enabled = true;

                spash = 0;
                SPANISH.BackColor = Color.White;
                SPANISHLATTECOFFEE = "";
                PRICE16OZ = 0;
                PRICE22OZ = 0;


            }

        }
        int vanilla = 0;
        private void button7_Click(object sender, EventArgs e)
        {

            if (vanilla ==0)
            {
                VANILATTE.BackColor= Color.Salmon;
                vanilla++;
                 Clicked7 = true;
                VANILLALATTECOFFEE = " VANILLA LATTE" + " \t" + "\t" + "\t" + "\t" + "\t";
                PRICE16OZ = 50;
                PRICE22OZ = 70;
                CoffeePREPTIME = 15;

                AMERICANO.Enabled = false;
                SPANISH.Enabled = false;
                CAPPU.Enabled = false;
                HAZLATTE.Enabled = false;
                CARAMEL.Enabled = false;

            }
            else
            {
                AMERICANO.Enabled = true;
                SPANISH.Enabled = true;
                CAPPU.Enabled = true;
                HAZLATTE.Enabled = true;
                CARAMEL.Enabled = true;

                vanilla = 0;
                VANILATTE.BackColor = Color.White;
                VANILLALATTECOFFEE = "";
                PRICE16OZ = 0;
                PRICE22OZ = 0;
            }
           
        }

      

        private void Coffee_Activated(object sender, EventArgs e)
        {

        }

 

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (HOT.Checked)
            {
                COLD.Enabled = false;
            }
            else
            {
                COLD.Enabled = true;
            }
        }

        private void COLD_CheckedChanged(object sender, EventArgs e)
        {
            if (COLD.Checked)
            {
                HOT.Enabled = false;
            }
            else
            {
                HOT.Enabled = true;
            }
        }

        private void size1_CheckedChanged(object sender, EventArgs e)
        {
            if (size1.Checked)
            {
                size2.Enabled = false;
            }
            else
            {
                size2.Enabled = true;
            }
        }

        private void size2_CheckedChanged(object sender, EventArgs e)
        {
            if (size2.Checked)
            {
                size1.Enabled = false;
            }
            else
            {
                size1.Enabled = true;
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

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
                if (HOT.Checked && size1.Checked && Clicked2.Equals(true) || HOT.Checked && size1.Checked && Clicked3.Equals(true)
                    || HOT.Checked && size1.Checked && Clicked4.Equals(true) || HOT.Checked && size1.Checked && Clicked5.Equals(true) || HOT.Checked && size1.Checked && Clicked6.Equals(true)
                    || HOT.Checked && size1.Checked && Clicked7.Equals(true))
                {

                    // addcoffee = " HOT " + COFFEE + " (16OZ)" + "\t" + "\t" + "\t" + "PHP" + PRICE16OZ;

                    if (Clicked2.Equals(true))
                    {
                        addAMERICANOCOFFEE = AMERICANOCOFFEE + "(HOT)" + PRICE16OZ;
                        cart.receiveData(addAMERICANOCOFFEE);

                        TOTAL = TOTAL + PRICE16OZ;
                        PREPTIME = PREPTIME + CoffeePREPTIME;
                    }
                    else if (Clicked3.Equals(true))
                    {
                        addSALTEDCARAMELCOFFEE = SALTEDCARAMELCOFFEE + "(HOT)" + PRICE16OZ;
                        cart.receiveData(addSALTEDCARAMELCOFFEE);

                        TOTAL = TOTAL + PRICE16OZ;
                        PREPTIME = PREPTIME + CoffeePREPTIME;
                    }
                    else if (Clicked4.Equals(true))
                    {
                        addCAPPUCINOCOFFEE = CAPPUCINOCOFFEE + "(HOT)" + PRICE16OZ;
                        cart.receiveData(addCAPPUCINOCOFFEE);

                        TOTAL = TOTAL + PRICE16OZ;
                        PREPTIME = PREPTIME + CoffeePREPTIME;
                    }
                    else if (Clicked5.Equals(true))
                    {
                        addHAZELNUTLATTECOFFEE = HAZELNUTLATTECOFFEE + "(HOT)" + PRICE16OZ;
                        cart.receiveData(addHAZELNUTLATTECOFFEE);

                        TOTAL = TOTAL + PRICE16OZ;
                        PREPTIME = PREPTIME + CoffeePREPTIME;
                    }
                    else if (Clicked6.Equals(true))
                    {
                        addSPANISHLATTECOFFEE = SPANISHLATTECOFFEE + "(HOT)" + PRICE16OZ;
                        cart.receiveData(addSPANISHLATTECOFFEE);

                        TOTAL = TOTAL + PRICE16OZ;
                        PREPTIME = PREPTIME + CoffeePREPTIME;
                    }
                    else if (Clicked7.Equals(true))
                    {
                        addVANILLALATTECOFFEE = VANILLALATTECOFFEE + "(HOT)" + PRICE16OZ;
                        cart.receiveData(addVANILLALATTECOFFEE);

                        TOTAL = TOTAL + PRICE16OZ;
                        PREPTIME = PREPTIME + CoffeePREPTIME;
                    }
                    else { }


                    Clicked2 = false;
                    HOT.Checked = false;
                    size1.Checked = false;
                    Clicked3 = false;
                    Clicked4 = false;
                    Clicked5 = false;
                    Clicked6 = false;
                    Clicked7 = false;
                    MessageBox.Show("Added to Cart", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    label1.Text = "";


                    CARAMEL.BackColor = Color.White;
                    salt = 0;
                    CARAMEL.Enabled = true;

                    AMERICANO.BackColor = Color.White;
                    ameri = 0;
                    AMERICANO.Enabled = true;

                    HAZLATTE.BackColor = Color.White;
                    hazl = 0;
                    HAZLATTE.Enabled = true;

                    CAPPU.BackColor = Color.White;
                    cap = 0;
                    CAPPU.Enabled = true;

                    VANILATTE.BackColor = Color.White;
                    vanilla = 0;
                    VANILATTE.Enabled = true;

                    SPANISH.BackColor = Color.White;
                    spash = 0;
                    SPANISH.Enabled = true;


                }
                else if (HOT.Checked && size2.Checked && Clicked2.Equals(true) || HOT.Checked && size2.Checked && Clicked3.Equals(true)
                    || HOT.Checked && size2.Checked && Clicked4.Equals(true) || HOT.Checked && size2.Checked && Clicked5.Equals(true) || HOT.Checked && size2.Checked && Clicked6.Equals(true)
                    || HOT.Checked && size2.Checked && Clicked7.Equals(true))
                {
                    // addcoffee2 = " HOT " + COFFEE + " (22OZ)" + "\t" + "\t" + "\t" + "PHP" + PRICE22OZ;


                    if (Clicked2.Equals(true))
                    {
                        addAMERICANOCOFFEE2 = AMERICANOCOFFEE + "(HOT)" + PRICE22OZ;
                        cart.receiveData(addAMERICANOCOFFEE2);

                        TOTAL = TOTAL + PRICE22OZ;
                        PREPTIME = PREPTIME + CoffeePREPTIME;
                    }
                    else if (Clicked3.Equals(true))
                    {
                        addSALTEDCARAMELCOFFEE2 = SALTEDCARAMELCOFFEE + "(HOT)" + PRICE22OZ;
                        cart.receiveData(addSALTEDCARAMELCOFFEE2);

                        TOTAL = TOTAL + PRICE22OZ;
                        PREPTIME = PREPTIME + CoffeePREPTIME;
                    }
                    else if (Clicked4.Equals(true))
                    {
                        addCAPPUCINOCOFFEE2 = CAPPUCINOCOFFEE + "(HOT)" + PRICE22OZ;
                        cart.receiveData(addCAPPUCINOCOFFEE2);

                        TOTAL = TOTAL + PRICE22OZ;
                        PREPTIME = PREPTIME + CoffeePREPTIME;
                    }
                    else if (Clicked5.Equals(true))
                    {
                        addHAZELNUTLATTECOFFEE2 = HAZELNUTLATTECOFFEE + "(HOT)" + PRICE22OZ;
                        cart.receiveData(addHAZELNUTLATTECOFFEE2);

                        TOTAL = TOTAL + PRICE22OZ;
                        PREPTIME = PREPTIME + CoffeePREPTIME;
                    }
                    else if (Clicked6.Equals(true))
                    {
                        addSPANISHLATTECOFFEE2 = SPANISHLATTECOFFEE + "(HOT)" + PRICE22OZ;
                        cart.receiveData(addSPANISHLATTECOFFEE2);

                        TOTAL = TOTAL + PRICE22OZ;
                        PREPTIME = PREPTIME + CoffeePREPTIME;
                    }
                    else if (Clicked7.Equals(true))
                    {
                        addVANILLALATTECOFFEE2 = VANILLALATTECOFFEE + "(HOT)" + PRICE22OZ;
                        cart.receiveData(addVANILLALATTECOFFEE2);

                        TOTAL = TOTAL + PRICE22OZ;
                        PREPTIME = PREPTIME + CoffeePREPTIME;
                    }
                    else { }
                    // cart.receiveData(addcoffee2);
                    Clicked2 = false;
                    HOT.Checked = false;
                    size2.Checked = false;
                    Clicked3 = false;
                    Clicked4 = false;
                    Clicked5 = false;
                    Clicked6 = false;
                    Clicked7 = false;
                    MessageBox.Show("Added to Cart", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    label1.Text = "";

                    CARAMEL.BackColor = Color.White;
                    salt = 0;
                    CARAMEL.Enabled = true;

                    AMERICANO.BackColor = Color.White;
                    ameri = 0;
                    AMERICANO.Enabled = true;

                    HAZLATTE.BackColor = Color.White;
                    hazl = 0;
                    HAZLATTE.Enabled = true;

                    CAPPU.BackColor = Color.White;
                    cap = 0;
                    CAPPU.Enabled = true;

                    VANILATTE.BackColor = Color.White;
                    vanilla = 0;
                    VANILATTE.Enabled = true;

                    SPANISH.BackColor = Color.White;
                    spash = 0;
                    SPANISH.Enabled = true;


                }
                else if (COLD.Checked && size1.Checked && Clicked2.Equals(true) || COLD.Checked && size1.Checked && Clicked3.Equals(true)
                    || COLD.Checked && size1.Checked && Clicked4.Equals(true) || COLD.Checked && size1.Checked && Clicked5.Equals(true) || COLD.Checked && size1.Checked && Clicked6.Equals(true)
                    || COLD.Checked && size1.Checked && Clicked7.Equals(true))
                {
                    //addcoffee = " ICE " + COFFEE + " (16OZ)" + "\t" + "\t" + "\t" + "PHP" + PRICE16OZ;


                    if (Clicked2.Equals(true))
                    {
                        addAMERICANOCOFFEE = AMERICANOCOFFEE + "(COLD)" + PRICE16OZ;
                        cart.receiveData(addAMERICANOCOFFEE);
                        TOTAL = TOTAL + PRICE16OZ;
                        PREPTIME = PREPTIME + CoffeePREPTIME;
                    }
                    else if (Clicked3.Equals(true))
                    {
                        addSALTEDCARAMELCOFFEE = SALTEDCARAMELCOFFEE + "(COLD)" + PRICE16OZ;
                        cart.receiveData(addSALTEDCARAMELCOFFEE);
                        TOTAL = TOTAL + PRICE16OZ;
                        PREPTIME = PREPTIME + CoffeePREPTIME;
                    }
                    else if (Clicked4.Equals(true))
                    {
                        addCAPPUCINOCOFFEE = CAPPUCINOCOFFEE + "(COLD)" + PRICE16OZ;
                        cart.receiveData(addCAPPUCINOCOFFEE);
                        TOTAL = TOTAL + PRICE16OZ;
                        PREPTIME = PREPTIME + CoffeePREPTIME;
                    }
                    else if (Clicked5.Equals(true))
                    {
                        addHAZELNUTLATTECOFFEE = HAZELNUTLATTECOFFEE + "(COLD)" + PRICE16OZ;
                        cart.receiveData(addHAZELNUTLATTECOFFEE);
                        TOTAL = TOTAL + PRICE16OZ;
                        PREPTIME = PREPTIME + CoffeePREPTIME;
                    }
                    else if (Clicked6.Equals(true))
                    {
                        addSPANISHLATTECOFFEE = SPANISHLATTECOFFEE + "(COLD)" + PRICE16OZ;
                        cart.receiveData(addSPANISHLATTECOFFEE);
                        TOTAL = TOTAL + PRICE16OZ;
                        PREPTIME = PREPTIME + CoffeePREPTIME;
                    }
                    else if (Clicked7.Equals(true))
                    {
                        addVANILLALATTECOFFEE = VANILLALATTECOFFEE + "(COLD)" + PRICE16OZ;
                        cart.receiveData(addVANILLALATTECOFFEE);
                        TOTAL = TOTAL + PRICE16OZ;
                        PREPTIME = PREPTIME + CoffeePREPTIME;
                    }
                    else { }
                    // cart.receiveData(addcoffee);
                    Clicked2 = false;
                    COLD.Checked = false;
                    size1.Checked = false;
                    Clicked3 = false;
                    Clicked4 = false;
                    Clicked5 = false;
                    Clicked6 = false;
                    Clicked7 = false;
                    MessageBox.Show("Added to Cart", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    label1.Text = "";

                    CARAMEL.BackColor = Color.White;
                    salt = 0;
                    CARAMEL.Enabled = true;

                    AMERICANO.BackColor = Color.White;
                    ameri = 0;
                    AMERICANO.Enabled = true;

                    HAZLATTE.BackColor = Color.White;
                    hazl = 0;
                    HAZLATTE.Enabled = true;

                    CAPPU.BackColor = Color.White;
                    cap = 0;
                    CAPPU.Enabled = true;

                    VANILATTE.BackColor = Color.White;
                    vanilla = 0;
                    VANILATTE.Enabled = true;

                    SPANISH.BackColor = Color.White;
                    spash = 0;
                    SPANISH.Enabled = true;

                }
                else if (COLD.Checked && size2.Checked && Clicked2.Equals(true) || COLD.Checked && size2.Checked && Clicked3.Equals(true) || COLD.Checked && size2.Checked && Clicked4.Equals(true) || COLD.Checked && size2.Checked && Clicked5.Equals(true) || COLD.Checked && size2.Checked && Clicked6.Equals(true)
                    || COLD.Checked && size2.Checked && Clicked7.Equals(true))
                {
                    //addcoffee2 = " ICE " + COFFEE + " (22OZ)" + "\t" + "\t" + "\t" + "PHP" + PRICE22OZ;


                    if (Clicked2.Equals(true))
                    {
                        addAMERICANOCOFFEE2 = AMERICANOCOFFEE + "(COLD)" + PRICE22OZ;
                        cart.receiveData(addAMERICANOCOFFEE2);
                        TOTAL = TOTAL + PRICE22OZ;
                        PREPTIME = PREPTIME + CoffeePREPTIME;
                    }
                    else if (Clicked3.Equals(true))
                    {
                        addSALTEDCARAMELCOFFEE2 = SALTEDCARAMELCOFFEE + "(COLD)" + PRICE22OZ;
                        cart.receiveData(addSALTEDCARAMELCOFFEE2);
                        TOTAL = TOTAL + PRICE22OZ;
                        PREPTIME = PREPTIME + CoffeePREPTIME;
                    }
                    else if (Clicked4.Equals(true))
                    {
                        addCAPPUCINOCOFFEE2 = CAPPUCINOCOFFEE + "(COLD)" + PRICE22OZ;
                        cart.receiveData(addCAPPUCINOCOFFEE2);
                        TOTAL = TOTAL + PRICE22OZ;
                        PREPTIME = PREPTIME + CoffeePREPTIME;
                    }
                    else if (Clicked5.Equals(true))
                    {
                        addHAZELNUTLATTECOFFEE2 = HAZELNUTLATTECOFFEE + "(COLD)" + PRICE22OZ;
                        cart.receiveData(addHAZELNUTLATTECOFFEE2);
                        TOTAL = TOTAL + PRICE22OZ;
                        PREPTIME = PREPTIME + CoffeePREPTIME;
                    }
                    else if (Clicked6.Equals(true))
                    {
                        addSPANISHLATTECOFFEE2 = SPANISHLATTECOFFEE + "(COLD)" + PRICE22OZ;
                        cart.receiveData(addSPANISHLATTECOFFEE2);
                        TOTAL = TOTAL + PRICE22OZ;
                        PREPTIME = PREPTIME + CoffeePREPTIME;
                    }
                    else if (Clicked7.Equals(true))
                    {
                        addVANILLALATTECOFFEE2 = VANILLALATTECOFFEE + "(COLD)" + PRICE22OZ;
                        cart.receiveData(addVANILLALATTECOFFEE2);
                        TOTAL = TOTAL + PRICE22OZ;
                        PREPTIME = PREPTIME + CoffeePREPTIME;
                    }
                    //cart.receiveData(addcoffee2);
                    Clicked2 = false;
                    COLD.Checked = false;
                    size2.Checked = false;
                    Clicked3 = false;
                    Clicked4 = false;
                    Clicked5 = false;
                    Clicked6 = false;
                    Clicked7 = false;
                    MessageBox.Show("Added to Cart", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    label1.Text = "";

                    CARAMEL.BackColor = Color.White;
                    salt = 0;
                    CARAMEL.Enabled = true;

                    AMERICANO.BackColor = Color.White;
                    ameri = 0;
                    AMERICANO.Enabled = true;

                    HAZLATTE.BackColor = Color.White;
                    hazl = 0;
                    HAZLATTE.Enabled = true;

                    CAPPU.BackColor = Color.White;
                    cap = 0;
                    CAPPU.Enabled = true;

                    VANILATTE.BackColor = Color.White;
                    vanilla = 0;
                    VANILATTE.Enabled = true;

                    SPANISH.BackColor = Color.White;
                    spash = 0;
                    SPANISH.Enabled = true;

                }
                //walang kape
                else if (HOT.Checked && size1.Checked && Clicked2.Equals(false))
                {

                    label1.Text = ("Choose your coffee");
                }
                else if (HOT.Checked && size2.Checked && Clicked2.Equals(false))
                {


                    label1.Text = ("Choose your coffee");

                }
                else if (COLD.Checked && size1.Checked && Clicked2.Equals(false))
                {
                    label1.Text = ("Choose your coffeee");

                }
                else if (COLD.Checked && size2.Checked && Clicked2.Equals(false))
                {
                    label1.Text = ("Choose your coffee");

                }
                // size and temp
                else if (HOT.Checked && !size1.Checked && Clicked2.Equals(false) || HOT.Checked && !size1.Checked && Clicked2.Equals(true))
                {
                    label1.Text = ("Please select your preferred size of drink");

                }
                else if (HOT.Checked && !size2.Checked && Clicked2.Equals(false) || HOT.Checked && !size2.Checked && Clicked2.Equals(true))
                {
                    label1.Text = ("Please select your preferred size of drink");

                }
                else if (!HOT.Checked && size1.Checked && Clicked2.Equals(false) || !HOT.Checked && size1.Checked && Clicked2.Equals(true))
                {
                    label1.Text = ("Please select your preferred drink temperature");

                }
                else if (!HOT.Checked && size2.Checked && Clicked2.Equals(false) || !HOT.Checked && size2.Checked && Clicked2.Equals(true))
                {
                    label1.Text = ("Please select your preferred drink temperature");
                }
                else if (COLD.Checked && !size1.Checked && Clicked2.Equals(false) || COLD.Checked && !size1.Checked && Clicked2.Equals(true))
                {
                    label1.Text = ("Please select your preferred size of drink");

                }
                else if (COLD.Checked && !size2.Checked && Clicked2.Equals(false) || COLD.Checked && !size2.Checked && Clicked2.Equals(true))
                {
                    label1.Text = ("Please select your preferred size of drink");

                }
                else if (!COLD.Checked && size1.Checked && Clicked2.Equals(false) || !COLD.Checked && size1.Checked && Clicked2.Equals(true))
                {
                    label1.Text = ("Please select your preferred drink temperature");


                }
                else if (!COLD.Checked && size2.Checked && Clicked2.Equals(false) || !COLD.Checked && size2.Checked && Clicked2.Equals(true))
                {
                    label1.Text = ("Please select your preferred drink temperature");

                }
                else
                {
                    label1.Text = ("Please select your order");
                }

                //  coffeetotal = TOTAL;
                // Clicked2.Equals(false);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

