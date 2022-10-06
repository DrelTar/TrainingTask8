using System;
using System.Collections.Generic; 
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

// As I think work everything from 1 to 9. No extra functions.

namespace WindowsFormsApp6
{
    public partial class StorageForm : Form
    {

        /// <summary>
        /// Current product form.
        /// </summary>
        ProductForm productForm;

        /// <summary>
        /// User register/authorize form.
        /// </summary>
        UserForm userForm;

        /// <summary>
        /// Cart of current user form.
        /// </summary>
        CartForm cartForm;

        /// <summary>
        /// Admin form.
        /// </summary>
        AdminForm adminForm;

        /// <summary>
        /// List of all users.
        /// </summary>
        List<User> users;

        /// <summary>
        /// Current user.
        /// </summary>
        User currentUser;

        /// <summary>
        /// List of all orders.
        /// </summary>
        List<Order> orders;

        /// <summary>
        /// Dictionary which store all classifiers.
        /// </summary>
        Dictionary<string, Classifier> nameToClassifier;

        /// <summary>
        /// Initialize form and some ataring values.
        /// </summary>
        public StorageForm()
        {
            InitializeComponent();
            treeView.Nodes.Add(new TreeNode("Products"));
            nameToClassifier = new Dictionary<string, Classifier>();
            nameToClassifier.Add("Products", new Classifier("Products"));
            ImageList imageList = new ImageList();
            imageList.Images.Add(Image.FromFile("folderIcon.jpg"));
            imageList.Images.Add(Image.FromFile("productIcon.png"));
            treeView.ImageList = imageList;
            users = new List<User>();
            users.Add(new User("Admin", "+7 123 456-78-90", "hse", "admin@admin.admin", "1234"));
            orders = new List<Order>();
            DataLoad();
        }

        /// <summary>
        /// Add new classfier to selected classifier.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addClassifierButton_Click(object sender, EventArgs e)
        {
            treeView.SelectedNode.Nodes.Add(new TreeNode(addClassifierTextBox.Text));
            nameToClassifier.Add(addClassifierTextBox.Text, new Classifier(addClassifierTextBox.Text));
            Check();
        }

        /// <summary>
        /// Change name of selected classifier.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void changeClassifierButton_Click(object sender, EventArgs e)
        {
            Classifier tmpClassifier = nameToClassifier[treeView.SelectedNode.Text];
            nameToClassifier.Remove(treeView.SelectedNode.Text);
            nameToClassifier.Add(changeClassifierTextBox.Text, tmpClassifier);
            treeView.SelectedNode.Text = changeClassifierTextBox.Text;
            Check();
        }

        /// <summary>
        /// Delete selected classifier.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteClassifierMenuItem_Click(object sender, EventArgs e)
        {
            nameToClassifier.Remove(treeView.SelectedNode.Text);
            treeView.SelectedNode.Remove();
            Check();
        }

        /// <summary>
        /// Add product to selected classifier.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addProductButton_Click(object sender, EventArgs e)
        {
            treeView.SelectedNode.Nodes.Add(new TreeNode(addProductTextBox.Text));
            treeView.SelectedNode.Nodes[treeView.SelectedNode.Nodes.Count - 1].ImageIndex = 1;
            treeView.SelectedNode.Nodes[treeView.SelectedNode.Nodes.Count - 1].SelectedImageIndex = 1;
            nameToClassifier[treeView.SelectedNode.Text].products.Add(addProductTextBox.Text, new Product(addProductTextBox.Text));
            Check();
        }

        /// <summary>
        /// Open product form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            // Checking if node is product.
            if (e.Node.ImageIndex == 1)
            {
                if (productForm != null) {
                    productForm.Close();
                }
                Product product = nameToClassifier[e.Node.Parent.Text].products[e.Node.Text];
                productForm = new ProductForm(product.Name, product.Code, product.Amount, product.Price, product.OtherData, e.Node.Parent.Text,
                    product, e.Node, nameToClassifier[e.Node.Parent.Text].products);
                productForm.okButton.Click += new EventHandler(ProductFormOK);
                productForm.deleteButton.Click += new EventHandler(ProductFormDelete);
                productForm.Show();
            }
        }

