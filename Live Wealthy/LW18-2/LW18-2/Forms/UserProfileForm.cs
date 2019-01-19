using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Db4objects.Db4o;
using Db4objects.Db4o.Query;

namespace LW18_2.Forms
{
    public partial class UserProfileForm : Form
    {
        IObjectContainer DB;
        User currentUser;
        public UserProfileForm(User currUser)
        {
            this.currentUser = currUser;
            InitializeComponent();
            emailTxt.Text = currentUser.Email;
            passTxt.Text = currentUser.Password;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            ShopForm sf = new ShopForm(currentUser);
            sf.Show();
            this.Hide();
        }

        //Function to validate Email
        bool isValidEmail(string email)
        {
            try
            {
                var address = new System.Net.Mail.MailAddress(email);
                return address.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DB = Db4oFactory.OpenFile("User Database.yap");
            if (!isValidEmail(upEmailTXT.Text))
                MessageBox.Show("Please enter a valid email");
            else
            {
                IObjectSet result = DB.QueryByExample(new User() {
                    Email = currentUser.Email,
                    Age = currentUser.Age,
                    Gender = currentUser.Gender,
                    ID = currentUser.ID,
                    Password = currentUser.Password
                });
                User found = (User)result.Next();

                found.Email = upEmailTXT.Text;
                found.Password = upPassTXT.Text;
                this.currentUser = found;
                DB.Store(found);
                DB.Close();
                MessageBox.Show("Update Success");
            }
        }
    }
}
