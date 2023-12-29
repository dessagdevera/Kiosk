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

    public partial class Cart : Form
    {

        public string nickname, receiptpass;
       public int updatedtotalcart = 0;
        public Button buttondelete;
        public int updatedpreptime = 0;
        public int FINALPREPTIME;
        public int totalcart = 0;
        public static BindingSource newItembindingSource = new BindingSource();
        public List<string> FrappeList = new List<string>();
      
        public Cart()
        {
            InitializeComponent();
            buttondelete = button2;
        }

        private void Cart_Load(object sender, EventArgs e)
        {

            //insert to listbox
            newItembindingSource.DataSource = Class1.newItem;

            listBox1.DataSource = newItembindingSource;
            Calculatetotal();


        }
        private void resetTotal()
        {
            totalcart = 0;
            FINALPREPTIME = 0;
        }

        public void itemload()
        {
            resetTotal();
            
            try
            {
                int del = listBox1.SelectedIndex;

                DialogResult ask = MessageBox.Show("Are you sure you want to delete this item?" + "\n" + "\n" + Class1.newItem[del], "CONFIRM DELETE", MessageBoxButtons.YesNo);
              
                if (ask == DialogResult.Yes)
                {

                   

                    if (listBox1.SelectedItems.Contains(Frappe.add) || listBox1.SelectedItems.Contains(Frappe.addtaro) || listBox1.SelectedItems.Contains(Frappe.addunicorn) || listBox1.SelectedItems.Contains(Frappe.addkitkat)
                        || listBox1.SelectedItems.Contains(Frappe.addstrawberry) || listBox1.SelectedItems.Contains(Frappe.addwhitechristmas))
                    {

                        Frappe.TOTAL -= Frappe.PRICE16OZ;
                        totalcart = Frappe.TOTAL + Lemon.TOTAL + Coffee.TOTAL + Fruit.TOTAL + Milk_Tea.TOTAL; //ddd
                        totallbl.Text = Convert.ToString(totalcart);

                        Frappe.PREPTIME -= Frappe.FRAPPEPREPTIME;
                        FINALPREPTIME = Frappe.PREPTIME + Fruit.PREPTIME + Lemon.PREPTIME + Milk_Tea.PREPTIME + Coffee.PREPTIME;
                        label5.Text = Convert.ToString(FINALPREPTIME) + "mins";

                    }
                    else if (listBox1.SelectedItems.Contains(Frappe.add1) || listBox1.SelectedItems.Contains(Frappe.addtaro2) || listBox1.SelectedItems.Contains(Frappe.addunicorn2) || listBox1.SelectedItems.Contains(Frappe.addkitkat2)
                                || listBox1.SelectedItems.Contains(Frappe.addstrawberry2) || listBox1.SelectedItems.Contains(Frappe.addwhitechristmas2))
                    {
                        Frappe.TOTAL -= Frappe.PRICE22OZ;
                        totalcart = totalcart = Frappe.TOTAL + Lemon.TOTAL + Coffee.TOTAL + Fruit.TOTAL + Milk_Tea.TOTAL;
                        totallbl.Text = Convert.ToString(totalcart);

                        Frappe.PREPTIME -= Frappe.FRAPPEPREPTIME;
                        FINALPREPTIME = Frappe.PREPTIME + Fruit.PREPTIME + Lemon.PREPTIME + Milk_Tea.PREPTIME + Coffee.PREPTIME;
                        label5.Text = Convert.ToString(FINALPREPTIME) + "mins";

                       
                    }
                    else if (listBox1.SelectedItems.Contains(Coffee.addAMERICANOCOFFEE) || listBox1.SelectedItems.Contains(Coffee.addCAPPUCINOCOFFEE) || listBox1.SelectedItems.Contains(Coffee.addHAZELNUTLATTECOFFEE) || listBox1.SelectedItems.Contains(Coffee.addSALTEDCARAMELCOFFEE)
                            || listBox1.SelectedItems.Contains(Coffee.addSPANISHLATTECOFFEE) || listBox1.SelectedItems.Contains(Coffee.addVANILLALATTECOFFEE))

                    {
                        Coffee.TOTAL -= Coffee.PRICE16OZ;
                        totalcart = totalcart = Frappe.TOTAL + Lemon.TOTAL + Coffee.TOTAL + Fruit.TOTAL + Milk_Tea.TOTAL;//ddd
                        totallbl.Text = Convert.ToString(totalcart);

                        Coffee.PREPTIME -= Coffee.CoffeePREPTIME;
                        FINALPREPTIME += Frappe.PREPTIME + Fruit.FruitPREPTIME + Lemon.LemonPREPTIME + Milk_Tea.MilkteaPREPTIME + Coffee.PREPTIME;
                        label5.Text = Convert.ToString(FINALPREPTIME) + "mins";

                  
                    }
                    else if (listBox1.SelectedItems.Contains(Coffee.addAMERICANOCOFFEE2) || listBox1.SelectedItems.Contains(Coffee.addCAPPUCINOCOFFEE2) || listBox1.SelectedItems.Contains(Coffee.addHAZELNUTLATTECOFFEE2) || listBox1.SelectedItems.Contains(Coffee.addSALTEDCARAMELCOFFEE2)
                            || listBox1.SelectedItems.Contains(Coffee.addSPANISHLATTECOFFEE2) || listBox1.SelectedItems.Contains(Coffee.addVANILLALATTECOFFEE2))
                    {
                        Coffee.TOTAL -= Coffee.PRICE22OZ;
                        totalcart = Frappe.TOTAL + Lemon.TOTAL + Coffee.TOTAL + Fruit.TOTAL + Milk_Tea.TOTAL;//ddd
                        totallbl.Text = Convert.ToString(totalcart);


                        Coffee.PREPTIME -= Coffee.CoffeePREPTIME;
                        FINALPREPTIME = Frappe.PREPTIME + Fruit.PREPTIME + Lemon.PREPTIME + Milk_Tea.PREPTIME + Coffee.PREPTIME;
                        label5.Text = Convert.ToString(FINALPREPTIME) + "mins";
                   
                    }
                    else if (listBox1.SelectedItems.Contains(Fruit.addBLUEBERRYTEAFRUITFLAVOR) || listBox1.SelectedItems.Contains(Fruit.addBLUEBUTTERFLYFRUITFLAVOR) || listBox1.SelectedItems.Contains(Fruit.addBLUEBERRYLEMONFRUITFLAVOR)
                        || listBox1.SelectedItems.Contains(Fruit.addKIWILEMONFRUITFLAVOR))
                    {
                        Fruit.TOTAL -= Fruit.PRICE16OZ;
                        totalcart = Frappe.TOTAL + Lemon.TOTAL + Coffee.TOTAL + Fruit.TOTAL + Milk_Tea.TOTAL;//ddd
                        totallbl.Text = Convert.ToString(totalcart);

                        Fruit.PREPTIME -= Fruit.FruitPREPTIME;
                        FINALPREPTIME = Frappe.PREPTIME + Fruit.PREPTIME + Lemon.PREPTIME + Milk_Tea.PREPTIME + Coffee.PREPTIME;
                        label5.Text = Convert.ToString(FINALPREPTIME) + "mins";

                   
                    }
                    else if (listBox1.SelectedItems.Contains(Fruit.addBLUEBERRYTEAFRUITFLAVOR2) || listBox1.SelectedItems.Contains(Fruit.addBLUEBUTTERFLYFRUITFLAVOR2) || listBox1.SelectedItems.Contains(Fruit.addBLUEBERRYLEMONFRUITFLAVOR2)
                        || listBox1.SelectedItems.Contains(Fruit.addKIWILEMONFRUITFLAVOR2))
                    {
                        Fruit.TOTAL -= Fruit.PRICE22OZ;
                        totalcart = Frappe.TOTAL + Lemon.TOTAL + Coffee.TOTAL + Fruit.TOTAL + Milk_Tea.TOTAL; //ddd
                        totallbl.Text = Convert.ToString(totalcart);

                        Fruit.PREPTIME -= Fruit.FruitPREPTIME;
                        FINALPREPTIME = Frappe.PREPTIME + Fruit.PREPTIME + Lemon.PREPTIME + Milk_Tea.PREPTIME + Coffee.PREPTIME;
                        label5.Text = Convert.ToString(FINALPREPTIME) + "mins";
                      
                    }
                    else if (listBox1.SelectedItems.Contains(Lemon.addBLUEBERRYLEMONFLAVOR) || listBox1.SelectedItems.Contains(Lemon.addCLASSICLEMONFLAVOR) || listBox1.SelectedItems.Contains(Lemon.addCUCUMBERLEMONFLAVOR)
                        || listBox1.SelectedItems.Contains(Lemon.addGREENAPPLELEMONFLAVOR) || listBox1.SelectedItems.Contains(Lemon.addKIWILEMONFLAVOR) || listBox1.SelectedItems.Contains(Lemon.addLYCHEELEMONFLAVOR))
                    {
                        Lemon.TOTAL -= Lemon.PRICE16OZ;
                        totalcart = Frappe.TOTAL + Lemon.TOTAL + Coffee.TOTAL + Fruit.TOTAL + Milk_Tea.TOTAL;
                        totallbl.Text = Convert.ToString(totalcart);

                        Lemon.PREPTIME -= Lemon.LemonPREPTIME;
                        FINALPREPTIME = Frappe.PREPTIME + Fruit.PREPTIME + Lemon.PREPTIME + Milk_Tea.PREPTIME + Coffee.PREPTIME;
                        label5.Text = Convert.ToString(FINALPREPTIME) + "mins";

                    
                    }
                    else if (listBox1.SelectedItems.Contains(Milk_Tea.addHAZELNUTMILKTEAFLAVOR) || listBox1.SelectedItems.Contains(Milk_Tea.addMATCHAMILKTEAFLAVOR) || listBox1.SelectedItems.Contains(Milk_Tea.addNUTELLAMILKTEAFLAVOR) ||
                        listBox1.SelectedItems.Contains(Milk_Tea.addOKINAWAMILKTEAFLAVOR) || listBox1.SelectedItems.Contains(Milk_Tea.addREDVELVETMILKTEAFLAVOR) || listBox1.SelectedItems.Contains(Milk_Tea.addWHITEBUNNYMILKTEAFLAVOR))
                    {

                        Milk_Tea.TOTAL -= Milk_Tea.PRICE16OZ;
                        totalcart = Frappe.TOTAL + Lemon.TOTAL + Coffee.TOTAL + Fruit.TOTAL + Milk_Tea.TOTAL;
                        totallbl.Text = Convert.ToString(totalcart);

                        Milk_Tea.PREPTIME -= Milk_Tea.MilkteaPREPTIME;
                        FINALPREPTIME = Frappe.PREPTIME + Fruit.PREPTIME + Lemon.PREPTIME + Milk_Tea.PREPTIME + Coffee.PREPTIME;
                        label5.Text = Convert.ToString(FINALPREPTIME) + "mins";

                    }
                    else if (listBox1.SelectedItems.Contains(Milk_Tea.addHAZELNUTMILKTEAFLAVOR2) || listBox1.SelectedItems.Contains(Milk_Tea.addMATCHAMILKTEAFLAVOR2) || listBox1.SelectedItems.Contains(Milk_Tea.addNUTELLAMILKTEAFLAVOR2) ||
                        listBox1.SelectedItems.Contains(Milk_Tea.addOKINAWAMILKTEAFLAVOR2) || listBox1.SelectedItems.Contains(Milk_Tea.addREDVELVETMILKTEAFLAVOR2) || listBox1.SelectedItems.Contains(Milk_Tea.addWHITEBUNNYMILKTEAFLAVOR2))
                    {

                        Milk_Tea.TOTAL -= Milk_Tea.PRICE22OZ;
                        totalcart = Frappe.TOTAL + Lemon.TOTAL + Coffee.TOTAL + Fruit.TOTAL + Milk_Tea.TOTAL;
                        totallbl.Text = Convert.ToString(totalcart);


                        Milk_Tea.PREPTIME -= Milk_Tea.MilkteaPREPTIME;
                        FINALPREPTIME = Frappe.PREPTIME + Fruit.PREPTIME + Lemon.PREPTIME + Milk_Tea.PREPTIME + Coffee.PREPTIME;
                        label5.Text = Convert.ToString(FINALPREPTIME) + "mins";
                        //Class1.newItem.RemoveAt(del);
                        //newItembindingSource.ResetBindings(false);
                    }

                    else
                    {

                    }
                    Class1.newItem.RemoveAt(del);
                    newItembindingSource.ResetBindings(false);
                  
                    //if (listBox1.SelectedIndex == -1)
                    //{

                    //    Frappe.frappetotal = Frappe.TOTAL = 0;
                    //    Coffee.coffeetotal = Coffee.TOTAL = 0;
                    //    Fruit.fruittotal = Fruit.TOTAL = 0;
                    //    Lemon.lemontotal = Lemon.TOTAL = 0;
                    //    Fries.snackstotal = Fries.TOTAL = 0;
                    //    Milk_Tea.milkteatotal = Milk_Tea.TOTAL = 0;
                    //    updatedtotalcart = Frappe.TOTAL + Coffee.TOTAL + Fruit.TOTAL + Lemon.TOTAL + Milk_Tea.TOTAL + Fries.TOTAL;
                    //    totalcart = updatedtotalcart;
                    //    totallbl.Text = Convert.ToString(updatedtotalcart);
                    //    //baka need condition here

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Calculatetotal() 
        {
            totalcart = Frappe.TOTAL + Lemon.TOTAL + Coffee.TOTAL + Fruit.TOTAL + Milk_Tea.TOTAL;
            totallbl.Text = /*"₱ " +*/ Convert.ToString(totalcart);
            label4.Text = ("₱");

            FINALPREPTIME = Frappe.PREPTIME + Coffee.PREPTIME + Fruit.PREPTIME + Lemon.PREPTIME + Milk_Tea.PREPTIME;
            label5.Text = Convert.ToString(FINALPREPTIME) + "mins";
        }


        internal void receiveData(string addnewitem)
        {
            Class1.newItem.Add(addnewitem);
        }

        private void Cart_Activated(object sender, EventArgs e)
        {
            newItembindingSource.ResetBindings(false);  // refresh?
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {

                if (listBox1.Items.Count == 0)
                {
                    label1.Text = ("No order detected");
                }

                else
                {

                    for (int i = 0; i < listBox1.Items.Count; i++)  //get items from cart orders
                    {
                        Class2.frmcart.Add(listBox1.Items[i].ToString());
                    }

                    Payment payments = new Payment(); //payment form
                    payments.nick = (Class2.nickname[0]); // set nickname eq to txtb1
                    payments.total = Convert.ToInt32(totallbl.Text); // total
                    payments.orders = Convert.ToString(Class1.newItem); 
                    payments.Show();
                    this.Hide();

                }
             }
             catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            itemload();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    
    }
}
