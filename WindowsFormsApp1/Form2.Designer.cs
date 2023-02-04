namespace WindowsFormsApp1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btn確認訂單 = new System.Windows.Forms.Button();
            this.btn移除 = new System.Windows.Forms.Button();
            this.btn清除 = new System.Windows.Forms.Button();
            this.lbl總價 = new System.Windows.Forms.Label();
            this.lbl訂購人資訊 = new System.Windows.Forms.Label();
            this.listBox訂購品項 = new System.Windows.Forms.ListBox();
            this.lbl單價 = new System.Windows.Forms.Label();
            this.txtBox優惠代碼 = new System.Windows.Forms.TextBox();
            this.lbl用餐 = new System.Windows.Forms.Label();
            this.timer訊息 = new System.Windows.Forms.Timer(this.components);
            this.lbl訊息 = new System.Windows.Forms.Label();
            this.lbl醬包 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn確認訂單
            // 
            this.btn確認訂單.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn確認訂單.BackgroundImage")));
            this.btn確認訂單.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn確認訂單.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn確認訂單.FlatAppearance.BorderSize = 0;
            this.btn確認訂單.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn確認訂單.Location = new System.Drawing.Point(876, 431);
            this.btn確認訂單.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn確認訂單.Name = "btn確認訂單";
            this.btn確認訂單.Size = new System.Drawing.Size(275, 49);
            this.btn確認訂單.TabIndex = 0;
            this.btn確認訂單.UseVisualStyleBackColor = true;
            this.btn確認訂單.Click += new System.EventHandler(this.btn確認訂單_Click);
            // 
            // btn移除
            // 
            this.btn移除.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn移除.BackgroundImage")));
            this.btn移除.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn移除.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn移除.FlatAppearance.BorderSize = 0;
            this.btn移除.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn移除.Location = new System.Drawing.Point(195, 552);
            this.btn移除.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn移除.Name = "btn移除";
            this.btn移除.Size = new System.Drawing.Size(294, 70);
            this.btn移除.TabIndex = 1;
            this.btn移除.UseVisualStyleBackColor = true;
            this.btn移除.Click += new System.EventHandler(this.btn移除_Click_1);
            // 
            // btn清除
            // 
            this.btn清除.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn清除.BackgroundImage")));
            this.btn清除.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn清除.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn清除.FlatAppearance.BorderSize = 0;
            this.btn清除.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn清除.Location = new System.Drawing.Point(526, 552);
            this.btn清除.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn清除.Name = "btn清除";
            this.btn清除.Size = new System.Drawing.Size(294, 70);
            this.btn清除.TabIndex = 2;
            this.btn清除.UseVisualStyleBackColor = true;
            this.btn清除.Click += new System.EventHandler(this.btn清除_Click_1);
            // 
            // lbl總價
            // 
            this.lbl總價.BackColor = System.Drawing.Color.Transparent;
            this.lbl總價.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl總價.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl總價.Location = new System.Drawing.Point(934, 288);
            this.lbl總價.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl總價.Name = "lbl總價";
            this.lbl總價.Size = new System.Drawing.Size(194, 41);
            this.lbl總價.TabIndex = 3;
            this.lbl總價.Text = "NT$";
            // 
            // lbl訂購人資訊
            // 
            this.lbl訂購人資訊.AutoSize = true;
            this.lbl訂購人資訊.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.lbl訂購人資訊.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl訂購人資訊.Location = new System.Drawing.Point(15, 132);
            this.lbl訂購人資訊.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl訂購人資訊.Name = "lbl訂購人資訊";
            this.lbl訂購人資訊.Size = new System.Drawing.Size(167, 38);
            this.lbl訂購人資訊.TabIndex = 4;
            this.lbl訂購人資訊.Text = "訂購人資料";
            // 
            // listBox訂購品項
            // 
            this.listBox訂購品項.BackColor = System.Drawing.Color.White;
            this.listBox訂購品項.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox訂購品項.ForeColor = System.Drawing.Color.Coral;
            this.listBox訂購品項.FormattingEnabled = true;
            this.listBox訂購品項.ItemHeight = 33;
            this.listBox訂購品項.Location = new System.Drawing.Point(15, 179);
            this.listBox訂購品項.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox訂購品項.Name = "listBox訂購品項";
            this.listBox訂購品項.Size = new System.Drawing.Size(834, 268);
            this.listBox訂購品項.TabIndex = 5;
            this.listBox訂購品項.SelectedIndexChanged += new System.EventHandler(this.listBox訂購品項_SelectedIndexChanged);
            // 
            // lbl單價
            // 
            this.lbl單價.BackColor = System.Drawing.Color.Transparent;
            this.lbl單價.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl單價.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.lbl單價.Location = new System.Drawing.Point(934, 230);
            this.lbl單價.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl單價.Name = "lbl單價";
            this.lbl單價.Size = new System.Drawing.Size(194, 44);
            this.lbl單價.TabIndex = 6;
            this.lbl單價.Text = "NT$";
            // 
            // txtBox優惠代碼
            // 
            this.txtBox優惠代碼.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox優惠代碼.Location = new System.Drawing.Point(984, 338);
            this.txtBox優惠代碼.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBox優惠代碼.Multiline = true;
            this.txtBox優惠代碼.Name = "txtBox優惠代碼";
            this.txtBox優惠代碼.Size = new System.Drawing.Size(180, 30);
            this.txtBox優惠代碼.TabIndex = 27;
            this.txtBox優惠代碼.TextChanged += new System.EventHandler(this.txtBox優惠代碼_TextChanged_1);
            // 
            // lbl用餐
            // 
            this.lbl用餐.BackColor = System.Drawing.Color.White;
            this.lbl用餐.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl用餐.Location = new System.Drawing.Point(880, 385);
            this.lbl用餐.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl用餐.Name = "lbl用餐";
            this.lbl用餐.Size = new System.Drawing.Size(90, 40);
            this.lbl用餐.TabIndex = 29;
            // 
            // timer訊息
            // 
            this.timer訊息.Enabled = true;
            this.timer訊息.Interval = 180;
            this.timer訊息.Tick += new System.EventHandler(this.timer訊息_Tick);
            // 
            // lbl訊息
            // 
            this.lbl訊息.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.lbl訊息.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl訊息.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lbl訊息.Location = new System.Drawing.Point(409, 9);
            this.lbl訊息.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl訊息.Name = "lbl訊息";
            this.lbl訊息.Size = new System.Drawing.Size(450, 32);
            this.lbl訊息.TabIndex = 30;
            this.lbl訊息.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl醬包
            // 
            this.lbl醬包.BackColor = System.Drawing.Color.White;
            this.lbl醬包.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl醬包.Location = new System.Drawing.Point(984, 385);
            this.lbl醬包.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl醬包.Name = "lbl醬包";
            this.lbl醬包.Size = new System.Drawing.Size(180, 40);
            this.lbl醬包.TabIndex = 31;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 680);
            this.Controls.Add(this.lbl醬包);
            this.Controls.Add(this.lbl訊息);
            this.Controls.Add(this.lbl用餐);
            this.Controls.Add(this.txtBox優惠代碼);
            this.Controls.Add(this.lbl單價);
            this.Controls.Add(this.listBox訂購品項);
            this.Controls.Add(this.lbl訂購人資訊);
            this.Controls.Add(this.lbl總價);
            this.Controls.Add(this.btn清除);
            this.Controls.Add(this.btn移除);
            this.Controls.Add(this.btn確認訂單);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "咪咪貓點餐系統";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn確認訂單;
        private System.Windows.Forms.Button btn移除;
        private System.Windows.Forms.Button btn清除;
        private System.Windows.Forms.Label lbl總價;
        private System.Windows.Forms.Label lbl訂購人資訊;
        private System.Windows.Forms.ListBox listBox訂購品項;
        private System.Windows.Forms.Label lbl單價;
        private System.Windows.Forms.TextBox txtBox優惠代碼;
        private System.Windows.Forms.Label lbl用餐;
        private System.Windows.Forms.Timer timer訊息;
        private System.Windows.Forms.Label lbl訊息;
        private System.Windows.Forms.Label lbl醬包;
    }
}