﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluationManagerG11
{
    public partial class frmLogin : Form
    {
        string username = "nastavnik";
        string password = "lozinka";

        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e) {
            
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            if (txtUsername.Text == "")
                MessageBox.Show("Niste unijeli korisničku oznaku!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (txtPassword.Text == "")
                MessageBox.Show("Niste unijeli lozinku!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (txtUsername.Text == username && txtPassword.Text == password) {
                MessageBox.Show("Dobrodošli!", "OK",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);        
            }

            else MessageBox.Show("Unijeli ste krive korisnicke podatke", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
