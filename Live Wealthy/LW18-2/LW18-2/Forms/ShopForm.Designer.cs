namespace LW18_2
{
    partial class ShopForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userBtn = new System.Windows.Forms.Button();
            this.cartBtn = new System.Windows.Forms.Button();
            this.shoeBtn = new System.Windows.Forms.Button();
            this.brandLabel = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.logoutBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(182, 206);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1382, 510);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // userBtn
            // 
            this.userBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userBtn.ForeColor = System.Drawing.Color.White;
            this.userBtn.Image = ((System.Drawing.Image)(resources.GetObject("userBtn.Image")));
            this.userBtn.Location = new System.Drawing.Point(978, 2);
            this.userBtn.Name = "userBtn";
            this.userBtn.Size = new System.Drawing.Size(135, 142);
            this.userBtn.TabIndex = 7;
            this.userBtn.UseVisualStyleBackColor = true;
            this.userBtn.Click += new System.EventHandler(this.userBtn_Click_1);
            // 
            // cartBtn
            // 
            this.cartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cartBtn.ForeColor = System.Drawing.Color.White;
            this.cartBtn.Image = ((System.Drawing.Image)(resources.GetObject("cartBtn.Image")));
            this.cartBtn.Location = new System.Drawing.Point(834, 1);
            this.cartBtn.Name = "cartBtn";
            this.cartBtn.Size = new System.Drawing.Size(138, 145);
            this.cartBtn.TabIndex = 6;
            this.cartBtn.UseVisualStyleBackColor = true;
            this.cartBtn.Click += new System.EventHandler(this.cartBtn_Click);
            // 
            // shoeBtn
            // 
            this.shoeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shoeBtn.ForeColor = System.Drawing.Color.White;
            this.shoeBtn.Image = ((System.Drawing.Image)(resources.GetObject("shoeBtn.Image")));
            this.shoeBtn.Location = new System.Drawing.Point(695, 1);
            this.shoeBtn.Name = "shoeBtn";
            this.shoeBtn.Size = new System.Drawing.Size(134, 145);
            this.shoeBtn.TabIndex = 3;
            this.shoeBtn.UseVisualStyleBackColor = true;
            this.shoeBtn.Click += new System.EventHandler(this.shoeBtn_Click);
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.Font = new System.Drawing.Font("Century Gothic", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandLabel.Location = new System.Drawing.Point(205, 38);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(373, 69);
            this.brandLabel.TabIndex = 3;
            this.brandLabel.Text = "Live Wealthy";
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(22, 10);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(122, 115);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 3;
            this.logoPictureBox.TabStop = false;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(207)))), ((int)(((byte)(83)))));
            this.headerPanel.Controls.Add(this.logoutBtn);
            this.headerPanel.Controls.Add(this.userBtn);
            this.headerPanel.Controls.Add(this.cartBtn);
            this.headerPanel.Controls.Add(this.shoeBtn);
            this.headerPanel.Controls.Add(this.brandLabel);
            this.headerPanel.Controls.Add(this.logoPictureBox);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1924, 145);
            this.headerPanel.TabIndex = 4;
            // 
            // logoutBtn
            // 
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.ForeColor = System.Drawing.Color.White;
            this.logoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("logoutBtn.Image")));
            this.logoutBtn.Location = new System.Drawing.Point(1790, -1);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(134, 145);
            this.logoutBtn.TabIndex = 8;
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ShopForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShopForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button userBtn;
        private System.Windows.Forms.Button cartBtn;
        private System.Windows.Forms.Button shoeBtn;
        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Button logoutBtn;
    }
}