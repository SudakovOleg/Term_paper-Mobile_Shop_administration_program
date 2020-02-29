namespace MobilShopNet
{
    partial class WindowOfShop
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
            this.ShopInfoBox = new System.Windows.Forms.GroupBox();
            this.InfoTable = new System.Windows.Forms.TableLayoutPanel();
            this.NameLbl = new System.Windows.Forms.Label();
            this.PhoneLbl = new System.Windows.Forms.Label();
            this.EmailLbl = new System.Windows.Forms.Label();
            this.lblForName = new System.Windows.Forms.Label();
            this.lblForBoss = new System.Windows.Forms.Label();
            this.lblForPhone = new System.Windows.Forms.Label();
            this.lblForEmail = new System.Windows.Forms.Label();
            this.BossLbl = new System.Windows.Forms.Label();
            this.btmDeleteShop = new System.Windows.Forms.Button();
            this.btmAddProduct = new System.Windows.Forms.Button();
            this.btmDeleteProduct = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.ListView();
            this.ShopInfoBox.SuspendLayout();
            this.InfoTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShopInfoBox
            // 
            this.ShopInfoBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShopInfoBox.Controls.Add(this.InfoTable);
            this.ShopInfoBox.Location = new System.Drawing.Point(12, 12);
            this.ShopInfoBox.Name = "ShopInfoBox";
            this.ShopInfoBox.Size = new System.Drawing.Size(277, 154);
            this.ShopInfoBox.TabIndex = 0;
            this.ShopInfoBox.TabStop = false;
            this.ShopInfoBox.Text = "Информация";
            // 
            // InfoTable
            // 
            this.InfoTable.ColumnCount = 2;
            this.InfoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.71698F));
            this.InfoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.28302F));
            this.InfoTable.Controls.Add(this.NameLbl, 0, 0);
            this.InfoTable.Controls.Add(this.PhoneLbl, 0, 2);
            this.InfoTable.Controls.Add(this.EmailLbl, 0, 3);
            this.InfoTable.Controls.Add(this.lblForName, 1, 0);
            this.InfoTable.Controls.Add(this.lblForBoss, 1, 1);
            this.InfoTable.Controls.Add(this.lblForPhone, 1, 2);
            this.InfoTable.Controls.Add(this.lblForEmail, 1, 3);
            this.InfoTable.Controls.Add(this.BossLbl, 0, 1);
            this.InfoTable.Location = new System.Drawing.Point(6, 19);
            this.InfoTable.Name = "InfoTable";
            this.InfoTable.RowCount = 4;
            this.InfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.01695F));
            this.InfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.98305F));
            this.InfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.InfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.InfoTable.Size = new System.Drawing.Size(271, 129);
            this.InfoTable.TabIndex = 1;
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLbl.Location = new System.Drawing.Point(3, 0);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(72, 17);
            this.NameLbl.TabIndex = 0;
            this.NameLbl.Text = "Название";
            // 
            // PhoneLbl
            // 
            this.PhoneLbl.AutoSize = true;
            this.PhoneLbl.Location = new System.Drawing.Point(3, 86);
            this.PhoneLbl.Name = "PhoneLbl";
            this.PhoneLbl.Size = new System.Drawing.Size(52, 13);
            this.PhoneLbl.TabIndex = 2;
            this.PhoneLbl.Text = "Телефон";
            // 
            // EmailLbl
            // 
            this.EmailLbl.AutoSize = true;
            this.EmailLbl.Location = new System.Drawing.Point(3, 107);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(37, 13);
            this.EmailLbl.TabIndex = 3;
            this.EmailLbl.Text = "Почта";
            // 
            // lblForName
            // 
            this.lblForName.AutoSize = true;
            this.lblForName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblForName.Location = new System.Drawing.Point(97, 0);
            this.lblForName.Name = "lblForName";
            this.lblForName.Size = new System.Drawing.Size(46, 17);
            this.lblForName.TabIndex = 4;
            this.lblForName.Text = "label5";
            // 
            // lblForBoss
            // 
            this.lblForBoss.AutoSize = true;
            this.lblForBoss.Location = new System.Drawing.Point(97, 53);
            this.lblForBoss.Name = "lblForBoss";
            this.lblForBoss.Size = new System.Drawing.Size(35, 13);
            this.lblForBoss.TabIndex = 5;
            this.lblForBoss.Text = "label6";
            // 
            // lblForPhone
            // 
            this.lblForPhone.AutoSize = true;
            this.lblForPhone.Location = new System.Drawing.Point(97, 86);
            this.lblForPhone.Name = "lblForPhone";
            this.lblForPhone.Size = new System.Drawing.Size(35, 13);
            this.lblForPhone.TabIndex = 6;
            this.lblForPhone.Text = "label7";
            // 
            // lblForEmail
            // 
            this.lblForEmail.AutoSize = true;
            this.lblForEmail.Location = new System.Drawing.Point(97, 107);
            this.lblForEmail.Name = "lblForEmail";
            this.lblForEmail.Size = new System.Drawing.Size(35, 13);
            this.lblForEmail.TabIndex = 7;
            this.lblForEmail.Text = "label8";
            // 
            // BossLbl
            // 
            this.BossLbl.AutoSize = true;
            this.BossLbl.Location = new System.Drawing.Point(3, 53);
            this.BossLbl.Name = "BossLbl";
            this.BossLbl.Size = new System.Drawing.Size(78, 13);
            this.BossLbl.TabIndex = 1;
            this.BossLbl.Text = "Руководитель";
            // 
            // btmDeleteShop
            // 
            this.btmDeleteShop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmDeleteShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btmDeleteShop.ForeColor = System.Drawing.Color.Red;
            this.btmDeleteShop.Location = new System.Drawing.Point(306, 125);
            this.btmDeleteShop.Name = "btmDeleteShop";
            this.btmDeleteShop.Size = new System.Drawing.Size(138, 36);
            this.btmDeleteShop.TabIndex = 1;
            this.btmDeleteShop.Text = "Удалить магазин";
            this.btmDeleteShop.UseVisualStyleBackColor = true;
            this.btmDeleteShop.Click += new System.EventHandler(this.BtmDeleteShop_Click);
            // 
            // btmAddProduct
            // 
            this.btmAddProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmAddProduct.Location = new System.Drawing.Point(306, 12);
            this.btmAddProduct.Name = "btmAddProduct";
            this.btmAddProduct.Size = new System.Drawing.Size(138, 36);
            this.btmAddProduct.TabIndex = 2;
            this.btmAddProduct.Text = "Добавить товар";
            this.btmAddProduct.UseVisualStyleBackColor = true;
            this.btmAddProduct.Click += new System.EventHandler(this.BtmAddProduct_Click);
            // 
            // btmDeleteProduct
            // 
            this.btmDeleteProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmDeleteProduct.Location = new System.Drawing.Point(306, 55);
            this.btmDeleteProduct.Name = "btmDeleteProduct";
            this.btmDeleteProduct.Size = new System.Drawing.Size(138, 36);
            this.btmDeleteProduct.TabIndex = 3;
            this.btmDeleteProduct.Text = "Удалить товар";
            this.btmDeleteProduct.UseVisualStyleBackColor = true;
            this.btmDeleteProduct.Click += new System.EventHandler(this.BtmDeleteProduct_Click);
            // 
            // table
            // 
            this.table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table.Location = new System.Drawing.Point(12, 172);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(434, 266);
            this.table.TabIndex = 4;
            this.table.UseCompatibleStateImageBehavior = false;
            // 
            // WindowOfShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 450);
            this.Controls.Add(this.table);
            this.Controls.Add(this.btmDeleteProduct);
            this.Controls.Add(this.btmAddProduct);
            this.Controls.Add(this.btmDeleteShop);
            this.Controls.Add(this.ShopInfoBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(474, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(474, 489);
            this.Name = "WindowOfShop";
            this.ShowIcon = false;
            this.Text = "WindowOfShop";
            this.ShopInfoBox.ResumeLayout(false);
            this.InfoTable.ResumeLayout(false);
            this.InfoTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ShopInfoBox;
        private System.Windows.Forms.TableLayoutPanel InfoTable;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label BossLbl;
        private System.Windows.Forms.Label PhoneLbl;
        private System.Windows.Forms.Label EmailLbl;
        private System.Windows.Forms.Label lblForName;
        private System.Windows.Forms.Label lblForBoss;
        private System.Windows.Forms.Label lblForPhone;
        private System.Windows.Forms.Label lblForEmail;
        private System.Windows.Forms.Button btmDeleteShop;
        private System.Windows.Forms.Button btmAddProduct;
        private System.Windows.Forms.Button btmDeleteProduct;
        private System.Windows.Forms.ListView table;
    }
}