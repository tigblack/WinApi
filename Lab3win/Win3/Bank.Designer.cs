namespace Win3
{
    partial class Bank
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bank));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.sur_txt = new System.Windows.Forms.TextBox();
            this.sal_txt = new System.Windows.Forms.TextBox();
            this.ex_txt = new System.Windows.Forms.TextBox();
            this.con_int = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.save_btn = new System.Windows.Forms.Button();
            this.del_bnt = new System.Windows.Forms.Button();
            this.up_btn = new System.Windows.Forms.Button();
            this.clr_btn = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.op_cmb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.key_txt = new System.Windows.Forms.TextBox();
            this.ok_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-2, -4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(991, 553);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.clr_btn);
            this.tabPage1.Controls.Add(this.up_btn);
            this.tabPage1.Controls.Add(this.del_bnt);
            this.tabPage1.Controls.Add(this.save_btn);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.con_int);
            this.tabPage1.Controls.Add(this.ex_txt);
            this.tabPage1.Controls.Add(this.sal_txt);
            this.tabPage1.Controls.Add(this.sur_txt);
            this.tabPage1.Controls.Add(this.name_txt);
            this.tabPage1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(983, 524);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Clien";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.ok_btn);
            this.tabPage2.Controls.Add(this.key_txt);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.op_cmb);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(983, 524);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Search";
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(127, 33);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(100, 29);
            this.name_txt.TabIndex = 0;
            // 
            // sur_txt
            // 
            this.sur_txt.Location = new System.Drawing.Point(127, 130);
            this.sur_txt.Name = "sur_txt";
            this.sur_txt.Size = new System.Drawing.Size(100, 29);
            this.sur_txt.TabIndex = 1;
            // 
            // sal_txt
            // 
            this.sal_txt.Location = new System.Drawing.Point(405, 32);
            this.sal_txt.Name = "sal_txt";
            this.sal_txt.Size = new System.Drawing.Size(100, 29);
            this.sal_txt.TabIndex = 2;
            // 
            // ex_txt
            // 
            this.ex_txt.Location = new System.Drawing.Point(405, 130);
            this.ex_txt.Name = "ex_txt";
            this.ex_txt.Size = new System.Drawing.Size(100, 29);
            this.ex_txt.TabIndex = 3;
            // 
            // con_int
            // 
            this.con_int.Location = new System.Drawing.Point(671, 32);
            this.con_int.Name = "con_int";
            this.con_int.Size = new System.Drawing.Size(100, 29);
            this.con_int.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Salary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Expences";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(534, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Contribution";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 209);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(902, 235);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_btn.Location = new System.Drawing.Point(538, 130);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(75, 42);
            this.save_btn.TabIndex = 13;
            this.save_btn.Text = "save";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // del_bnt
            // 
            this.del_bnt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.del_bnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del_bnt.Location = new System.Drawing.Point(644, 130);
            this.del_bnt.Name = "del_bnt";
            this.del_bnt.Size = new System.Drawing.Size(75, 42);
            this.del_bnt.TabIndex = 14;
            this.del_bnt.Text = "delete";
            this.del_bnt.UseVisualStyleBackColor = false;
            this.del_bnt.Click += new System.EventHandler(this.del_bnt_Click);
            // 
            // up_btn
            // 
            this.up_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.up_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.up_btn.Location = new System.Drawing.Point(748, 130);
            this.up_btn.Name = "up_btn";
            this.up_btn.Size = new System.Drawing.Size(84, 42);
            this.up_btn.TabIndex = 15;
            this.up_btn.Text = "update";
            this.up_btn.UseVisualStyleBackColor = false;
            this.up_btn.Click += new System.EventHandler(this.up_btn_Click);
            // 
            // clr_btn
            // 
            this.clr_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.clr_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clr_btn.Location = new System.Drawing.Point(856, 130);
            this.clr_btn.Name = "clr_btn";
            this.clr_btn.Size = new System.Drawing.Size(75, 42);
            this.clr_btn.TabIndex = 16;
            this.clr_btn.Text = "clear";
            this.clr_btn.UseVisualStyleBackColor = false;
            this.clr_btn.Click += new System.EventHandler(this.clr_btn_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(42, 191);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(794, 248);
            this.dataGridView2.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "Search report";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 22);
            this.label7.TabIndex = 2;
            this.label7.Text = "Select column";
            // 
            // op_cmb
            // 
            this.op_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.op_cmb.FormattingEnabled = true;
            this.op_cmb.Items.AddRange(new object[] {
            "Name",
            "Surname",
            "Salary",
            "Expences",
            "Contribution"});
            this.op_cmb.Location = new System.Drawing.Point(208, 93);
            this.op_cmb.Name = "op_cmb";
            this.op_cmb.Size = new System.Drawing.Size(121, 30);
            this.op_cmb.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(384, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 22);
            this.label8.TabIndex = 4;
            this.label8.Text = "Key word";
            // 
            // key_txt
            // 
            this.key_txt.Location = new System.Drawing.Point(560, 93);
            this.key_txt.Name = "key_txt";
            this.key_txt.Size = new System.Drawing.Size(100, 29);
            this.key_txt.TabIndex = 5;
            // 
            // ok_btn
            // 
            this.ok_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ok_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ok_btn.Location = new System.Drawing.Point(761, 143);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(75, 31);
            this.ok_btn.TabIndex = 6;
            this.ok_btn.Text = "Ok";
            this.ok_btn.UseVisualStyleBackColor = false;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(856, 459);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 17;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(42, 445);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 40);
            this.button2.TabIndex = 18;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Bank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 536);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bank";
            this.Text = "Information";
            this.Load += new System.EventHandler(this.Bank_Load_1);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox con_int;
        private System.Windows.Forms.TextBox ex_txt;
        private System.Windows.Forms.TextBox sal_txt;
        private System.Windows.Forms.TextBox sur_txt;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button clr_btn;
        private System.Windows.Forms.Button up_btn;
        private System.Windows.Forms.Button del_bnt;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.TextBox key_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox op_cmb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

