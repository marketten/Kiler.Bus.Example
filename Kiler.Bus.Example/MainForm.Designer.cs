
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.btnGetCategoryTree = new System.Windows.Forms.Button();
            this.btnUpdateAllProduct = new System.Windows.Forms.Button();
            this.btnDisableAll = new System.Windows.Forms.Button();
            this.btnUpdateSingle = new System.Windows.Forms.Button();
            this.txtErpId = new System.Windows.Forms.TextBox();
            this.txtApiId = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rtbData = new System.Windows.Forms.RichTextBox();
            this.cbEventType = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 83);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.txtCompany);
            this.groupBox1.Controls.Add(this.btnGetCategoryTree);
            this.groupBox1.Controls.Add(this.btnUpdateAllProduct);
            this.groupBox1.Controls.Add(this.btnDisableAll);
            this.groupBox1.Controls.Add(this.btnUpdateSingle);
            this.groupBox1.Controls.Add(this.txtErpId);
            this.groupBox1.Controls.Add(this.txtApiId);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 83);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server Info";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(393, 34);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(113, 20);
            this.btnConnect.TabIndex = 8;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(5, 34);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(134, 20);
            this.txtCompany.TabIndex = 1;
            // 
            // btnGetCategoryTree
            // 
            this.btnGetCategoryTree.Location = new System.Drawing.Point(393, 58);
            this.btnGetCategoryTree.Name = "btnGetCategoryTree";
            this.btnGetCategoryTree.Size = new System.Drawing.Size(115, 20);
            this.btnGetCategoryTree.TabIndex = 3;
            this.btnGetCategoryTree.Text = "Get Category Tree";
            this.btnGetCategoryTree.UseVisualStyleBackColor = true;
            this.btnGetCategoryTree.Click += new System.EventHandler(this.btnGetCategoryTree_Click);
            // 
            // btnUpdateAllProduct
            // 
            this.btnUpdateAllProduct.Location = new System.Drawing.Point(285, 58);
            this.btnUpdateAllProduct.Name = "btnUpdateAllProduct";
            this.btnUpdateAllProduct.Size = new System.Drawing.Size(104, 20);
            this.btnUpdateAllProduct.TabIndex = 7;
            this.btnUpdateAllProduct.Text = "Update All Product";
            this.btnUpdateAllProduct.UseVisualStyleBackColor = true;
            this.btnUpdateAllProduct.Click += new System.EventHandler(this.btnUpdateAllProduct_Click);
            // 
            // btnDisableAll
            // 
            this.btnDisableAll.Location = new System.Drawing.Point(211, 58);
            this.btnDisableAll.Name = "btnDisableAll";
            this.btnDisableAll.Size = new System.Drawing.Size(74, 20);
            this.btnDisableAll.TabIndex = 6;
            this.btnDisableAll.Text = "Disable All Product";
            this.btnDisableAll.UseVisualStyleBackColor = true;
            this.btnDisableAll.Click += new System.EventHandler(this.btnDisableAll_Click);
            // 
            // btnUpdateSingle
            // 
            this.btnUpdateSingle.Location = new System.Drawing.Point(111, 58);
            this.btnUpdateSingle.Name = "btnUpdateSingle";
            this.btnUpdateSingle.Size = new System.Drawing.Size(98, 20);
            this.btnUpdateSingle.TabIndex = 5;
            this.btnUpdateSingle.Text = "Update Single Product";
            this.btnUpdateSingle.UseVisualStyleBackColor = true;
            this.btnUpdateSingle.Click += new System.EventHandler(this.btnUpdateSingle_Click);
            // 
            // txtErpId
            // 
            this.txtErpId.Location = new System.Drawing.Point(60, 57);
            this.txtErpId.Name = "txtErpId";
            this.txtErpId.Size = new System.Drawing.Size(49, 20);
            this.txtErpId.TabIndex = 4;
            // 
            // txtApiId
            // 
            this.txtApiId.Location = new System.Drawing.Point(144, 34);
            this.txtApiId.Name = "txtApiId";
            this.txtApiId.Size = new System.Drawing.Size(243, 20);
            this.txtApiId.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rtbData);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(684, 307);
            this.panel2.TabIndex = 1;
            // 
            // rtbData
            // 
            this.rtbData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbData.Location = new System.Drawing.Point(0, 0);
            this.rtbData.Name = "rtbData";
            this.rtbData.Size = new System.Drawing.Size(684, 307);
            this.rtbData.TabIndex = 0;
            this.rtbData.Text = "";
            // 
            // cbEventType
            // 
            this.cbEventType.FormattingEnabled = true;
            this.cbEventType.Items.AddRange(new object[] {
            "OrderCreated",
            "Logs"});
            this.cbEventType.Location = new System.Drawing.Point(5, 31);
            this.cbEventType.Name = "cbEventType";
            this.cbEventType.Size = new System.Drawing.Size(152, 21);
            this.cbEventType.TabIndex = 8;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(5, 57);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(152, 20);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnStart);
            this.groupBox2.Controls.Add(this.cbEventType);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(512, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(172, 83);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "EventType";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Region Id:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(684, 390);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kiler Bus Example";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtApiId;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox rtbData;
        private System.Windows.Forms.Button btnUpdateAllProduct;
        private System.Windows.Forms.Button btnDisableAll;
        private System.Windows.Forms.Button btnUpdateSingle;
        private System.Windows.Forms.TextBox txtErpId;
        private System.Windows.Forms.Button btnGetCategoryTree;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox cbEventType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

