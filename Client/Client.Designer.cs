namespace Client
{
    partial class clientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clientForm));
            this.botPanel = new System.Windows.Forms.Panel();
            this.sendBtn = new System.Windows.Forms.Button();
            this.sendRTBox = new System.Windows.Forms.RichTextBox();
            this.topPanel = new System.Windows.Forms.Panel();
            this.userLabel = new System.Windows.Forms.Label();
            this.ipLabel = new System.Windows.Forms.Label();
            this.ipTBox = new System.Windows.Forms.TextBox();
            this.userTBox = new System.Windows.Forms.TextBox();
            this.connectBtn = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.mainRTBox = new System.Windows.Forms.RichTextBox();
            this.botPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // botPanel
            // 
            this.botPanel.Controls.Add(this.sendBtn);
            this.botPanel.Controls.Add(this.sendRTBox);
            this.botPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.botPanel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botPanel.Location = new System.Drawing.Point(0, 283);
            this.botPanel.Name = "botPanel";
            this.botPanel.Size = new System.Drawing.Size(582, 70);
            this.botPanel.TabIndex = 1;
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(500, 9);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(70, 50);
            this.sendBtn.TabIndex = 1;
            this.sendBtn.Text = "SEND";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // sendRTBox
            // 
            this.sendRTBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sendRTBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendRTBox.Location = new System.Drawing.Point(11, 9);
            this.sendRTBox.Name = "sendRTBox";
            this.sendRTBox.Size = new System.Drawing.Size(481, 50);
            this.sendRTBox.TabIndex = 0;
            this.sendRTBox.Text = "";
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.userLabel);
            this.topPanel.Controls.Add(this.ipLabel);
            this.topPanel.Controls.Add(this.ipTBox);
            this.topPanel.Controls.Add(this.userTBox);
            this.topPanel.Controls.Add(this.connectBtn);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(582, 41);
            this.topPanel.TabIndex = 2;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(261, 13);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(78, 15);
            this.userLabel.TabIndex = 4;
            this.userLabel.Text = "Username:";
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Location = new System.Drawing.Point(43, 13);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(24, 15);
            this.ipLabel.TabIndex = 3;
            this.ipLabel.Text = "IP:";
            // 
            // ipTBox
            // 
            this.ipTBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipTBox.Location = new System.Drawing.Point(68, 8);
            this.ipTBox.Name = "ipTBox";
            this.ipTBox.Size = new System.Drawing.Size(153, 25);
            this.ipTBox.TabIndex = 2;
            this.ipTBox.Text = "127.0.0.1";
            this.ipTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // userTBox
            // 
            this.userTBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTBox.Location = new System.Drawing.Point(340, 8);
            this.userTBox.Name = "userTBox";
            this.userTBox.Size = new System.Drawing.Size(100, 25);
            this.userTBox.TabIndex = 1;
            this.userTBox.Text = "tu";
            this.userTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // connectBtn
            // 
            this.connectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.connectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectBtn.Location = new System.Drawing.Point(460, 5);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(100, 32);
            this.connectBtn.TabIndex = 0;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = false;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Controls.Add(this.mainRTBox);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 41);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(582, 242);
            this.mainPanel.TabIndex = 3;
            // 
            // mainRTBox
            // 
            this.mainRTBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainRTBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainRTBox.Enabled = false;
            this.mainRTBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainRTBox.Location = new System.Drawing.Point(0, 0);
            this.mainRTBox.Name = "mainRTBox";
            this.mainRTBox.Size = new System.Drawing.Size(580, 240);
            this.mainRTBox.TabIndex = 0;
            this.mainRTBox.Text = "";
            // 
            // clientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.botPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "clientForm";
            this.Text = "Client";
            this.botPanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel botPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.RichTextBox mainRTBox;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.TextBox userTBox;
        private System.Windows.Forms.TextBox ipTBox;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.RichTextBox sendRTBox;
    }
}

