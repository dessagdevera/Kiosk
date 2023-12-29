using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiosk
{
    internal class Class1
    {
        public static List<String> newItem = new List<String>();
        public static List<String> itemName = new List<String>();
        public static List<String> itemSize = new List<String>();
        public static List<String> itemprice = new List<String>();

        public void ClearData()
        {
            Class1.newItem.Clear();
        }

        public void ClearItem()
        {
            Class1.itemName.Clear();
        }
        public void ClearSize()
        {
            Class1.itemSize.Clear();
        }
        public void ClearPrice()
        {
            Class1.itemprice.Clear();
        }

    }
}
