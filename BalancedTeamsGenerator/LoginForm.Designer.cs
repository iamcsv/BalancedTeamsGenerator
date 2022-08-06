namespace BalancedTeamsGenerator
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.loginMainPanel = new System.Windows.Forms.Panel();
            this.loginRegButton = new System.Windows.Forms.Button();
            this.loginEnterButton = new System.Windows.Forms.Button();
            this.LoginPasswordTextBox = new System.Windows.Forms.TextBox();
            this.LoginNameTextBox = new System.Windows.Forms.TextBox();
            this.loginPassBox = new System.Windows.Forms.PictureBox();
            this.loginNameBox = new System.Windows.Forms.PictureBox();
            this.loginUpPanel = new System.Windows.Forms.Panel();
            this.closeLabel = new System.Windows.Forms.Label();
            this.loginUpPanelLabel = new System.Windows.Forms.Label();
            this.loginMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginPassBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginNameBox)).BeginInit();
            this.loginUpPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginMainPanel
            // 
            this.loginMainPanel.BackColor = System.Drawing.Color.DarkGreen;
            this.loginMainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginMainPanel.BackgroundImage")));
            this.loginMainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginMainPanel.Controls.Add(this.loginRegButton);
            this.loginMainPanel.Controls.Add(this.loginEnterButton);
            this.loginMainPanel.Controls.Add(this.LoginPasswordTextBox);
            this.loginMainPanel.Controls.Add(this.LoginNameTextBox);
            this.loginMainPanel.Controls.Add(this.loginPassBox);
            this.loginMainPanel.Controls.Add(this.loginNameBox);
            this.loginMainPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loginMainPanel.Location = new System.Drawing.Point(0, 50);
            this.loginMainPanel.Name = "loginMainPanel";
            this.loginMainPanel.Size = new System.Drawing.Size(750, 375);
            this.loginMainPanel.TabIndex = 0;
            this.loginMainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loginMainPanel_MouseDown);
            this.loginMainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.loginMainPanel_MouseMove);
            // 
            // loginRegButton
            // 
            this.loginRegButton.BackColor = System.Drawing.Color.DarkGreen;
            this.loginRegButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginRegButton.FlatAppearance.BorderSize = 0;
            this.loginRegButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginRegButton.Font = new System.Drawing.Font("Calibri", 16.27826F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginRegButton.ForeColor = System.Drawing.Color.PaleGreen;
            this.loginRegButton.Location = new System.Drawing.Point(255, 277);
            this.loginRegButton.Margin = new System.Windows.Forms.Padding(0);
            this.loginRegButton.Name = "loginRegButton";
            this.loginRegButton.Size = new System.Drawing.Size(110, 39);
            this.loginRegButton.TabIndex = 5;
            this.loginRegButton.Text = "Sign Up";
            this.loginRegButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.loginRegButton.UseVisualStyleBackColor = false;
            this.loginRegButton.Click += new System.EventHandler(this.loginRegButton_Click);
            this.loginRegButton.MouseEnter += new System.EventHandler(this.loginRegButton_MouseEnter_1);
            this.loginRegButton.MouseLeave += new System.EventHandler(this.loginRegButton_MouseLeave_1);
            // 
            // loginEnterButton
            // 
            this.loginEnterButton.BackColor = System.Drawing.Color.DarkGreen;
            this.loginEnterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginEnterButton.FlatAppearance.BorderSize = 0;
            this.loginEnterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginEnterButton.Font = new System.Drawing.Font("Calibri", 16.27826F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginEnterButton.ForeColor = System.Drawing.Color.PaleGreen;
            this.loginEnterButton.Location = new System.Drawing.Point(103, 277);
            this.loginEnterButton.Margin = new System.Windows.Forms.Padding(0);
            this.loginEnterButton.Name = "loginEnterButton";
            this.loginEnterButton.Size = new System.Drawing.Size(110, 39);
            this.loginEnterButton.TabIndex = 4;
            this.loginEnterButton.Text = "Log In";
            this.loginEnterButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.loginEnterButton.UseVisualStyleBackColor = false;
            this.loginEnterButton.Click += new System.EventHandler(this.loginEnterButton_Click);
            this.loginEnterButton.MouseEnter += new System.EventHandler(this.loginEnterButton_MouseEnter);
            this.loginEnterButton.MouseLeave += new System.EventHandler(this.loginEnterButton_MouseLeave);
            // 
            // LoginPasswordTextBox
            // 
            this.LoginPasswordTextBox.Font = new System.Drawing.Font("Calibri", 16.27826F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginPasswordTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.LoginPasswordTextBox.Location = new System.Drawing.Point(103, 179);
            this.LoginPasswordTextBox.MaxLength = 32;
            this.LoginPasswordTextBox.Name = "LoginPasswordTextBox";
            this.LoginPasswordTextBox.Size = new System.Drawing.Size(262, 39);
            this.LoginPasswordTextBox.TabIndex = 3;
            this.LoginPasswordTextBox.Text = "Password";
            this.LoginPasswordTextBox.UseSystemPasswordChar = true;
            this.LoginPasswordTextBox.Enter += new System.EventHandler(this.LoginPasswordTextBox_Enter);
            this.LoginPasswordTextBox.Leave += new System.EventHandler(this.LoginPasswordTextBox_Leave);
            // 
            // LoginNameTextBox
            // 
            this.LoginNameTextBox.Font = new System.Drawing.Font("Calibri", 16.27826F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginNameTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.LoginNameTextBox.Location = new System.Drawing.Point(103, 87);
            this.LoginNameTextBox.MaxLength = 32;
            this.LoginNameTextBox.Name = "LoginNameTextBox";
            this.LoginNameTextBox.Size = new System.Drawing.Size(262, 39);
            this.LoginNameTextBox.TabIndex = 2;
            this.LoginNameTextBox.Text = "Login Name";
            this.LoginNameTextBox.Enter += new System.EventHandler(this.LoginNameTextBox_Enter);
            this.LoginNameTextBox.Leave += new System.EventHandler(this.LoginNameTextBox_Leave);
            // 
            // loginPassBox
            // 
            this.loginPassBox.BackColor = System.Drawing.Color.Transparent;
            this.loginPassBox.Image = ((System.Drawing.Image)(resources.GetObject("loginPassBox.Image")));
            this.loginPassBox.Location = new System.Drawing.Point(12, 143);
            this.loginPassBox.Name = "loginPassBox";
            this.loginPassBox.Size = new System.Drawing.Size(75, 75);
            this.loginPassBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loginPassBox.TabIndex = 1;
            this.loginPassBox.TabStop = false;
            // 
            // loginNameBox
            // 
            this.loginNameBox.BackColor = System.Drawing.Color.Transparent;
            this.loginNameBox.Image = ((System.Drawing.Image)(resources.GetObject("loginNameBox.Image")));
            this.loginNameBox.Location = new System.Drawing.Point(12, 51);
            this.loginNameBox.Name = "loginNameBox";
            this.loginNameBox.Size = new System.Drawing.Size(75, 75);
            this.loginNameBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loginNameBox.TabIndex = 0;
            this.loginNameBox.TabStop = false;
            // 
            // loginUpPanel
            // 
            this.loginUpPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(57)))), ((int)(((byte)(0)))));
            this.loginUpPanel.Controls.Add(this.closeLabel);
            this.loginUpPanel.Controls.Add(this.loginUpPanelLabel);
            this.loginUpPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.loginUpPanel.Location = new System.Drawing.Point(0, 0);
            this.loginUpPanel.Name = "loginUpPanel";
            this.loginUpPanel.Size = new System.Drawing.Size(750, 54);
            this.loginUpPanel.TabIndex = 1;
            // 
            // closeLabel
            // 
            this.closeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeLabel.Font = new System.Drawing.Font("Calibri", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.closeLabel.Location = new System.Drawing.Point(734, -5);
            this.closeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Size = new System.Drawing.Size(18, 26);
            this.closeLabel.TabIndex = 1;
            this.closeLabel.Text = "x";
            this.closeLabel.Click += new System.EventHandler(this.closeLabel_Click);
            this.closeLabel.MouseEnter += new System.EventHandler(this.closeLabel_MouseEnter);
            this.closeLabel.MouseLeave += new System.EventHandler(this.closeLabel_MouseLeave_1);
            // 
            // loginUpPanelLabel
            // 
            this.loginUpPanelLabel.Font = new System.Drawing.Font("Calibri", 23.7913F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginUpPanelLabel.ForeColor = System.Drawing.Color.PaleGreen;
            this.loginUpPanelLabel.Location = new System.Drawing.Point(3, 0);
            this.loginUpPanelLabel.Name = "loginUpPanelLabel";
            this.loginUpPanelLabel.Size = new System.Drawing.Size(728, 54);
            this.loginUpPanelLabel.TabIndex = 0;
            this.loginUpPanelLabel.Text = "Balanced Teams Generator";
            this.loginUpPanelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 425);
            this.ControlBox = false;
            this.Controls.Add(this.loginUpPanel);
            this.Controls.Add(this.loginMainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.loginMainPanel.ResumeLayout(false);
            this.loginMainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginPassBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginNameBox)).EndInit();
            this.loginUpPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel loginMainPanel;
        private Panel loginUpPanel;
        private Label loginUpPanelLabel;
        private Label closeLabel;
        private PictureBox loginPassBox;
        private PictureBox loginNameBox;
        private Button loginEnterButton;
        private TextBox LoginPasswordTextBox;
        private TextBox LoginNameTextBox;
        private Button loginRegButton;
    }
}