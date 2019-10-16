namespace CloudLog
{
    partial class Search
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
            this.txtSeverity = new System.Windows.Forms.TextBox();
            this.lblSeverity = new System.Windows.Forms.Label();
            this.lblLogTimestamp = new System.Windows.Forms.Label();
            this.lblReceiveTimestamp = new System.Windows.Forms.Label();
            this.txtProtoBValue = new System.Windows.Forms.TextBox();
            this.lblProtoBvalue = new System.Windows.Forms.Label();
            this.txtProtoBType = new System.Windows.Forms.TextBox();
            this.lblProtoTypeUrl = new System.Windows.Forms.Label();
            this.txtLogName = new System.Windows.Forms.TextBox();
            this.lblLogName = new System.Windows.Forms.Label();
            this.txtInsertId = new System.Windows.Forms.TextBox();
            this.lblInsertId = new System.Windows.Forms.Label();
            this.txtLogId = new System.Windows.Forms.TextBox();
            this.lblLogId = new System.Windows.Forms.Label();
            this.txtResource = new System.Windows.Forms.TextBox();
            this.lblResource = new System.Windows.Forms.Label();
            this.ddgSearch = new System.Windows.Forms.DataGridView();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dpRecieveFrom = new System.Windows.Forms.DateTimePicker();
            this.dpLogTimestampFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dpRecieveTo = new System.Windows.Forms.DateTimePicker();
            this.dpLogTimestampTo = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.ddgSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSeverity
            // 
            this.txtSeverity.Location = new System.Drawing.Point(80, 119);
            this.txtSeverity.Name = "txtSeverity";
            this.txtSeverity.Size = new System.Drawing.Size(265, 20);
            this.txtSeverity.TabIndex = 32;
            // 
            // lblSeverity
            // 
            this.lblSeverity.AutoSize = true;
            this.lblSeverity.Location = new System.Drawing.Point(7, 122);
            this.lblSeverity.Name = "lblSeverity";
            this.lblSeverity.Size = new System.Drawing.Size(45, 13);
            this.lblSeverity.TabIndex = 31;
            this.lblSeverity.Text = "Severity";
            // 
            // lblLogTimestamp
            // 
            this.lblLogTimestamp.AutoSize = true;
            this.lblLogTimestamp.Location = new System.Drawing.Point(7, 93);
            this.lblLogTimestamp.Name = "lblLogTimestamp";
            this.lblLogTimestamp.Size = new System.Drawing.Size(49, 13);
            this.lblLogTimestamp.TabIndex = 29;
            this.lblLogTimestamp.Text = "Log date";
            // 
            // lblReceiveTimestamp
            // 
            this.lblReceiveTimestamp.AutoSize = true;
            this.lblReceiveTimestamp.Location = new System.Drawing.Point(7, 67);
            this.lblReceiveTimestamp.Name = "lblReceiveTimestamp";
            this.lblReceiveTimestamp.Size = new System.Drawing.Size(71, 13);
            this.lblReceiveTimestamp.TabIndex = 27;
            this.lblReceiveTimestamp.Text = "Recieve date";
            // 
            // txtProtoBValue
            // 
            this.txtProtoBValue.Location = new System.Drawing.Point(80, 197);
            this.txtProtoBValue.Name = "txtProtoBValue";
            this.txtProtoBValue.Size = new System.Drawing.Size(265, 20);
            this.txtProtoBValue.TabIndex = 26;
            // 
            // lblProtoBvalue
            // 
            this.lblProtoBvalue.AutoSize = true;
            this.lblProtoBvalue.Location = new System.Drawing.Point(7, 200);
            this.lblProtoBvalue.Name = "lblProtoBvalue";
            this.lblProtoBvalue.Size = new System.Drawing.Size(68, 13);
            this.lblProtoBvalue.TabIndex = 25;
            this.lblProtoBvalue.Text = "ProtoB value";
            // 
            // txtProtoBType
            // 
            this.txtProtoBType.Location = new System.Drawing.Point(80, 171);
            this.txtProtoBType.Name = "txtProtoBType";
            this.txtProtoBType.Size = new System.Drawing.Size(265, 20);
            this.txtProtoBType.TabIndex = 24;
            // 
            // lblProtoTypeUrl
            // 
            this.lblProtoTypeUrl.AutoSize = true;
            this.lblProtoTypeUrl.Location = new System.Drawing.Point(7, 174);
            this.lblProtoTypeUrl.Name = "lblProtoTypeUrl";
            this.lblProtoTypeUrl.Size = new System.Drawing.Size(62, 13);
            this.lblProtoTypeUrl.TabIndex = 23;
            this.lblProtoTypeUrl.Text = "ProtoB type";
            // 
            // txtLogName
            // 
            this.txtLogName.Location = new System.Drawing.Point(80, 145);
            this.txtLogName.Name = "txtLogName";
            this.txtLogName.Size = new System.Drawing.Size(265, 20);
            this.txtLogName.TabIndex = 22;
            // 
            // lblLogName
            // 
            this.lblLogName.AutoSize = true;
            this.lblLogName.Location = new System.Drawing.Point(7, 148);
            this.lblLogName.Name = "lblLogName";
            this.lblLogName.Size = new System.Drawing.Size(56, 13);
            this.lblLogName.TabIndex = 21;
            this.lblLogName.Text = "Log Name";
            // 
            // txtInsertId
            // 
            this.txtInsertId.Location = new System.Drawing.Point(80, 38);
            this.txtInsertId.Name = "txtInsertId";
            this.txtInsertId.Size = new System.Drawing.Size(265, 20);
            this.txtInsertId.TabIndex = 20;
            // 
            // lblInsertId
            // 
            this.lblInsertId.AutoSize = true;
            this.lblInsertId.Location = new System.Drawing.Point(7, 38);
            this.lblInsertId.Name = "lblInsertId";
            this.lblInsertId.Size = new System.Drawing.Size(42, 13);
            this.lblInsertId.TabIndex = 19;
            this.lblInsertId.Text = "InsertId";
            // 
            // txtLogId
            // 
            this.txtLogId.Location = new System.Drawing.Point(80, 12);
            this.txtLogId.Name = "txtLogId";
            this.txtLogId.Size = new System.Drawing.Size(265, 20);
            this.txtLogId.TabIndex = 18;
            this.txtLogId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLogId_KeyPress);
            // 
            // lblLogId
            // 
            this.lblLogId.AutoSize = true;
            this.lblLogId.Location = new System.Drawing.Point(7, 12);
            this.lblLogId.Name = "lblLogId";
            this.lblLogId.Size = new System.Drawing.Size(34, 13);
            this.lblLogId.TabIndex = 17;
            this.lblLogId.Text = "LogId";
            // 
            // txtResource
            // 
            this.txtResource.Location = new System.Drawing.Point(80, 223);
            this.txtResource.Name = "txtResource";
            this.txtResource.Size = new System.Drawing.Size(265, 20);
            this.txtResource.TabIndex = 34;
            // 
            // lblResource
            // 
            this.lblResource.AutoSize = true;
            this.lblResource.Location = new System.Drawing.Point(7, 226);
            this.lblResource.Name = "lblResource";
            this.lblResource.Size = new System.Drawing.Size(53, 13);
            this.lblResource.TabIndex = 33;
            this.lblResource.Text = "Resource";
            // 
            // ddgSearch
            // 
            this.ddgSearch.AllowUserToAddRows = false;
            this.ddgSearch.AllowUserToDeleteRows = false;
            this.ddgSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ddgSearch.Location = new System.Drawing.Point(10, 249);
            this.ddgSearch.Name = "ddgSearch";
            this.ddgSearch.ReadOnly = true;
            this.ddgSearch.Size = new System.Drawing.Size(729, 319);
            this.ddgSearch.TabIndex = 35;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(577, 574);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 36;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(658, 574);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 37;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dpRecieveFrom
            // 
            this.dpRecieveFrom.Location = new System.Drawing.Point(80, 67);
            this.dpRecieveFrom.Name = "dpRecieveFrom";
            this.dpRecieveFrom.Size = new System.Drawing.Size(265, 20);
            this.dpRecieveFrom.TabIndex = 38;
            // 
            // dpLogTimestampFrom
            // 
            this.dpLogTimestampFrom.Location = new System.Drawing.Point(80, 93);
            this.dpLogTimestampFrom.Name = "dpLogTimestampFrom";
            this.dpLogTimestampFrom.Size = new System.Drawing.Size(265, 20);
            this.dpLogTimestampFrom.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "TO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "TO";
            // 
            // dpRecieveTo
            // 
            this.dpRecieveTo.Location = new System.Drawing.Point(379, 70);
            this.dpRecieveTo.Name = "dpRecieveTo";
            this.dpRecieveTo.Size = new System.Drawing.Size(265, 20);
            this.dpRecieveTo.TabIndex = 42;
            // 
            // dpLogTimestampTo
            // 
            this.dpLogTimestampTo.Location = new System.Drawing.Point(379, 96);
            this.dpLogTimestampTo.Name = "dpLogTimestampTo";
            this.dpLogTimestampTo.Size = new System.Drawing.Size(265, 20);
            this.dpLogTimestampTo.TabIndex = 43;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 607);
            this.Controls.Add(this.dpLogTimestampTo);
            this.Controls.Add(this.dpRecieveTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dpLogTimestampFrom);
            this.Controls.Add(this.dpRecieveFrom);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.ddgSearch);
            this.Controls.Add(this.txtResource);
            this.Controls.Add(this.lblResource);
            this.Controls.Add(this.txtSeverity);
            this.Controls.Add(this.lblSeverity);
            this.Controls.Add(this.lblLogTimestamp);
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
            this.Name = "Search";
            this.Text = "Search";
            ((System.ComponentModel.ISupportInitialize)(this.ddgSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSeverity;
        private System.Windows.Forms.Label lblSeverity;
        private System.Windows.Forms.Label lblLogTimestamp;
        private System.Windows.Forms.Label lblReceiveTimestamp;
        private System.Windows.Forms.TextBox txtProtoBValue;
        private System.Windows.Forms.Label lblProtoBvalue;
        private System.Windows.Forms.TextBox txtProtoBType;
        private System.Windows.Forms.Label lblProtoTypeUrl;
        private System.Windows.Forms.TextBox txtLogName;
        private System.Windows.Forms.Label lblLogName;
        private System.Windows.Forms.TextBox txtInsertId;
        private System.Windows.Forms.Label lblInsertId;
        private System.Windows.Forms.TextBox txtLogId;
        private System.Windows.Forms.Label lblLogId;
        private System.Windows.Forms.TextBox txtResource;
        private System.Windows.Forms.Label lblResource;
        private System.Windows.Forms.DataGridView ddgSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dpRecieveFrom;
        private System.Windows.Forms.DateTimePicker dpLogTimestampFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dpRecieveTo;
        private System.Windows.Forms.DateTimePicker dpLogTimestampTo;
    }
}