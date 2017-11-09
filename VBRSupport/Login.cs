using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VBRSupport
{
    public partial class Login : Form
    {
        private Login()
        {
            InitializeComponent();
        }
        public bool IsLogin { get; set; }


        //FOR ENTER BUTTON
        private void form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1.PerformClick();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((!String.IsNullOrEmpty(txtUserName.Text)) && (!String.IsNullOrEmpty(txtPassWord.Text)))
            {
                string UserId = txtUserName.Text;
                string Password = txtPassWord.Text;
                int UserIdIntVal = 0;
                bool isValidUserId = false;
                try
                {
                    UserIdIntVal = Convert.ToInt32(UserId);
                    isValidUserId = true;
                }
                catch
                {

                }
                if (isValidUserId)
                {
                    List<VBRStaffModel> lm = VBRStaffDA.LoginVBRStaffModel(Config.VBR4000Connection, UserIdIntVal);
                    if (lm.Count > 0)
                    {
                        if (Password.Equals(lm[0].Password))
                        {
                            IsLogin = true;
                            txtUserName.BackColor = Color.Green;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Login Failed");
                            txtUserName.BackColor = Color.Red;
                            txtPassWord.BackColor = Color.Red;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Login Failed");
                        txtUserName.BackColor = Color.Red;
                        txtPassWord.BackColor = Color.Red;
                    }
                }
                else
                {
                    MessageBox.Show("UserId Should be Integer");
                }
            }
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtUserName.Text.Trim().Length > 0)
                {
                    txtPassWord.Focus();
                }
            }
        }

        private void txtPassWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((!String.IsNullOrEmpty(txtUserName.Text)) && (!String.IsNullOrEmpty(txtPassWord.Text)))
                {
                    string UserId = txtUserName.Text;
                    string Password = txtPassWord.Text;
                    int UserIdIntVal = 0;
                    bool isValidUserId = false;
                    try
                    {
                        UserIdIntVal = Convert.ToInt32(UserId);
                        isValidUserId = true;
                    }
                    catch
                    {

                    }
                    if (isValidUserId)
                    {
                        List<VBRStaffModel> lm = VBRStaffDA.LoginVBRStaffModel(Config.VBR4000Connection, UserIdIntVal);
                        if (lm.Count > 0)
                        {
                            if (Password.Equals(lm[0].Password))
                            {
                                IsLogin = true;
                                txtUserName.BackColor = Color.Green;
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Login Failed");
                                txtUserName.BackColor = Color.Red;
                                txtPassWord.BackColor = Color.Red;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Login Failed");
                            txtUserName.BackColor = Color.Red;
                            txtPassWord.BackColor = Color.Red;
                        }
                    }
                    else
                    {
                        MessageBox.Show("UserId Should be Integer");
                    }
                }
            }
        }


    }
}

      

       