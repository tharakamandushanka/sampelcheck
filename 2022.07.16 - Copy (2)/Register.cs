using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp7
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
       

            private void Register_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Submitbtn_Click(object sender, EventArgs e)
        {
            ConnectionManager connectionManager = new ConnectionManager();
           SqlConnection con =new SqlConnection(connectionManager.ConString);
            con.Open();
            if (comboBox1.SelectedIndex != null)
            {


                if (ShortName.Text.Length != 0)
                {
                        if(FullName.Text.Length != 0)
                        {
                            
                                if(Dob.Text.Length != 0)
                                {
                                    if(Nic.Text.Length != 0)
                                    {
                                        if(Nic.Text.Length==12)
                                        {
                                            if(MphoneNo.Text.Length != 0)
                                            {
                                                if(MphoneNo.Text.Length==10 )
                                                {
                                                    if(HphoneNo.Text.Length != 0)
                                                    {
                                                        if (HphoneNo.Text.Length==10)
                                                        {
                                                            if (Email.Text.Length != 0)
                                                            {
                                                                string pattren = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z]*@[0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
                                                                if (!Regex.IsMatch(Email.Text, pattren))
                                                                {
                                                                    if(Address.Text.Length!=0)
                                                                    {
                                                                        Close();
                                                                        MessageBox.Show("success registation", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                    }
                                                                    else
                                                                    {
                                                                        MessageBox.Show("empty adderss", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                    }
                                                                    
                                                                }
                                                                else
                                                                {
                                                                    MessageBox.Show("valide email adderss", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                }
                                                            }
                                                            else
                                                            {
                                                                MessageBox.Show("invalide email adderss", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                            }

                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("please enter valide landphone number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("empty landphone numer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("please enter valide mobile phone number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("empty mobile phone number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("please enter valide national idinty card number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("empty national idinty card number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("empty dath of birth", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                           
                        }
                        else
                        {
                            MessageBox.Show("empty full name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                   // }
                    //else
                    //{
                      //  MessageBox.Show("please enter valide short name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   // }
                }
                else
                {
                    MessageBox.Show("empty short name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("pleas select titel", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            

        }
    }
}
