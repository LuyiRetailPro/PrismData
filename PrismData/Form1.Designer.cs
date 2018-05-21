namespace PrismData
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
            this.PrismServerNameLabel = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.PrismPasswordLabel = new System.Windows.Forms.Label();
            this.WorkStation = new System.Windows.Forms.Label();
            this.AuthNonceLabel = new System.Windows.Forms.Label();
            this.AuthNonceResponseLabel = new System.Windows.Forms.Label();
            this.PrismServerName = new System.Windows.Forms.TextBox();
            this.AuthNonce = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.PrismPassword = new System.Windows.Forms.TextBox();
            this.PrismUserName = new System.Windows.Forms.TextBox();
            this.AuthNonceResponse = new System.Windows.Forms.TextBox();
            this.Authenticate = new System.Windows.Forms.Button();
            this.AuthSessionLabel = new System.Windows.Forms.Label();
            this.AuthSessionToken = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.ResponsePayLoadTab = new System.Windows.Forms.TabPage();
            this.ResponsePayload = new System.Windows.Forms.RichTextBox();
            this.RequestPayloadTab = new System.Windows.Forms.TabPage();
            this.RequestPayload = new System.Windows.Forms.RichTextBox();
            this.tabpage3 = new System.Windows.Forms.TabPage();
            this.ResponseLog = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RequestSource = new System.Windows.Forms.ComboBox();
            this.ExcuteRequest = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.RequestMethod = new System.Windows.Forms.ComboBox();
            this.ResourceColumns = new System.Windows.Forms.TextBox();
            this.ResourceFilter = new System.Windows.Forms.TextBox();
            this.ResourceName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tabControl.SuspendLayout();
            this.ResponsePayLoadTab.SuspendLayout();
            this.RequestPayloadTab.SuspendLayout();
            this.tabpage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PrismServerNameLabel
            // 
            this.PrismServerNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrismServerNameLabel.AutoSize = true;
            this.PrismServerNameLabel.Location = new System.Drawing.Point(6, 21);
            this.PrismServerNameLabel.Name = "PrismServerNameLabel";
            this.PrismServerNameLabel.Size = new System.Drawing.Size(130, 17);
            this.PrismServerNameLabel.TabIndex = 0;
            this.PrismServerNameLabel.Text = "Prism Server Name";
            // 
            // UserName
            // 
            this.UserName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(303, 18);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(118, 17);
            this.UserName.TabIndex = 1;
            this.UserName.Text = "Prism User Name";
            // 
            // PrismPasswordLabel
            // 
            this.PrismPasswordLabel.AutoSize = true;
            this.PrismPasswordLabel.Location = new System.Drawing.Point(607, 16);
            this.PrismPasswordLabel.Name = "PrismPasswordLabel";
            this.PrismPasswordLabel.Size = new System.Drawing.Size(108, 17);
            this.PrismPasswordLabel.TabIndex = 2;
            this.PrismPasswordLabel.Text = "Prism Password";
            // 
            // WorkStation
            // 
            this.WorkStation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WorkStation.AutoSize = true;
            this.WorkStation.Location = new System.Drawing.Point(6, 53);
            this.WorkStation.Name = "WorkStation";
            this.WorkStation.Size = new System.Drawing.Size(89, 17);
            this.WorkStation.TabIndex = 3;
            this.WorkStation.Text = "Work Station";
            // 
            // AuthNonceLabel
            // 
            this.AuthNonceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AuthNonceLabel.AutoSize = true;
            this.AuthNonceLabel.Location = new System.Drawing.Point(303, 53);
            this.AuthNonceLabel.Name = "AuthNonceLabel";
            this.AuthNonceLabel.Size = new System.Drawing.Size(82, 17);
            this.AuthNonceLabel.TabIndex = 4;
            this.AuthNonceLabel.Text = "Auth Nonce";
            // 
            // AuthNonceResponseLabel
            // 
            this.AuthNonceResponseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AuthNonceResponseLabel.Location = new System.Drawing.Point(607, 50);
            this.AuthNonceResponseLabel.Name = "AuthNonceResponseLabel";
            this.AuthNonceResponseLabel.Size = new System.Drawing.Size(152, 20);
            this.AuthNonceResponseLabel.TabIndex = 5;
            this.AuthNonceResponseLabel.Text = "Auth Nonce Response";
            this.AuthNonceResponseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PrismServerName
            // 
            this.PrismServerName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrismServerName.Location = new System.Drawing.Point(142, 21);
            this.PrismServerName.Name = "PrismServerName";
            this.PrismServerName.Size = new System.Drawing.Size(153, 22);
            this.PrismServerName.TabIndex = 6;
            // 
            // AuthNonce
            // 
            this.AuthNonce.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AuthNonce.Location = new System.Drawing.Point(441, 50);
            this.AuthNonce.Name = "AuthNonce";
            this.AuthNonce.Size = new System.Drawing.Size(153, 22);
            this.AuthNonce.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(142, 50);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(153, 22);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "1";
            // 
            // PrismPassword
            // 
            this.PrismPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrismPassword.Location = new System.Drawing.Point(777, 16);
            this.PrismPassword.Name = "PrismPassword";
            this.PrismPassword.Size = new System.Drawing.Size(153, 22);
            this.PrismPassword.TabIndex = 9;
            this.PrismPassword.Text = "sysadmin";
            // 
            // PrismUserName
            // 
            this.PrismUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrismUserName.Location = new System.Drawing.Point(441, 18);
            this.PrismUserName.Name = "PrismUserName";
            this.PrismUserName.Size = new System.Drawing.Size(153, 22);
            this.PrismUserName.TabIndex = 10;
            this.PrismUserName.Text = "sysadmin";
            // 
            // AuthNonceResponse
            // 
            this.AuthNonceResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AuthNonceResponse.Location = new System.Drawing.Point(777, 48);
            this.AuthNonceResponse.Name = "AuthNonceResponse";
            this.AuthNonceResponse.Size = new System.Drawing.Size(153, 22);
            this.AuthNonceResponse.TabIndex = 11;
            // 
            // Authenticate
            // 
            this.Authenticate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Authenticate.Location = new System.Drawing.Point(610, 82);
            this.Authenticate.Name = "Authenticate";
            this.Authenticate.Size = new System.Drawing.Size(320, 22);
            this.Authenticate.TabIndex = 12;
            this.Authenticate.Text = "Get Authentication";
            this.Authenticate.UseVisualStyleBackColor = true;
            this.Authenticate.Click += new System.EventHandler(this.Authenticate_Click);
            // 
            // AuthSessionLabel
            // 
            this.AuthSessionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AuthSessionLabel.AutoSize = true;
            this.AuthSessionLabel.Location = new System.Drawing.Point(6, 82);
            this.AuthSessionLabel.Name = "AuthSessionLabel";
            this.AuthSessionLabel.Size = new System.Drawing.Size(91, 17);
            this.AuthSessionLabel.TabIndex = 13;
            this.AuthSessionLabel.Text = "Auth Session";
            // 
            // AuthSessionToken
            // 
            this.AuthSessionToken.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AuthSessionToken.Location = new System.Drawing.Point(142, 82);
            this.AuthSessionToken.Name = "AuthSessionToken";
            this.AuthSessionToken.Size = new System.Drawing.Size(452, 22);
            this.AuthSessionToken.TabIndex = 14;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.ResponsePayLoadTab);
            this.tabControl.Controls.Add(this.RequestPayloadTab);
            this.tabControl.Controls.Add(this.tabpage3);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(3, 18);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(943, 319);
            this.tabControl.TabIndex = 16;
            // 
            // ResponsePayLoadTab
            // 
            this.ResponsePayLoadTab.Controls.Add(this.ResponsePayload);
            this.ResponsePayLoadTab.Location = new System.Drawing.Point(4, 25);
            this.ResponsePayLoadTab.Name = "ResponsePayLoadTab";
            this.ResponsePayLoadTab.Padding = new System.Windows.Forms.Padding(3);
            this.ResponsePayLoadTab.Size = new System.Drawing.Size(935, 290);
            this.ResponsePayLoadTab.TabIndex = 1;
            this.ResponsePayLoadTab.Text = "Response Payload";
            this.ResponsePayLoadTab.UseVisualStyleBackColor = true;
            // 
            // ResponsePayload
            // 
            this.ResponsePayload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResponsePayload.Location = new System.Drawing.Point(3, 3);
            this.ResponsePayload.Name = "ResponsePayload";
            this.ResponsePayload.Size = new System.Drawing.Size(929, 284);
            this.ResponsePayload.TabIndex = 0;
            this.ResponsePayload.Text = "";
            // 
            // RequestPayloadTab
            // 
            this.RequestPayloadTab.Controls.Add(this.RequestPayload);
            this.RequestPayloadTab.Location = new System.Drawing.Point(4, 25);
            this.RequestPayloadTab.Name = "RequestPayloadTab";
            this.RequestPayloadTab.Padding = new System.Windows.Forms.Padding(3);
            this.RequestPayloadTab.Size = new System.Drawing.Size(935, 287);
            this.RequestPayloadTab.TabIndex = 0;
            this.RequestPayloadTab.Text = "Request Payload";
            this.RequestPayloadTab.UseVisualStyleBackColor = true;
            // 
            // RequestPayload
            // 
            this.RequestPayload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RequestPayload.Location = new System.Drawing.Point(3, 3);
            this.RequestPayload.Name = "RequestPayload";
            this.RequestPayload.Size = new System.Drawing.Size(929, 281);
            this.RequestPayload.TabIndex = 0;
            this.RequestPayload.Text = "";
            // 
            // tabpage3
            // 
            this.tabpage3.Controls.Add(this.ResponseLog);
            this.tabpage3.Location = new System.Drawing.Point(4, 25);
            this.tabpage3.Name = "tabpage3";
            this.tabpage3.Size = new System.Drawing.Size(935, 287);
            this.tabpage3.TabIndex = 2;
            this.tabpage3.Text = "Logs";
            this.tabpage3.UseVisualStyleBackColor = true;
            // 
            // ResponseLog
            // 
            this.ResponseLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResponseLog.Location = new System.Drawing.Point(0, 0);
            this.ResponseLog.Name = "ResponseLog";
            this.ResponseLog.Size = new System.Drawing.Size(935, 287);
            this.ResponseLog.TabIndex = 0;
            this.ResponseLog.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.UserName);
            this.groupBox1.Controls.Add(this.PrismServerNameLabel);
            this.groupBox1.Controls.Add(this.AuthSessionToken);
            this.groupBox1.Controls.Add(this.PrismPasswordLabel);
            this.groupBox1.Controls.Add(this.AuthSessionLabel);
            this.groupBox1.Controls.Add(this.WorkStation);
            this.groupBox1.Controls.Add(this.Authenticate);
            this.groupBox1.Controls.Add(this.AuthNonceLabel);
            this.groupBox1.Controls.Add(this.AuthNonceResponse);
            this.groupBox1.Controls.Add(this.AuthNonceResponseLabel);
            this.groupBox1.Controls.Add(this.PrismUserName);
            this.groupBox1.Controls.Add(this.PrismServerName);
            this.groupBox1.Controls.Add(this.PrismPassword);
            this.groupBox1.Controls.Add(this.AuthNonce);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(949, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.RequestSource);
            this.groupBox2.Controls.Add(this.ExcuteRequest);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.RequestMethod);
            this.groupBox2.Controls.Add(this.ResourceColumns);
            this.groupBox2.Controls.Add(this.ResourceFilter);
            this.groupBox2.Controls.Add(this.ResourceName);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(949, 118);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // RequestSource
            // 
            this.RequestSource.FormattingEnabled = true;
            this.RequestSource.Items.AddRange(new object[] {
            "/v1/rest/",
            "/api/backoffice/"});
            this.RequestSource.Location = new System.Drawing.Point(139, 73);
            this.RequestSource.Name = "RequestSource";
            this.RequestSource.Size = new System.Drawing.Size(214, 24);
            this.RequestSource.TabIndex = 16;
            this.RequestSource.Text = "/v1/rest/";
            // 
            // ExcuteRequest
            // 
            this.ExcuteRequest.Location = new System.Drawing.Point(842, 16);
            this.ExcuteRequest.Name = "ExcuteRequest";
            this.ExcuteRequest.Size = new System.Drawing.Size(88, 52);
            this.ExcuteRequest.TabIndex = 15;
            this.ExcuteRequest.Text = "Excute";
            this.ExcuteRequest.UseVisualStyleBackColor = true;
            this.ExcuteRequest.Click += new System.EventHandler(this.ExcuteRequest_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(296, 47);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(57, 21);
            this.radioButton2.TabIndex = 14;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "XML";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(223, 46);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(66, 21);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "JSON";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // RequestMethod
            // 
            this.RequestMethod.FormattingEnabled = true;
            this.RequestMethod.Items.AddRange(new object[] {
            "Get",
            "Post",
            "Put",
            "Delete"});
            this.RequestMethod.Location = new System.Drawing.Point(139, 44);
            this.RequestMethod.Name = "RequestMethod";
            this.RequestMethod.Size = new System.Drawing.Size(78, 24);
            this.RequestMethod.TabIndex = 12;
            this.RequestMethod.Text = "Get";
            // 
            // ResourceColumns
            // 
            this.ResourceColumns.Location = new System.Drawing.Point(517, 46);
            this.ResourceColumns.Name = "ResourceColumns";
            this.ResourceColumns.Size = new System.Drawing.Size(313, 22);
            this.ResourceColumns.TabIndex = 10;
            // 
            // ResourceFilter
            // 
            this.ResourceFilter.Location = new System.Drawing.Point(517, 15);
            this.ResourceFilter.Name = "ResourceFilter";
            this.ResourceFilter.Size = new System.Drawing.Size(313, 22);
            this.ResourceFilter.TabIndex = 9;
            // 
            // ResourceName
            // 
            this.ResourceName.Location = new System.Drawing.Point(139, 18);
            this.ResourceName.Name = "ResourceName";
            this.ResourceName.Size = new System.Drawing.Size(214, 22);
            this.ResourceName.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Request Source";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(604, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(378, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Resource Columns";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Request Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(604, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Resource Filter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resource Name";
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.tabControl);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 232);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(949, 340);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 572);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Prism Data";
            this.tabControl.ResumeLayout(false);
            this.ResponsePayLoadTab.ResumeLayout(false);
            this.RequestPayloadTab.ResumeLayout(false);
            this.tabpage3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PrismServerNameLabel;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label PrismPasswordLabel;
        private System.Windows.Forms.Label WorkStation;
        private System.Windows.Forms.Label AuthNonceLabel;
        private System.Windows.Forms.Label AuthNonceResponseLabel;
        private System.Windows.Forms.TextBox PrismServerName;
        private System.Windows.Forms.TextBox AuthNonce;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox PrismPassword;
        private System.Windows.Forms.TextBox PrismUserName;
        private System.Windows.Forms.TextBox AuthNonceResponse;
        private System.Windows.Forms.Button Authenticate;
        private System.Windows.Forms.Label AuthSessionLabel;
        private System.Windows.Forms.TextBox AuthSessionToken;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage RequestPayloadTab;
        private System.Windows.Forms.TabPage ResponsePayLoadTab;
        private System.Windows.Forms.RichTextBox ResponsePayload;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox RequestMethod;
        private System.Windows.Forms.TextBox ResourceColumns;
        private System.Windows.Forms.TextBox ResourceFilter;
        private System.Windows.Forms.TextBox ResourceName;
        private System.Windows.Forms.Button ExcuteRequest;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RichTextBox RequestPayload;
        private System.Windows.Forms.TabPage tabpage3;
        private System.Windows.Forms.RichTextBox ResponseLog;
        private System.Windows.Forms.ComboBox RequestSource;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

