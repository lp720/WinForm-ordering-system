namespace WindowsFormsApp1
{
    partial class ProductDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductDetail));
            this.pictureBox商品圖檔 = new System.Windows.Forms.PictureBox();
            this.lblID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chk供應狀態 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt商品價格 = new System.Windows.Forms.TextBox();
            this.txt商品名稱 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox新增商品 = new GrouboxAttribute.GroupBoxBC(this.components);
            this.btn儲存商品 = new System.Windows.Forms.Button();
            this.btn選取新增商品照片 = new System.Windows.Forms.Button();
            this.btn清空欄位 = new System.Windows.Forms.Button();
            this.groupBox修改商品 = new GrouboxAttribute.GroupBoxBC(this.components);
            this.btn選取商品照片 = new System.Windows.Forms.Button();
            this.btn儲存修改 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox商品圖檔)).BeginInit();
            this.groupBox新增商品.SuspendLayout();
            this.groupBox修改商品.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox商品圖檔
            // 
            this.pictureBox商品圖檔.Location = new System.Drawing.Point(312, 38);
            this.pictureBox商品圖檔.Name = "pictureBox商品圖檔";
            this.pictureBox商品圖檔.Size = new System.Drawing.Size(238, 272);
            this.pictureBox商品圖檔.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox商品圖檔.TabIndex = 26;
            this.pictureBox商品圖檔.TabStop = false;
            // 
            // lblID
            // 
            this.lblID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.lblID.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(92, 11);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(200, 40);
            this.lblID.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(386, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "商品圖檔";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(58, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "id";
            // 
            // chk供應狀態
            // 
            this.chk供應狀態.AutoSize = true;
            this.chk供應狀態.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chk供應狀態.Location = new System.Drawing.Point(98, 155);
            this.chk供應狀態.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chk供應狀態.Name = "chk供應狀態";
            this.chk供應狀態.Size = new System.Drawing.Size(98, 26);
            this.chk供應狀態.TabIndex = 31;
            this.chk供應狀態.Text = "供應中";
            this.chk供應狀態.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(3, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 25);
            this.label5.TabIndex = 30;
            this.label5.Text = "供應狀態";
            // 
            // txt商品價格
            // 
            this.txt商品價格.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.txt商品價格.Location = new System.Drawing.Point(98, 106);
            this.txt商品價格.Multiline = true;
            this.txt商品價格.Name = "txt商品價格";
            this.txt商品價格.Size = new System.Drawing.Size(196, 30);
            this.txt商品價格.TabIndex = 35;
            // 
            // txt商品名稱
            // 
            this.txt商品名稱.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.txt商品名稱.Location = new System.Drawing.Point(98, 62);
            this.txt商品名稱.Multiline = true;
            this.txt商品名稱.Name = "txt商品名稱";
            this.txt商品名稱.Size = new System.Drawing.Size(196, 31);
            this.txt商品名稱.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(3, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 33;
            this.label4.Text = "商品價格";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "商品名稱";
            // 
            // groupBox新增商品
            // 
            this.groupBox新增商品.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.groupBox新增商品.Controls.Add(this.btn儲存商品);
            this.groupBox新增商品.Controls.Add(this.btn選取新增商品照片);
            this.groupBox新增商品.Controls.Add(this.btn清空欄位);
            this.groupBox新增商品.Location = new System.Drawing.Point(156, 181);
            this.groupBox新增商品.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox新增商品.Name = "groupBox新增商品";
            this.groupBox新增商品.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox新增商品.Size = new System.Drawing.Size(150, 134);
            this.groupBox新增商品.TabIndex = 37;
            this.groupBox新增商品.TabStop = false;
            // 
            // btn儲存商品
            // 
            this.btn儲存商品.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn儲存商品.BackgroundImage")));
            this.btn儲存商品.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn儲存商品.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn儲存商品.FlatAppearance.BorderSize = 0;
            this.btn儲存商品.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn儲存商品.Location = new System.Drawing.Point(21, 10);
            this.btn儲存商品.Name = "btn儲存商品";
            this.btn儲存商品.Size = new System.Drawing.Size(115, 37);
            this.btn儲存商品.TabIndex = 1;
            this.btn儲存商品.UseVisualStyleBackColor = true;
            this.btn儲存商品.Click += new System.EventHandler(this.btn儲存修改_Click);
            // 
            // btn選取新增商品照片
            // 
            this.btn選取新增商品照片.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn選取新增商品照片.BackgroundImage")));
            this.btn選取新增商品照片.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn選取新增商品照片.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn選取新增商品照片.FlatAppearance.BorderSize = 0;
            this.btn選取新增商品照片.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn選取新增商品照片.Location = new System.Drawing.Point(21, 93);
            this.btn選取新增商品照片.Name = "btn選取新增商品照片";
            this.btn選取新增商品照片.Size = new System.Drawing.Size(115, 36);
            this.btn選取新增商品照片.TabIndex = 3;
            this.btn選取新增商品照片.UseVisualStyleBackColor = true;
            this.btn選取新增商品照片.Click += new System.EventHandler(this.btn選取新增商品照片_Click);
            // 
            // btn清空欄位
            // 
            this.btn清空欄位.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn清空欄位.BackgroundImage")));
            this.btn清空欄位.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn清空欄位.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn清空欄位.FlatAppearance.BorderSize = 0;
            this.btn清空欄位.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn清空欄位.Location = new System.Drawing.Point(21, 52);
            this.btn清空欄位.Name = "btn清空欄位";
            this.btn清空欄位.Size = new System.Drawing.Size(115, 37);
            this.btn清空欄位.TabIndex = 2;
            this.btn清空欄位.UseVisualStyleBackColor = true;
            this.btn清空欄位.Click += new System.EventHandler(this.btn清空欄位_Click);
            // 
            // groupBox修改商品
            // 
            this.groupBox修改商品.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.groupBox修改商品.Controls.Add(this.btn選取商品照片);
            this.groupBox修改商品.Controls.Add(this.btn儲存修改);
            this.groupBox修改商品.Location = new System.Drawing.Point(10, 181);
            this.groupBox修改商品.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox修改商品.Name = "groupBox修改商品";
            this.groupBox修改商品.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox修改商品.Size = new System.Drawing.Size(142, 134);
            this.groupBox修改商品.TabIndex = 36;
            this.groupBox修改商品.TabStop = false;
            // 
            // btn選取商品照片
            // 
            this.btn選取商品照片.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn選取商品照片.BackgroundImage")));
            this.btn選取商品照片.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn選取商品照片.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn選取商品照片.FlatAppearance.BorderSize = 0;
            this.btn選取商品照片.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn選取商品照片.Location = new System.Drawing.Point(6, 64);
            this.btn選取商品照片.Name = "btn選取商品照片";
            this.btn選取商品照片.Size = new System.Drawing.Size(121, 36);
            this.btn選取商品照片.TabIndex = 0;
            this.btn選取商品照片.UseVisualStyleBackColor = true;
            this.btn選取商品照片.Click += new System.EventHandler(this.btn選取商品照片_Click);
            // 
            // btn儲存修改
            // 
            this.btn儲存修改.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn儲存修改.BackgroundImage")));
            this.btn儲存修改.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn儲存修改.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn儲存修改.FlatAppearance.BorderSize = 0;
            this.btn儲存修改.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn儲存修改.Location = new System.Drawing.Point(6, 10);
            this.btn儲存修改.Name = "btn儲存修改";
            this.btn儲存修改.Size = new System.Drawing.Size(115, 37);
            this.btn儲存修改.TabIndex = 4;
            this.btn儲存修改.UseVisualStyleBackColor = true;
            this.btn儲存修改.Click += new System.EventHandler(this.btn儲存商品_Click);
            // 
            // ProductDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(559, 315);
            this.Controls.Add(this.groupBox新增商品);
            this.Controls.Add(this.groupBox修改商品);
            this.Controls.Add(this.txt商品價格);
            this.Controls.Add(this.txt商品名稱);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chk供應狀態);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox商品圖檔);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ProductDetail";
            this.Text = "產品細節";
            this.Load += new System.EventHandler(this.ProductDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox商品圖檔)).EndInit();
            this.groupBox新增商品.ResumeLayout(false);
            this.groupBox修改商品.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn儲存修改;
        private System.Windows.Forms.Button btn選取新增商品照片;
        private System.Windows.Forms.Button btn清空欄位;
        private System.Windows.Forms.Button btn儲存商品;
        private System.Windows.Forms.Button btn選取商品照片;
        private System.Windows.Forms.PictureBox pictureBox商品圖檔;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chk供應狀態;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt商品價格;
        private System.Windows.Forms.TextBox txt商品名稱;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private GrouboxAttribute.GroupBoxBC groupBox修改商品;
        private GrouboxAttribute.GroupBoxBC groupBox新增商品;
    }
}