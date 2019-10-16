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
            ((System.ComponentModel.ISupportInitialize)(this.ddgDefault)).BeginInit();
            this.SuspendLayout();
            // 
            // ddgDefault
            // 
            this.ddgDefault.AllowUserToAddRows = false;
            this.ddgDefault.AllowUserToDeleteRows = false;
            this.ddgDefault.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ddgDefault.Location = new System.Drawing.Point(30, 99);
            this.ddgDefault.Name = "ddgDefault";
            this.ddgDefault.ReadOnly = true;
            this.ddgDefault.Size = new System.Drawing.Size(744, 309);
            this.ddgDefault.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ddgDefault);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ddgDefault)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ddgDefault;
    }
}

