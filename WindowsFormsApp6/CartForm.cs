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
    public partial class CartForm : Form
    {

        /// <summary>
        /// User whom cart is open.
        /// </summary>
        User user;

        /// <summary>
        /// Orders of all users.
        /// </summary>
        List<Order> orders;

        /// <summary>
        /// Initialize user and orders.
        /// </summary>
        /// <param name="user"> Current user from main form. </param>
        /// <param name="orders"> Orders of all users from main form. </param>
        public CartForm(User user, List<Order> orders)
        {
            InitializeComponent();
            this.user = user;
            this.orders = orders; 
        }

        /// <summary>
        /// Show orders of current user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CartForm_Load(object sender, EventArgs e)
        {
            DataTable orderTable = new DataTable();
            orderTable.Columns.Add(new DataColumn("Number"));
            orderTable.Columns.Add(new DataColumn("Price"));
            orderTable.Columns.Add(new DataColumn("State"));
            foreach (Order order in (from order in orders 
                                     where order.User.Email == user.Email && order.Number != -2 
                                     select order).ToArray())
            {
                DataRow productRow = orderTable.NewRow();
                productRow[0] = order.Number;
                productRow[1] = order.Price;
                productRow[2] = order.State;
                orderTable.Rows.Add(productRow);
            }
            orderView.DataSource = orderTable;
        }

        /// <summary>
        /// Chnage visual state.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void payMenuItem_Click(object sender, EventArgs e)
        {
            orderView.SelectedRows[0].Cells[2].Value = State.Paid;
        }

        /// <summary>
        /// Show right cick menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void orderView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && orderView.SelectedRows.Count > 0)
            {
                rightClickOrderViewMenu.Show(this, new Point(e.X, e.Y));
                payMenuItem.Enabled = orderView.SelectedRows[0].Cells[2].Value.ToString() == "Processed";
            }
        }
    }
}
