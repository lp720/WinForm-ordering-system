namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn結帳 = new System.Windows.Forms.Button();
            this.lbl小計 = new System.Windows.Forms.Label();
            this.lbl總計 = new System.Windows.Forms.Label();
            this.cmbBox醬包 = new System.Windows.Forms.ComboBox();
            this.cmbBox配餐 = new System.Windows.Forms.ComboBox();
            this.cmbBox飲料 = new System.Windows.Forms.ComboBox();
            this.cmbBox加價購 = new System.Windows.Forms.ComboBox();
            this.txtbox數量 = new System.Windows.Forms.TextBox();
            this.btn加入訂單 = new System.Windows.Forms.Button();
            this.btn支援 = new System.Windows.Forms.Button();
            this.listView商品展示 = new System.Windows.Forms.ListView();
            this.imageList商品圖檔 = new System.Windows.Forms.ImageList(this.components);
            this.chkBox購物袋 = new System.Windows.Forms.CheckBox();
            this.btn維護系統 = new System.Windows.Forms.Button();
            this.btn會員系統 = new System.Windows.Forms.Button();
            this.lbl資訊 = new System.Windows.Forms.Label();
            this.btn登入 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxBC1 = new GrouboxAttribute.GroupBoxBC(this.components);
            this.radio外帶 = new System.Windows.Forms.RadioButton();
            this.radio內用 = new System.Windows.Forms.RadioButton();
            this.groupBoxBC1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn結帳
            // 
            this.btn結帳.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn結帳.FlatAppearance.BorderSize = 0;
            this.btn結帳.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn結帳.Image = ((System.Drawing.Image)(resources.GetObject("btn結帳.Image")));
            this.btn結帳.Location = new System.Drawing.Point(907, 361);
            this.btn結帳.Name = "btn結帳";
            this.btn結帳.Size = new System.Drawing.Size(299, 59);
            this.btn結帳.TabIndex = 0;
            this.btn結帳.UseVisualStyleBackColor = true;
            this.btn結帳.Click += new System.EventHandler(this.btn結帳_Click);
            // 
            // lbl小計
            // 
            this.lbl小計.BackColor = System.Drawing.Color.Transparent;
            this.lbl小計.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl小計.ForeColor = System.Drawing.Color.Gray;
            this.lbl小計.Location = new System.Drawing.Point(981, 236);
            this.lbl小計.Name = "lbl小計";
            this.lbl小計.Size = new System.Drawing.Size(234, 33);
            this.lbl小計.TabIndex = 1;
            this.lbl小計.Text = "NT$ 0元";
            // 
            // lbl總計
            // 
            this.lbl總計.BackColor = System.Drawing.Color.Transparent;
            this.lbl總計.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl總計.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl總計.Location = new System.Drawing.Point(981, 293);
            this.lbl總計.Name = "lbl總計";
            this.lbl總計.Size = new System.Drawing.Size(234, 33);
            this.lbl總計.TabIndex = 2;
            this.lbl總計.Text = "NT$ 0元";
            // 
            // cmbBox醬包
            // 
            this.cmbBox醬包.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmbBox醬包.FormattingEnabled = true;
            this.cmbBox醬包.Location = new System.Drawing.Point(1040, 524);
            this.cmbBox醬包.Name = "cmbBox醬包";
            this.cmbBox醬包.Size = new System.Drawing.Size(126, 27);
            this.cmbBox醬包.TabIndex = 3;
            this.cmbBox醬包.SelectedIndexChanged += new System.EventHandler(this.cmbBox醬包_SelectedIndexChanged);
            // 
            // cmbBox配餐
            // 
            this.cmbBox配餐.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmbBox配餐.ForeColor = System.Drawing.Color.Black;
            this.cmbBox配餐.FormattingEnabled = true;
            this.cmbBox配餐.IntegralHeight = false;
            this.cmbBox配餐.ItemHeight = 16;
            this.cmbBox配餐.Location = new System.Drawing.Point(432, 693);
            this.cmbBox配餐.MaxDropDownItems = 5;
            this.cmbBox配餐.Name = "cmbBox配餐";
            this.cmbBox配餐.Size = new System.Drawing.Size(215, 24);
            this.cmbBox配餐.TabIndex = 5;
            this.cmbBox配餐.SelectedIndexChanged += new System.EventHandler(this.cmbBox配餐_SelectedIndexChanged);
            // 
            // cmbBox飲料
            // 
            this.cmbBox飲料.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmbBox飲料.FormattingEnabled = true;
            this.cmbBox飲料.IntegralHeight = false;
            this.cmbBox飲料.ItemHeight = 17;
            this.cmbBox飲料.Location = new System.Drawing.Point(649, 693);
            this.cmbBox飲料.MaxDropDownItems = 5;
            this.cmbBox飲料.Name = "cmbBox飲料";
            this.cmbBox飲料.Size = new System.Drawing.Size(156, 25);
            this.cmbBox飲料.TabIndex = 6;
            this.cmbBox飲料.SelectedIndexChanged += new System.EventHandler(this.cmbBox飲料_SelectedIndexChanged);
            // 
            // cmbBox加價購
            // 
            this.cmbBox加價購.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmbBox加價購.FormattingEnabled = true;
            this.cmbBox加價購.IntegralHeight = false;
            this.cmbBox加價購.Location = new System.Drawing.Point(853, 693);
            this.cmbBox加價購.MaxDropDownItems = 5;
            this.cmbBox加價購.Name = "cmbBox加價購";
            this.cmbBox加價購.Size = new System.Drawing.Size(152, 25);
            this.cmbBox加價購.TabIndex = 7;
            this.cmbBox加價購.SelectedIndexChanged += new System.EventHandler(this.cmbBox加價購_SelectedIndexChanged);
            // 
            // txtbox數量
            // 
            this.txtbox數量.Font = new System.Drawing.Font("新細明體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtbox數量.Location = new System.Drawing.Point(307, 693);
            this.txtbox數量.Multiline = true;
            this.txtbox數量.Name = "txtbox數量";
            this.txtbox數量.Size = new System.Drawing.Size(87, 39);
            this.txtbox數量.TabIndex = 8;
            this.txtbox數量.TextChanged += new System.EventHandler(this.txtbox數量_TextChanged);
            // 
            // btn加入訂單
            // 
            this.btn加入訂單.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn加入訂單.BackgroundImage")));
            this.btn加入訂單.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn加入訂單.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn加入訂單.FlatAppearance.BorderSize = 0;
            this.btn加入訂單.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn加入訂單.Location = new System.Drawing.Point(1046, 644);
            this.btn加入訂單.Name = "btn加入訂單";
            this.btn加入訂單.Size = new System.Drawing.Size(139, 117);
            this.btn加入訂單.TabIndex = 9;
            this.btn加入訂單.UseVisualStyleBackColor = true;
            this.btn加入訂單.Click += new System.EventHandler(this.btn加入訂單_Click);
            // 
            // btn支援
            // 
            this.btn支援.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn支援.BackgroundImage")));
            this.btn支援.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn支援.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn支援.FlatAppearance.BorderSize = 0;
            this.btn支援.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn支援.Location = new System.Drawing.Point(462, 47);
            this.btn支援.Name = "btn支援";
            this.btn支援.Size = new System.Drawing.Size(219, 56);
            this.btn支援.TabIndex = 25;
            this.btn支援.UseVisualStyleBackColor = true;
            this.btn支援.Click += new System.EventHandler(this.btn支援_Click);
            // 
            // listView商品展示
            // 
            this.listView商品展示.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView商品展示.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.listView商品展示.HideSelection = false;
            this.listView商品展示.Location = new System.Drawing.Point(41, 168);
            this.listView商品展示.Name = "listView商品展示";
            this.listView商品展示.Size = new System.Drawing.Size(847, 467);
            this.listView商品展示.TabIndex = 27;
            this.listView商品展示.UseCompatibleStateImageBehavior = false;
            this.listView商品展示.ItemActivate += new System.EventHandler(this.listView商品展示_ItemActivate);
            // 
            // imageList商品圖檔
            // 
            this.imageList商品圖檔.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList商品圖檔.ImageSize = new System.Drawing.Size(256, 256);
            this.imageList商品圖檔.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // chkBox購物袋
            // 
            this.chkBox購物袋.AutoSize = true;
            this.chkBox購物袋.BackColor = System.Drawing.Color.White;
            this.chkBox購物袋.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkBox購物袋.Location = new System.Drawing.Point(1041, 497);
            this.chkBox購物袋.Name = "chkBox購物袋";
            this.chkBox購物袋.Size = new System.Drawing.Size(127, 25);
            this.chkBox購物袋.TabIndex = 29;
            this.chkBox購物袋.Text = "購物袋(+2元)";
            this.chkBox購物袋.UseVisualStyleBackColor = false;
            this.chkBox購物袋.CheckedChanged += new System.EventHandler(this.chkBox購物袋_CheckedChanged);
            // 
            // btn維護系統
            // 
            this.btn維護系統.BackColor = System.Drawing.SystemColors.Control;
            this.btn維護系統.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn維護系統.BackgroundImage")));
            this.btn維護系統.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn維護系統.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn維護系統.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn維護系統.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn維護系統.Location = new System.Drawing.Point(1205, 774);
            this.btn維護系統.Name = "btn維護系統";
            this.btn維護系統.Size = new System.Drawing.Size(53, 48);
            this.btn維護系統.TabIndex = 30;
            this.btn維護系統.UseVisualStyleBackColor = false;
            this.btn維護系統.Click += new System.EventHandler(this.btn維護系統_Click);
            // 
            // btn會員系統
            // 
            this.btn會員系統.BackColor = System.Drawing.Color.White;
            this.btn會員系統.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn會員系統.BackgroundImage")));
            this.btn會員系統.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn會員系統.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn會員系統.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn會員系統.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn會員系統.Location = new System.Drawing.Point(1146, 774);
            this.btn會員系統.Name = "btn會員系統";
            this.btn會員系統.Size = new System.Drawing.Size(53, 48);
            this.btn會員系統.TabIndex = 31;
            this.btn會員系統.UseVisualStyleBackColor = false;
            this.btn會員系統.Click += new System.EventHandler(this.btn會員系統_Click);
            // 
            // lbl資訊
            // 
            this.lbl資訊.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl資訊.ForeColor = System.Drawing.Color.Black;
            this.lbl資訊.Location = new System.Drawing.Point(1057, 5);
            this.lbl資訊.Name = "lbl資訊";
            this.lbl資訊.Size = new System.Drawing.Size(92, 39);
            this.lbl資訊.TabIndex = 32;
            this.lbl資訊.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn登入
            // 
            this.btn登入.BackColor = System.Drawing.Color.Transparent;
            this.btn登入.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn登入.BackgroundImage")));
            this.btn登入.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn登入.FlatAppearance.BorderSize = 0;
            this.btn登入.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn登入.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn登入.Location = new System.Drawing.Point(1167, 12);
            this.btn登入.Name = "btn登入";
            this.btn登入.Size = new System.Drawing.Size(48, 29);
            this.btn登入.TabIndex = 33;
            this.btn登入.Text = "登入";
            this.btn登入.UseVisualStyleBackColor = false;
            this.btn登入.Click += new System.EventHandler(this.btn登入_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1142, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 39);
            this.label1.TabIndex = 34;
            this.label1.Text = "|";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxBC1
            // 
            this.groupBoxBC1.BackColor = System.Drawing.Color.White;
            this.groupBoxBC1.BorderColor = System.Drawing.Color.Transparent;
            this.groupBoxBC1.Controls.Add(this.radio外帶);
            this.groupBoxBC1.Controls.Add(this.radio內用);
            this.groupBoxBC1.Location = new System.Drawing.Point(1029, 449);
            this.groupBoxBC1.Name = "groupBoxBC1";
            this.groupBoxBC1.Size = new System.Drawing.Size(166, 32);
            this.groupBoxBC1.TabIndex = 28;
            this.groupBoxBC1.TabStop = false;
            // 
            // radio外帶
            // 
            this.radio外帶.AutoSize = true;
            this.radio外帶.BackColor = System.Drawing.Color.Transparent;
            this.radio外帶.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radio外帶.Location = new System.Drawing.Point(79, 4);
            this.radio外帶.Name = "radio外帶";
            this.radio外帶.Size = new System.Drawing.Size(60, 25);
            this.radio外帶.TabIndex = 1;
            this.radio外帶.TabStop = true;
            this.radio外帶.Text = "外帶";
            this.radio外帶.UseVisualStyleBackColor = false;
            // 
            // radio內用
            // 
            this.radio內用.AutoSize = true;
            this.radio內用.BackColor = System.Drawing.Color.Transparent;
            this.radio內用.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radio內用.Location = new System.Drawing.Point(11, 4);
            this.radio內用.Name = "radio內用";
            this.radio內用.Size = new System.Drawing.Size(60, 25);
            this.radio內用.TabIndex = 0;
            this.radio內用.TabStop = true;
            this.radio內用.Text = "內用";
            this.radio內用.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1260, 824);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn登入);
            this.Controls.Add(this.lbl資訊);
            this.Controls.Add(this.btn會員系統);
            this.Controls.Add(this.btn維護系統);
            this.Controls.Add(this.chkBox購物袋);
            this.Controls.Add(this.groupBoxBC1);
            this.Controls.Add(this.listView商品展示);
            this.Controls.Add(this.btn支援);
            this.Controls.Add(this.btn加入訂單);
            this.Controls.Add(this.txtbox數量);
            this.Controls.Add(this.cmbBox加價購);
            this.Controls.Add(this.cmbBox飲料);
            this.Controls.Add(this.cmbBox配餐);
            this.Controls.Add(this.cmbBox醬包);
            this.Controls.Add(this.lbl總計);
            this.Controls.Add(this.lbl小計);
            this.Controls.Add(this.btn結帳);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "咪咪貓點餐系統";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxBC1.ResumeLayout(false);
            this.groupBoxBC1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn結帳;
        private System.Windows.Forms.Label lbl小計;
        private System.Windows.Forms.Label lbl總計;
        private System.Windows.Forms.ComboBox cmbBox醬包;
        private System.Windows.Forms.ComboBox cmbBox配餐;
        private System.Windows.Forms.ComboBox cmbBox飲料;
        private System.Windows.Forms.ComboBox cmbBox加價購;
        private System.Windows.Forms.TextBox txtbox數量;
        private System.Windows.Forms.Button btn加入訂單;
        private System.Windows.Forms.RadioButton radio外帶;
        private System.Windows.Forms.RadioButton radio內用;
        private System.Windows.Forms.Button btn支援;
        private System.Windows.Forms.ListView listView商品展示;
        private System.Windows.Forms.ImageList imageList商品圖檔;
        private GrouboxAttribute.GroupBoxBC groupBoxBC1;
        private System.Windows.Forms.CheckBox chkBox購物袋;
        private System.Windows.Forms.Button btn維護系統;
        private System.Windows.Forms.Button btn會員系統;
        private System.Windows.Forms.Label lbl資訊;
        private System.Windows.Forms.Button btn登入;
        private System.Windows.Forms.Label label1;
    }
}

