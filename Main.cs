using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web;
using System.Net;
using System.Xml.Linq;
namespace IBoodHuntMonitor
{
    public partial class Main : Form
    {
        //private WebClient wc;
        private Uri iboodUri = new Uri("http://www.ibood.com/be/nl/", UriKind.Absolute);
        private IBoodProduct lastProduct = null;
        private ProductPreview previewForm;// = new ProductPreview();

        public Main()
        {
            InitializeComponent();
            webBrowser.DocumentCompleted += webBrowser_DocumentCompleted;
            
        }

        void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tmrCheckIbood.Enabled = true;
            txtOutput.Text += "Done!" + Environment.NewLine;

            if (webBrowser.Document.Title == "Navigation Canceled")
            {
                txtOutput.Text += webBrowser.Document.Title + Environment.NewLine;
            }
            else 
            { 
                var prod = IBoodProduct.Create(webBrowser.Document);

                if (prod == null)
                    return;

                //txtOutput.Text += prod.ToString() + Environment.NewLine;

                if (lastProduct == null || lastProduct.Name != prod.Name)
                {
                    lastProduct = prod;

                    ShowProductPreview(prod);
                }
            }
            
        }

        private void ShowProductPreview(IBoodProduct prod)
        {
            if (previewForm == null || previewForm.IsDisposed) 
            { 
                previewForm = new ProductPreview(); 
            }
            previewForm.LoadIboodProduct(prod);
            previewForm.Show();
        }

        
        private void tmrCheckIbood_Tick(object sender, EventArgs e)
        {
            tmrCheckIbood.Enabled = false;
            txtOutput.Text += "Navigating to '" + iboodUri.ToString() + "' ... ";
            webBrowser.Navigate(iboodUri);
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            
            this.Show();
            this.BringToFront();
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ShowProductPreview(lastProduct);
            }
        }

        private void mniDebugWindow_Click(object sender, EventArgs e)
        {
            if (!this.Visible)
            {
                this.Show();
            }
            this.WindowState = FormWindowState.Maximized;
            this.BringToFront();
        }


    }
}
