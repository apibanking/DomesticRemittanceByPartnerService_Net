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
            this.RUN = new System.Windows.Forms.Button();
            this.response = new System.Windows.Forms.TextBox();
            this.accountNo = new System.Windows.Forms.TextBox();
            this.PartnerCode = new System.Windows.Forms.TextBox();
            this.CustomerID = new System.Windows.Forms.TextBox();
            this.Code = new System.Windows.Forms.Label();
            this.Account = new System.Windows.Forms.Label();
            this.CustomerCode = new System.Windows.Forms.Label();
            this.ResponseText = new System.Windows.Forms.Label();
            this.clientSSL = new System.Windows.Forms.CheckBox();
            this.RequestedURL = new System.Windows.Forms.Label();
            this.reqURL = new System.Windows.Forms.TextBox();
            this.reset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RUN
            // 
            this.RUN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RUN.Location = new System.Drawing.Point(649, 572);
            this.RUN.Name = "RUN";
            this.RUN.Size = new System.Drawing.Size(191, 87);
            this.RUN.TabIndex = 1;
            this.RUN.Text = "RUN";
            this.RUN.UseVisualStyleBackColor = false;
            this.RUN.Click += new System.EventHandler(this.run_Click);
            // 
            // response
            // 
            this.response.Location = new System.Drawing.Point(894, 372);
            this.response.Multiline = true;
            this.response.Name = "response";
            this.response.ReadOnly = true;
            this.response.Size = new System.Drawing.Size(689, 180);
            this.response.TabIndex = 3;
            // 
            // accountNo
            // 
            this.accountNo.Location = new System.Drawing.Point(339, 314);
            this.accountNo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.accountNo.Name = "accountNo";
            this.accountNo.Size = new System.Drawing.Size(321, 44);
            this.accountNo.TabIndex = 4;
            this.accountNo.Text = "001587700000054";
            // 
            // PartnerCode
            // 
            this.PartnerCode.Location = new System.Drawing.Point(339, 400);
            this.PartnerCode.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.PartnerCode.Name = "PartnerCode";
            this.PartnerCode.Size = new System.Drawing.Size(321, 44);
            this.PartnerCode.TabIndex = 5;
            this.PartnerCode.Text = "smb1";
            // 
            // CustomerID
            // 
            this.CustomerID.Location = new System.Drawing.Point(339, 486);
            this.CustomerID.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Size = new System.Drawing.Size(321, 44);
            this.CustomerID.TabIndex = 6;
            this.CustomerID.Text = "857552";
            // 
            // Code
            // 
            this.Code.AutoSize = true;
            this.Code.Location = new System.Drawing.Point(69, 400);
            this.Code.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(207, 37);
            this.Code.TabIndex = 7;
            this.Code.Text = "Partner Code";
            // 
            // Account
            // 
            this.Account.AutoSize = true;
            this.Account.Location = new System.Drawing.Point(69, 314);
            this.Account.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(185, 37);
            this.Account.TabIndex = 8;
            this.Account.Text = "Account No";
            // 
            // CustomerCode
            // 
            this.CustomerCode.AutoSize = true;
            this.CustomerCode.Location = new System.Drawing.Point(69, 486);
            this.CustomerCode.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CustomerCode.Name = "CustomerCode";
            this.CustomerCode.Size = new System.Drawing.Size(241, 37);
            this.CustomerCode.TabIndex = 9;
            this.CustomerCode.Text = "Customer Code";
            // 
            // ResponseText
            // 
            this.ResponseText.AutoSize = true;
            this.ResponseText.Location = new System.Drawing.Point(1077, 294);
            this.ResponseText.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ResponseText.Name = "ResponseText";
            this.ResponseText.Size = new System.Drawing.Size(220, 37);
            this.ResponseText.TabIndex = 10;
            this.ResponseText.Text = "ResponseText";
            // 
            // clientSSL
            // 
            this.clientSSL.AutoSize = true;
            this.clientSSL.Location = new System.Drawing.Point(171, 134);
            this.clientSSL.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.clientSSL.Name = "clientSSL";
            this.clientSSL.Size = new System.Drawing.Size(347, 41);
            this.clientSSL.TabIndex = 11;
            this.clientSSL.Text = "Use client certificate";
            this.clientSSL.UseVisualStyleBackColor = true;
            // 
            // RequestedURL
            // 
            this.RequestedURL.AutoSize = true;
            this.RequestedURL.Location = new System.Drawing.Point(681, 134);
            this.RequestedURL.Name = "RequestedURL";
            this.RequestedURL.Size = new System.Drawing.Size(241, 37);
            this.RequestedURL.TabIndex = 12;
            this.RequestedURL.Text = "Requested URL";
            // 
            // reqURL
            // 
            this.reqURL.BackColor = System.Drawing.SystemColors.Info;
            this.reqURL.Location = new System.Drawing.Point(939, 127);
            this.reqURL.Name = "reqURL";
            this.reqURL.Size = new System.Drawing.Size(1313, 44);
            this.reqURL.TabIndex = 13;
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.reset.ForeColor = System.Drawing.SystemColors.ControlText;
            this.reset.Location = new System.Drawing.Point(288, 572);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(170, 91);
            this.reset.TabIndex = 14;
            this.reset.Text = "RESET";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 37);
            this.label1.TabIndex = 15;
            this.label1.Text = "getBalanceInput";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(171, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(555, 37);
            this.label2.TabIndex = 16;
            this.label2.Text = "DomesticRemittanceByPartnerService";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3328, 1521);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.reqURL);
            this.Controls.Add(this.RequestedURL);
            this.Controls.Add(this.clientSSL);
            this.Controls.Add(this.ResponseText);
            this.Controls.Add(this.CustomerCode);
            this.Controls.Add(this.Account);
            this.Controls.Add(this.Code);
            this.Controls.Add(this.CustomerID);
            this.Controls.Add(this.PartnerCode);
            this.Controls.Add(this.accountNo);
            this.Controls.Add(this.response);
            this.Controls.Add(this.RUN);
            this.Name = "Main";
            this.Text = "Quantiguous Solutions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button RUN;
        private System.Windows.Forms.TextBox response;
        private System.Windows.Forms.TextBox accountNo;
        private System.Windows.Forms.TextBox PartnerCode;
        private System.Windows.Forms.TextBox CustomerID;
        private System.Windows.Forms.Label Code;
        private System.Windows.Forms.Label Account;
        private System.Windows.Forms.Label CustomerCode;
        private System.Windows.Forms.Label ResponseText;
        private System.Windows.Forms.CheckBox clientSSL;
        private System.Windows.Forms.Label RequestedURL;
        private System.Windows.Forms.TextBox reqURL;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

