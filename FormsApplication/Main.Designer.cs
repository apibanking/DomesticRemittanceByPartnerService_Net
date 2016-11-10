namespace FormsApplication
{
    partial class Main
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
            this.run = new System.Windows.Forms.Button();
            this.response = new System.Windows.Forms.TextBox();
            this.accountNo = new System.Windows.Forms.TextBox();
            this.PartnerCode = new System.Windows.Forms.TextBox();
            this.CustomerID = new System.Windows.Forms.TextBox();
            this.Code = new System.Windows.Forms.Label();
            this.Account = new System.Windows.Forms.Label();
            this.CustomerCode = new System.Windows.Forms.Label();
            this.ResponseText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // run
            // 
            this.run.Location = new System.Drawing.Point(602, 793);
            this.run.Margin = new System.Windows.Forms.Padding(2);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(310, 87);
            this.run.TabIndex = 1;
            this.run.Text = "run";
            this.run.UseVisualStyleBackColor = true;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // response
            // 
            this.response.Location = new System.Drawing.Point(188, 225);
            this.response.Margin = new System.Windows.Forms.Padding(2);
            this.response.Multiline = true;
            this.response.Name = "response";
            this.response.ReadOnly = true;
            this.response.Size = new System.Drawing.Size(592, 445);
            this.response.TabIndex = 3;
            // 
            // accountNo
            // 
            this.accountNo.Location = new System.Drawing.Point(983, 245);
            this.accountNo.Name = "accountNo";
            this.accountNo.Size = new System.Drawing.Size(204, 31);
            this.accountNo.TabIndex = 4;
            this.accountNo.Text = "001587700000054";
            // 
            // PartnerCode
            // 
            this.PartnerCode.Location = new System.Drawing.Point(983, 317);
            this.PartnerCode.Name = "PartnerCode";
            this.PartnerCode.Size = new System.Drawing.Size(204, 31);
            this.PartnerCode.TabIndex = 5;
            this.PartnerCode.Text = "857552";
            this.PartnerCode.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CustomerID
            // 
            this.CustomerID.Location = new System.Drawing.Point(983, 401);
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Size = new System.Drawing.Size(204, 31);
            this.CustomerID.TabIndex = 6;
            this.CustomerID.Text = "smb1";
            // 
            // Code
            // 
            this.Code.AutoSize = true;
            this.Code.Location = new System.Drawing.Point(812, 317);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(133, 25);
            this.Code.TabIndex = 7;
            this.Code.Text = "PartnerCode";
            // 
            // Account
            // 
            this.Account.AutoSize = true;
            this.Account.Location = new System.Drawing.Point(812, 245);
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(117, 25);
            this.Account.TabIndex = 8;
            this.Account.Text = "AccountNo";
            // 
            // CustomerCode
            // 
            this.CustomerCode.AutoSize = true;
            this.CustomerCode.Location = new System.Drawing.Point(812, 407);
            this.CustomerCode.Name = "CustomerCode";
            this.CustomerCode.Size = new System.Drawing.Size(155, 25);
            this.CustomerCode.TabIndex = 9;
            this.CustomerCode.Text = "CustomerCode";
            // 
            // ResponseText
            // 
            this.ResponseText.AutoSize = true;
            this.ResponseText.Location = new System.Drawing.Point(296, 178);
            this.ResponseText.Name = "ResponseText";
            this.ResponseText.Size = new System.Drawing.Size(151, 25);
            this.ResponseText.TabIndex = 10;
            this.ResponseText.Text = "ResponseText";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2985, 1028);
            this.Controls.Add(this.ResponseText);
            this.Controls.Add(this.CustomerCode);
            this.Controls.Add(this.Account);
            this.Controls.Add(this.Code);
            this.Controls.Add(this.CustomerID);
            this.Controls.Add(this.PartnerCode);
            this.Controls.Add(this.accountNo);
            this.Controls.Add(this.response);
            this.Controls.Add(this.run);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button run;
        private System.Windows.Forms.TextBox response;
        private System.Windows.Forms.TextBox accountNo;
        private System.Windows.Forms.TextBox PartnerCode;
        private System.Windows.Forms.TextBox CustomerID;
        private System.Windows.Forms.Label Code;
        private System.Windows.Forms.Label Account;
        private System.Windows.Forms.Label CustomerCode;
        private System.Windows.Forms.Label ResponseText;
    }
}

