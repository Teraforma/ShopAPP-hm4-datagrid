namespace ShopApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Merch_dataGridView = new System.Windows.Forms.DataGridView();
            this.NameMerch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOfOrigin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackagingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdditionaInf1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdditionaInf2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdditionaInf3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.switch_button = new System.Windows.Forms.Button();
            this.Name_textbox = new System.Windows.Forms.TextBox();
            this.ProducedDate_textbox = new System.Windows.Forms.TextBox();
            this.CofOrigin_textbox = new System.Windows.Forms.TextBox();
            this.Descrip_textBox = new System.Windows.Forms.TextBox();
            this.Price_textBox = new System.Windows.Forms.TextBox();
            this.AditinalInfo2_textBox = new System.Windows.Forms.TextBox();
            this.AditinalInfo1_textBox = new System.Windows.Forms.TextBox();
            this.Add_button = new System.Windows.Forms.Button();
            this.Autors_textBox = new System.Windows.Forms.TextBox();
            this.Delete_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Merch_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Merch_dataGridView
            // 
            this.Merch_dataGridView.AllowUserToAddRows = false;
            this.Merch_dataGridView.AllowUserToDeleteRows = false;
            this.Merch_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Merch_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameMerch,
            this.Price,
            this.cOfOrigin,
            this.PackagingDate,
            this.Description,
            this.AdditionaInf1,
            this.AdditionaInf2,
            this.AdditionaInf3});
            this.Merch_dataGridView.Location = new System.Drawing.Point(12, 19);
            this.Merch_dataGridView.Name = "Merch_dataGridView";
            this.Merch_dataGridView.ReadOnly = true;
            this.Merch_dataGridView.RowHeadersWidth = 72;
            this.Merch_dataGridView.RowTemplate.Height = 37;
            this.Merch_dataGridView.Size = new System.Drawing.Size(1434, 874);
            this.Merch_dataGridView.TabIndex = 0;
            this.Merch_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.Merch_dataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Merch_dataGridView_RowHeaderMouseClick);
            // 
            // NameMerch
            // 
            this.NameMerch.HeaderText = "Name";
            this.NameMerch.MinimumWidth = 9;
            this.NameMerch.Name = "NameMerch";
            this.NameMerch.ReadOnly = true;
            this.NameMerch.Width = 120;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 9;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 120;
            // 
            // cOfOrigin
            // 
            this.cOfOrigin.HeaderText = "Origin";
            this.cOfOrigin.MinimumWidth = 9;
            this.cOfOrigin.Name = "cOfOrigin";
            this.cOfOrigin.ReadOnly = true;
            this.cOfOrigin.Width = 120;
            // 
            // PackagingDate
            // 
            this.PackagingDate.HeaderText = "Packaging D";
            this.PackagingDate.MinimumWidth = 9;
            this.PackagingDate.Name = "PackagingDate";
            this.PackagingDate.ReadOnly = true;
            this.PackagingDate.Width = 175;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 9;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 300;
            // 
            // AdditionaInf1
            // 
            this.AdditionaInf1.HeaderText = "Additional info1";
            this.AdditionaInf1.MinimumWidth = 9;
            this.AdditionaInf1.Name = "AdditionaInf1";
            this.AdditionaInf1.ReadOnly = true;
            this.AdditionaInf1.Width = 175;
            // 
            // AdditionaInf2
            // 
            this.AdditionaInf2.HeaderText = "Additional info2";
            this.AdditionaInf2.MinimumWidth = 9;
            this.AdditionaInf2.Name = "AdditionaInf2";
            this.AdditionaInf2.ReadOnly = true;
            this.AdditionaInf2.Width = 175;
            // 
            // AdditionaInf3
            // 
            this.AdditionaInf3.HeaderText = "Additional info3";
            this.AdditionaInf3.MinimumWidth = 9;
            this.AdditionaInf3.Name = "AdditionaInf3";
            this.AdditionaInf3.ReadOnly = true;
            this.AdditionaInf3.Width = 175;
            // 
            // switch_button
            // 
            this.switch_button.Location = new System.Drawing.Point(1506, 19);
            this.switch_button.Name = "switch_button";
            this.switch_button.Size = new System.Drawing.Size(187, 43);
            this.switch_button.TabIndex = 1;
            this.switch_button.Text = "Switch";
            this.switch_button.UseVisualStyleBackColor = true;
            this.switch_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Name_textbox
            // 
            this.Name_textbox.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name_textbox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Name_textbox.Location = new System.Drawing.Point(1506, 84);
            this.Name_textbox.Name = "Name_textbox";
            this.Name_textbox.Size = new System.Drawing.Size(175, 48);
            this.Name_textbox.TabIndex = 2;
            this.Name_textbox.Text = "Name";
            this.Name_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Name_textbox.TextChanged += new System.EventHandler(this.name_textbox_TextChanged);
            this.Name_textbox.Enter += new System.EventHandler(this.Name_textbox_Enter);
            this.Name_textbox.Leave += new System.EventHandler(this.Name_textbox_Leave);
            // 
            // ProducedDate_textbox
            // 
            this.ProducedDate_textbox.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProducedDate_textbox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.ProducedDate_textbox.Location = new System.Drawing.Point(1506, 153);
            this.ProducedDate_textbox.Name = "ProducedDate_textbox";
            this.ProducedDate_textbox.Size = new System.Drawing.Size(175, 48);
            this.ProducedDate_textbox.TabIndex = 3;
            this.ProducedDate_textbox.Text = "Produced";
            this.ProducedDate_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProducedDate_textbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.ProducedDate_textbox.Enter += new System.EventHandler(this.ProducedDate_textbox_Enter);
            this.ProducedDate_textbox.Leave += new System.EventHandler(this.ProducedDate_textbox_Leave);
            // 
            // CofOrigin_textbox
            // 
            this.CofOrigin_textbox.Font = new System.Drawing.Font("Segoe UI", 12.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CofOrigin_textbox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.CofOrigin_textbox.Location = new System.Drawing.Point(1506, 230);
            this.CofOrigin_textbox.Name = "CofOrigin_textbox";
            this.CofOrigin_textbox.Size = new System.Drawing.Size(175, 47);
            this.CofOrigin_textbox.TabIndex = 4;
            this.CofOrigin_textbox.Text = "Origin";
            this.CofOrigin_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CofOrigin_textbox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.CofOrigin_textbox.Enter += new System.EventHandler(this.CofOrigin_textbox_Enter);
            this.CofOrigin_textbox.Leave += new System.EventHandler(this.CofOrigin_textbox_Leave);
            // 
            // Descrip_textBox
            // 
            this.Descrip_textBox.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Descrip_textBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Descrip_textBox.Location = new System.Drawing.Point(1506, 308);
            this.Descrip_textBox.Name = "Descrip_textBox";
            this.Descrip_textBox.Size = new System.Drawing.Size(175, 48);
            this.Descrip_textBox.TabIndex = 5;
            this.Descrip_textBox.Text = "Description";
            this.Descrip_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Descrip_textBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.Descrip_textBox.Enter += new System.EventHandler(this.Descrip_textBox_Enter);
            this.Descrip_textBox.Leave += new System.EventHandler(this.Descrip_textBox_Leave);
            // 
            // Price_textBox
            // 
            this.Price_textBox.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Price_textBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Price_textBox.Location = new System.Drawing.Point(1506, 388);
            this.Price_textBox.Name = "Price_textBox";
            this.Price_textBox.Size = new System.Drawing.Size(175, 48);
            this.Price_textBox.TabIndex = 6;
            this.Price_textBox.Text = "Price";
            this.Price_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Price_textBox.Enter += new System.EventHandler(this.Price_textBox_Enter);
            this.Price_textBox.Leave += new System.EventHandler(this.Price_textBox_Leave);
            // 
            // AditinalInfo2_textBox
            // 
            this.AditinalInfo2_textBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.AditinalInfo2_textBox.Location = new System.Drawing.Point(1720, 195);
            this.AditinalInfo2_textBox.Name = "AditinalInfo2_textBox";
            this.AditinalInfo2_textBox.Size = new System.Drawing.Size(175, 35);
            this.AditinalInfo2_textBox.TabIndex = 7;
            this.AditinalInfo2_textBox.Text = "PerKilo/PerPiece";
            this.AditinalInfo2_textBox.Enter += new System.EventHandler(this.AditinalInfo2_textBox_Enter);
            this.AditinalInfo2_textBox.Leave += new System.EventHandler(this.AditinalInfo2_textBox_Leave);
            // 
            // AditinalInfo1_textBox
            // 
            this.AditinalInfo1_textBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.AditinalInfo1_textBox.Location = new System.Drawing.Point(1720, 123);
            this.AditinalInfo1_textBox.Name = "AditinalInfo1_textBox";
            this.AditinalInfo1_textBox.Size = new System.Drawing.Size(175, 35);
            this.AditinalInfo1_textBox.TabIndex = 8;
            this.AditinalInfo1_textBox.Text = "Fresh by";
            this.AditinalInfo1_textBox.TextChanged += new System.EventHandler(this.aditinalInfo1_textBox_TextChanged);
            this.AditinalInfo1_textBox.Enter += new System.EventHandler(this.AditinalInfo1_textBox_Enter);
            this.AditinalInfo1_textBox.Leave += new System.EventHandler(this.AditinalInfo1_textBox_Leave);
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(1740, 23);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(131, 40);
            this.Add_button.TabIndex = 11;
            this.Add_button.Text = "Add";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Autors_textBox
            // 
            this.Autors_textBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Autors_textBox.Location = new System.Drawing.Point(1720, 268);
            this.Autors_textBox.Name = "Autors_textBox";
            this.Autors_textBox.Size = new System.Drawing.Size(175, 35);
            this.Autors_textBox.TabIndex = 12;
            this.Autors_textBox.Text = "Autors";
            this.Autors_textBox.Enter += new System.EventHandler(this.Autors_textBox_Enter);
            this.Autors_textBox.Leave += new System.EventHandler(this.Autors_textBox_Leave);
            // 
            // Delete_Button
            // 
            this.Delete_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Delete_Button.BackgroundImage")));
            this.Delete_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Delete_Button.Location = new System.Drawing.Point(1492, 762);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(169, 115);
            this.Delete_Button.TabIndex = 13;
            this.Delete_Button.UseVisualStyleBackColor = true;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1927, 909);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.Autors_textBox);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.AditinalInfo1_textBox);
            this.Controls.Add(this.AditinalInfo2_textBox);
            this.Controls.Add(this.Price_textBox);
            this.Controls.Add(this.Descrip_textBox);
            this.Controls.Add(this.CofOrigin_textbox);
            this.Controls.Add(this.ProducedDate_textbox);
            this.Controls.Add(this.Name_textbox);
            this.Controls.Add(this.switch_button);
            this.Controls.Add(this.Merch_dataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Merch_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView Merch_dataGridView;
        private Button switch_button;
        private TextBox Name_textbox;
        private TextBox ProducedDate_textbox;
        private TextBox CofOrigin_textbox;
        private TextBox Descrip_textBox;
        private TextBox Price_textBox;
        private TextBox AditinalInfo2_textBox;
        private TextBox AditinalInfo1_textBox;
        private Button Add_button;
        private TextBox Autors_textBox;
        private DataGridViewTextBoxColumn addInfo3;
        private DataGridViewTextBoxColumn NameMerch;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn cOfOrigin;
        private DataGridViewTextBoxColumn PackagingDate;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn AdditionaInf1;
        private DataGridViewTextBoxColumn AdditionaInf2;
        private DataGridViewTextBoxColumn AdditionaInf3;
        private Button Delete_Button;
    }
}