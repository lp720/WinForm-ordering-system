namespace WindowsFormsApp1
{
    partial class Member
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Member));
            this.groupBoxBC2 = new GrouboxAttribute.GroupBoxBC(this.components);
            this.listBox搜尋結果 = new System.Windows.Forms.ListBox();
            this.dtp生日結束時間 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dtp生日起始時間 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBox關鍵字搜尋 = new System.Windows.Forms.TextBox();
            this.btn搜尋 = new System.Windows.Forms.Button();
            this.cbox欄位搜尋 = new System.Windows.Forms.ComboBox();
            this.groupBoxBC1 = new GrouboxAttribute.GroupBoxBC(this.components);
            this.btn清空欄位 = new System.Windows.Forms.Button();
            this.btn刪除資料 = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.btn新增資料 = new System.Windows.Forms.Button();
            this.dtp生日 = new System.Windows.Forms.DateTimePicker();
            this.btn修改資料 = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btn資料搜尋 = new System.Windows.Forms.Button();
            this.txt地址 = new System.Windows.Forms.TextBox();
            this.txt電話 = new System.Windows.Forms.TextBox();
            this.txt姓名 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxBC2.SuspendLayout();
            this.groupBoxBC1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxBC2
            // 
            this.groupBoxBC2.BackColor = System.Drawing.Color.Black;
            this.groupBoxBC2.BorderColor = System.Drawing.Color.Transparent;
            this.groupBoxBC2.Controls.Add(this.listBox搜尋結果);
            this.groupBoxBC2.Controls.Add(this.dtp生日結束時間);
            this.groupBoxBC2.Controls.Add(this.label9);
            this.groupBoxBC2.Controls.Add(this.dtp生日起始時間);
            this.groupBoxBC2.Controls.Add(this.label10);
            this.groupBoxBC2.Controls.Add(this.label14);
            this.groupBoxBC2.Controls.Add(this.label12);
            this.groupBoxBC2.Controls.Add(this.label13);
            this.groupBoxBC2.Controls.Add(this.txtBox關鍵字搜尋);
            this.groupBoxBC2.Controls.Add(this.btn搜尋);
            this.groupBoxBC2.Controls.Add(this.cbox欄位搜尋);
            this.groupBoxBC2.Location = new System.Drawing.Point(423, -1);
            this.groupBoxBC2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxBC2.Name = "groupBoxBC2";
            this.groupBoxBC2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxBC2.Size = new System.Drawing.Size(333, 679);
            this.groupBoxBC2.TabIndex = 42;
            this.groupBoxBC2.TabStop = false;
            // 
            // listBox搜尋結果
            // 
            this.listBox搜尋結果.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox搜尋結果.FormattingEnabled = true;
            this.listBox搜尋結果.ItemHeight = 20;
            this.listBox搜尋結果.Location = new System.Drawing.Point(11, 399);
            this.listBox搜尋結果.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox搜尋結果.Name = "listBox搜尋結果";
            this.listBox搜尋結果.Size = new System.Drawing.Size(308, 264);
            this.listBox搜尋結果.TabIndex = 11;
            this.listBox搜尋結果.SelectedIndexChanged += new System.EventHandler(this.listBox搜尋結果_SelectedIndexChanged);
            // 
            // dtp生日結束時間
            // 
            this.dtp生日結束時間.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp生日結束時間.Location = new System.Drawing.Point(12, 325);
            this.dtp生日結束時間.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp生日結束時間.Name = "dtp生日結束時間";
            this.dtp生日結束時間.Size = new System.Drawing.Size(272, 31);
            this.dtp生日結束時間.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(7, 12);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(208, 27);
            this.label9.TabIndex = 0;
            this.label9.Text = "欄位關鍵字搜尋";
            // 
            // dtp生日起始時間
            // 
            this.dtp生日起始時間.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp生日起始時間.Location = new System.Drawing.Point(12, 252);
            this.dtp生日起始時間.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp生日起始時間.Name = "dtp生日起始時間";
            this.dtp生日起始時間.Size = new System.Drawing.Size(272, 31);
            this.dtp生日起始時間.TabIndex = 9;
            this.dtp生日起始時間.Value = new System.DateTime(1940, 1, 1, 11, 40, 0, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(7, 182);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 27);
            this.label10.TabIndex = 1;
            this.label10.Text = "生日區間";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(7, 298);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 20);
            this.label14.TabIndex = 8;
            this.label14.Text = "到";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(7, 368);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 27);
            this.label12.TabIndex = 3;
            this.label12.Text = "搜尋結果";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(7, 222);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 20);
            this.label13.TabIndex = 7;
            this.label13.Text = "從";
            // 
            // txtBox關鍵字搜尋
            // 
            this.txtBox關鍵字搜尋.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBox關鍵字搜尋.Location = new System.Drawing.Point(7, 69);
            this.txtBox關鍵字搜尋.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBox關鍵字搜尋.Multiline = true;
            this.txtBox關鍵字搜尋.Name = "txtBox關鍵字搜尋";
            this.txtBox關鍵字搜尋.Size = new System.Drawing.Size(141, 36);
            this.txtBox關鍵字搜尋.TabIndex = 4;
            // 
            // btn搜尋
            // 
            this.btn搜尋.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn搜尋.Location = new System.Drawing.Point(83, 114);
            this.btn搜尋.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn搜尋.Name = "btn搜尋";
            this.btn搜尋.Size = new System.Drawing.Size(152, 61);
            this.btn搜尋.TabIndex = 6;
            this.btn搜尋.Text = "搜尋";
            this.btn搜尋.UseVisualStyleBackColor = true;
            this.btn搜尋.Click += new System.EventHandler(this.btn搜尋_Click);
            // 
            // cbox欄位搜尋
            // 
            this.cbox欄位搜尋.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox欄位搜尋.FormattingEnabled = true;
            this.cbox欄位搜尋.Location = new System.Drawing.Point(156, 76);
            this.cbox欄位搜尋.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbox欄位搜尋.Name = "cbox欄位搜尋";
            this.cbox欄位搜尋.Size = new System.Drawing.Size(163, 28);
            this.cbox欄位搜尋.TabIndex = 5;
            // 
            // groupBoxBC1
            // 
            this.groupBoxBC1.BackColor = System.Drawing.Color.Black;
            this.groupBoxBC1.BorderColor = System.Drawing.Color.Transparent;
            this.groupBoxBC1.Controls.Add(this.btn清空欄位);
            this.groupBoxBC1.Controls.Add(this.btn刪除資料);
            this.groupBoxBC1.Controls.Add(this.lblID);
            this.groupBoxBC1.Controls.Add(this.btn新增資料);
            this.groupBoxBC1.Controls.Add(this.dtp生日);
            this.groupBoxBC1.Controls.Add(this.btn修改資料);
            this.groupBoxBC1.Controls.Add(this.txtEmail);
            this.groupBoxBC1.Controls.Add(this.btn資料搜尋);
            this.groupBoxBC1.Controls.Add(this.txt地址);
            this.groupBoxBC1.Controls.Add(this.txt電話);
            this.groupBoxBC1.Controls.Add(this.txt姓名);
            this.groupBoxBC1.Controls.Add(this.label7);
            this.groupBoxBC1.Controls.Add(this.label8);
            this.groupBoxBC1.Controls.Add(this.label4);
            this.groupBoxBC1.Controls.Add(this.label3);
            this.groupBoxBC1.Controls.Add(this.label2);
            this.groupBoxBC1.Controls.Add(this.label1);
            this.groupBoxBC1.Location = new System.Drawing.Point(0, 0);
            this.groupBoxBC1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxBC1.Name = "groupBoxBC1";
            this.groupBoxBC1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxBC1.Size = new System.Drawing.Size(423, 684);
            this.groupBoxBC1.TabIndex = 25;
            this.groupBoxBC1.TabStop = false;
            // 
            // btn清空欄位
            // 
            this.btn清空欄位.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn清空欄位.Location = new System.Drawing.Point(221, 410);
            this.btn清空欄位.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn清空欄位.Name = "btn清空欄位";
            this.btn清空欄位.Size = new System.Drawing.Size(180, 74);
            this.btn清空欄位.TabIndex = 29;
            this.btn清空欄位.Text = "清空欄位";
            this.btn清空欄位.UseVisualStyleBackColor = true;
            this.btn清空欄位.Click += new System.EventHandler(this.btn清空欄位_Click);
            // 
            // btn刪除資料
            // 
            this.btn刪除資料.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn刪除資料.Location = new System.Drawing.Point(127, 574);
            this.btn刪除資料.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn刪除資料.Name = "btn刪除資料";
            this.btn刪除資料.Size = new System.Drawing.Size(180, 74);
            this.btn刪除資料.TabIndex = 28;
            this.btn刪除資料.Text = "刪除資料";
            this.btn刪除資料.UseVisualStyleBackColor = true;
            this.btn刪除資料.Click += new System.EventHandler(this.btn刪除資料_Click);
            // 
            // lblID
            // 
            this.lblID.BackColor = System.Drawing.Color.Black;
            this.lblID.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(85, 12);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(139, 28);
            this.lblID.TabIndex = 41;
            // 
            // btn新增資料
            // 
            this.btn新增資料.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn新增資料.Location = new System.Drawing.Point(221, 492);
            this.btn新增資料.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn新增資料.Name = "btn新增資料";
            this.btn新增資料.Size = new System.Drawing.Size(180, 74);
            this.btn新增資料.TabIndex = 27;
            this.btn新增資料.Text = "新增資料";
            this.btn新增資料.UseVisualStyleBackColor = true;
            this.btn新增資料.Click += new System.EventHandler(this.btn新增資料_Click_1);
            // 
            // dtp生日
            // 
            this.dtp生日.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp生日.Location = new System.Drawing.Point(85, 366);
            this.dtp生日.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp生日.Name = "dtp生日";
            this.dtp生日.Size = new System.Drawing.Size(329, 31);
            this.dtp生日.TabIndex = 40;
            // 
            // btn修改資料
            // 
            this.btn修改資料.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn修改資料.Location = new System.Drawing.Point(33, 492);
            this.btn修改資料.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn修改資料.Name = "btn修改資料";
            this.btn修改資料.Size = new System.Drawing.Size(180, 74);
            this.btn修改資料.TabIndex = 26;
            this.btn修改資料.Text = "修改資料";
            this.btn修改資料.UseVisualStyleBackColor = true;
            this.btn修改資料.Click += new System.EventHandler(this.btn修改資料_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEmail.Location = new System.Drawing.Point(85, 288);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(329, 40);
            this.txtEmail.TabIndex = 39;
            // 
            // btn資料搜尋
            // 
            this.btn資料搜尋.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn資料搜尋.Location = new System.Drawing.Point(33, 410);
            this.btn資料搜尋.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn資料搜尋.Name = "btn資料搜尋";
            this.btn資料搜尋.Size = new System.Drawing.Size(180, 74);
            this.btn資料搜尋.TabIndex = 25;
            this.btn資料搜尋.Text = "資料搜尋";
            this.btn資料搜尋.UseVisualStyleBackColor = true;
            this.btn資料搜尋.Click += new System.EventHandler(this.btn資料搜尋_Click);
            // 
            // txt地址
            // 
            this.txt地址.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt地址.Location = new System.Drawing.Point(85, 214);
            this.txt地址.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt地址.Multiline = true;
            this.txt地址.Name = "txt地址";
            this.txt地址.Size = new System.Drawing.Size(329, 39);
            this.txt地址.TabIndex = 38;
            // 
            // txt電話
            // 
            this.txt電話.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt電話.Location = new System.Drawing.Point(85, 135);
            this.txt電話.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt電話.Multiline = true;
            this.txt電話.Name = "txt電話";
            this.txt電話.Size = new System.Drawing.Size(329, 39);
            this.txt電話.TabIndex = 37;
            // 
            // txt姓名
            // 
            this.txt姓名.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt姓名.Location = new System.Drawing.Point(85, 68);
            this.txt姓名.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt姓名.Multiline = true;
            this.txt姓名.Name = "txt姓名";
            this.txt姓名.Size = new System.Drawing.Size(329, 36);
            this.txt姓名.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 368);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 30);
            this.label7.TabIndex = 35;
            this.label7.Text = "生日";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(-1, 292);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 30);
            this.label8.TabIndex = 34;
            this.label8.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 214);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 30);
            this.label4.TabIndex = 33;
            this.label4.Text = "地址";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 30);
            this.label3.TabIndex = 32;
            this.label3.Text = "電話";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 30);
            this.label2.TabIndex = 31;
            this.label2.Text = "姓名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 30);
            this.label1.TabIndex = 30;
            this.label1.Text = "ID";
            // 
            // Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 678);
            this.Controls.Add(this.groupBoxBC2);
            this.Controls.Add(this.groupBoxBC1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Member";
            this.Text = "會員系統";
            this.Load += new System.EventHandler(this.Member_Load);
            this.groupBoxBC2.ResumeLayout(false);
            this.groupBoxBC2.PerformLayout();
            this.groupBoxBC1.ResumeLayout(false);
            this.groupBoxBC1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBox搜尋結果;
        private System.Windows.Forms.DateTimePicker dtp生日結束時間;
        private System.Windows.Forms.DateTimePicker dtp生日起始時間;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn搜尋;
        private System.Windows.Forms.ComboBox cbox欄位搜尋;
        private System.Windows.Forms.TextBox txtBox關鍵字搜尋;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private GrouboxAttribute.GroupBoxBC groupBoxBC1;
        private System.Windows.Forms.Button btn清空欄位;
        private System.Windows.Forms.Button btn刪除資料;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btn新增資料;
        private System.Windows.Forms.DateTimePicker dtp生日;
        private System.Windows.Forms.Button btn修改資料;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btn資料搜尋;
        private System.Windows.Forms.TextBox txt地址;
        private System.Windows.Forms.TextBox txt電話;
        private System.Windows.Forms.TextBox txt姓名;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private GrouboxAttribute.GroupBoxBC groupBoxBC2;
    }
}