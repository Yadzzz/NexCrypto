namespace NexCrypto
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.loadingLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.adminPanel = new System.Windows.Forms.Panel();
            this.adminUsersPanel = new System.Windows.Forms.Panel();
            this.adminEditUserButton = new System.Windows.Forms.Button();
            this.adminAddUserButton = new System.Windows.Forms.Button();
            this.adminUsersButton = new System.Windows.Forms.Button();
            this.adminUserButton = new System.Windows.Forms.Button();
            this.adminButton = new System.Windows.Forms.Button();
            this.cryptosPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.cryptosButton = new System.Windows.Forms.Button();
            this.cryptoButton = new System.Windows.Forms.Button();
            this.dashboardButton = new System.Windows.Forms.Button();
            this.childPanel = new System.Windows.Forms.Panel();
            this.topPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.adminPanel.SuspendLayout();
            this.adminUsersPanel.SuspendLayout();
            this.cryptosPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(33)))), ((int)(((byte)(71)))));
            this.topPanel.Controls.Add(this.loadingLabel);
            this.topPanel.Controls.Add(this.usernameLabel);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(828, 66);
            this.topPanel.TabIndex = 0;
            // 
            // loadingLabel
            // 
            this.loadingLabel.AutoSize = true;
            this.loadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.loadingLabel.Location = new System.Drawing.Point(382, 23);
            this.loadingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loadingLabel.Name = "loadingLabel";
            this.loadingLabel.Size = new System.Drawing.Size(0, 24);
            this.loadingLabel.TabIndex = 2;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.usernameLabel.Location = new System.Drawing.Point(729, 23);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(0, 18);
            this.usernameLabel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nex Crypto";
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(33)))), ((int)(((byte)(71)))));
            this.leftPanel.Controls.Add(this.adminPanel);
            this.leftPanel.Controls.Add(this.adminButton);
            this.leftPanel.Controls.Add(this.cryptosPanel);
            this.leftPanel.Controls.Add(this.cryptoButton);
            this.leftPanel.Controls.Add(this.dashboardButton);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 66);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(2);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(134, 522);
            this.leftPanel.TabIndex = 1;
            // 
            // adminPanel
            // 
            this.adminPanel.AutoSize = true;
            this.adminPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(33)))), ((int)(((byte)(60)))));
            this.adminPanel.Controls.Add(this.adminUsersPanel);
            this.adminPanel.Controls.Add(this.adminUserButton);
            this.adminPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.adminPanel.Location = new System.Drawing.Point(0, 170);
            this.adminPanel.Margin = new System.Windows.Forms.Padding(2);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(134, 136);
            this.adminPanel.TabIndex = 2;
            this.adminPanel.Visible = false;
            // 
            // adminUsersPanel
            // 
            this.adminUsersPanel.AutoSize = true;
            this.adminUsersPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(33)))), ((int)(((byte)(60)))));
            this.adminUsersPanel.Controls.Add(this.adminEditUserButton);
            this.adminUsersPanel.Controls.Add(this.adminAddUserButton);
            this.adminUsersPanel.Controls.Add(this.adminUsersButton);
            this.adminUsersPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.adminUsersPanel.Location = new System.Drawing.Point(0, 34);
            this.adminUsersPanel.Margin = new System.Windows.Forms.Padding(2);
            this.adminUsersPanel.Name = "adminUsersPanel";
            this.adminUsersPanel.Size = new System.Drawing.Size(134, 102);
            this.adminUsersPanel.TabIndex = 4;
            this.adminUsersPanel.Visible = false;
            // 
            // adminEditUserButton
            // 
            this.adminEditUserButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.adminEditUserButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(65)))));
            this.adminEditUserButton.FlatAppearance.BorderSize = 0;
            this.adminEditUserButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(77)))));
            this.adminEditUserButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(65)))));
            this.adminEditUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminEditUserButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.adminEditUserButton.Location = new System.Drawing.Point(0, 68);
            this.adminEditUserButton.Margin = new System.Windows.Forms.Padding(2);
            this.adminEditUserButton.Name = "adminEditUserButton";
            this.adminEditUserButton.Size = new System.Drawing.Size(134, 34);
            this.adminEditUserButton.TabIndex = 4;
            this.adminEditUserButton.Text = "Edit User";
            this.adminEditUserButton.UseVisualStyleBackColor = true;
            // 
            // adminAddUserButton
            // 
            this.adminAddUserButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.adminAddUserButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(65)))));
            this.adminAddUserButton.FlatAppearance.BorderSize = 0;
            this.adminAddUserButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(77)))));
            this.adminAddUserButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(65)))));
            this.adminAddUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminAddUserButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.adminAddUserButton.Location = new System.Drawing.Point(0, 34);
            this.adminAddUserButton.Margin = new System.Windows.Forms.Padding(2);
            this.adminAddUserButton.Name = "adminAddUserButton";
            this.adminAddUserButton.Size = new System.Drawing.Size(134, 34);
            this.adminAddUserButton.TabIndex = 3;
            this.adminAddUserButton.Text = "Add User";
            this.adminAddUserButton.UseVisualStyleBackColor = true;
            // 
            // adminUsersButton
            // 
            this.adminUsersButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.adminUsersButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(65)))));
            this.adminUsersButton.FlatAppearance.BorderSize = 0;
            this.adminUsersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(77)))));
            this.adminUsersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(65)))));
            this.adminUsersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminUsersButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.adminUsersButton.Location = new System.Drawing.Point(0, 0);
            this.adminUsersButton.Margin = new System.Windows.Forms.Padding(2);
            this.adminUsersButton.Name = "adminUsersButton";
            this.adminUsersButton.Size = new System.Drawing.Size(134, 34);
            this.adminUsersButton.TabIndex = 2;
            this.adminUsersButton.Text = "Users";
            this.adminUsersButton.UseVisualStyleBackColor = true;
            this.adminUsersButton.Click += new System.EventHandler(this.adminUsersButton_Click);
            // 
            // adminUserButton
            // 
            this.adminUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(33)))), ((int)(((byte)(71)))));
            this.adminUserButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.adminUserButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(65)))));
            this.adminUserButton.FlatAppearance.BorderSize = 0;
            this.adminUserButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(77)))));
            this.adminUserButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(65)))));
            this.adminUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminUserButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.adminUserButton.Location = new System.Drawing.Point(0, 0);
            this.adminUserButton.Margin = new System.Windows.Forms.Padding(2);
            this.adminUserButton.Name = "adminUserButton";
            this.adminUserButton.Size = new System.Drawing.Size(134, 34);
            this.adminUserButton.TabIndex = 2;
            this.adminUserButton.Text = "User";
            this.adminUserButton.UseVisualStyleBackColor = false;
            this.adminUserButton.Click += new System.EventHandler(this.adminUserButton_Click);
            // 
            // adminButton
            // 
            this.adminButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.adminButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(65)))));
            this.adminButton.FlatAppearance.BorderSize = 0;
            this.adminButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(77)))));
            this.adminButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(65)))));
            this.adminButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.adminButton.Location = new System.Drawing.Point(0, 136);
            this.adminButton.Margin = new System.Windows.Forms.Padding(2);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(134, 34);
            this.adminButton.TabIndex = 3;
            this.adminButton.Text = "Admin";
            this.adminButton.UseVisualStyleBackColor = true;
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click);
            // 
            // cryptosPanel
            // 
            this.cryptosPanel.AutoSize = true;
            this.cryptosPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(33)))), ((int)(((byte)(60)))));
            this.cryptosPanel.Controls.Add(this.button1);
            this.cryptosPanel.Controls.Add(this.cryptosButton);
            this.cryptosPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.cryptosPanel.Location = new System.Drawing.Point(0, 68);
            this.cryptosPanel.Margin = new System.Windows.Forms.Padding(2);
            this.cryptosPanel.Name = "cryptosPanel";
            this.cryptosPanel.Size = new System.Drawing.Size(134, 68);
            this.cryptosPanel.TabIndex = 2;
            this.cryptosPanel.Visible = false;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(65)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(77)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(65)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Location = new System.Drawing.Point(0, 34);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cryptosButton
            // 
            this.cryptosButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.cryptosButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(65)))));
            this.cryptosButton.FlatAppearance.BorderSize = 0;
            this.cryptosButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(77)))));
            this.cryptosButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(65)))));
            this.cryptosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cryptosButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cryptosButton.Location = new System.Drawing.Point(0, 0);
            this.cryptosButton.Margin = new System.Windows.Forms.Padding(2);
            this.cryptosButton.Name = "cryptosButton";
            this.cryptosButton.Size = new System.Drawing.Size(134, 34);
            this.cryptosButton.TabIndex = 1;
            this.cryptosButton.Text = "Cryptos";
            this.cryptosButton.UseVisualStyleBackColor = true;
            this.cryptosButton.Click += new System.EventHandler(this.cryptosButton_Click);
            // 
            // cryptoButton
            // 
            this.cryptoButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.cryptoButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(65)))));
            this.cryptoButton.FlatAppearance.BorderSize = 0;
            this.cryptoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(77)))));
            this.cryptoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(65)))));
            this.cryptoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cryptoButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cryptoButton.Location = new System.Drawing.Point(0, 34);
            this.cryptoButton.Margin = new System.Windows.Forms.Padding(2);
            this.cryptoButton.Name = "cryptoButton";
            this.cryptoButton.Size = new System.Drawing.Size(134, 34);
            this.cryptoButton.TabIndex = 1;
            this.cryptoButton.Text = "Crypto";
            this.cryptoButton.UseVisualStyleBackColor = true;
            this.cryptoButton.Click += new System.EventHandler(this.cryptoButton_Click);
            // 
            // dashboardButton
            // 
            this.dashboardButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashboardButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(65)))));
            this.dashboardButton.FlatAppearance.BorderSize = 0;
            this.dashboardButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(77)))));
            this.dashboardButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(65)))));
            this.dashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dashboardButton.Location = new System.Drawing.Point(0, 0);
            this.dashboardButton.Margin = new System.Windows.Forms.Padding(2);
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.Size = new System.Drawing.Size(134, 34);
            this.dashboardButton.TabIndex = 0;
            this.dashboardButton.Text = "Dashboard";
            this.dashboardButton.UseVisualStyleBackColor = true;
            this.dashboardButton.Click += new System.EventHandler(this.dashboardButton_Click);
            // 
            // childPanel
            // 
            this.childPanel.AutoSize = true;
            this.childPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childPanel.Location = new System.Drawing.Point(134, 66);
            this.childPanel.Margin = new System.Windows.Forms.Padding(2);
            this.childPanel.Name = "childPanel";
            this.childPanel.Size = new System.Drawing.Size(694, 522);
            this.childPanel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(51)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(828, 588);
            this.Controls.Add(this.childPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.adminPanel.ResumeLayout(false);
            this.adminPanel.PerformLayout();
            this.adminUsersPanel.ResumeLayout(false);
            this.cryptosPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dashboardButton;
        private System.Windows.Forms.Button cryptoButton;
        private System.Windows.Forms.Panel adminPanel;
        private System.Windows.Forms.Panel adminUsersPanel;
        private System.Windows.Forms.Button adminUserButton;
        private System.Windows.Forms.Button adminUsersButton;
        private System.Windows.Forms.Button adminEditUserButton;
        private System.Windows.Forms.Button adminAddUserButton;
        private System.Windows.Forms.Panel cryptosPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cryptosButton;
        private System.Windows.Forms.Button adminButton;
        private System.Windows.Forms.Panel childPanel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label loadingLabel;
    }
}

