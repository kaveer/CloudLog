namespace CloudLog
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
            this.ddgDefault = new System.Windows.Forms.DataGridView();
            this.lblLogId = new System.Windows.Forms.Label();
            this.txtLogId = new System.Windows.Forms.TextBox();
            this.txtInsertId = new System.Windows.Forms.TextBox();
            this.lblInsertId = new System.Windows.Forms.Label();
            this.txtLogName = new System.Windows.Forms.TextBox();
            this.lblLogName = new System.Windows.Forms.Label();
            this.txtProtoBType = new System.Windows.Forms.TextBox();
            this.lblProtoTypeUrl = new System.Windows.Forms.Label();
            this.txtProtoBValue = new System.Windows.Forms.TextBox();
            this.lblProtoBvalue = new System.Windows.Forms.Label();
            this.txtRecieveDate = new System.Windows.Forms.TextBox();
            this.lblReceiveTimestamp = new System.Windows.Forms.Label();
            this.txtLogTimstamp = new System.Windows.Forms.TextBox();
            this.lblLogTimestamp = new System.Windows.Forms.Label();
            this.txtSeverity = new System.Windows.Forms.TextBox();
            this.lblSeverity = new System.Windows.Forms.Label();
            this.ddgResource = new System.Windows.Forms.DataGridView();
            this.lblResource = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ddgDefault)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddgResource)).BeginInit();
            this.SuspendLayout();
            // 
            // ddgDefault
            // 
            this.ddgDefault.AllowUserToAddRows = false;
            this.ddgDefault.AllowUserToDeleteRows = false;
            this.ddgDefault.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ddgDefault.Location = new System.Drawing.Point(12, 12);
            this.ddgDefault.Name = "ddgDefault";
            this.ddgDefault.ReadOnly = true;
            this.ddgDefault.Size = new System.Drawing.Size(469, 370);
            this.ddgDefault.TabIndex = 0;
            // 
            // lblLogId
            // 
            this.lblLogId.AutoSize = true;
            this.lblLogId.Location = new System.Drawing.Point(489, 13);
            this.lblLogId.Name = "lblLogId";
            this.lblLogId.Size = new System.Drawing.Size(34, 13);
            this.lblLogId.TabIndex = 1;
            this.lblLogId.Text = "LogId";
            // 
            // txtLogId
            // 
            this.txtLogId.Location = new System.Drawing.Point(562, 13);
            this.txtLogId.Name = "txtLogId";
            this.txtLogId.Size = new System.Drawing.Size(111, 20);
            this.txtLogId.TabIndex = 2;
            // 
            // txtInsertId
            // 
            this.txtInsertId.Location = new System.Drawing.Point(727, 12);
            this.txtInsertId.Name = "txtInsertId";
            this.txtInsertId.Size = new System.Drawing.Size(100, 20);
            this.txtInsertId.TabIndex = 4;
            // 
            // lblInsertId
            // 
            this.lblInsertId.AutoSize = true;
            this.lblInsertId.Location = new System.Drawing.Point(679, 13);
            this.lblInsertId.Name = "lblInsertId";
            this.lblInsertId.Size = new System.Drawing.Size(42, 13);
            this.lblInsertId.TabIndex = 3;
            this.lblInsertId.Text = "InsertId";
            // 
            // txtLogName
            // 
            this.txtLogName.Location = new System.Drawing.Point(562, 39);
            this.txtLogName.Name = "txtLogName";
            this.txtLogName.Size = new System.Drawing.Size(265, 20);
            this.txtLogName.TabIndex = 6;
            // 
            // lblLogName
            // 
            this.lblLogName.AutoSize = true;
            this.lblLogName.Location = new System.Drawing.Point(488, 39);
            this.lblLogName.Name = "lblLogName";
            this.lblLogName.Size = new System.Drawing.Size(56, 13);
            this.lblLogName.TabIndex = 5;
            this.lblLogName.Text = "Log Name";
            // 
            // txtProtoBType
            // 
            this.txtProtoBType.Location = new System.Drawing.Point(562, 65);
            this.txtProtoBType.Name = "txtProtoBType";
            this.txtProtoBType.Size = new System.Drawing.Size(265, 20);
            this.txtProtoBType.TabIndex = 8;
            // 
            // lblProtoTypeUrl
            // 
            this.lblProtoTypeUrl.AutoSize = true;
            this.lblProtoTypeUrl.Location = new System.Drawing.Point(488, 65);
            this.lblProtoTypeUrl.Name = "lblProtoTypeUrl";
            this.lblProtoTypeUrl.Size = new System.Drawing.Size(62, 13);
            this.lblProtoTypeUrl.TabIndex = 7;
            this.lblProtoTypeUrl.Text = "ProtoB type";
            // 
            // txtProtoBValue
            // 
            this.txtProtoBValue.Location = new System.Drawing.Point(562, 91);
            this.txtProtoBValue.Multiline = true;
            this.txtProtoBValue.Name = "txtProtoBValue";
            this.txtProtoBValue.Size = new System.Drawing.Size(265, 86);
            this.txtProtoBValue.TabIndex = 10;
            // 
            // lblProtoBvalue
            // 
            this.lblProtoBvalue.AutoSize = true;
            this.lblProtoBvalue.Location = new System.Drawing.Point(488, 91);
            this.lblProtoBvalue.Name = "lblProtoBvalue";
            this.lblProtoBvalue.Size = new System.Drawing.Size(68, 13);
            this.lblProtoBvalue.TabIndex = 9;
            this.lblProtoBvalue.Text = "ProtoB value";
            // 
            // txtRecieveDate
            // 
            this.txtRecieveDate.Location = new System.Drawing.Point(562, 183);
            this.txtRecieveDate.Name = "txtRecieveDate";
            this.txtRecieveDate.Size = new System.Drawing.Size(111, 20);
            this.txtRecieveDate.TabIndex = 12;
            // 
            // lblReceiveTimestamp
            // 
            this.lblReceiveTimestamp.AutoSize = true;
            this.lblReceiveTimestamp.Location = new System.Drawing.Point(488, 183);
            this.lblReceiveTimestamp.Name = "lblReceiveTimestamp";
            this.lblReceiveTimestamp.Size = new System.Drawing.Size(71, 13);
            this.lblReceiveTimestamp.TabIndex = 11;
            this.lblReceiveTimestamp.Text = "Recieve date";
            // 
            // txtLogTimstamp
            // 
            this.txtLogTimstamp.Location = new System.Drawing.Point(727, 183);
            this.txtLogTimstamp.Name = "txtLogTimstamp";
            this.txtLogTimstamp.Size = new System.Drawing.Size(100, 20);
            this.txtLogTimstamp.TabIndex = 14;
            // 
            // lblLogTimestamp
            // 
            this.lblLogTimestamp.AutoSize = true;
            this.lblLogTimestamp.Location = new System.Drawing.Point(679, 186);
            this.lblLogTimestamp.Name = "lblLogTimestamp";
            this.lblLogTimestamp.Size = new System.Drawing.Size(49, 13);
            this.lblLogTimestamp.TabIndex = 13;
            this.lblLogTimestamp.Text = "Log date";
            // 
            // txtSeverity
            // 
            this.txtSeverity.Location = new System.Drawing.Point(562, 209);
            this.txtSeverity.Name = "txtSeverity";
            this.txtSeverity.Size = new System.Drawing.Size(265, 20);
            this.txtSeverity.TabIndex = 16;
            // 
            // lblSeverity
            // 
            this.lblSeverity.AutoSize = true;
            this.lblSeverity.Location = new System.Drawing.Point(486, 209);
            this.lblSeverity.Name = "lblSeverity";
            this.lblSeverity.Size = new System.Drawing.Size(45, 13);
            this.lblSeverity.TabIndex = 15;
            this.lblSeverity.Text = "Severity";
            // 
            // ddgResource
            // 
            this.ddgResource.AllowUserToAddRows = false;
            this.ddgResource.AllowUserToDeleteRows = false;
            this.ddgResource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ddgResource.Location = new System.Drawing.Point(491, 288);
            this.ddgResource.Name = "ddgResource";
            this.ddgResource.ReadOnly = true;
            this.ddgResource.Size = new System.Drawing.Size(336, 150);
            this.ddgResource.TabIndex = 17;
            // 
            // lblResource
            // 
            this.lblResource.AutoSize = true;
            this.lblResource.Location = new System.Drawing.Point(488, 272);
            this.lblResource.Name = "lblResource";
            this.lblResource.Size = new System.Drawing.Size(53, 13);
            this.lblResource.TabIndex = 18;
            this.lblResource.Text = "Resource";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(13, 405);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 19;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(95, 404);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 450);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblResource);
            this.Controls.Add(this.ddgResource);
            this.Controls.Add(this.txtSeverity);
            this.Controls.Add(this.lblSeverity);
            this.Controls.Add(this.txtLogTimstamp);
            this.Controls.Add(this.lblLogTimestamp);
            this.Controls.Add(this.txtRecieveDate);
            this.Controls.Add(this.lblReceiveTimestamp);
            this.Controls.Add(this.txtProtoBValue);
            this.Controls.Add(this.lblProtoBvalue);
            this.Controls.Add(this.txtProtoBType);
            this.Controls.Add(this.lblProtoTypeUrl);
            this.Controls.Add(this.txtLogName);
            this.Controls.Add(this.lblLogName);
            this.Controls.Add(this.txtInsertId);
            this.Controls.Add(this.lblInsertId);
            this.Controls.Add(this.txtLogId);
            this.Controls.Add(this.lblLogId);
            this.Controls.Add(this.ddgDefault);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ddgDefault)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddgResource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ddgDefault;
        private System.Windows.Forms.Label lblLogId;
        private System.Windows.Forms.TextBox txtLogId;
        private System.Windows.Forms.TextBox txtInsertId;
        private System.Windows.Forms.Label lblInsertId;
        private System.Windows.Forms.TextBox txtLogName;
        private System.Windows.Forms.Label lblLogName;
        private System.Windows.Forms.TextBox txtProtoBType;
        private System.Windows.Forms.Label lblProtoTypeUrl;
        private System.Windows.Forms.TextBox txtProtoBValue;
        private System.Windows.Forms.Label lblProtoBvalue;
        private System.Windows.Forms.TextBox txtRecieveDate;
        private System.Windows.Forms.Label lblReceiveTimestamp;
        private System.Windows.Forms.TextBox txtLogTimstamp;
        private System.Windows.Forms.Label lblLogTimestamp;
        private System.Windows.Forms.TextBox txtSeverity;
        private System.Windows.Forms.Label lblSeverity;
        private System.Windows.Forms.DataGridView ddgResource;
        private System.Windows.Forms.Label lblResource;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
    }
}

