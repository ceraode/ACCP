namespace 体检
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblMakenew = new System.Windows.Forms.Label();
            this.txtHealthName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvHealthList = new System.Windows.Forms.DataGridView();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cboItems = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboSets = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSetPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSetName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHealthList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOK);
            this.groupBox2.Controls.Add(this.lblMakenew);
            this.groupBox2.Controls.Add(this.txtHealthName);
            this.groupBox2.Location = new System.Drawing.Point(13, 12);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(635, 85);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "新建套餐";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(344, 36);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 29);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "添加";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // lblMakenew
            // 
            this.lblMakenew.AutoSize = true;
            this.lblMakenew.Font = new System.Drawing.Font("宋体", 10.5F);
            this.lblMakenew.Location = new System.Drawing.Point(51, 44);
            this.lblMakenew.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMakenew.Name = "lblMakenew";
            this.lblMakenew.Size = new System.Drawing.Size(80, 18);
            this.lblMakenew.TabIndex = 5;
            this.lblMakenew.Text = "套餐名称";
            // 
            // txtHealthName
            // 
            this.txtHealthName.Location = new System.Drawing.Point(140, 38);
            this.txtHealthName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtHealthName.Name = "txtHealthName";
            this.txtHealthName.Size = new System.Drawing.Size(163, 25);
            this.txtHealthName.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvHealthList);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.cboItems);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboSets);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblSetPrice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblSetName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(13, 103);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(635, 370);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "检查套餐维护";
            // 
            // dgvHealthList
            // 
            this.dgvHealthList.AllowUserToAddRows = false;
            this.dgvHealthList.AllowUserToResizeRows = false;
            this.dgvHealthList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHealthList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHealthList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemName,
            this.description,
            this.price});
            this.dgvHealthList.Location = new System.Drawing.Point(8, 135);
            this.dgvHealthList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvHealthList.Name = "dgvHealthList";
            this.dgvHealthList.RowTemplate.Height = 23;
            this.dgvHealthList.Size = new System.Drawing.Size(584, 211);
            this.dgvHealthList.TabIndex = 8;
            // 
            // itemName
            // 
            this.itemName.DataPropertyName = "Name";
            this.itemName.HeaderText = "项目名";
            this.itemName.Name = "itemName";
            this.itemName.ReadOnly = true;
            // 
            // description
            // 
            this.description.DataPropertyName = "Description";
            this.description.HeaderText = "描述";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // price
            // 
            this.price.DataPropertyName = "Price";
            this.price.HeaderText = "价格";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(452, 66);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(100, 29);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(344, 66);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 29);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cboItems
            // 
            this.cboItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboItems.FormattingEnabled = true;
            this.cboItems.Items.AddRange(new object[] {
            "请选择",
            "身高",
            "体重",
            "视力",
            "听力",
            "肝功能",
            "B超",
            "心电图",
            "血压",
            "血常规"});
            this.cboItems.Location = new System.Drawing.Point(432, 29);
            this.cboItems.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboItems.Name = "cboItems";
            this.cboItems.Size = new System.Drawing.Size(160, 25);
            this.cboItems.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "检查项目";
            // 
            // cboSets
            // 
            this.cboSets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSets.FormattingEnabled = true;
            this.cboSets.Location = new System.Drawing.Point(143, 29);
            this.cboSets.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboSets.Name = "cboSets";
            this.cboSets.Size = new System.Drawing.Size(160, 25);
            this.cboSets.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "套餐列表";
            // 
            // lblSetPrice
            // 
            this.lblSetPrice.AutoSize = true;
            this.lblSetPrice.Location = new System.Drawing.Point(397, 114);
            this.lblSetPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSetPrice.Name = "lblSetPrice";
            this.lblSetPrice.Size = new System.Drawing.Size(62, 18);
            this.lblSetPrice.TabIndex = 4;
            this.lblSetPrice.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "价格：";
            // 
            // lblSetName
            // 
            this.lblSetName.AutoSize = true;
            this.lblSetName.Location = new System.Drawing.Point(143, 114);
            this.lblSetName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSetName.Name = "lblSetName";
            this.lblSetName.Size = new System.Drawing.Size(62, 18);
            this.lblSetName.TabIndex = 2;
            this.lblSetName.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "套餐名：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 478);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHealthList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblMakenew;
        private System.Windows.Forms.TextBox txtHealthName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvHealthList;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cboItems;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboSets;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSetPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSetName;
        private System.Windows.Forms.Label label1;
    }
}

