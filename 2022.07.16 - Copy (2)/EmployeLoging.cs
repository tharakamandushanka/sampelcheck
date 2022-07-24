using System.Data.SqlClient;
namespace WinFormsApp7
{
    public partial class EmployeLoging  :Form

        
    {
        
        

        public EmployeLoging()
        {
            InitializeComponent();
        }

        public object form1 { get; private set; }

        private void Logbtn_Click(object sender, EventArgs e)
        {
         //SqlConnection con = new SqlConnection(conString)
            string index, password;
            bool val;
            String type ="e";



            index = indexTexBox.Text;
             password = PasswordtextBox.Text;

            Form1 f1 = new Form1();   
            
            if(index == "1234")
            {
                if(password == "12345")
                {
                    val = true;
                   
                   Close();
                    MessageBox.Show("login succese", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    f1.panelvisibel(val,type);
                }
                 else
                 {
                    val = false;
                    f1.panelvisibel(val,type);
                    MessageBox.Show("invalide password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
             {
                val=false;
               f1.panelvisibel(val,type);
                MessageBox.Show("invalide user name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

       
    }
}
