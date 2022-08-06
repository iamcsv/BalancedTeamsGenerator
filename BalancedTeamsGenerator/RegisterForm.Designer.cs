namespace BalancedTeamsGenerator
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.loginUpPanel = new System.Windows.Forms.Panel();
            this.closeLabel = new System.Windows.Forms.Label();
            this.RegUpPanelLabel = new System.Windows.Forms.Label();
            this.loginMainPanel = new System.Windows.Forms.Panel();
            this.backLoginButton = new System.Windows.Forms.Button();
            this.RegPasswordTextBox2 = new System.Windows.Forms.TextBox();
            this.RegRegButton = new System.Windows.Forms.Button();
            this.RegPasswordTextBox1 = new System.Windows.Forms.TextBox();
            this.RegNameTextBox = new System.Windows.Forms.TextBox();
            this.loginPassBox = new System.Windows.Forms.PictureBox();
            this.loginNameBox = new System.Windows.Forms.PictureBox();
            this.loginUpPanel.SuspendLayout();
            this.loginMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginPassBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginNameBox)).BeginInit();
            this.SuspendLayout();
            // 
            // loginUpPanel
            // 
            this.loginUpPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(57)))), ((int)(((byte)(0)))));
            this.loginUpPanel.Controls.Add(this.closeLabel);
            this.loginUpPanel.Controls.Add(this.RegUpPanelLabel);
            this.loginUpPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.loginUpPanel.Location = new System.Drawing.Point(0, 0);
            this.loginUpPanel.Name = "loginUpPanel";
            this.loginUpPanel.Size = new System.Drawing.Size(700, 48);
            this.loginUpPanel.TabIndex = 3;
            // 
            // closeLabel
            // 
            this.closeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.closeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeLabel.Font = new System.Drawing.Font("Calibri", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.closeLabel.Location = new System.Drawing.Point(682, 0);
            this.closeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Size = new System.Drawing.Size(16, 23);
            this.closeLabel.TabIndex = 1;
            this.closeLabel.Text = "x";
            this.closeLabel.Click += new System.EventHandler(this.closeLabel_Click);
            this.closeLabel.MouseEnter += new System.EventHandler(this.closeLabel_MouseEnter_1);
            this.closeLabel.MouseLeave += new System.EventHandler(this.closeLabel_MouseLeave);
            // 
            // RegUpPanelLabel
            // 
            this.RegUpPanelLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.RegUpPanelLabel.Font = new System.Drawing.Font("Calibri", 23.7913F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RegUpPanelLabel.ForeColor = System.Drawing.Color.PaleGreen;
            this.RegUpPanelLabel.Location = new System.Drawing.Point(3, 0);
            this.RegUpPanelLabel.Name = "RegUpPanelLabel";
            this.RegUpPanelLabel.Size = new System.Drawing.Size(695, 48);
            this.RegUpPanelLabel.TabIndex = 0;
            this.RegUpPanelLabel.Text = "Registration";
            this.RegUpPanelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginMainPanel
            // 
            this.loginMainPanel.BackColor = System.Drawing.Color.DarkGreen;
            this.loginMainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginMainPanel.BackgroundImage")));
            this.loginMainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginMainPanel.Controls.Add(this.backLoginButton);
            this.loginMainPanel.Controls.Add(this.RegPasswordTextBox2);
            this.loginMainPanel.Controls.Add(this.RegRegButton);
            this.loginMainPanel.Controls.Add(this.RegPasswordTextBox1);
            this.loginMainPanel.Controls.Add(this.RegNameTextBox);
            this.loginMainPanel.Controls.Add(this.loginPassBox);
            this.loginMainPanel.Controls.Add(this.loginNameBox);
            this.loginMainPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loginMainPanel.Location = new System.Drawing.Point(0, 41);
            this.loginMainPanel.Name = "loginMainPanel";
            this.loginMainPanel.Size = new System.Drawing.Size(700, 362);
            this.loginMainPanel.TabIndex = 2;
            this.loginMainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loginMainPanel_MouseDown);
            this.loginMainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.loginMainPanel_MouseMove);
            // 
            // backLoginButton
            // 
            this.backLoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.backLoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backLoginButton.FlatAppearance.BorderSize = 0;
            this.backLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backLoginButton.Font = new System.Drawing.Font("Calibri", 13.77391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backLoginButton.ForeColor = System.Drawing.Color.PaleGreen;
            this.backLoginButton.Location = new System.Drawing.Point(90, 304);
            this.backLoginButton.Margin = new System.Windows.Forms.Padding(0);
            this.backLoginButton.Name = "backLoginButton";
            this.backLoginButton.Size = new System.Drawing.Size(230, 40);
            this.backLoginButton.TabIndex = 7;
            this.backLoginButton.Text = "Back to Log In";
            this.backLoginButton.UseVisualStyleBackColor = false;
            this.backLoginButton.Click += new System.EventHandler(this.backLoginButton_Click);
            this.backLoginButton.MouseEnter += new System.EventHandler(this.backLoginButton_MouseEnter);
            this.backLoginButton.MouseLeave += new System.EventHandler(this.backLoginButton_MouseLeave);
            // 
            // RegPasswordTextBox2
            // 
            this.RegPasswordTextBox2.Font = new System.Drawing.Font("Calibri", 16.27826F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RegPasswordTextBox2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.RegPasswordTextBox2.Location = new System.Drawing.Point(90, 181);
            this.RegPasswordTextBox2.MaxLength = 32;
            this.RegPasswordTextBox2.Name = "RegPasswordTextBox2";
            this.RegPasswordTextBox2.Size = new System.Drawing.Size(230, 39);
            this.RegPasswordTextBox2.TabIndex = 6;
            this.RegPasswordTextBox2.Text = "Password";
            this.RegPasswordTextBox2.UseSystemPasswordChar = true;
            this.RegPasswordTextBox2.Enter += new System.EventHandler(this.RegPasswordTextBox2_Enter);
            this.RegPasswordTextBox2.Leave += new System.EventHandler(this.RegPasswordTextBox2_Leave);
            // 
            // RegRegButton
            // 
            this.RegRegButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.RegRegButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegRegButton.FlatAppearance.BorderSize = 0;
            this.RegRegButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegRegButton.Font = new System.Drawing.Font("Calibri", 15.02609F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RegRegButton.ForeColor = System.Drawing.Color.PaleGreen;
            this.RegRegButton.Location = new System.Drawing.Point(90, 241);
            this.RegRegButton.Margin = new System.Windows.Forms.Padding(0);
            this.RegRegButton.Name = "RegRegButton";
            this.RegRegButton.Size = new System.Drawing.Size(230, 40);
            this.RegRegButton.TabIndex = 5;
            this.RegRegButton.Text = "Register me";
            this.RegRegButton.UseVisualStyleBackColor = false;
            this.RegRegButton.Click += new System.EventHandler(this.RegRegButton_Click);
            this.RegRegButton.MouseEnter += new System.EventHandler(this.RegRegButton_MouseEnter_1);
            this.RegRegButton.MouseLeave += new System.EventHandler(this.RegRegButton_MouseLeave_1);
            // 
            // RegPasswordTextBox1
            // 
            this.RegPasswordTextBox1.Font = new System.Drawing.Font("Calibri", 16.27826F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RegPasswordTextBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.RegPasswordTextBox1.Location = new System.Drawing.Point(90, 121);
            this.RegPasswordTextBox1.MaxLength = 32;
            this.RegPasswordTextBox1.Name = "RegPasswordTextBox1";
            this.RegPasswordTextBox1.Size = new System.Drawing.Size(230, 39);
            this.RegPasswordTextBox1.TabIndex = 3;
            this.RegPasswordTextBox1.Text = "Password";
            this.RegPasswordTextBox1.UseSystemPasswordChar = true;
            this.RegPasswordTextBox1.Enter += new System.EventHandler(this.RegPasswordTextBox1_Enter);
            this.RegPasswordTextBox1.Leave += new System.EventHandler(this.RegPasswordTextBox1_Leave);
            // 
            // RegNameTextBox
            // 
            this.RegNameTextBox.Font = new System.Drawing.Font("Calibri", 16.27826F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RegNameTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.RegNameTextBox.Location = new System.Drawing.Point(90, 60);
            this.RegNameTextBox.MaxLength = 32;
            this.RegNameTextBox.Name = "RegNameTextBox";
            this.RegNameTextBox.Size = new System.Drawing.Size(230, 39);
            this.RegNameTextBox.TabIndex = 2;
            this.RegNameTextBox.Text = "Enter Name";
            this.RegNameTextBox.Enter += new System.EventHandler(this.RegNameTextBox_Enter);
            this.RegNameTextBox.Leave += new System.EventHandler(this.RegNameTextBox_Leave);
            // 
            // loginPassBox
            // 
            this.loginPassBox.BackColor = System.Drawing.Color.Transparent;
            this.loginPassBox.Image = ((System.Drawing.Image)(resources.GetObject("loginPassBox.Image")));
            this.loginPassBox.Location = new System.Drawing.Point(2, 148);
            this.loginPassBox.Name = "loginPassBox";
            this.loginPassBox.Size = new System.Drawing.Size(78, 76);
            this.loginPassBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loginPassBox.TabIndex = 1;
            this.loginPassBox.TabStop = false;
            // 
            // loginNameBox
            // 
            this.loginNameBox.BackColor = System.Drawing.Color.Transparent;
            this.loginNameBox.Image = ((System.Drawing.Image)(resources.GetObject("loginNameBox.Image")));
            this.loginNameBox.Location = new System.Drawing.Point(12, 60);
            this.loginNameBox.Name = "loginNameBox";
            this.loginNameBox.Size = new System.Drawing.Size(66, 67);
            this.loginNameBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loginNameBox.TabIndex = 0;
            this.loginNameBox.TabStop = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 403);
            this.Controls.Add(this.loginUpPanel);
            this.Controls.Add(this.loginMainPanel);
            this.Font = new System.Drawing.Font("Calibri", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.loginUpPanel.ResumeLayout(false);
            this.loginMainPanel.ResumeLayout(false);
            this.loginMainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginPassBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginNameBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel loginUpPanel;
        private Label closeLabel;
        private Label RegUpPanelLabel;
        private Panel loginMainPanel;
        private Button RegRegButton;
        private TextBox RegPasswordTextBox1;
        private TextBox RegNameTextBox;
        private PictureBox loginPassBox;
        private PictureBox loginNameBox;
        private TextBox RegPasswordTextBox2;
        private Button backLoginButton;
    }
}