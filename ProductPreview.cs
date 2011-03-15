using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace IBoodHuntMonitor
{
    public partial class ProductPreview : Form
    {
        public IBoodProduct IBoodProduct { get; private set; }

        public ProductPreview()
        {
            InitializeComponent();
            Rectangle r = Screen.PrimaryScreen.WorkingArea;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, Screen.PrimaryScreen.WorkingArea.Height - this.Height);
        }

        public void LoadIboodProduct(IBoodProduct prod)
        {
            IBoodProduct = prod;
            lblProductName.Text = prod.Name;
            lblRegularPrice.Text = prod.RegularPrice.ToString("c");
            lblOurPrice.Text = prod.OurPrice.ToString("c");
            lblShippingCost.Text = prod.ShippingCost.ToString("c");
            pictureBox1.LoadAsync(prod.ImageUri.ToString());
            btnAction.Enabled = prod.Status == ProductStatus.NotSoldOut;
            //btnAction.Text = prod.Status.ToString();
            
        }

       

        private void btnMoreInfo_Click(object sender, EventArgs e)
        {
            Process.Start(IBoodProduct.MoreInfoUri.ToString());
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            Process.Start(IBoodProduct.BuyNowUri.ToString());
        }

    }
}
