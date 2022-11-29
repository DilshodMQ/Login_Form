namespace Megabite
{
    partial class RegistrForm
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
            this.passField = new System.Windows.Forms.TextBox();
            this.passField_image = new System.Windows.Forms.PictureBox();
            this.loginField = new System.Windows.Forms.TextBox();
            this.loginField_image = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.open_pass_button = new System.Windows.Forms.PictureBox();
            this.close_pass_button = new System.Windows.Forms.PictureBox();
            this.registrBtn = new System.Windows.Forms.Button();
            this.povtorPassField = new System.Windows.Forms.TextBox();
            this.povtorpassField_image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.passField_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginField_image)).BeginInit();
            this.panel2.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.open_pass_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_pass_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.povtorpassField_image)).BeginInit();
            this.SuspendLayout();
            // 
            // passField
            // 
            this.passField.Font = new System.Drawing.Font("Times New Roman", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passField.Location = new System.Drawing.Point(95, 174);
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(274, 45);
            this.passField.TabIndex = 2;
            this.passField.TextChanged += new System.EventHandler(this.passField_TextChanged);
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
            this.loginField.Location = new System.Drawing.Point(95, 104);
            this.loginField.Multiline = true;
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(274, 45);
            this.loginField.TabIndex = 2;
            this.loginField.TextChanged += new System.EventHandler(this.loginField_TextChanged);
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
            this.panel2.Size = new System.Drawing.Size(426, 100);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.mainPanel.Controls.Add(this.open_pass_button);
            this.mainPanel.Controls.Add(this.close_pass_button);
            this.mainPanel.Controls.Add(this.registrBtn);
            this.mainPanel.Controls.Add(this.povtorPassField);
            this.mainPanel.Controls.Add(this.povtorpassField_image);
            this.mainPanel.Controls.Add(this.passField);
            this.mainPanel.Controls.Add(this.passField_image);
            this.mainPanel.Controls.Add(this.loginField);
            this.mainPanel.Controls.Add(this.loginField_image);
            this.mainPanel.Controls.Add(this.panel2);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(426, 378);
            this.mainPanel.TabIndex = 1;
            // 
            // open_pass_button
            // 
            this.open_pass_button.Image = global::Megabite.Properties.Resources.open;
            this.open_pass_button.Location = new System.Drawing.Point(375, 186);
            this.open_pass_button.Name = "open_pass_button";
            this.open_pass_button.Size = new System.Drawing.Size(39, 33);
            this.open_pass_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.open_pass_button.TabIndex = 11;
            this.open_pass_button.TabStop = false;
            this.open_pass_button.Click += new System.EventHandler(this.open_pass_button_Click);
            // 
            // close_pass_button
            // 
            this.close_pass_button.Image = global::Megabite.Properties.Resources.close1;
            this.close_pass_button.Location = new System.Drawing.Point(375, 185);
            this.close_pass_button.Name = "close_pass_button";
            this.close_pass_button.Size = new System.Drawing.Size(39, 33);
            this.close_pass_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close_pass_button.TabIndex = 10;
            this.close_pass_button.TabStop = false;
            this.close_pass_button.Click += new System.EventHandler(this.close_pass_button_Click);
            // 
            // registrBtn
            // 
            this.registrBtn.Location = new System.Drawing.Point(135, 322);
            this.registrBtn.Name = "registrBtn";
            this.registrBtn.Size = new System.Drawing.Size(144, 23);
            this.registrBtn.TabIndex = 6;
            this.registrBtn.Text = "Создать аккаунт";
            this.registrBtn.UseVisualStyleBackColor = true;
            this.registrBtn.Click += new System.EventHandler(this.registrBtn_Click);
            // 
            // povtorPassField
            // 
            this.povtorPassField.Font = new System.Drawing.Font("Times New Roman", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.povtorPassField.Location = new System.Drawing.Point(95, 240);
            this.povtorPassField.Name = "povtorPassField";
            this.povtorPassField.Size = new System.Drawing.Size(274, 45);
            this.povtorPassField.TabIndex = 4;
            this.povtorPassField.TextChanged += new System.EventHandler(this.povtorPassField_TextChanged);
            this.povtorPassField.Enter += new System.EventHandler(this.povtorPassField_Enter);
            this.povtorPassField.Leave += new System.EventHandler(this.povtorPassField_Leave);
            // 
            // povtorpassField_image
            // 
            this.povtorpassField_image.Image = global::Megabite.Properties.Resources._lock;
            this.povtorpassField_image.Location = new System.Drawing.Point(12, 242);
            this.povtorpassField_image.Name = "povtorpassField_image";
            this.povtorpassField_image.Size = new System.Drawing.Size(64, 54);
            this.povtorpassField_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.povtorpassField_image.TabIndex = 5;
            this.povtorpassField_image.TabStop = false;
            // 
            // RegistrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 378);
            this.Controls.Add(this.mainPanel);
            this.Name = "RegistrForm";
            this.Text = "RegistrForm";
            ((System.ComponentModel.ISupportInitialize)(this.passField_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginField_image)).EndInit();
            this.panel2.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.open_pass_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_pass_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.povtorpassField_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox passField;
        private PictureBox passField_image;
        private TextBox loginField;
        private PictureBox loginField_image;
        private Panel panel2;
        private Label label1;
        private Panel mainPanel;
        private TextBox povtorPassField;
        private PictureBox povtorpassField_image;
        private Button registrBtn;
        private PictureBox close_pass_button;
        private PictureBox open_pass_button;
    }
}