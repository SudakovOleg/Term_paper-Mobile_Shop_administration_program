namespace MobilShopNet
{
    partial class deleteProduct
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
            this.lblProduct = new System.Windows.Forms.Label();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.deleteBtm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProduct
            // 
            this.lblProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(12, 15);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(95, 13);
            this.lblProduct.TabIndex = 0;
            this.lblProduct.Text = "Название товара";
            // 
            // txtProduct
            // 
            this.txtProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProduct.Location = new System.Drawing.Point(116, 10);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(126, 20);
            this.txtProduct.TabIndex = 1;
            // 
            // deleteBtm
            // 
            this.deleteBtm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteBtm.Location = new System.Drawing.Point(12, 36);
            this.deleteBtm.Name = "deleteBtm";
            this.deleteBtm.Size = new System.Drawing.Size(230, 29);
            this.deleteBtm.TabIndex = 2;
            this.deleteBtm.Text = "Удалить";
            this.deleteBtm.UseVisualStyleBackColor = true;
            this.deleteBtm.Click += new System.EventHandler(this.DeleteBtm_Click);
            // 
            // deleteProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 77);
            this.Controls.Add(this.deleteBtm);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.lblProduct);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(270, 116);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(270, 116);
            this.Name = "deleteProduct";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Удалить товар";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.Button deleteBtm;
    }
}