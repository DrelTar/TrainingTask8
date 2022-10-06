using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    [Serializable]
    public class Product
    {
        static int lastCode = 0;
        public string Name { get; set; }
        public string Code { get; set; }
        public string OtherData { get; set; }
        public uint Amount { get; set; }
        public uint Price { get; set; }

        public Product(string name)
        {
            Name = name;
            Code = lastCode.ToString();
            ++lastCode;
            OtherData = "";
            Amount = 0;
            Price = 1;
        }

        public Product(string name, string code, string otherData, uint amount, uint price)
        {
            Name = name;
            Code = code;
            OtherData = otherData;
            Amount = amount;
            Price = price;
        }


    }
}
