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
using LW18_2.Database_Classes;

namespace LW18_2.Forms
{
    public partial class ShoeForm : Form
    {
        IObjectContainer DB;
        private int buyAP = 0;
        private int buyAJ = 0;
        private int buyNMD = 0;
        User currentUser;
        HeaderTransaction currHT;
        public ShoeForm(User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
        }

        //Function to generate id for three different type of shoes
        private string GenerateID(string identity) {
            string lastID = (from x in DB.Query<ShoeClass>()
                             where x.ShoeID.StartsWith(identity)
                             orderby x.ShoeID descending
                             select x.ShoeID).FirstOrDefault();
            if (lastID == null)
                lastID = identity + "001";
            return lastID;
        }

        //Function to generate Header Transaction ID
        private string genereateHeaderID()
        {
            string lastID = (from x in DB.Query<HeaderTransaction>()
                             orderby x.HeaderTransactionID descending
                             select x.HeaderTransactionID).FirstOrDefault();
            string newID;
            if (lastID == null)
                newID = "HT001";
            else
            {
                int lastDigit = int.Parse(lastID.Substring(2));
                lastDigit++;
                newID = "HT" + lastDigit.ToString("d3");
            }
            return newID;
        }

        //Function to store Header Transaction
        private void storeHeaderTransaction()
        {
            DB = Db4oFactory.OpenFile("Header Transaction.yap");
            HeaderTransaction ht = new HeaderTransaction()
            {
                HeaderTransactionID = genereateHeaderID(),
                UserId = currentUser.ID.ToString()
            };
            currHT = ht;
            DB.Store(ht);
            DB.Close();
        }

        //Function to store Detail Transaction
        private void storeDetailTransaction(string ht, string shoeid, int qty)
        {
            DB = Db4oFactory.OpenFile("Detail Transaction.yap");
            DetailTransaction dt = new DetailTransaction()
            {
                ShoeID = shoeid,
                HeaderTransactionID = ht,
                Quantity = qty
            };
            DB.Store(dt);
            DB.Close();
        }

        //Function to insert shoes into database
        public void buyShoes()
        {
            if (buyNMD == 0 && buyAJ == 0 && buyAP == 0)
                MessageBox.Show("Thank you for visiting!");
            else
            {
                storeHeaderTransaction();
                if (buyAP != 0)
                {
                    storeDetailTransaction(currHT.HeaderTransactionID, "AP001", buyAP);
                }

                if (buyAJ != 0)
                {
                    storeDetailTransaction(currHT.HeaderTransactionID, "AJ001", buyAJ);
                }

                if (buyNMD != 0)
                {
                    storeDetailTransaction(currHT.HeaderTransactionID, "NM001", buyNMD);
                }
            }
        }


        private void backBtn_Click(object sender, EventArgs e)
        {
            buyShoes();
            ShopForm sf = new ShopForm(currentUser);
            sf.Show();
            this.Hide();
        }

        private void buyBtnAP_Click(object sender, EventArgs e)
        {
            buyAP += 1;
        }

        private void buyBtnAJ_Click(object sender, EventArgs e)
        {
            buyAJ += 1;
        }

        private void buyBtnNMD_Click(object sender, EventArgs e)
        {
            buyNMD += 1;
        }

        private void backBtn_Click_1(object sender, EventArgs e)
        {
            buyShoes();
            ShopForm sf = new ShopForm(currentUser);
            sf.Show();
            this.Hide();
        }
    }
}
