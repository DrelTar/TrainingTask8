using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    [Serializable]
    class Classifier
    {
        public Dictionary<string, Product> products;
        string name;

        public Classifier(string name)
        {
            this.name = name;
            products = new Dictionary<string, Product>();
        }
    }
}
