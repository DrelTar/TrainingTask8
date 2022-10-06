using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{

    public enum State
    {
        NotStarted = 0,
        Processed,
        Paid,
        Shipped,
        Executed
    }

    [Serializable]
    public class Order
    {
        public List<Product> Products { get; set; }
        public int Number { get; set; }
        public Dictionary<Product, int> Amount { get; set; }
        DateTime Time { get; set; }
        public User User { get; set; }
        public State State { get; set; }
        public int Price
        {
            get
            {
                int price = 0;
                foreach (Product product in Amount.Keys)
                {
                    price += (int)product.Price * Amount[product];
                }
                return price;
            }
        }

        public Order (User user)
        {
            Products = new List<Product>();
            Amount = new Dictionary<Product, int>();
            Time = DateTime.Now;
            User = user;
            State = State.NotStarted;
            Number = -2;
        }
    }
}
