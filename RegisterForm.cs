﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace News
{
    public partial class RegisterForm : Form
    {
        DbConnect dbConnect = new DbConnect();
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
           Boolean check = dbConnect.RegisterConnect(firstname.Text,lastname.Text,email.Text,pass.Text);
            if (check == false)
            {

                MessageBox.Show("email is already exist");
                DialogResult = DialogResult.None;



            }
        }
    }
}
