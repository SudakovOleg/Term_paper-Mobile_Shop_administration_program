namespace MobilShopNet
{
    partial class addProduct
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.Accept_btm = new System.Windows.Forms.Button();
            this.labelOffice = new System.Windows.Forms.Label();
            this.labelContry = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelRegion = new System.Windows.Forms.Label();
            this.labelStreet = new System.Windows.Forms.Label();
            this.txtPlace = new System.Windows.Forms.TextBox();
            this.numCost = new System.Windows.Forms.NumericUpDown();
            this.numCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.BoxType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(127, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(201, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtInfo
            // 
            this.txtInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInfo.Location = new System.Drawing.Point(127, 144);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(201, 20);
            this.txtInfo.TabIndex = 4;
            // 
            // Accept_btm
            // 
            this.Accept_btm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Accept_btm.Location = new System.Drawing.Point(12, 170);
            this.Accept_btm.Name = "Accept_btm";
            this.Accept_btm.Size = new System.Drawing.Size(316, 52);
            this.Accept_btm.TabIndex = 7;
            this.Accept_btm.Text = "Добавить";
            this.Accept_btm.UseVisualStyleBackColor = true;
            this.Accept_btm.Click += new System.EventHandler(this.Accept_btm_Click);
            // 
            // labelOffice
            // 
            this.labelOffice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOffice.AutoSize = true;
            this.labelOffice.Location = new System.Drawing.Point(12, 19);
            this.labelOffice.Name = "labelOffice";
            this.labelOffice.Size = new System.Drawing.Size(57, 13);
            this.labelOffice.TabIndex = 8;
            this.labelOffice.Text = "Название";
            // 
            // labelContry
            // 
            this.labelContry.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelContry.AutoSize = true;
            this.labelContry.Location = new System.Drawing.Point(12, 45);
            this.labelContry.Name = "labelContry";
            this.labelContry.Size = new System.Drawing.Size(66, 13);
            this.labelContry.TabIndex = 9;
            this.labelContry.Text = "Количество";
            // 
            // labelEmail
            // 
            this.labelEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(12, 125);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(39, 13);
            this.labelEmail.TabIndex = 16;
            this.labelEmail.Text = "Место";
            // 
            // labelRegion
            // 
            this.labelRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRegion.AutoSize = true;
            this.labelRegion.Location = new System.Drawing.Point(12, 71);
            this.labelRegion.Name = "labelRegion";
            this.labelRegion.Size = new System.Drawing.Size(33, 13);
            this.labelRegion.TabIndex = 10;
            this.labelRegion.Text = "Цена";
            // 
            // labelStreet
            // 
            this.labelStreet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStreet.AutoSize = true;
            this.labelStreet.Location = new System.Drawing.Point(12, 151);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(73, 13);
            this.labelStreet.TabIndex = 12;
            this.labelStreet.Text = "Информация";
            // 
            // txtPlace
            // 
            this.txtPlace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPlace.Location = new System.Drawing.Point(127, 118);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(201, 20);
            this.txtPlace.TabIndex = 3;
            // 
            // numCost
            // 
            this.numCost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numCost.Location = new System.Drawing.Point(127, 64);
            this.numCost.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numCost.Name = "numCost";
            this.numCost.Size = new System.Drawing.Size(201, 20);
            this.numCost.TabIndex = 17;
            // 
            // numCount
            // 
            this.numCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numCount.Location = new System.Drawing.Point(127, 39);
            this.numCount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numCount.Name = "numCount";
            this.numCount.Size = new System.Drawing.Size(201, 20);
            this.numCount.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Тип";
            // 
            // BoxType
            // 
            this.BoxType.FormattingEnabled = true;
            this.BoxType.Location = new System.Drawing.Point(127, 91);
            this.BoxType.Name = "BoxType";
            this.BoxType.Size = new System.Drawing.Size(201, 21);
            this.BoxType.TabIndex = 20;
            // 
            // addProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 231);
            this.Controls.Add(this.BoxType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numCount);
            this.Controls.Add(this.numCost);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelStreet);
            this.Controls.Add(this.labelRegion);
            this.Controls.Add(this.labelContry);
            this.Controls.Add(this.labelOffice);
            this.Controls.Add(this.Accept_btm);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.txtPlace);
            this.Controls.Add(this.txtName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(356, 232);
            this.Name = "addProduct";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Добавить Магазин";
            ((System.ComponentModel.ISupportInitialize)(this.numCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Button Accept_btm;
        private System.Windows.Forms.Label labelOffice;
        private System.Windows.Forms.Label labelContry;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelRegion;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.TextBox txtPlace;
        private System.Windows.Forms.NumericUpDown numCost;
        private System.Windows.Forms.NumericUpDown numCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox BoxType;
    }
}