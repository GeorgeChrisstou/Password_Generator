using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace password_generator
{
    public partial class Form1 : Form
    {
        int currentPasswordLength = 0;
        Random character = new Random();
        private void syms_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void nums_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lower_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void upper_CheckedChanged(object sender, EventArgs e)
        {
            
        }

  

        private void password_Click(object sender, EventArgs e)
        {
            string uppercase_letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase_letters = uppercase_letters.ToLower();
            string digits = "0123456789";
            string symbols = "<>{}[]()!£$%^&*_-=+;:'@#~<>?/";

            string all = "";
            if(upper.CheckState == CheckState.Checked)
            {
                all += uppercase_letters;
            }
            if (lower.CheckState == CheckState.Checked)
            {
                all += lowercase_letters;
            }
            if (nums.CheckState == CheckState.Checked)
            {
                all += digits;
            }
            if (syms.CheckState == CheckState.Checked)
            {
                all += symbols;
            }
            

        }

        private void passwordGenerator(int passwordLength, string password)
        {

            string randompassword = "";
            for (int i = 0; i < passwordLength; i++)
            {
                int randomNum = character.Next(0, all.Length);
                randompassword += all[randomNum];
            }
            password_label.Text = randompassword;

        }
        public Form1()
        {

            InitializeComponent();
            passwordlengthtrackbar.Minimum = 6;
            passwordlengthtrackbar.Maximum = 20;
            passwordGenerator(6);
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            passwordlength.Text = "Password Length: " + passwordlengthtrackbar.Value.ToString();
            currentPasswordLength = passwordlengthtrackbar.Value;
            passwordGenerator(currentPasswordLength);

        }
        private void copypassword_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(password_label.Text);

        }

    }
}
