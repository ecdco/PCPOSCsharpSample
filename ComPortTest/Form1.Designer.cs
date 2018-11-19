namespace ComPortTest
{
    partial class Form1
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
            this.txt = new System.Windows.Forms.TextBox();
            this.butSale = new System.Windows.Forms.Button();
            this.butConn = new System.Windows.Forms.Button();
            this.butDis = new System.Windows.Forms.Button();
            this.butBalance = new System.Windows.Forms.Button();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMerchant = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTerminal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt
            // 
            this.txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt.Location = new System.Drawing.Point(3, 5);
            this.txt.Multiline = true;
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(292, 155);
            this.txt.TabIndex = 1;
            // 
            // butSale
            // 
            this.butSale.Location = new System.Drawing.Point(160, 281);
            this.butSale.Name = "butSale";
            this.butSale.Size = new System.Drawing.Size(99, 46);
            this.butSale.TabIndex = 6;
            this.butSale.Text = "Sale";
            this.butSale.UseVisualStyleBackColor = true;
            this.butSale.Click += new System.EventHandler(this.butSale_Click);
            // 
            // butConn
            // 
            this.butConn.Location = new System.Drawing.Point(196, 166);
            this.butConn.Name = "butConn";
            this.butConn.Size = new System.Drawing.Size(99, 46);
            this.butConn.TabIndex = 7;
            this.butConn.Text = "Connect";
            this.butConn.UseVisualStyleBackColor = true;
            this.butConn.Click += new System.EventHandler(this.butConn_Click);
            // 
            // butDis
            // 
            this.butDis.Location = new System.Drawing.Point(196, 218);
            this.butDis.Name = "butDis";
            this.butDis.Size = new System.Drawing.Size(99, 46);
            this.butDis.TabIndex = 8;
            this.butDis.Text = "Disconnect";
            this.butDis.UseVisualStyleBackColor = true;
            this.butDis.Click += new System.EventHandler(this.butDis_Click);
            // 
            // butBalance
            // 
            this.butBalance.Location = new System.Drawing.Point(47, 281);
            this.butBalance.Name = "butBalance";
            this.butBalance.Size = new System.Drawing.Size(99, 46);
            this.butBalance.TabIndex = 9;
            this.butBalance.Text = "Balance";
            this.butBalance.UseVisualStyleBackColor = true;
            this.butBalance.Click += new System.EventHandler(this.butBalance_Click);
            // 
            // txtSerial
            // 
            this.txtSerial.Location = new System.Drawing.Point(83, 166);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(107, 20);
            this.txtSerial.TabIndex = 10;
            this.txtSerial.Text = "3000009592";
            this.txtSerial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "SerialNo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "MerchantNo:";
            // 
            // txtMerchant
            // 
            this.txtMerchant.Location = new System.Drawing.Point(83, 192);
            this.txtMerchant.Name = "txtMerchant";
            this.txtMerchant.Size = new System.Drawing.Size(107, 20);
            this.txtMerchant.TabIndex = 12;
            this.txtMerchant.Text = "017379960528001";
            this.txtMerchant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "TerminalNo:";
            // 
            // txtTerminal
            // 
            this.txtTerminal.Location = new System.Drawing.Point(83, 218);
            this.txtTerminal.Name = "txtTerminal";
            this.txtTerminal.Size = new System.Drawing.Size(107, 20);
            this.txtTerminal.TabIndex = 14;
            this.txtTerminal.Text = "95050002";
            this.txtTerminal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Amount:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(83, 244);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(107, 20);
            this.txtAmount.TabIndex = 16;
            this.txtAmount.Text = "1000";
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 339);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTerminal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMerchant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSerial);
            this.Controls.Add(this.butBalance);
            this.Controls.Add(this.butDis);
            this.Controls.Add(this.butConn);
            this.Controls.Add(this.butSale);
            this.Controls.Add(this.txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "ECD PC POS Test Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Button butSale;
        private System.Windows.Forms.Button butConn;
        private System.Windows.Forms.Button butDis;
        private System.Windows.Forms.Button butBalance;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMerchant;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTerminal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAmount;
    }
}

