using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp7
{
    public partial class AdmingLoging : Form
    {
        public AdmingLoging()
        {
            InitializeComponent();
        }

        private void Logbtn_Click(object sender, EventArgs e)
        {
            if (indexTexBox.TextLength != 0)
            {


                if (PasswordtextBox.TextLength != 0)
                {
                    Close();
                    MessageBox.Show("login succese", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("invalide or empty password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
              
            }
            else
            {
                MessageBox.Show("invalide or empty index ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
               
            }
        }
    }
}