        /// <summary>
        /// Open rightclick menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                rightClickTreeViewMenu.Show(this, new Point(e.X, e.Y));
            }
        }

        /// <summary>
        /// Check if new classifier name is cool.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addClassifierTextBox_TextChanged(object sender, EventArgs e)
        {
            addClassifierButton.Enabled = addClassifierTextBox.Text != "" && treeView.SelectedNode.ImageIndex != 1 &&
                                          !nameToClassifier.ContainsKey(addClassifierTextBox.Text);
        }

        /// <summary>
        /// Check if new product name is cool.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addProductTextBox_TextChanged(object sender, EventArgs e)
        { 
            addProductButton.Enabled = addProductTextBox.Text != "" && treeView.SelectedNode.ImageIndex != 1 &&
                !nameToClassifier[treeView.SelectedNode.Text].products.ContainsKey(addProductTextBox.Text);
        }

        /// <summary>
        /// Check if classifier new name is cool.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void changeClassifierTextBox_TextChanged(object sender, EventArgs e)
        {
            changeClassifierButton.Enabled = changeClassifierTextBox.Text != "" && treeView.SelectedNode.ImageIndex != 1 &&
                                             !nameToClassifier.ContainsKey(changeClassifierTextBox.Text);
        }

        /// <summary>
        /// Check if classifer can be deleted.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            deleteClassifierMenuItem.Enabled = treeView.SelectedNode.Nodes.Count == 0 && treeView.SelectedNode.ImageIndex != 1 &&
                                                treeView.SelectedNode != treeView.TopNode;
            if (treeView.SelectedNode.ImageIndex != 1)
            {
                ProductTable();
            }
        }

        /// <summary>
        /// Calculate and display product table.
        /// </summary>
        private void ProductTable()
        {
            DataTable productTable = new DataTable();
            productTable.Columns.Add(new DataColumn("Name"));
            productTable.Columns.Add(new DataColumn("Code"));
            productTable.Columns.Add(new DataColumn("Amount"));
            productTable.Columns.Add(new DataColumn("Price"));
            foreach (Product product in nameToClassifier[treeView.SelectedNode.Text].products.Values)
            {
                DataRow productRow = productTable.NewRow();
                productRow[0] = product.Name;
                productRow[1] = product.Code;
                productRow[2] = product.Amount;
                productRow[3] = product.Price;
                productTable.Rows.Add(productRow);
            }
            productView.DataSource = productTable;
        }

        /// <summary>
        /// Check if everything is okay for button enabling.
        /// </summary>
        private void Check()
        {
            addClassifierButton.Enabled = addClassifierTextBox.Text != "" && treeView.SelectedNode.ImageIndex != 1 &&
                                          !nameToClassifier.ContainsKey(addClassifierTextBox.Text);
            addProductButton.Enabled = addProductTextBox.Text != "" && treeView.SelectedNode.ImageIndex != 1 &&
               !nameToClassifier[treeView.SelectedNode.Text].products.ContainsKey(addProductTextBox.Text);
            changeClassifierButton.Enabled = changeClassifierTextBox.Text != "" && treeView.SelectedNode.ImageIndex != 1 &&
                                             !nameToClassifier.ContainsKey(changeClassifierTextBox.Text);
            deleteClassifierMenuItem.Enabled = treeView.SelectedNode.Nodes.Count == 0 && treeView.SelectedNode.ImageIndex != 1 && 
                                                treeView.SelectedNode != treeView.TopNode;
            addMenuItem.Enabled = int.TryParse(amountTextBox.Text, out int tmp) && currentUser != null;
            if (treeView.SelectedNode.ImageIndex != 1)
            {
                ProductTable();
            }
            Save();
        }

        /// <summary>
        /// Get data from product form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductFormOK(object sender, EventArgs e)
        {
            Product product = productForm.product;
            nameToClassifier[productForm.parent].products.Remove(product.Name);
            product.Name = productForm.nameTextBox.Text;
            product.Code = productForm.codeTextBox.Text;
            product.Amount = uint.Parse(productForm.amountTextBox.Text);
            product.Price = uint.Parse(productForm.priceTextBox.Text);
            product.OtherData = productForm.otherDataTextBox.Text;
            nameToClassifier[productForm.parent].products.Add(product.Name, product);
            productForm.node.Text = product.Name;
            Check();
        }

        /// <summary>
        /// Delete selected product.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductFormDelete(object sender, EventArgs e)
        {
            Product product = productForm.product;
            nameToClassifier[productForm.parent].products.Remove(product.Name);
            productForm.node.Parent.Nodes.Remove(productForm.node);
            Check();
            productForm.Close();
        }

        /// <summary>
        /// Save all useful data.
        /// </summary>
        private void Save()
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("products.dat", FileMode.OpenOrCreate))
            {
                binaryFormatter.Serialize(fs, nameToClassifier[treeView.SelectedNode.Text].products);
            }
            using (FileStream fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                binaryFormatter.Serialize(fs, users);
            }
            using (FileStream fs = new FileStream("orders.dat", FileMode.OpenOrCreate))
            {
                binaryFormatter.Serialize(fs, orders);
            }
        }

        /// <summary>
        /// Load all useful data back.
        /// </summary>
        private void DataLoad()
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("products.dat", FileMode.OpenOrCreate))
            {
                nameToClassifier["Products"].products = (Dictionary<string, Product>)binaryFormatter.Deserialize(fs);
            }
            using (FileStream fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                users = (List<User>)binaryFormatter.Deserialize(fs);
            }
            using (FileStream fs = new FileStream("orders.dat", FileMode.OpenOrCreate))
            {
                orders = (List<Order>)binaryFormatter.Deserialize(fs);
            }
        }

        /// <summary>
        /// Show user registration/authorization form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void userButton_Click(object sender, EventArgs e)
        {
            if (userForm != null)
            {
                userForm.Close();
            }
            userForm = new UserForm(users);
            userForm.registrationButton.Click += new EventHandler(userFormRegistration);
            userForm.authorizationButton.Click += new EventHandler(userFormAuthorization);
            userForm.Show();
        }

        /// <summary>
        /// Registrate user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void userFormRegistration(object sender, EventArgs e)
        {
            users.Add(new User(userForm.nameTextBox.Text, userForm.phoneTextBox.Text,
                userForm.adressTextBox.Text, userForm.emailTextBox.Text, userForm.passwordTextBox.Text));
            currentUser = users.Last();
            Authorized();
        }

        /// <summary>
        /// Authorize user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void userFormAuthorization(object sender, EventArgs e)
        {
            var authorizedUser = (from user in users
                                  where user.Email == userForm.emailTextBox.Text
                                  where user.Password == userForm.passwordTextBox.Text
                                  select user);
            if (authorizedUser.Count() > 0)
            {
                currentUser = authorizedUser.ToArray()[0];
                Authorized();
            }
        }

        /// <summary>
        /// After registered/authorized.
        /// </summary>
        private void Authorized()
        {
            nameLabel.Text = currentUser.Name;
            userForm.Close();
            if (orders.Count > 0)
            {
                orders.Remove(orders.Last());
            }
            orders.Add(new Order(currentUser));
            if (currentUser.Email == "admin@admin.admin")
            {
                adminButton.Enabled = true;
                adminButton.Visible = true; 
                cartButton.Enabled = false;
                cartButton.Visible = false;
            }
            else
            {
                adminButton.Enabled = false;
                adminButton.Visible = false;
                cartButton.Enabled = true;
                cartButton.Visible = true;
            }
            Save();
        }

        /// <summary>
        /// Right click productview menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void productView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                addMenuItem.Enabled = int.TryParse(amountTextBox.Text, out int tmp) && currentUser != null;
                rightClickProductsViewMenu.Show(this, new Point(e.X, e.Y));
            }
        }

        /// <summary>
        /// Add new product to order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addMenuItem_Click(object sender, EventArgs e)
        {
            if (currentUser != null && productView.SelectedRows.Count > 0) {
                foreach (DataGridViewRow row in productView.SelectedRows) {
                    Product product = nameToClassifier["Products"].products[row.Cells[0].Value.ToString()];
                    if (!orders.Last().Amount.ContainsKey(product)) {
                        orders.Last().Products.Add(product);
                        orders.Last().Amount.Add(product, int.Parse(amountTextBox.Text));
                    }
                    else
                    {
                        orders.Last().Amount[product] += int.Parse(amountTextBox.Text);
                    }
                }
                closeOrderMenuItem.Enabled = true;
            }
            Save();
        }

        /// <summary>
        /// User close order and give it number.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeOrderMenuItem_Click(object sender, EventArgs e)
        {
            orders[orders.Count() - 1].Number = orders.Count();
            orders.Add(new Order(currentUser));
            Save();
        }

        /// <summary>
        /// Check if amount of product is ok.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void amountTextBox_TextChanged(object sender, EventArgs e)
        {
            addMenuItem.Enabled = int.TryParse(amountTextBox.Text, out int tmp) && currentUser != null;
        }

        /// <summary>
        /// Show cart form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cartButton_Click(object sender, EventArgs e)
        {
            if (cartForm != null)
            {
                cartForm.Close();
            }
            cartForm = new CartForm(currentUser, orders);
            cartForm.payMenuItem.Click += new EventHandler(PayButton);
            cartForm.Show();
        }

        /// <summary>
        /// Really change state of order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PayButton(object sender, EventArgs e) 
        {
            if (cartForm.orderView.SelectedRows.Count > 0)
            {
                Order tmpOrder = (from order in orders
                                  where order.Number.ToString() == cartForm.orderView.SelectedRows[0].Cells[0].Value.ToString()
                                  select order).ToArray()[0];
                tmpOrder.State = State.Paid;
                tmpOrder.User.PaidMoney += tmpOrder.Price;
            }
            Save();
        }

        /// <summary>
        /// Show admin form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void adminButton_Click(object sender, EventArgs e)
        {
            if (adminForm != null)
            {
                adminForm.Close();
            }
            adminForm = new AdminForm(users, orders);
            adminForm.processedMenuItem.Click += new EventHandler(ProcessedButton);
            adminForm.shippedMenuItem.Click += new EventHandler(ShippedButton);
            adminForm.executedMenuItem.Click += new EventHandler(ExecutedButton);
            adminForm.Show();
        }

        /// <summary>
        /// Really change state of order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProcessedButton(object sender, EventArgs e)
        {
            if (adminForm.userOrderView.SelectedRows.Count > 0)
            {
                (from order in orders
                 where order.Number.ToString() == adminForm.userOrderView.SelectedRows[0].Cells[0].Value.ToString()
                 select order).ToArray()[0].State = State.Processed;
            }
            Save();
        }

        /// <summary>
        /// Really change state of order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShippedButton(object sender, EventArgs e)
        {
            if (adminForm.userOrderView.SelectedRows.Count > 0)
            {
                (from order in orders
                 where order.Number.ToString() == adminForm.userOrderView.SelectedRows[0].Cells[0].Value.ToString()
                 select order).ToArray()[0].State = State.Shipped;
            }
            Save();
        }

        /// <summary>
        /// Really change state of order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExecutedButton(object sender, EventArgs e)
        {
            if (adminForm.userOrderView.SelectedRows.Count > 0)
            {
                (from order in orders
                 where order.Number.ToString() == adminForm.userOrderView.SelectedRows[0].Cells[0].Value.ToString()
                 select order).ToArray()[0].State = State.Executed;
            }
            Save();
        }
    }
}
