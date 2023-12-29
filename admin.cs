using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using Newtonsoft.Json;
using FireSharp;

namespace kiosk
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }
        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "Ql07FR3YmFXtH5Yq9SemfO43ZyQgdiEB7pJeNCHz",
            BasePath = "https://systemdatabase-29086-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;

        private void button1_Click_1(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            //this.Hide();
        }

        private void admin_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FirebaseClient(fcon);
            }
            catch
            {
                MessageBox.Show("There was a problem in your internet");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            MessageBox.Show("COMING SOON");

        }
        void PopulateData(Dictionary<string, Class2> record)
        {
            try
            {

                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();


                dataGridView1.Columns.Add("Order ID", "Order ID");
                dataGridView1.Columns.Add("Date", "Date");
                dataGridView1.Columns.Add("CustomerName", "CustomerName");
                dataGridView1.Columns.Add("Data", "Orders");
                dataGridView1.Columns.Add("Total", "Total");


                foreach (var item in record)
                {
                    dataGridView1.Rows.Add(item.Key, item.Value.Date, item.Value.CustomerName, item.Value.Data, item.Value.Total);

                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //may checkbox tayong column pwedeng pagclick ng checkbox auto delete ng sa datagridview para ibigsabihin order ready na or pwede ring click ng checkbox then another button for action. di ko kasi macode yung sa status na checkbox, if pre design kasi sa properties gagawin ko pag nagrefresh button ako nawawala  tapos pag hard coded naman di ko mapagana yung checkbox at di ko matawag para magawan function

            //note dapat pag nagcheck na ng status sa datagrid view lang mawawla hindi sa firebase kasi need parin yung data para sa sales
            MessageBox.Show("COMING SOON");
        }

        private void button4_Click(object sender, EventArgs e)
        {

            FirebaseResponse res = client.Get("Customer Information");
            Dictionary<string, Class2> data = JsonConvert.DeserializeObject<Dictionary<string, Class2>>(res.Body.ToString());
            PopulateDatas(data);






        }
        void PopulateDatas(Dictionary<string, Class2> record)
        {
            /* try
             {*/

            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();


            dataGridView1.Columns.Add("Order ID", "Order ID");
            dataGridView1.Columns.Add("Date", "Date");
            dataGridView1.Columns.Add("CustomerName", "CustomerName");
            dataGridView1.Columns.Add("Data", "Orders");
            dataGridView1.Columns.Add("Total", "Total");

            int newtotal = 0;


            foreach (var item in record)
            {
                dataGridView1.Rows.Add(item.Key, item.Value.Date, item.Value.CustomerName, item.Value.Data, item.Value.Total);
                int sub = Convert.ToInt32(item.Value.Total.Substring(1));
                newtotal += sub;


            }
            label1.Text = "Total: " + newtotal;
            // MessageBox.Show(newtotal+"");


            //    }
            /* catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }*/
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                FirebaseResponse res = client.Get("Customer Information");
                Dictionary<string, Class2> data = JsonConvert.DeserializeObject<Dictionary<string, Class2>>(res.Body.ToString());
                DateTime time = DateTime.Now;


                var date = time.ToShortDateString();
                int variable = 0;

                foreach (var item in data)
                {
                    if (date == item.Value.Date)
                    {
                        int sub = Convert.ToInt32(item.Value.Total.Substring(1));
                        variable += sub;

                    }



                }
                string datenow = date.ToString();
                var insert = new firebase_insert()
                {
                    daily_total = variable,
                };
                FirebaseResponse inserdaily = client.Set("Week1/" + datenow, insert);



            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            string day, month, year;
            day = textBox1.Text + "/";
            month = textBox2.Text + "/";
            year = textBox3.Text + "/";
            string date = textBox1.Text + "/" + textBox2.Text + "/" + textBox3.Text;
            FirebaseResponse res1 = client.Get("Customer Information");
            Dictionary<string, Class2> data = JsonConvert.DeserializeObject<Dictionary<string, Class2>>(res1.Body.ToString());
            PopulateData1(data, date);




            FirebaseResponse res = client.Get(day + month + year);
            firebase_insert total = res.ResultAs<firebase_insert>();
            if (total == null)
            {
                MessageBox.Show("di gumagawna");
            }
            else
            {

            }
        }
        void PopulateData1(Dictionary<string, Class2> record, string date)
        {
            /* try
             {*/

            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();


            dataGridView1.Columns.Add("Order ID", "Order ID");
            dataGridView1.Columns.Add("Date", "Date");
            dataGridView1.Columns.Add("CustomerName", "CustomerName");
            dataGridView1.Columns.Add("Data", "Orders");
            dataGridView1.Columns.Add("Total", "Total");

            int newtotal = 0;


            foreach (var item in record)
            {

                if (date.Equals(item.Value.Date))
                {

                    dataGridView1.Rows.Add(item.Key, item.Value.Date, item.Value.CustomerName, item.Value.Data, item.Value.Total);
                    int sub = Convert.ToInt32(item.Value.Total.Substring(1));
                    newtotal += sub;
                }

            }
            label1.Text = "Total: " + newtotal;
            // MessageBox.Show(newtotal+"");


            //    }
            /* catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }*/
        }
    }

    
}
