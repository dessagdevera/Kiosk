using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace kiosk
{

    public partial class Frappe : Form
    {

        public static string FRAPPEFLAVOR, add,add1, addtaro, addtaro2, price1, price2,size1,size2,TAROFLAVOR, UNICORNFLAVOR, addunicorn2,addunicorn, KITKATFLAVOR,addkitkat2, addkitkat,
             STRAWBERRYFLAVOR,WHITECHRISTMASFLAVOR, addstrawberry2,addwhitechristmas2, addstrawberry, addwhitechristmas;
        public static int PRICE16OZ, PRICE22OZ, TOTAL, FRAPPEPREPTIME, PREPTIME;
        public static int NEWTOTAL = 0;
        private bool Clicked2 = false;
        private bool Clicked3 = false;
        private bool Clicked4 = false;
        private bool Clicked5 = false;
        private bool Clicked6 = false;
        private bool Clicked7 = false;
        private bool NEWITEMClicked = false;
        public static int frappetotal = 0;
        public List<string> FrappeList = new List<string>();

        public Frappe()
        {
            InitializeComponent();
        }

        private void Frappe_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu men = new Menu();
            men.Show();
            this.Hide();
        }
        int cara = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            if(cara == 0)
            {
                //change color once clicked
                CARAMELMACHIATTO.BackColor = Color.Salmon;
                cara++;

                //original
                Clicked2 = true;
                FRAPPEFLAVOR = " CARAMEL MACCHIATO " + "\t" + "\t" + "\t" + "\t" + "\t";
                PRICE16OZ = 48;
                PRICE22OZ = 68;
                //add = FRAPPEFLAVOR + PRICE16OZ;
                FRAPPEPREPTIME = 10;


                //other button not clickable
                TARO.Enabled = false;
                KITKATOVERLOAD.Enabled = false;
                UNICORNFRAPPE.Enabled = false;
                WHITECHRISTMAS.Enabled = false;
                STRAWBERRY.Enabled = false;

            }
            else
            {
                //other button will be clickable
                TARO.Enabled = true;
                KITKATOVERLOAD.Enabled = true;
                UNICORNFRAPPE.Enabled = true;
                WHITECHRISTMAS.Enabled = true;
                STRAWBERRY.Enabled = true;

                //reset
                cara = 0;

                CARAMELMACHIATTO.BackColor = Color.White;
                FRAPPEFLAVOR = "";
                PRICE16OZ = 0;
                PRICE22OZ = 0;
            }
            

            
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            //RADIOBUTTON1 22OZ

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //RADIOBUTTON1 16OZ
        }

        int taro = 0;
        private void button5_Click(object sender, EventArgs e)
        {
            if (taro == 0)
            {
                TARO.BackColor = Color.Salmon;
                taro++;

                Clicked3 = true;
                TAROFLAVOR = " TARO " + "\t" + "\t" + "\t" + "\t" + "\t" + "\t" + "\t";
                PRICE16OZ = 48;
                PRICE22OZ = 68;
                //addtaro = TAROFLAVOR + PRICE16OZ;
                FRAPPEPREPTIME = 10;

                CARAMELMACHIATTO.Enabled = false;
                KITKATOVERLOAD.Enabled = false;
                UNICORNFRAPPE.Enabled = false;
                WHITECHRISTMAS.Enabled = false;
                STRAWBERRY.Enabled = false;
            }
            else
            {
                CARAMELMACHIATTO.Enabled = true;
                KITKATOVERLOAD.Enabled = true;
                UNICORNFRAPPE.Enabled = true;
                WHITECHRISTMAS.Enabled = true;
                STRAWBERRY.Enabled = true;

                taro = 0;
                TARO.BackColor = Color.White;             
                FRAPPEFLAVOR = "";
                PRICE16OZ = 0;
                PRICE22OZ = 0;
            }
}
        int uni = 0;
        private void button6_Click(object sender, EventArgs e)
        {
            if (uni ==0)
            {
                UNICORNFRAPPE.BackColor = Color.Salmon;
                uni++;

                  Clicked4 = true;
                UNICORNFLAVOR = " UNICORN FRAPPE " + "\t" + "\t" + "\t" + "\t" + "\t";
                PRICE16OZ = 48;
                PRICE22OZ = 68;
                FRAPPEPREPTIME = 10;

                CARAMELMACHIATTO.Enabled = false;
                TARO.Enabled = false;
                KITKATOVERLOAD.Enabled = false;
                WHITECHRISTMAS.Enabled = false;
                STRAWBERRY.Enabled = false;


            }
            else
            {
                CARAMELMACHIATTO.Enabled = true;
                TARO.Enabled = true;
                KITKATOVERLOAD.Enabled = true;
                WHITECHRISTMAS.Enabled = true;
                STRAWBERRY.Enabled = true;

                uni = 0;
                UNICORNFRAPPE.BackColor = Color.White;

                FRAPPEFLAVOR = "";
                PRICE16OZ = 0;
                PRICE22OZ = 0;

            }
        }

        int kit = 0;
        private void button3_Click(object sender, EventArgs e)
        {

            if (kit == 0)
            {
                KITKATOVERLOAD.BackColor = Color.Salmon;
                kit++;


                Clicked5 = true;
                KITKATFLAVOR = " KITKAT OVERLOAD" + "\t" + "\t" + "\t" + "\t" + "\t";
                PRICE16OZ = 48;
                PRICE22OZ = 68;
                FRAPPEPREPTIME = 10;

                CARAMELMACHIATTO.Enabled = false;
                TARO.Enabled = false;
                UNICORNFRAPPE.Enabled = false;
                WHITECHRISTMAS.Enabled = false;
                STRAWBERRY.Enabled = false;
            }
            else
            {
                CARAMELMACHIATTO.Enabled = true;
                TARO.Enabled = true;
                UNICORNFRAPPE.Enabled = true;
                WHITECHRISTMAS.Enabled = true;
                STRAWBERRY.Enabled = true;

                kit = 0;
                KITKATOVERLOAD.BackColor = Color.White;

                FRAPPEFLAVOR = "";
                PRICE16OZ = 0;
                PRICE22OZ = 0;
            }
        }


        int straw = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            if (straw == 0)
            {
                STRAWBERRY.BackColor = Color.Salmon;
                straw++;


                Clicked6 = true;
                STRAWBERRYFLAVOR = " STRAWBERRY " + "\t" + "\t" + "\t" + "\t" + "\t" + "\t";
                PRICE16OZ = 48;
                PRICE22OZ = 68;
                FRAPPEPREPTIME = 10;

                CARAMELMACHIATTO.Enabled = false;
                TARO.Enabled = false;
                KITKATOVERLOAD.Enabled = false;
                UNICORNFRAPPE.Enabled = false;
                WHITECHRISTMAS.Enabled = false;
            }
            else
            {
                CARAMELMACHIATTO.Enabled = true;
                TARO.Enabled = true;
                KITKATOVERLOAD.Enabled = true;
                UNICORNFRAPPE.Enabled = true;
                WHITECHRISTMAS.Enabled = true;


                straw = 0;
                STRAWBERRY.BackColor = Color.White;
                FRAPPEFLAVOR = "";
                PRICE16OZ = 0;
                PRICE22OZ = 0;
            }

        }
        int white = 0;
        private void button7_Click(object sender, EventArgs e)
        {
            if (white == 0)
            {
                WHITECHRISTMAS.BackColor = Color.Salmon;
                white++;


                Clicked7 = true;
                WHITECHRISTMASFLAVOR = " WHITE CHRISTMAS" + "\t" + "\t" + "\t" + "\t" + "\t";
                PRICE16OZ = 48;
                PRICE22OZ = 68;
                FRAPPEPREPTIME = 10;

                CARAMELMACHIATTO.Enabled = false;
                TARO.Enabled = false;
                KITKATOVERLOAD.Enabled = false;
                UNICORNFRAPPE.Enabled = false;
                STRAWBERRY.Enabled = false;
            }
            else
            {
                CARAMELMACHIATTO.Enabled = true;
                TARO.Enabled = true;
                KITKATOVERLOAD.Enabled = true;
                UNICORNFRAPPE.Enabled = true;
                STRAWBERRY.Enabled = true;

                white = 0;

                WHITECHRISTMAS.BackColor = Color.White;
                FRAPPEFLAVOR = "";
                PRICE16OZ = 0;
                PRICE22OZ = 0;
            }

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

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
                            add = FRAPPEFLAVOR + PRICE16OZ;
                            cart.receiveData(add);
                            TOTAL = TOTAL + PRICE16OZ;
                            PREPTIME = PREPTIME + FRAPPEPREPTIME;


                        }
                        else if (Clicked3.Equals(true))
                        {
                            addtaro = TAROFLAVOR + PRICE16OZ;
                            cart.receiveData(addtaro);
                            TOTAL = TOTAL + PRICE16OZ;
                            PREPTIME = PREPTIME + FRAPPEPREPTIME;


                        }
                        else if (Clicked4.Equals(true))
                        {
                            addunicorn = UNICORNFLAVOR + PRICE16OZ;
                            cart.receiveData(addunicorn);
                            TOTAL = TOTAL + PRICE16OZ;
                            PREPTIME = PREPTIME + FRAPPEPREPTIME;


                        }
                        else if (Clicked5.Equals(true))
                        {
                            addkitkat = KITKATFLAVOR + PRICE16OZ;
                            cart.receiveData(addkitkat);
                            TOTAL = TOTAL + PRICE16OZ;
                            PREPTIME = PREPTIME + FRAPPEPREPTIME;



                        }
                        else if (Clicked6.Equals(true))
                        {
                            addstrawberry = STRAWBERRYFLAVOR + PRICE16OZ;
                            cart.receiveData(addstrawberry);
                            TOTAL = TOTAL + PRICE16OZ;
                            PREPTIME = PREPTIME + FRAPPEPREPTIME;


                        }
                        else if (Clicked7.Equals(true))
                        {
                            addwhitechristmas = WHITECHRISTMASFLAVOR + PRICE16OZ;
                            cart.receiveData(addwhitechristmas);
                            TOTAL = TOTAL + PRICE16OZ;
                            PREPTIME = PREPTIME + FRAPPEPREPTIME;


                        }
                        else { }

                        FrappeList.Add(add);
                        SMALLSIZE.Checked = false;
                        Clicked2 = false;
                        Clicked3 = false;
                        Clicked4 = false;
                        Clicked5 = false;
                        Clicked6 = false;
                        Clicked7 = false;
                        MessageBox.Show("Added to Cart", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        label1.Text = "";

                        CARAMELMACHIATTO.BackColor = Color.White;
                        cara = 0;
                        CARAMELMACHIATTO.Enabled = true;

                        TARO.BackColor = Color.White;
                        taro = 0;
                        TARO.Enabled = true;

                        UNICORNFRAPPE.BackColor = Color.White;
                        uni = 0;
                        UNICORNFRAPPE.Enabled = true;


                        KITKATOVERLOAD.BackColor = Color.White;
                        kit = 0;
                        KITKATOVERLOAD.Enabled = true;

                        STRAWBERRY.BackColor = Color.White;
                        straw = 0;
                        STRAWBERRY.Enabled = true;

                        WHITECHRISTMAS.BackColor = Color.White;
                        white = 0;
                        WHITECHRISTMAS.Enabled = true;



                    }
                    if (LARGESIZE.Checked)
                    {

                        TOTAL = TOTAL + PRICE22OZ;
                        PREPTIME = PREPTIME + FRAPPEPREPTIME;

                        if (Clicked2.Equals(true))
                        {
                            add1 = FRAPPEFLAVOR + PRICE22OZ;
                            cart.receiveData(add1);


                        }
                        else if (Clicked3.Equals(true))
                        {
                            addtaro2 = TAROFLAVOR + PRICE22OZ;
                            cart.receiveData(addtaro2);


                        }
                        else if (Clicked4.Equals(true))
                        {
                            addunicorn2 = UNICORNFLAVOR + PRICE22OZ;
                            cart.receiveData(addunicorn2);


                        }
                        else if (Clicked5.Equals(true))
                        {
                            addkitkat2 = KITKATFLAVOR + PRICE22OZ;
                            cart.receiveData(addkitkat2);

                        }
                        else if (Clicked6.Equals(true))
                        {
                            addstrawberry2 = STRAWBERRYFLAVOR + PRICE22OZ;
                            cart.receiveData(addstrawberry2);


                        }
                        else if (Clicked7.Equals(true))
                        {
                            addwhitechristmas2 = WHITECHRISTMASFLAVOR + PRICE22OZ;
                            cart.receiveData(addwhitechristmas2);


                        }
                        else { }



                        LARGESIZE.Checked = false;
                        Clicked2 = false;
                        Clicked3 = false;
                        Clicked4 = false;
                        Clicked5 = false;
                        Clicked6 = false;
                        Clicked7 = false;
                        MessageBox.Show("Added to Cart", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        label1.Text = "";

                        CARAMELMACHIATTO.BackColor = Color.White;
                        cara = 0;
                        CARAMELMACHIATTO.Enabled = true;

                        TARO.BackColor = Color.White;
                        taro = 0;
                        TARO.Enabled = true;

                        UNICORNFRAPPE.BackColor = Color.White;
                        uni = 0;
                        UNICORNFRAPPE.Enabled = true;


                        KITKATOVERLOAD.BackColor = Color.White;
                        kit = 0;
                        KITKATOVERLOAD.Enabled = true;

                        STRAWBERRY.BackColor = Color.White;
                        straw = 0;
                        STRAWBERRY.Enabled = true;

                        WHITECHRISTMAS.BackColor = Color.White;
                        white = 0;
                        WHITECHRISTMAS.Enabled = true;

                    }

                    //  frappetotal = TOTAL;


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

        private void button2_Click_1(object sender, EventArgs e)
        {
            //ADD ITEM            
           flowLayoutPanel1.Controls.Add(AddnewITEM());
            
        }

        private void Cart_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart();
            cart.Show();
            this.Hide();
        }

        public System.Windows.Forms.Button AddnewITEM() { 
            System.Windows.Forms.Button button = new System.Windows.Forms.Button();
            this.Controls.Add(button);
            button.Size = new System.Drawing.Size(148, 84);
            button.Font = new Font("Segoe Print",  15.75F, FontStyle.Bold); 
            button.Text = textBox1.Text;
            return button;
        }
    }
}



