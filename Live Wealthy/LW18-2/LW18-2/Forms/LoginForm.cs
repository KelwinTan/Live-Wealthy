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
using LW18_2.Forms;
using LW18_2.Database_Classes;

namespace LW18_2
{
    public partial class LoginForm : Form
    {
        IObjectContainer DB;
        public LoginForm()
        {
            InitializeComponent();
            initShoeDB();
        }

        //Initialize Shoe Database
        public void initShoeDB()
        {
            DB = Db4oFactory.OpenFile("Shoe Database.yap");
            IList<ShoeClass> dtList = DB.Query<ShoeClass>(typeof(ShoeClass));
            if (dtList.Count() <= 0)
            {
                ShoeClass AP = new ShoeClass()
                {
                    ShoeID = "AP001",
                    ShoeName = "Air Presto Off-White",
                    Price = 1900
                };

                ShoeClass AJ = new ShoeClass()
                {
                    ShoeID = "AJ001",
                    ShoeName = "Air Jordan 1 Retro High Off-White Chicago",
                    Price = 2000
                };

                ShoeClass NMD = new ShoeClass()
                {
                    ShoeID = "NM001",
                    ShoeName = "Adidas Human Race NMD Pharrell x Chanel Black",
                    Price = 8000
                };

                DB.Store(NMD);
                DB.Store(AJ);
                DB.Store(AP);
            }
            DB.Close();
        }


        public void resetValues()
        {
            emailTxt.Text = "";
            passTxt.Text = "";
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if(emailTxt.Text.Equals("admin@gmail.com") && passTxt.Text.Equals("admin"))
            {
                MessageBox.Show("Welcome Admin!");
                AdminForm af = new AdminForm();
                af.Show();
                this.Hide();
                resetValues();
            }else{
                try
                {
                    DB = Db4oFactory.OpenFile("User Database.yap");
                    List<User> userList = (from x in DB.Query<User>()
                                           where x.Email.Equals(emailTxt.Text) && x.Password.Equals(passTxt.Text)
                                           select x).ToList();
                    if (userList.Count == 0)
                        MessageBox.Show("Invalid Username/Password");
                    else
                    {
                        //gets current user and redirect currUser to shop form
                        MessageBox.Show("Welcome, " + userList.ElementAt(0).Email);
                        ShopForm sf = new ShopForm(userList.ElementAt(0));
                        sf.Show();
                        this.Hide();
                        resetValues();
                    }
                }
                finally
                {
                    DB.Close();
                }
            }
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            RegisterForm rf = new RegisterForm();
            rf.Show();
            this.Hide();
        }
    }
}
