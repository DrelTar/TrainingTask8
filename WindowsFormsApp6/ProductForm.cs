using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{

    public partial class ProductForm : Form
    {
        /// <summary>
        /// Values passed from StorageForm through ProductForm again to StorageForm.
        /// </summary>
        public string parent;
        public Product product;
        public TreeNode node;
        Dictionary<string, Product> parentProducts;
        public ProductForm(string name, string code, uint amount, uint price, string otherData, string parent, Product product, 
            TreeNode node, Dictionary<string, Product> parentProducts)
        {
            InitializeComponent();
            nameTextBox.Text = name;
            codeTextBox.Text = code;
            amountTextBox.Text = amount.ToString();
            priceTextBox.Text = price.ToString();
            otherDataTextBox.Text = otherData;
            this.product = product;
            this.parent = parent;
            this.node = node;
            this.parentProducts = parentProducts;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            // Not working without it.
            okButton.DialogResult = DialogResult.OK;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            deleteButton.DialogResult = DialogResult.OK;
        }

        // Checking if OK button can be pressed.
        private void amountTextBox_TextChanged(object sender, EventArgs e)
        {
            okButton.Enabled = uint.TryParse(amountTextBox.Text, out uint tmp);
        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {
            okButton.Enabled = uint.TryParse(priceTextBox.Text, out uint tmp);
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            okButton.Enabled = nameTextBox.Text != "" && parentProducts != null && !parentProducts.ContainsKey(nameTextBox.Text);
        }

        private void codeTextBox_TextChanged(object sender, EventArgs e)
        {
            okButton.Enabled = codeTextBox.Text != "";
        }
    }
}
