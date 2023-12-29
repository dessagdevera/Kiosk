using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiosk
{

    internal class Class2
    {
        public static List<String> frmcart = new List<String>();
        public static List<String> nickname = new List<String>();
        public static List<int> TOTALRECEIPT = new List<int>();
      //  public static List<string> MODEOFPAYMENT = new List<string>();

        public void ClearData()
        {
            Class2.frmcart.Clear();
        }

        public string Date { get; set; }
        public string Data { get; set; }

        public string CustomerName { get; set; }
        public string Total { get; set; }
      
    }
}
