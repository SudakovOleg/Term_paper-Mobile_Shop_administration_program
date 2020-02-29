namespace MobilShopNet
{
    partial class deleteOffice
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
            this.txtOfficeName = new System.Windows.Forms.TextBox();
            this.lblOffice = new System.Windows.Forms.Label();
            this.DelBtm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOfficeName
            // 
            this.txtOfficeName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOfficeName.Location = new System.Drawing.Point(132, 13);
            this.txtOfficeName.Name = "txtOfficeName";
            this.txtOfficeName.Size = new System.Drawing.Size(165, 20);
            this.txtOfficeName.TabIndex = 0;
            // 
            // lblOffice
            // 
            this.lblOffice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOffice.AutoSize = true;
            this.lblOffice.Location = new System.Drawing.Point(13, 13);
            this.lblOffice.Name = "lblOffice";
            this.lblOffice.Size = new System.Drawing.Size(92, 13);
            this.lblOffice.TabIndex = 2;
            this.lblOffice.Text = "Название офиса";
            // 
            // DelBtm
            // 
            this.DelBtm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DelBtm.Location = new System.Drawing.Point(12, 40);
            this.DelBtm.Name = "DelBtm";
            this.DelBtm.Size = new System.Drawing.Size(285, 34);
            this.DelBtm.TabIndex = 4;
            this.DelBtm.Text = "Удалить";
            this.DelBtm.UseVisualStyleBackColor = true;
            this.DelBtm.Click += new System.EventHandler(this.DelBtm_Click);
            // 
            // deleteOffice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 86);
            this.Controls.Add(this.DelBtm);
            this.Controls.Add(this.lblOffice);
            this.Controls.Add(this.txtOfficeName);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(325, 125);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(325, 125);
            this.Name = "deleteOffice";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Удалить офис";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOfficeName;
        private System.Windows.Forms.Label lblOffice;
        private System.Windows.Forms.Button DelBtm;
    }
}