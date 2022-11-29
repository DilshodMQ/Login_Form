namespace Megabite
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.close_pass_button = new System.Windows.Forms.PictureBox();
            this.open_pass_button = new System.Windows.Forms.PictureBox();
            this.registr_button = new System.Windows.Forms.Button();
            this.rememberCheckBox = new System.Windows.Forms.CheckBox();
            this.login_button = new System.Windows.Forms.Button();
            this.passField = new System.Windows.Forms.TextBox();
            this.passField_image = new System.Windows.Forms.PictureBox();
            this.loginField = new System.Windows.Forms.TextBox();
            this.loginField_image = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_pass_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.open_pass_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passField_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginField_image)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.mainPanel.Controls.Add(this.close_pass_button);
            this.mainPanel.Controls.Add(this.open_pass_button);
            this.mainPanel.Controls.Add(this.registr_button);
            this.mainPanel.Controls.Add(this.rememberCheckBox);
            this.mainPanel.Controls.Add(this.login_button);
            this.mainPanel.Controls.Add(this.passField);
            this.mainPanel.Controls.Add(this.passField_image);
            this.mainPanel.Controls.Add(this.loginField);
            this.mainPanel.Controls.Add(this.loginField_image);
            this.mainPanel.Controls.Add(this.panel2);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(407, 385);
            this.mainPanel.TabIndex = 0;
            // 
            // close_pass_button
            // 
            this.close_pass_button.Image = global::Megabite.Properties.Resources.close1;
            this.close_pass_button.Location = new System.Drawing.Point(350, 185);
            this.close_pass_button.Name = "close_pass_button";
            this.close_pass_button.Size = new System.Drawing.Size(39, 33);
            this.close_pass_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close_pass_button.TabIndex = 9;
            this.close_pass_button.TabStop = false;
            this.close_pass_button.Click += new System.EventHandler(this.close_pass_button_Click);
            // 
            // open_pass_button
            // 
            this.open_pass_button.Image = global::Megabite.Properties.Resources.open;
            this.open_pass_button.Location = new System.Drawing.Point(350, 185);
            this.open_pass_button.Name = "open_pass_button";
            this.open_pass_button.Size = new System.Drawing.Size(39, 33);
            this.open_pass_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.open_pass_button.TabIndex = 8;
            this.open_pass_button.TabStop = false;
            this.open_pass_button.Click += new System.EventHandler(this.open_pass_button_Click);
            // 
            // registr_button
            // 
            this.registr_button.Location = new System.Drawing.Point(132, 347);
            this.registr_button.Name = "registr_button";
            this.registr_button.Size = new System.Drawing.Size(151, 23);
            this.registr_button.TabIndex = 7;
            this.registr_button.Text = "Зарегистрироваться";
            this.registr_button.UseVisualStyleBackColor = true;
            this.registr_button.Click += new System.EventHandler(this.registr_button_Click);
            // 
            // rememberCheckBox
            // 
            this.rememberCheckBox.AutoSize = true;
            this.rememberCheckBox.Location = new System.Drawing.Point(95, 246);
            this.rememberCheckBox.Name = "rememberCheckBox";
            this.rememberCheckBox.Size = new System.Drawing.Size(121, 19);
            this.rememberCheckBox.TabIndex = 6;
            this.rememberCheckBox.Text = "Запомнить меня ";
            this.rememberCheckBox.UseVisualStyleBackColor = true;
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(153)))));
            this.login_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_button.FlatAppearance.BorderSize = 0;
            this.login_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(0)))));
            this.login_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_button.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login_button.ForeColor = System.Drawing.Color.White;
            this.login_button.Location = new System.Drawing.Point(95, 271);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(225, 53);
            this.login_button.TabIndex = 5;
            this.login_button.Text = "Войти";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // passField
            // 
            this.passField.Font = new System.Drawing.Font("Times New Roman", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passField.Location = new System.Drawing.Point(95, 173);
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(252, 45);
            this.passField.TabIndex = 2;
            this.passField.Enter += new System.EventHandler(this.passField_Enter);
            this.passField.Leave += new System.EventHandler(this.passField_Leave);
            // 
            // passField_image
            // 
            this.passField_image.Image = global::Megabite.Properties.Resources._lock;
            this.passField_image.Location = new System.Drawing.Point(12, 173);
            this.passField_image.Name = "passField_image";
            this.passField_image.Size = new System.Drawing.Size(64, 54);
            this.passField_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.passField_image.TabIndex = 3;
            this.passField_image.TabStop = false;
            // 
            // loginField
            // 
            this.loginField.Font = new System.Drawing.Font("Times New Roman", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginField.Location = new System.Drawing.Point(95, 106);
            this.loginField.Multiline = true;
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(252, 45);
            this.loginField.TabIndex = 2;
            this.loginField.Enter += new System.EventHandler(this.loginField_Enter);
            this.loginField.Leave += new System.EventHandler(this.loginField_Leave);
            // 
            // loginField_image
            // 
            this.loginField_image.Image = global::Megabite.Properties.Resources.user;
            this.loginField_image.Location = new System.Drawing.Point(12, 106);
            this.loginField_image.Name = "loginField_image";
            this.loginField_image.Size = new System.Drawing.Size(64, 49);
            this.loginField_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loginField_image.TabIndex = 1;
            this.loginField_image.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(196)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(407, 100);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 385);
            this.Controls.Add(this.mainPanel);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_pass_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.open_pass_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passField_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginField_image)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel mainPanel;
        private Panel panel2;
        private Label label1;
        private Button login_button;
        private TextBox passField;
        private PictureBox passField_image;
        private TextBox loginField;
        private PictureBox loginField_image;
        private CheckBox rememberCheckBox;
        private Button registr_button;
        private PictureBox close_pass_button;
        private PictureBox open_pass_button;

        public string passText
        {
            get { return passField.Text; }
            set { passField.Text = value; }
        }

        public string loginText
        {
            get { return loginField.Text; }
            set { loginField.Text = value; }
        }
    }
}