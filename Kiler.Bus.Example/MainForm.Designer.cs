
namespace Kiler.Bus.Example
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.cbEventType = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGetCategoryTree = new System.Windows.Forms.Button();
            this.btnUpdateAllProduct = new System.Windows.Forms.Button();
            this.btnDisableAll = new System.Windows.Forms.Button();
            this.btnUpdateSingle = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtApiId = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rtbData = new System.Windows.Forms.RichTextBox();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 96);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnStart);
            this.groupBox2.Controls.Add(this.cbEventType);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(597, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 96);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "EventType";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(72, 66);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(111, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cbEventType
            // 
            this.cbEventType.FormattingEnabled = true;
            this.cbEventType.Items.AddRange(new object[] {
            "OrderCreated",
            "Logs"});
            this.cbEventType.Location = new System.Drawing.Point(6, 36);
            this.cbEventType.Name = "cbEventType";
            this.cbEventType.Size = new System.Drawing.Size(177, 23);
            this.cbEventType.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCompany);
            this.groupBox1.Controls.Add(this.btnGetCategoryTree);
            this.groupBox1.Controls.Add(this.btnUpdateAllProduct);
            this.groupBox1.Controls.Add(this.btnDisableAll);
            this.groupBox1.Controls.Add(this.btnUpdateSingle);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.txtApiId);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(798, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server Info";
            // 
            // btnGetCategoryTree
            // 
            this.btnGetCategoryTree.Location = new System.Drawing.Point(310, 35);
            this.btnGetCategoryTree.Name = "btnGetCategoryTree";
            this.btnGetCategoryTree.Size = new System.Drawing.Size(134, 23);
            this.btnGetCategoryTree.TabIndex = 8;
            this.btnGetCategoryTree.Text = "Get Category Tree";
            this.btnGetCategoryTree.UseVisualStyleBackColor = true;
            this.btnGetCategoryTree.Click += new System.EventHandler(this.btnGetCategoryTree_Click);
            // 
            // btnUpdateAllProduct
            // 
            this.btnUpdateAllProduct.Location = new System.Drawing.Point(450, 65);
            this.btnUpdateAllProduct.Name = "btnUpdateAllProduct";
            this.btnUpdateAllProduct.Size = new System.Drawing.Size(135, 23);
            this.btnUpdateAllProduct.TabIndex = 7;
            this.btnUpdateAllProduct.Text = "Update All Product";
            this.btnUpdateAllProduct.UseVisualStyleBackColor = true;
            this.btnUpdateAllProduct.Click += new System.EventHandler(this.btnUpdateAllProduct_Click);
            // 
            // btnDisableAll
            // 
            this.btnDisableAll.Location = new System.Drawing.Point(309, 65);
            this.btnDisableAll.Name = "btnDisableAll";
            this.btnDisableAll.Size = new System.Drawing.Size(135, 23);
            this.btnDisableAll.TabIndex = 6;
            this.btnDisableAll.Text = "Disable All Product";
            this.btnDisableAll.UseVisualStyleBackColor = true;
            this.btnDisableAll.Click += new System.EventHandler(this.btnDisableAll_Click);
            // 
            // btnUpdateSingle
            // 
            this.btnUpdateSingle.Location = new System.Drawing.Point(168, 66);
            this.btnUpdateSingle.Name = "btnUpdateSingle";
            this.btnUpdateSingle.Size = new System.Drawing.Size(135, 23);
            this.btnUpdateSingle.TabIndex = 5;
            this.btnUpdateSingle.Text = "Update Single Product";
            this.btnUpdateSingle.UseVisualStyleBackColor = true;
            this.btnUpdateSingle.Click += new System.EventHandler(this.btnUpdateSingle_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Region Erp Id";
            this.textBox1.Size = new System.Drawing.Size(155, 23);
            this.textBox1.TabIndex = 4;
            // 
            // txtApiId
            // 
            this.txtApiId.Location = new System.Drawing.Point(7, 37);
            this.txtApiId.Name = "txtApiId";
            this.txtApiId.PlaceholderText = "ApiId";
            this.txtApiId.Size = new System.Drawing.Size(155, 23);
            this.txtApiId.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rtbData);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(798, 354);
            this.panel2.TabIndex = 1;
            // 
            // rtbData
            // 
            this.rtbData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbData.Location = new System.Drawing.Point(0, 0);
            this.rtbData.Name = "rtbData";
            this.rtbData.Size = new System.Drawing.Size(798, 354);
            this.rtbData.TabIndex = 0;
            this.rtbData.Text = "";
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(169, 37);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.PlaceholderText = "CompanyName";
            this.txtCompany.Size = new System.Drawing.Size(135, 23);
            this.txtCompany.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(798, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Kiler Bus Example";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtApiId;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox rtbData;
        private System.Windows.Forms.ComboBox cbEventType;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnUpdateAllProduct;
        private System.Windows.Forms.Button btnDisableAll;
        private System.Windows.Forms.Button btnUpdateSingle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnGetCategoryTree;
        private System.Windows.Forms.TextBox txtCompany;
    }
}

