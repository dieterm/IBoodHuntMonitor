namespace IBoodHuntMonitor
{
    partial class ProductPreview
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblRegularPrice = new System.Windows.Forms.Label();
            this.lblOurPrice = new System.Windows.Forms.Label();
            this.lblShippingCost = new System.Windows.Forms.Label();
            this.btnAction = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMoreInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblProductName
            // 
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(153, 12);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(211, 43);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "PRODUCT NAME";
            // 
            // lblRegularPrice
            // 
            this.lblRegularPrice.AutoSize = true;
            this.lblRegularPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegularPrice.Location = new System.Drawing.Point(210, 55);
            this.lblRegularPrice.Name = "lblRegularPrice";
            this.lblRegularPrice.Size = new System.Drawing.Size(35, 13);
            this.lblRegularPrice.TabIndex = 2;
            this.lblRegularPrice.Text = "label2";
            // 
            // lblOurPrice
            // 
            this.lblOurPrice.AutoSize = true;
            this.lblOurPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOurPrice.ForeColor = System.Drawing.Color.Red;
            this.lblOurPrice.Location = new System.Drawing.Point(208, 81);
            this.lblOurPrice.Name = "lblOurPrice";
            this.lblOurPrice.Size = new System.Drawing.Size(70, 25);
            this.lblOurPrice.TabIndex = 3;
            this.lblOurPrice.Text = "label2";
            // 
            // lblShippingCost
            // 
            this.lblShippingCost.AutoSize = true;
            this.lblShippingCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShippingCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblShippingCost.Location = new System.Drawing.Point(284, 81);
            this.lblShippingCost.Name = "lblShippingCost";
            this.lblShippingCost.Size = new System.Drawing.Size(51, 20);
            this.lblShippingCost.TabIndex = 4;
            this.lblShippingCost.Text = "label2";
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(159, 125);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(107, 23);
            this.btnAction.TabIndex = 5;
            this.btnAction.Text = "Ik neem er een!";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Prijs:";
            // 
            // btnMoreInfo
            // 
            this.btnMoreInfo.Location = new System.Drawing.Point(272, 124);
            this.btnMoreInfo.Name = "btnMoreInfo";
            this.btnMoreInfo.Size = new System.Drawing.Size(107, 23);
            this.btnMoreInfo.TabIndex = 7;
            this.btnMoreInfo.Text = "Meer Info";
            this.btnMoreInfo.UseVisualStyleBackColor = true;
            this.btnMoreInfo.Click += new System.EventHandler(this.btnMoreInfo_Click);
            // 
            // ProductPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(383, 165);
            this.Controls.Add(this.btnMoreInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.lblShippingCost);
            this.Controls.Add(this.lblOurPrice);
            this.Controls.Add(this.lblRegularPrice);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ProductPreview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ProductPreview";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblRegularPrice;
        private System.Windows.Forms.Label lblOurPrice;
        private System.Windows.Forms.Label lblShippingCost;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMoreInfo;
    }
}