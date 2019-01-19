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
    public partial class AdminForm : Form
    {
        IObjectContainer DB;
        User currUser;
        
        public AdminForm()
        {
            InitializeComponent();
            loadData();
        }
        
        //User Data
        public void loadUserData()
        {
            DB = Db4oFactory.OpenFile("User Database.yap");
            IList<User> userList = DB.Query<User>(typeof(User));
            userDGV.DataSource = userList.ToList();
            DB.Close();
        }

        //Shoe Data
        public void loadShoeData()
        {
            DB = Db4oFactory.OpenFile("Shoe Database.yap");
            IList<ShoeClass> shoeList = DB.Query<ShoeClass>(typeof(ShoeClass));
            shoeDGV.DataSource = shoeList.ToList();
            DB.Close();
        }

        //Header Transaction
        public void loadHTData()
        {
            DB = Db4oFactory.OpenFile("Header Transaction.yap");
            IList<HeaderTransaction> htList = DB.Query<HeaderTransaction>(typeof(HeaderTransaction));
            htDGV.DataSource = htList.ToList();
            DB.Close();
        }

        //Detail Transaction
        public void loadDTData()
        {
            DB = Db4oFactory.OpenFile("Detail Transaction.yap");
            IList<DetailTransaction> dtList = DB.Query<DetailTransaction>(typeof(DetailTransaction));
            dtDGV.DataSource = dtList.ToList();
            DB.Close();
        }

        //Function to load all the data and place it to the data grid view
        public void loadData()
        {
            loadUserData();
            loadShoeData();
            loadHTData();
            loadDTData();
        }

        private void deluserBtn_Click(object sender, EventArgs e)
        {
            //DB = Db4oFactory.OpenFile("User Database.yap");
            //IObjectSet result = DB.QueryByExample(typeof(User));
            //foreach(object user in result)
            //{
            //    DB.Delete(user);
            //}
            //DB.Close();
            DB = Db4oFactory.OpenFile("User Database.yap");
            currUser = (from x in DB.Query<User>()
                        where x.ID == userTxt.Text
                        select x).FirstOrDefault();
            DB.Delete(currUser);
            DB.Close();
            MessageBox.Show("Success in deleting the specified user");
        }

        private void delAllBtn_Click(object sender, EventArgs e)
        {
            DB = Db4oFactory.OpenFile("Header Transaction.yap");
            IObjectSet result2 = DB.QueryByExample(typeof(HeaderTransaction));
            foreach(object ht in result2)
            {
                DB.Delete(ht);
            }
            DB.Close();

            DB = Db4oFactory.OpenFile("Detail Transaction.yap");
            IObjectSet result3 = DB.QueryByExample(typeof(DetailTransaction));
            foreach(object dt in result3)
            {
                DB.Delete(dt);
            }
            DB.Close();
            MessageBox.Show("Success in deleting all transactions!");
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }

        private void userDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Click Email buat muncul user id
            if (e.RowIndex < userDGV.Rows.Count-1)
                userTxt.Text = userDGV.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void delShoeBtn_Click(object sender, EventArgs e)
        {
            DB = Db4oFactory.OpenFile("Shoe Database.yap");
            IObjectSet result = DB.QueryByExample(typeof(ShoeClass));
            foreach(object delShoe in result)
            {
                DB.Delete(delShoe);
            }
            DB.Close();
            MessageBox.Show("Success in deleting all shoes");
        }

        private void excelBtn_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
            app.Visible = true;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Detail Transactions";
            var grandTotal = 0;
            for (int i = 1; i < dtDGV.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dtDGV.Columns[i - 1].HeaderText;
                worksheet.Cells[1, 4] = "Subtotal";
                worksheet.Cells[1, 5] = "Grand Total";

            }

            for (int j = 0; j<dtDGV.Rows.Count; j++)
            {
                for(int z = 0; z<dtDGV.Columns.Count; z++)
                {
                    worksheet.Cells[j + 2, z + 1] = dtDGV.Rows[j].Cells[z].Value.ToString();
                    if (dtDGV.Rows[j].Cells[0].Value.ToString() == "AP001")
                    {
                        var APtotal = (int)dtDGV.Rows[j].Cells[2].Value * 1900;
                        worksheet.Cells[j + 2, z + 2] = APtotal;
                        grandTotal += APtotal;
                    } else if (dtDGV.Rows[j].Cells[0].Value.ToString() == "AJ001")
                    {
                        var AJtotal = (int)dtDGV.Rows[j].Cells[2].Value * 2000;
                        worksheet.Cells[j + 2, z + 2] = AJtotal;
                        grandTotal += AJtotal;
                    }
                    else if (dtDGV.Rows[j].Cells[0].Value.ToString() == "NM001")
                    {
                        var NMtotal = (int)dtDGV.Rows[j].Cells[2].Value * 8000;
                        worksheet.Cells[j + 2, z + 2] = NMtotal;
                        grandTotal += NMtotal;
                    }
                }
            }

            //for(int j=0; j<dtDGV.Rows.Count+1; j++)
            //{
            //    var GrandTotal = 0;/
            //    GrandTotal += worksheet.Cells[j + 1, 3];
            //    worksheet.Cells[2, 5] = GrandTotal;
            //}
            worksheet.Cells[2, 5] = grandTotal/dtDGV.ColumnCount;

            workbook.SaveAs("D:\\Detail Transactions.xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            app.Quit();
        }
    }
}
