using pcboxproba.Model;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pcboxproba.Frames
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new PcBoxDbContext()) 
            {
                var login_users_array = db.res_users.Select(b=>b.login).ToArray();
                if (login_users_array != null)
                {
                    if(emailtb.Text!="")
                    {
                        for(int i=0; i < login_users_array.Length; i++)
                        {
                            if (emailtb.Text == login_users_array[i])
                            {
                                var login_password_array = db.res_users.Select(b => b.password).ToArray();
                                if (Model.res.GenerateComparableHash.VerifyNonstandardHash(paswordtb.Text, login_password_array[i]))
                                {

                                    Main main = new Main();
                                    main.Show();

                                    main.erabiltzailea_target_label.Text = main.erabiltzailea_target_label.Text + " " + login_users_array[i];
                                    Visible = false;
                                }

                            }
                        }
                    }
                }
                

                
            }

            

        }

        private void password_visible_btn_Click(object sender, EventArgs e)
        {
            if (paswordtb.PasswordChar == '\0')
            {
                paswordtb.PasswordChar = '*';
            }
            else
            {
                paswordtb.PasswordChar = '\0';
            }

        }
    }
}
