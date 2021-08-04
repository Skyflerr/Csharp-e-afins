namespace Login_Interface
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label MainLoginLogo;
            this.NameBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.Name = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.SignInButton = new System.Windows.Forms.Button();
            MainLoginLogo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MainLoginLogo
            // 
            MainLoginLogo.AutoSize = true;
            MainLoginLogo.Font = new System.Drawing.Font("Miriam CLM", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            MainLoginLogo.Location = new System.Drawing.Point(189, 23);
            MainLoginLogo.Name = "MainLoginLogo";
            MainLoginLogo.Size = new System.Drawing.Size(82, 32);
            MainLoginLogo.TabIndex = 3;
            MainLoginLogo.Text = "Login";
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBox.Location = new System.Drawing.Point(25, 118);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(393, 26);
            this.NameBox.TabIndex = 0;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordBox.Location = new System.Drawing.Point(26, 192);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(392, 26);
            this.PasswordBox.TabIndex = 1;
            this.PasswordBox.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged);
            // 
            // SignUpButton
            // 
            this.SignUpButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SignUpButton.Location = new System.Drawing.Point(60, 238);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(117, 46);
            this.SignUpButton.TabIndex = 2;
            this.SignUpButton.Text = "Sign Up";
            this.SignUpButton.UseVisualStyleBackColor = true;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.Location = new System.Drawing.Point(21, 82);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(61, 24);
            this.Name.TabIndex = 4;
            this.Name.Text = "Name";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(21, 164);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(92, 24);
            this.Password.TabIndex = 5;
            this.Password.Text = "Password";
            // 
            // SignInButton
            // 
            this.SignInButton.Location = new System.Drawing.Point(249, 238);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(132, 46);
            this.SignInButton.TabIndex = 6;
            this.SignInButton.Text = "Sign In";
            this.SignInButton.UseVisualStyleBackColor = true;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 324);
            this.Controls.Add(this.SignInButton);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Name);
            this.Controls.Add(MainLoginLogo);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.NameBox);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button SignInButton;
    }
}

