namespace Server
{
    partial class serverForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(serverForm));
            this.topPanel = new System.Windows.Forms.Panel();
            this.ipTBox = new System.Windows.Forms.TextBox();
            this.ipLabel = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.logLabel = new System.Windows.Forms.Label();
            this.logRTBox = new System.Windows.Forms.RichTextBox();
            this.topPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.ipTBox);
            this.topPanel.Controls.Add(this.ipLabel);
            this.topPanel.Controls.Add(this.startBtn);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(353, 60);
            this.topPanel.TabIndex = 0;
            // 
            // ipTBox
            // 
            this.ipTBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipTBox.Location = new System.Drawing.Point(67, 16);
            this.ipTBox.Name = "ipTBox";
            this.ipTBox.Size = new System.Drawing.Size(150, 27);
            this.ipTBox.TabIndex = 0;
            this.ipTBox.Text = "127.0.0.1";
            this.ipTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipLabel.Location = new System.Drawing.Point(34, 20);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(30, 19);
            this.ipLabel.TabIndex = 2;
            this.ipLabel.Text = "IP:";
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(244, 10);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(80, 40);
            this.startBtn.TabIndex = 1;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Controls.Add(this.logLabel);
            this.mainPanel.Controls.Add(this.logRTBox);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 60);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(353, 366);
            this.mainPanel.TabIndex = 1;
            // 
            // logLabel
            // 
            this.logLabel.AutoSize = true;
            this.logLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logLabel.Location = new System.Drawing.Point(3, 2);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(45, 20);
            this.logLabel.TabIndex = 1;
            this.logLabel.Text = "Log:";
            // 
            // logRTBox
            // 
            this.logRTBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logRTBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logRTBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logRTBox.Location = new System.Drawing.Point(0, 25);
            this.logRTBox.Name = "logRTBox";
            this.logRTBox.Size = new System.Drawing.Size(351, 339);
            this.logRTBox.TabIndex = 0;
            this.logRTBox.Text = "";
            // 
            // serverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 426);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.topPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "serverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Server";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.TextBox ipTBox;
        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.RichTextBox logRTBox;
        private System.Windows.Forms.Label logLabel;
    }
}

