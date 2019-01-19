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
    public partial class ManageShoeForm : Form
    {
        User currentUser;
        IList<HeaderTransaction> currHT;
        IObjectContainer DB;
        public ManageShoeForm(User currUser)
        {
            this.currentUser = currUser;
            InitializeComponent();
            loadData();
        }

        public void loadData()
        {
            //Header Transaction 
            DB = Db4oFactory.OpenFile("Header Transaction.yap");
            currHT = (from x in DB.Query<HeaderTransaction>()
                      where x.UserId == currentUser.ID
                      select x).ToList();

            DB.Close();
            if (currHT.Count() <=0) MessageBox.Show("Please Buy First!");
            else
            {
                List<ShoeClass> shoeList = new List<ShoeClass>();
                //Detail Transaction
                for (int i = 0; i < currHT.Count; i++)
                {

                    DB = Db4oFactory.OpenFile("Detail Transaction.yap");
                    List<DetailTransaction> dtList = DB.Query<DetailTransaction>(delegate (DetailTransaction dt)
                    {
                        return dt.HeaderTransactionID == currHT.ElementAt(i).HeaderTransactionID;
                    }).ToList();
                    //ShoeClass
                    DB.Close();

                    DB = Db4oFactory.OpenFile("Shoe Database.yap");
                    foreach (var obj in dtList)
                    {
                        ShoeClass shoe = (from x in DB.Query<ShoeClass>()
                                          where x.ShoeID == obj.ShoeID
                                          select x).FirstOrDefault();
                        shoeList.Add(shoe);
                    }
                    //IList<ShoeClass> shoeList = DB.Query<ShoeClass>(delegate(ShoeClass shoe){
                    //});

                    //Query Detail Transaction to get Shoes from ShoeClass
                    //IQuery dtQuery = DB.Query();
                    //dtQuery.Constrain(typeof(ShoeClass));
                    //dtQuery.Descend("ShoeID").Constrain(dtList.)

                    dgvMSF.DataSource = shoeList.ToList();

                    //dgvMSF.DataSource = shoeList.ToList();
                    DB.Close();
                }
            }

        }

        public void backForm()
        {
            ShopForm sf = new ShopForm(currentUser);
            sf.Show();
            this.Hide();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            backForm();
        }
    }
}
