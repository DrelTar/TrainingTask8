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
    public partial class UserForm : Form
    {

        /// <summary>
        /// Users list.
        /// </summary>
        List<User> users;

        /// <summary>
        /// Initialize form with users list.
        /// </summary>
        /// <param name="users"> Users list from main form.</param>
        public UserForm(List<User> users)
        {
            InitializeComponent();
            this.users = users;
        }

        /// <summary>
        /// Click to registrate new user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void registrationButton_Click(object sender, EventArgs e)
        {
            // Not working without it.
            registrationButton.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Click to authorize old user or admin.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void authorizationButton_Click(object sender, EventArgs e)
        {
            // Not working without it.
            authorizationButton.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Check if user can register or authorize.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            registrationButton.Enabled = passwordTextBox.Text != "" && adressTextBox.Text != "" && nameTextBox.Text != "" &&
                phoneTextBox.Text != "" && (from user in users
                                            where user.Email == emailTextBox.Text
                                            select user.Email).Count() == 0;
            authorizationButton.Enabled = passwordTextBox.Text != "" && (from user in users
                                                                         where user.Email == emailTextBox.Text
                                                                         select user.Email).Count() > 0;
        }

        /// <summary>
        /// Check if user can register or authorize.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void phoneTextBox_TextChanged(object sender, EventArgs e)
        {
            registrationButton.Enabled = passwordTextBox.Text != "" && adressTextBox.Text != "" && nameTextBox.Text != "" &&
                phoneTextBox.Text != "" && (from user in users
                                            where user.Email == emailTextBox.Text
                                            select user.Email).Count() == 0;
        }

        /// <summary>
        /// Check if user can register or authorize.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            registrationButton.Enabled = passwordTextBox.Text != "" && adressTextBox.Text != "" && nameTextBox.Text != "" &&
                phoneTextBox.Text != "" && (from user in users
                                            where user.Email == emailTextBox.Text
                                            select user.Email).Count() == 0;
        }

        /// <summary>
        /// Check if user can register or authorize.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void adressTextBox_TextChanged(object sender, EventArgs e)
        {
            registrationButton.Enabled = passwordTextBox.Text != "" && adressTextBox.Text != "" && nameTextBox.Text != "" &&
                phoneTextBox.Text != "" && (from user in users
                                            where user.Email == emailTextBox.Text
                                            select user.Email).Count() == 0;
        }

        /// <summary>
        /// Check if user can register or authorize.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            registrationButton.Enabled = passwordTextBox.Text != "" && adressTextBox.Text != "" && nameTextBox.Text != "" &&
                phoneTextBox.Text != "" && (from user in users
                                            where user.Email == emailTextBox.Text
                                            select user.Email).Count() == 0;
            authorizationButton.Enabled = passwordTextBox.Text != "" && (from user in users
                                                                         where user.Email == emailTextBox.Text
                                                                         select user.Email).Count() > 0;
        }
    }
}
