namespace library_management_system.UserControls
{
    partial class settings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_confirmpassword = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_newp = new System.Windows.Forms.TextBox();
            this.txt_oldp = new System.Windows.Forms.TextBox();
            this.btn_changepassword = new System.Windows.Forms.Button();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.btn_changename = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_confirmpassword
            // 
            this.txt_confirmpassword.Location = new System.Drawing.Point(126, 240);
            this.txt_confirmpassword.Name = "txt_confirmpassword";
            this.txt_confirmpassword.Size = new System.Drawing.Size(136, 20);
            this.txt_confirmpassword.TabIndex = 40;
            this.txt_confirmpassword.TextChanged += new System.EventHandler(this.txt_confirmpassword_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(171)))), ((int)(((byte)(200)))));
            this.label11.Location = new System.Drawing.Point(13, 243);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "Confirm Password";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(171)))), ((int)(((byte)(200)))));
            this.label12.Location = new System.Drawing.Point(13, 195);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 13);
            this.label12.TabIndex = 38;
            this.label12.Text = "New Password";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(171)))), ((int)(((byte)(200)))));
            this.label13.Location = new System.Drawing.Point(13, 152);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 13);
            this.label13.TabIndex = 37;
            this.label13.Text = "Old password";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(171)))), ((int)(((byte)(200)))));
            this.label14.Location = new System.Drawing.Point(13, 110);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 13);
            this.label14.TabIndex = 36;
            this.label14.Text = "LastName";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(171)))), ((int)(((byte)(200)))));
            this.label15.Location = new System.Drawing.Point(13, 67);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 13);
            this.label15.TabIndex = 35;
            this.label15.Text = "FirstName";
            // 
            // txt_newp
            // 
            this.txt_newp.Location = new System.Drawing.Point(126, 192);
            this.txt_newp.Name = "txt_newp";
            this.txt_newp.Size = new System.Drawing.Size(136, 20);
            this.txt_newp.TabIndex = 34;
            this.txt_newp.TextChanged += new System.EventHandler(this.txt_newp_TextChanged);
            // 
            // txt_oldp
            // 
            this.txt_oldp.Location = new System.Drawing.Point(126, 149);
            this.txt_oldp.Name = "txt_oldp";
            this.txt_oldp.Size = new System.Drawing.Size(136, 20);
            this.txt_oldp.TabIndex = 33;
            this.txt_oldp.TextChanged += new System.EventHandler(this.txt_oldp_TextChanged);
            // 
            // btn_changepassword
            // 
            this.btn_changepassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_changepassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_changepassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(171)))), ((int)(((byte)(200)))));
            this.btn_changepassword.Location = new System.Drawing.Point(281, 189);
            this.btn_changepassword.Name = "btn_changepassword";
            this.btn_changepassword.Size = new System.Drawing.Size(120, 31);
            this.btn_changepassword.TabIndex = 32;
            this.btn_changepassword.Text = "Change Password";
            this.btn_changepassword.UseVisualStyleBackColor = false;
            this.btn_changepassword.Click += new System.EventHandler(this.btn_changepassword_Click);
            // 
            // txt_lname
            // 
            this.txt_lname.Location = new System.Drawing.Point(126, 107);
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(136, 20);
            this.txt_lname.TabIndex = 31;
            // 
            // txt_fname
            // 
            this.txt_fname.Location = new System.Drawing.Point(126, 64);
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(136, 20);
            this.txt_fname.TabIndex = 30;
            // 
            // btn_changename
            // 
            this.btn_changename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_changename.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_changename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(171)))), ((int)(((byte)(200)))));
            this.btn_changename.Location = new System.Drawing.Point(281, 86);
            this.btn_changename.Name = "btn_changename";
            this.btn_changename.Size = new System.Drawing.Size(120, 28);
            this.btn_changename.TabIndex = 29;
            this.btn_changename.Text = "Change Name";
            this.btn_changename.UseVisualStyleBackColor = false;
            this.btn_changename.Click += new System.EventHandler(this.button6_Click);
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.txt_confirmpassword);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txt_newp);
            this.Controls.Add(this.txt_oldp);
            this.Controls.Add(this.btn_changepassword);
            this.Controls.Add(this.txt_lname);
            this.Controls.Add(this.txt_fname);
            this.Controls.Add(this.btn_changename);
            this.Name = "settings";
            this.Size = new System.Drawing.Size(421, 291);
            this.Load += new System.EventHandler(this.settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_confirmpassword;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_newp;
        private System.Windows.Forms.TextBox txt_oldp;
        private System.Windows.Forms.Button btn_changepassword;
        private System.Windows.Forms.TextBox txt_lname;
        private System.Windows.Forms.TextBox txt_fname;
        private System.Windows.Forms.Button btn_changename;
    }
}
