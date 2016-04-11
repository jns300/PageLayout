using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PageLayout.Core;

namespace PageLayout
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnGenerateCopy_Click(object sender, EventArgs e)
        {
            txtPages.Text = GetPageString();
            CopyToClipboard(txtPages.Text);
        }
        private void CopyToClipboard(String str)
        {
            try
            {
                Clipboard.SetText(str);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show(this, String.Format("Cannot copy text to the clipboard:\n{0}", ex.Message), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            txtPages.Text = GetPageString();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (txtPages.Text.Trim().Length == 0)
                MessageBox.Show(this, "Pages were not generated.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                CopyToClipboard(txtPages.Text);
        }
        private List<int> Generate()
        {
            Brochure brochure = new Brochure((int)nudAllPages.Value, 
                (int)nudRows.Value, (int)nudColumns.Value, chkPageWithSingleCard.Checked);
            return brochure.GetPrintingPageNumbers();
        }

        public String GetPageString()
        {
            StringBuilder sb = new StringBuilder();
            int i = 0;
            foreach (int v in Generate())
            {
                if (i++ > 0)
                {
                    sb.Append(",");
                }
                sb.Append(v);
            }
            return sb.ToString();
        }

        private void nudRows_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudAllPages_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
