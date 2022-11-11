namespace CinemaSystemWF
{
    partial class CheckTicket
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
            this.label4 = new System.Windows.Forms.Label();
            this.CheckBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxOTP = new System.Windows.Forms.TextBox();
            this.TextBoxEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DGLogs = new System.Windows.Forms.DataGridView();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(376, 42);
            this.label4.TabIndex = 8;
            this.label4.Text = "Check Ticket";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CheckBtn
            // 
            this.CheckBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckBtn.Location = new System.Drawing.Point(130, 208);
            this.CheckBtn.Name = "CheckBtn";
            this.CheckBtn.Size = new System.Drawing.Size(140, 40);
            this.CheckBtn.TabIndex = 13;
            this.CheckBtn.Text = "Check";
            this.CheckBtn.UseVisualStyleBackColor = true;
            this.CheckBtn.Click += new System.EventHandler(this.CheckBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "OTP";
            // 
            // TextBoxOTP
            // 
            this.TextBoxOTP.Location = new System.Drawing.Point(75, 166);
            this.TextBoxOTP.Name = "TextBoxOTP";
            this.TextBoxOTP.Size = new System.Drawing.Size(313, 23);
            this.TextBoxOTP.TabIndex = 11;
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.Location = new System.Drawing.Point(75, 137);
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.Size = new System.Drawing.Size(313, 23);
            this.TextBoxEmail.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Email";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.DGLogs);
            this.groupBox1.Location = new System.Drawing.Point(394, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 402);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Logs";
            // 
            // DGLogs
            // 
            this.DGLogs.AllowUserToAddRows = false;
            this.DGLogs.AllowUserToDeleteRows = false;
            this.DGLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.Email,
            this.Status});
            this.DGLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGLogs.Location = new System.Drawing.Point(3, 19);
            this.DGLogs.Name = "DGLogs";
            this.DGLogs.ReadOnly = true;
            this.DGLogs.RowTemplate.Height = 25;
            this.DGLogs.Size = new System.Drawing.Size(388, 380);
            this.DGLogs.TabIndex = 0;
            // 
            // Time
            // 
            this.Time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Width = 58;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 64;
            // 
            // CheckTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CheckBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxOTP);
            this.Controls.Add(this.TextBoxEmail);
            this.Controls.Add(this.label2);
            this.Name = "CheckTicket";
            this.Text = "CheckTicket";
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.TextBoxEmail, 0);
            this.Controls.SetChildIndex(this.TextBoxOTP, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.CheckBtn, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGLogs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label4;
        private Button CheckBtn;
        private Label label3;
        private TextBox TextBoxOTP;
        private TextBox TextBoxEmail;
        private Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox1;
        private DataGridView DGLogs;
        private DataGridViewTextBoxColumn Time;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Status;
    }
}