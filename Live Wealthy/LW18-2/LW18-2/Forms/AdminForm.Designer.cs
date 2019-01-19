namespace LW18_2.Forms
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.userDGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.shoeDGV = new System.Windows.Forms.DataGridView();
            this.htDGV = new System.Windows.Forms.DataGridView();
            this.dtDGV = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.UserGB = new System.Windows.Forms.GroupBox();
            this.userTxt = new System.Windows.Forms.TextBox();
            this.deluserBtn = new System.Windows.Forms.Button();
            this.ShoeGB = new System.Windows.Forms.GroupBox();
            this.delShoeBtn = new System.Windows.Forms.Button();
            this.HTGB = new System.Windows.Forms.GroupBox();
            this.DTGB = new System.Windows.Forms.GroupBox();
            this.excelBtn = new System.Windows.Forms.Button();
            this.delAllBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoeDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.htDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDGV)).BeginInit();
            this.UserGB.SuspendLayout();
            this.ShoeGB.SuspendLayout();
            this.DTGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // userDGV
            // 
            this.userDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDGV.Location = new System.Drawing.Point(20, 31);
            this.userDGV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userDGV.Name = "userDGV";
            this.userDGV.RowTemplate.Height = 28;
            this.userDGV.Size = new System.Drawing.Size(543, 132);
            this.userDGV.TabIndex = 0;
            this.userDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userDGV_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Database";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 172);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Shoe Database";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(607, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Header Transasction ";
            // 
            // shoeDGV
            // 
            this.shoeDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shoeDGV.Location = new System.Drawing.Point(20, 198);
            this.shoeDGV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.shoeDGV.Name = "shoeDGV";
            this.shoeDGV.RowTemplate.Height = 28;
            this.shoeDGV.Size = new System.Drawing.Size(543, 132);
            this.shoeDGV.TabIndex = 6;
            // 
            // htDGV
            // 
            this.htDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.htDGV.Location = new System.Drawing.Point(610, 31);
            this.htDGV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.htDGV.Name = "htDGV";
            this.htDGV.RowTemplate.Height = 28;
            this.htDGV.Size = new System.Drawing.Size(543, 132);
            this.htDGV.TabIndex = 7;
            // 
            // dtDGV
            // 
            this.dtDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDGV.Location = new System.Drawing.Point(610, 198);
            this.dtDGV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtDGV.Name = "dtDGV";
            this.dtDGV.RowTemplate.Height = 28;
            this.dtDGV.Size = new System.Drawing.Size(543, 132);
            this.dtDGV.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(607, 172);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Detail Transasction ";
            // 
            // UserGB
            // 
            this.UserGB.Controls.Add(this.userTxt);
            this.UserGB.Controls.Add(this.deluserBtn);
            this.UserGB.Location = new System.Drawing.Point(20, 358);
            this.UserGB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UserGB.Name = "UserGB";
            this.UserGB.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UserGB.Size = new System.Drawing.Size(253, 65);
            this.UserGB.TabIndex = 10;
            this.UserGB.TabStop = false;
            this.UserGB.Text = "User";
            // 
            // userTxt
            // 
            this.userTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.userTxt.Location = new System.Drawing.Point(142, 28);
            this.userTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(93, 30);
            this.userTxt.TabIndex = 15;
            // 
            // deluserBtn
            // 
            this.deluserBtn.Location = new System.Drawing.Point(11, 25);
            this.deluserBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deluserBtn.Name = "deluserBtn";
            this.deluserBtn.Size = new System.Drawing.Size(106, 23);
            this.deluserBtn.TabIndex = 14;
            this.deluserBtn.Text = "Delete User";
            this.deluserBtn.UseVisualStyleBackColor = true;
            this.deluserBtn.Click += new System.EventHandler(this.deluserBtn_Click);
            // 
            // ShoeGB
            // 
            this.ShoeGB.Controls.Add(this.delShoeBtn);
            this.ShoeGB.Location = new System.Drawing.Point(277, 358);
            this.ShoeGB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ShoeGB.Name = "ShoeGB";
            this.ShoeGB.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ShoeGB.Size = new System.Drawing.Size(286, 65);
            this.ShoeGB.TabIndex = 11;
            this.ShoeGB.TabStop = false;
            this.ShoeGB.Text = "Shoe";
            // 
            // delShoeBtn
            // 
            this.delShoeBtn.Location = new System.Drawing.Point(17, 25);
            this.delShoeBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.delShoeBtn.Name = "delShoeBtn";
            this.delShoeBtn.Size = new System.Drawing.Size(110, 23);
            this.delShoeBtn.TabIndex = 0;
            this.delShoeBtn.Text = "Delete All Shoes";
            this.delShoeBtn.UseVisualStyleBackColor = true;
            this.delShoeBtn.Click += new System.EventHandler(this.delShoeBtn_Click);
            // 
            // HTGB
            // 
            this.HTGB.Location = new System.Drawing.Point(610, 358);
            this.HTGB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HTGB.Name = "HTGB";
            this.HTGB.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HTGB.Size = new System.Drawing.Size(268, 65);
            this.HTGB.TabIndex = 12;
            this.HTGB.TabStop = false;
            this.HTGB.Text = "Header Transaction";
            // 
            // DTGB
            // 
            this.DTGB.Controls.Add(this.excelBtn);
            this.DTGB.Location = new System.Drawing.Point(882, 358);
            this.DTGB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DTGB.Name = "DTGB";
            this.DTGB.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DTGB.Size = new System.Drawing.Size(271, 65);
            this.DTGB.TabIndex = 13;
            this.DTGB.TabStop = false;
            this.DTGB.Text = "Detail Transaction";
            // 
            // excelBtn
            // 
            this.excelBtn.Location = new System.Drawing.Point(15, 19);
            this.excelBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.excelBtn.Name = "excelBtn";
            this.excelBtn.Size = new System.Drawing.Size(236, 34);
            this.excelBtn.TabIndex = 0;
            this.excelBtn.Text = "Export to Excel";
            this.excelBtn.UseVisualStyleBackColor = true;
            this.excelBtn.Click += new System.EventHandler(this.excelBtn_Click);
            // 
            // delAllBtn
            // 
            this.delAllBtn.Location = new System.Drawing.Point(333, 438);
            this.delAllBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.delAllBtn.Name = "delAllBtn";
            this.delAllBtn.Size = new System.Drawing.Size(347, 68);
            this.delAllBtn.TabIndex = 14;
            this.delAllBtn.Text = "Delete All Transactions";
            this.delAllBtn.UseVisualStyleBackColor = true;
            this.delAllBtn.Click += new System.EventHandler(this.delAllBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(123, 461);
            this.backBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(87, 44);
            this.backBtn.TabIndex = 15;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 487);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.delAllBtn);
            this.Controls.Add(this.DTGB);
            this.Controls.Add(this.HTGB);
            this.Controls.Add(this.ShoeGB);
            this.Controls.Add(this.UserGB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtDGV);
            this.Controls.Add(this.htDGV);
            this.Controls.Add(this.shoeDGV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userDGV);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.userDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoeDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.htDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDGV)).EndInit();
            this.UserGB.ResumeLayout(false);
            this.UserGB.PerformLayout();
            this.ShoeGB.ResumeLayout(false);
            this.DTGB.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView userDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView shoeDGV;
        private System.Windows.Forms.DataGridView htDGV;
        private System.Windows.Forms.DataGridView dtDGV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox UserGB;
        private System.Windows.Forms.GroupBox ShoeGB;
        private System.Windows.Forms.GroupBox HTGB;
        private System.Windows.Forms.GroupBox DTGB;
        private System.Windows.Forms.Button deluserBtn;
        private System.Windows.Forms.Button delAllBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.TextBox userTxt;
        private System.Windows.Forms.Button delShoeBtn;
        private System.Windows.Forms.Button excelBtn;
    }
}