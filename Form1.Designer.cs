namespace ADO.NET_HW_5
{
    partial class Form1
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
            this.grpBox_CountryAdd = new System.Windows.Forms.GroupBox();
            this.txtBox_Continent = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_AddRow = new System.Windows.Forms.Button();
            this.txtBox_CountryArea = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBox_ResidentsAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBox_CapitalName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_CountryName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtBox_TaskText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Execute = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpBox_CountryAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBox_CountryAdd
            // 
            this.grpBox_CountryAdd.Controls.Add(this.txtBox_Continent);
            this.grpBox_CountryAdd.Controls.Add(this.label5);
            this.grpBox_CountryAdd.Controls.Add(this.btn_AddRow);
            this.grpBox_CountryAdd.Controls.Add(this.txtBox_CountryArea);
            this.grpBox_CountryAdd.Controls.Add(this.label4);
            this.grpBox_CountryAdd.Controls.Add(this.txtBox_ResidentsAmount);
            this.grpBox_CountryAdd.Controls.Add(this.label3);
            this.grpBox_CountryAdd.Controls.Add(this.txtBox_CapitalName);
            this.grpBox_CountryAdd.Controls.Add(this.label2);
            this.grpBox_CountryAdd.Controls.Add(this.txtBox_CountryName);
            this.grpBox_CountryAdd.Controls.Add(this.label1);
            this.grpBox_CountryAdd.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grpBox_CountryAdd.ForeColor = System.Drawing.Color.Blue;
            this.grpBox_CountryAdd.Location = new System.Drawing.Point(13, 13);
            this.grpBox_CountryAdd.Name = "grpBox_CountryAdd";
            this.grpBox_CountryAdd.Size = new System.Drawing.Size(277, 355);
            this.grpBox_CountryAdd.TabIndex = 0;
            this.grpBox_CountryAdd.TabStop = false;
            this.grpBox_CountryAdd.Text = "Добавление страны";
            // 
            // txtBox_Continent
            // 
            this.txtBox_Continent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_Continent.Location = new System.Drawing.Point(10, 238);
            this.txtBox_Continent.Name = "txtBox_Continent";
            this.txtBox_Continent.Size = new System.Drawing.Size(229, 23);
            this.txtBox_Continent.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(7, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Континент(Название)";
            // 
            // btn_AddRow
            // 
            this.btn_AddRow.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_AddRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_AddRow.Location = new System.Drawing.Point(10, 285);
            this.btn_AddRow.Name = "btn_AddRow";
            this.btn_AddRow.Size = new System.Drawing.Size(131, 64);
            this.btn_AddRow.TabIndex = 8;
            this.btn_AddRow.Text = "Добавить";
            this.btn_AddRow.UseVisualStyleBackColor = true;
            this.btn_AddRow.Click += new System.EventHandler(this.btn_AddRow_Click);
            // 
            // txtBox_CountryArea
            // 
            this.txtBox_CountryArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_CountryArea.Location = new System.Drawing.Point(10, 184);
            this.txtBox_CountryArea.Name = "txtBox_CountryArea";
            this.txtBox_CountryArea.Size = new System.Drawing.Size(229, 23);
            this.txtBox_CountryArea.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(7, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Площадь страны";
            // 
            // txtBox_ResidentsAmount
            // 
            this.txtBox_ResidentsAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_ResidentsAmount.Location = new System.Drawing.Point(10, 138);
            this.txtBox_ResidentsAmount.Name = "txtBox_ResidentsAmount";
            this.txtBox_ResidentsAmount.Size = new System.Drawing.Size(229, 23);
            this.txtBox_ResidentsAmount.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(7, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Количество жителей страны";
            // 
            // txtBox_CapitalName
            // 
            this.txtBox_CapitalName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_CapitalName.Location = new System.Drawing.Point(10, 92);
            this.txtBox_CapitalName.Name = "txtBox_CapitalName";
            this.txtBox_CapitalName.Size = new System.Drawing.Size(229, 23);
            this.txtBox_CapitalName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(7, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Столица(Название)";
            // 
            // txtBox_CountryName
            // 
            this.txtBox_CountryName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_CountryName.Location = new System.Drawing.Point(10, 43);
            this.txtBox_CountryName.Name = "txtBox_CountryName";
            this.txtBox_CountryName.Size = new System.Drawing.Size(229, 23);
            this.txtBox_CountryName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Страна(Название)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(296, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Выберите задание";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(296, 298);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(125, 25);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtBox_TaskText
            // 
            this.txtBox_TaskText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_TaskText.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBox_TaskText.ForeColor = System.Drawing.Color.Blue;
            this.txtBox_TaskText.Location = new System.Drawing.Point(455, 298);
            this.txtBox_TaskText.Multiline = true;
            this.txtBox_TaskText.Name = "txtBox_TaskText";
            this.txtBox_TaskText.Size = new System.Drawing.Size(248, 70);
            this.txtBox_TaskText.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(452, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Задание";
            // 
            // btn_Execute
            // 
            this.btn_Execute.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Execute.ForeColor = System.Drawing.Color.Goldenrod;
            this.btn_Execute.Location = new System.Drawing.Point(296, 325);
            this.btn_Execute.Name = "btn_Execute";
            this.btn_Execute.Size = new System.Drawing.Size(122, 43);
            this.btn_Execute.TabIndex = 14;
            this.btn_Execute.Text = "Выполнить";
            this.btn_Execute.UseVisualStyleBackColor = true;
            this.btn_Execute.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(299, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(642, 261);
            this.dataGridView1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Execute);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBox_TaskText);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grpBox_CountryAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpBox_CountryAdd.ResumeLayout(false);
            this.grpBox_CountryAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBox_CountryAdd;
        private System.Windows.Forms.Button btn_AddRow;
        private System.Windows.Forms.TextBox txtBox_CountryArea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBox_ResidentsAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBox_CapitalName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_CountryName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_Continent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBox_TaskText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Execute;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.ComboBox comboBox1;
    }
}

