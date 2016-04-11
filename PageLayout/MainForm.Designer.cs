namespace PageLayout
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnGenerateCopy = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.txtPages = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudAllPages = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudColumns = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudRows = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.chkPageWithSingleCard = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudAllPages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRows)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerateCopy
            // 
            this.btnGenerateCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerateCopy.Location = new System.Drawing.Point(238, 150);
            this.btnGenerateCopy.Name = "btnGenerateCopy";
            this.btnGenerateCopy.Size = new System.Drawing.Size(96, 23);
            this.btnGenerateCopy.TabIndex = 5;
            this.btnGenerateCopy.Text = "Generate && Copy";
            this.btnGenerateCopy.UseVisualStyleBackColor = true;
            this.btnGenerateCopy.Click += new System.EventHandler(this.btnGenerateCopy_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.Location = new System.Drawing.Point(340, 150);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.Location = new System.Drawing.Point(421, 150);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 7;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // txtPages
            // 
            this.txtPages.Location = new System.Drawing.Point(95, 113);
            this.txtPages.Name = "txtPages";
            this.txtPages.ReadOnly = true;
            this.txtPages.Size = new System.Drawing.Size(401, 20);
            this.txtPages.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Generated list:";
            // 
            // nudAllPages
            // 
            this.nudAllPages.Location = new System.Drawing.Point(374, 12);
            this.nudAllPages.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudAllPages.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAllPages.Name = "nudAllPages";
            this.nudAllPages.Size = new System.Drawing.Size(120, 20);
            this.nudAllPages.TabIndex = 0;
            this.nudAllPages.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAllPages.ValueChanged += new System.EventHandler(this.nudAllPages_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Number of all pages in a document:";
            // 
            // nudColumns
            // 
            this.nudColumns.Location = new System.Drawing.Point(374, 37);
            this.nudColumns.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudColumns.Name = "nudColumns";
            this.nudColumns.Size = new System.Drawing.Size(120, 20);
            this.nudColumns.TabIndex = 1;
            this.nudColumns.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Number of columns for double cards on a single printing card:";
            // 
            // nudRows
            // 
            this.nudRows.Location = new System.Drawing.Point(374, 63);
            this.nudRows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRows.Name = "nudRows";
            this.nudRows.Size = new System.Drawing.Size(120, 20);
            this.nudRows.TabIndex = 2;
            this.nudRows.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudRows.ValueChanged += new System.EventHandler(this.nudRows_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(278, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Number of rows for double cards on a single printing card:";
            // 
            // chkPageWithSingleCard
            // 
            this.chkPageWithSingleCard.AutoSize = true;
            this.chkPageWithSingleCard.Location = new System.Drawing.Point(15, 90);
            this.chkPageWithSingleCard.Name = "chkPageWithSingleCard";
            this.chkPageWithSingleCard.Size = new System.Drawing.Size(335, 17);
            this.chkPageWithSingleCard.TabIndex = 3;
            this.chkPageWithSingleCard.Text = "On each printing page place only a single double card many times";
            this.chkPageWithSingleCard.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 182);
            this.Controls.Add(this.chkPageWithSingleCard);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudRows);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudColumns);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudAllPages);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPages);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnGenerateCopy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Page Layout Generation";
            ((System.ComponentModel.ISupportInitialize)(this.nudAllPages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRows)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerateCopy;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.TextBox txtPages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudAllPages;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudColumns;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudRows;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkPageWithSingleCard;
    }
}

