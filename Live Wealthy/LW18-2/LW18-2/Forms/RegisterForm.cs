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
using System.Text.RegularExpressions;

namespace LW18_2
{
    public partial class RegisterForm : Form
    {
        //Access db4o
        IObjectContainer DB;
        public RegisterForm()
        {
            InitializeComponent();
        }

        public String generateUserId()
        {
            DB = Db4oFactory.OpenFile("User Database.yap");
            string lastID = (from x in DB.Query<User>()
                             orderby x.ID descending
                             select x.ID).FirstOrDefault();
            //generateUserId last ID
            DB.Close();
            string newID;
            if (lastID == null)
                newID = "US001";
            else
            {
                int lastDigit = int.Parse(lastID.Substring(2));
                lastDigit++;
                newID = "US" + lastDigit.ToString("d3");
            }

            return newID;
        }
        
        public string checkStrength(string password)
        {
            string state = "Weak";
            if (password.Length <= 10 && password.Length >= 5)
                state = "Good";
            else if ((Regex.Match(password, @"\d+", RegexOptions.ECMAScript).Success || Regex.Match(password, @"[a-z]+", RegexOptions.ECMAScript).Success && Regex.Match(password, @"[A-Z]+", RegexOptions.ECMAScript
                ).Success || Regex.Match(password, @"[!,@,#,$,%,^,&,*,?,_,~,-,(,)]",RegexOptions.ECMAScript).Success) && password.Length>11)
                state = "Strong";
            
            return state;
        }

        public bool checkEmail(string email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
                return true;
            else
                return false;
        }

        //Function to input user in database
        public void insertUser(string gender)
        {
            User user = new User()
            {
                ID = generateUserId(),
                Email = emailTxt.Text,
                Gender = gender,
                Age = (int)ageNum.Value,
                Password = passTxt.Text
            };
            DB = Db4oFactory.OpenFile("User Database.yap");
            DB.Store(user);
            DB.Close();
            MessageBox.Show(user.ID);
            MessageBox.Show("Register Success!");
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            //Use this to validate alpahnumeric password
            Regex alphanumericPass = new Regex("^[a-zA-Z0-9]*$");
            if (!checkEmail(emailTxt.Text))
                MessageBox.Show("Your email is invalid");
            else if ((int)ageNum.Value < 0)
                MessageBox.Show("Invalid Age");
            else if (passTxt.Text != cPassTxt.Text)
                MessageBox.Show("Your Password is not the same");
            else if (!maleRb.Checked && !femaleRb.Checked)
                MessageBox.Show("Please check your gender");
            else if (alphanumericPass.IsMatch(passTxt.Text))
                MessageBox.Show("please enter an alphanumeric password");
            else
            {
                string newUserID = generateUserId();
                if (maleRb.Checked)
                {
                    insertUser("Male");
                }
                else if (femaleRb.Checked)
                {
                    insertUser("Female");
                }
                MessageBox.Show(checkStrength(passTxt.Text).ToString());
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }
    }
}
