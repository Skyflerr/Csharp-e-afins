using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Interface
{
    public partial class Form1 : Form
    {
        List<string> Names = new List<string>();
        List<string> Passwords = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            PasswordBox.PasswordChar = '*';
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            if(Names.Contains(NameBox.Text))
            {
                MessageBox.Show("Name already taken, try a new one");
            }

            if (!Names.Contains(NameBox.Text))
            {
                Names.Add(NameBox.Text);
                Passwords.Add(PasswordBox.Text);
                MessageBox.Show("You're signed in !");
            }                        
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            if (Names.IndexOf(NameBox.Text) == Passwords.IndexOf(PasswordBox.Text) && Names.Contains(NameBox.Text))
                MessageBox.Show("You're loged in");
            if (Names.IndexOf(NameBox.Text) != Passwords.IndexOf(PasswordBox.Text) || !Names.Contains(NameBox.Text))
                MessageBox.Show("Something went wrong try again");
        }
    }
}
