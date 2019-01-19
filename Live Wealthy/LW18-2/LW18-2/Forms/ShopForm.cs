using LW18_2.Database_Classes;
using LW18_2.Forms;
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

namespace LW18_2
{
    public partial class ShopForm : Form
    {
        User currentUser;
        HeaderTransaction ht;
        IObjectContainer DB;        
        public ShopForm(User currUser)
        {
            InitializeComponent();
            this.currentUser = currUser;
            MessageBox.Show(currentUser.Email.ToString());
            MessageBox.Show(currentUser.ID.ToString());
            
        }

        private void shoeBtn_Click(object sender, EventArgs e)
        {
            ShoeForm sf = new ShoeForm(currentUser);
            sf.Show();
            this.Hide();

        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }

        private void userBtn_Click_1(object sender, EventArgs e)
        {
            UserProfileForm upf = new UserProfileForm(currentUser);
            upf.Show();
            this.Hide();
        }

        private void cartBtn_Click(object sender, EventArgs e)
        {
            ManageShoeForm msf = new ManageShoeForm(currentUser);
            msf.Show();
            this.Hide();
        }
    }
}
