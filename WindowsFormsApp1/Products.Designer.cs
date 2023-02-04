namespace WindowsFormsApp1
{
    partial class Products
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
            this.btn重新 = new System.Windows.Forms.Button();
            this.btn新增 = new System.Windows.Forms.Button();
            this.btn列表 = new System.Windows.Forms.Button();
            this.btn圖片 = new System.Windows.Forms.Button();
            this.listView商品展示 = new System.Windows.Forms.ListView();
            this.imageListPhoto = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // btn重新
            // 
            this.btn重新.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn重新.BackgroundImage")));
            this.btn重新.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn重新.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn重新.FlatAppearance.BorderSize = 0;
            this.btn重新.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn重新.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn重新.ForeColor = System.Drawing.Color.Black;
            this.btn重新.Location = new System.Drawing.Point(433, 491);
            this.btn重新.Margin = new System.Windows.Forms.Padding(4);
            this.btn重新.Name = "btn重新";
            this.btn重新.Size = new System.Drawing.Size(111, 60);
            this.btn重新.TabIndex = 11;
            this.btn重新.UseVisualStyleBackColor = true;
            this.btn重新.Click += new System.EventHandler(this.btn重新_Click);
            // 
            // btn新增
            // 
            this.btn新增.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn新增.BackgroundImage")));
            this.btn新增.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn新增.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn新增.FlatAppearance.BorderSize = 0;
            this.btn新增.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn新增.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn新增.ForeColor = System.Drawing.Color.Black;
            this.btn新增.Location = new System.Drawing.Point(315, 491);
            this.btn新增.Margin = new System.Windows.Forms.Padding(4);
            this.btn新增.Name = "btn新增";
            this.btn新增.Size = new System.Drawing.Size(111, 60);
            this.btn新增.TabIndex = 10;
            this.btn新增.UseVisualStyleBackColor = true;
            this.btn新增.Click += new System.EventHandler(this.btn新增_Click);
            // 
            // btn列表
            // 
            this.btn列表.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn列表.BackgroundImage")));
            this.btn列表.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn列表.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn列表.FlatAppearance.BorderSize = 0;
            this.btn列表.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn列表.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn列表.ForeColor = System.Drawing.Color.Black;
            this.btn列表.Location = new System.Drawing.Point(196, 491);
            this.btn列表.Margin = new System.Windows.Forms.Padding(4);
            this.btn列表.Name = "btn列表";
            this.btn列表.Size = new System.Drawing.Size(111, 60);
            this.btn列表.TabIndex = 9;
            this.btn列表.UseVisualStyleBackColor = true;
            this.btn列表.Click += new System.EventHandler(this.btn列表_Click);
            // 
            // btn圖片
            // 
            this.btn圖片.BackColor = System.Drawing.Color.Transparent;
            this.btn圖片.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn圖片.BackgroundImage")));
            this.btn圖片.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn圖片.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn圖片.FlatAppearance.BorderSize = 0;
            this.btn圖片.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn圖片.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn圖片.ForeColor = System.Drawing.Color.Black;
            this.btn圖片.Location = new System.Drawing.Point(77, 491);
            this.btn圖片.Margin = new System.Windows.Forms.Padding(4);
            this.btn圖片.Name = "btn圖片";
            this.btn圖片.Size = new System.Drawing.Size(111, 60);
            this.btn圖片.TabIndex = 8;
            this.btn圖片.UseVisualStyleBackColor = false;
            this.btn圖片.Click += new System.EventHandler(this.btn圖片_Click);
            // 
            // listView商品展示
            // 
            this.listView商品展示.HideSelection = false;
            this.listView商品展示.Location = new System.Drawing.Point(0, 1);
            this.listView商品展示.Margin = new System.Windows.Forms.Padding(4);
            this.listView商品展示.Name = "listView商品展示";
            this.listView商品展示.Size = new System.Drawing.Size(638, 482);
            this.listView商品展示.TabIndex = 7;
            this.listView商品展示.UseCompatibleStateImageBehavior = false;
            this.listView商品展示.ItemActivate += new System.EventHandler(this.listView商品展示_ItemActivate);
            // 
            // imageListPhoto
            // 
            this.imageListPhoto.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListPhoto.ImageSize = new System.Drawing.Size(16, 16);
            this.imageListPhoto.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(637, 564);
            this.Controls.Add(this.btn重新);
            this.Controls.Add(this.btn新增);
            this.Controls.Add(this.btn列表);
            this.Controls.Add(this.btn圖片);
            this.Controls.Add(this.listView商品展示);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Products";
            this.Text = "產品";
            this.Load += new System.EventHandler(this.Products_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn重新;
        private System.Windows.Forms.Button btn新增;
        private System.Windows.Forms.Button btn列表;
        private System.Windows.Forms.Button btn圖片;
        private System.Windows.Forms.ListView listView商品展示;
        private System.Windows.Forms.ImageList imageListPhoto;
    }
}