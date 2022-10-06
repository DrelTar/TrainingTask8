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
    public partial class AdminForm : Form
    {
        /// <summary>
        /// All users.
        /// </summary>
        List<User> users;
        /// <summary>
        /// Orders of all users.
        /// </summary>
        List<Order> orders;
        /// <summary>
        /// Chosen user.
        /// </summary>
        User user;
        
        /// <summary>
        /// Initialize users and orders.
        /// </summary>
        /// <param name="users"> Users from main form. </param>
        /// <param name="orders"> Orders form main form. </param>
        public AdminForm(List<User> users, List<Order> orders)
        {
            InitializeComponent();
            this.users = users;
            this.orders = orders;
        }

        /// <summary>
        /// Fill listbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdminForm_Load(object sender, EventArgs e)
        {
            userList.Items.AddRange((from user in users select user.Email).ToArray());
            userList.Items.Add("all");
            userList.Items.Add("active");
            userList.SelectedIndex = userList.Items.Count - 1;
            UserOrderView();
        }

        /// <summary>
        /// Function for short linq. 
        /// </summary>
        /// <param name="index"> Index of selected listbox item. </param>
        /// <param name="order"> All orders. </param>
        /// <returns></returns>
        private bool OrderSorter(int index, Order order)
        {
            // All orders.
            if (userList.SelectedIndex == userList.Items.Count - 2)
            {
                return order.Number != -2;
            }
            // Active orders.
            else if (userList.SelectedIndex == userList.Items.Count - 1)
            {
                return order.State != State.Executed && order.Number != -2;
            }
            // Chosen user.
            else
            {
                return order.User.Email == user.Email && order.Number != -2;
            }
        }

        /// <summary>
        /// Create data table with orders.
        /// </summary>
        private void UserOrderView()
        {
            DataTable orderTable = new DataTable();
            orderTable.Columns.Add(new DataColumn("Number"));
            orderTable.Columns.Add(new DataColumn("Price"));
            orderTable.Columns.Add(new DataColumn("State"));
            foreach (Order order in (from order in orders
                                     where OrderSorter(userList.SelectedIndex, order)
                                     select order).ToArray())
            {
                DataRow productRow = orderTable.NewRow();
                productRow[0] = order.Number;
                productRow[1] = order.Price;
                productRow[2] = order.State;
                orderTable.Rows.Add(productRow);
            }
            userOrderView.DataSource = orderTable;
        }

        /// <summary>
        /// If listbox selected item changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void userList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                user = (from user in users where user.Email == userList.SelectedItem.ToString() select user).ToArray()[0];
            }
            catch { }
            UserOrderView();
        }

        /// <summary>
        /// Right click menu initializer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void userOrderView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && userOrderView.SelectedRows.Count > 0)
            {
                rightClickUserOrderViewMenu.Show(this, new Point(e.X, e.Y));
            }
        }

        /// <summary>
        /// Visualy change state.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void processedMenuItem_Click(object sender, EventArgs e)
        {
            userOrderView.SelectedRows[0].Cells[2].Value = State.Processed;
        }

        /// <summary>
        /// Visualy change state.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void shippedMenuItem_Click(object sender, EventArgs e)
        {
            userOrderView.SelectedRows[0].Cells[2].Value = State.Shipped;
        }

        /// <summary>
        /// Visualy change state.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void executedMenuItem_Click(object sender, EventArgs e)
        {
            userOrderView.SelectedRows[0].Cells[2].Value = State.Executed;
        }
    }
}
