namespace library_management_system
{
    partial class Form4
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
            this.View = new System.Windows.Forms.TabPage();
            this.dataGridView_edit = new System.Windows.Forms.DataGridView();
            this.manage = new System.Windows.Forms.TabPage();
            this.add = new System.Windows.Forms.TabPage();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.txt_mobile = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.txt_gender = new System.Windows.Forms.TextBox();
            this.pnl_login = new System.Windows.Forms.Panel();
            this.txt_role = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_signup = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView_view = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox_gender = new System.Windows.Forms.ComboBox();
            this.text_address = new System.Windows.Forms.TextBox();
            this.text_mobile = new System.Windows.Forms.TextBox();
            this.text_email = new System.Windows.Forms.TextBox();
            this.text_lname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.text_fname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_filter = new System.Windows.Forms.TextBox();
            this.View.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_edit)).BeginInit();
            this.manage.SuspendLayout();
            this.add.SuspendLayout();
            this.pnl_login.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_view)).BeginInit();
            this.SuspendLayout();
            // 
            // View
            // 
            this.View.Controls.Add(this.label16);
            this.View.Controls.Add(this.label15);
            this.View.Controls.Add(this.label14);
            this.View.Controls.Add(this.label13);
            this.View.Controls.Add(this.label12);
            this.View.Controls.Add(this.label11);
            this.View.Controls.Add(this.button1);
            this.View.Controls.Add(this.comboBox_gender);
            this.View.Controls.Add(this.text_address);
            this.View.Controls.Add(this.text_mobile);
            this.View.Controls.Add(this.text_email);
            this.View.Controls.Add(this.text_lname);
            this.View.Controls.Add(this.label10);
            this.View.Controls.Add(this.text_fname);
            this.View.Controls.Add(this.label9);
            this.View.Controls.Add(this.txt_filter);
            this.View.Controls.Add(this.dataGridView_edit);
            this.View.Location = new System.Drawing.Point(4, 22);
            this.View.Name = "View";
            this.View.Padding = new System.Windows.Forms.Padding(3);
            this.View.Size = new System.Drawing.Size(709, 322);
            this.View.TabIndex = 2;
            this.View.Text = "Edit Members";
            this.View.UseVisualStyleBackColor = true;
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // dataGridView_edit
            // 
            this.dataGridView_edit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_edit.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_edit.Name = "dataGridView_edit";
            this.dataGridView_edit.Size = new System.Drawing.Size(700, 148);
            this.dataGridView_edit.TabIndex = 0;
            this.dataGridView_edit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView_edit.SelectionChanged += new System.EventHandler(this.dataGridView_edit_SelectionChanged);
            // 
            // manage
            // 
            this.manage.Controls.Add(this.dataGridView_view);
            this.manage.Location = new System.Drawing.Point(4, 22);
            this.manage.Name = "manage";
            this.manage.Padding = new System.Windows.Forms.Padding(3);
            this.manage.Size = new System.Drawing.Size(709, 322);
            this.manage.TabIndex = 1;
            this.manage.Text = "View Members";
            this.manage.UseVisualStyleBackColor = true;
            this.manage.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // add
            // 
            this.add.Controls.Add(this.btn_register);
            this.add.Controls.Add(this.pnl_login);
            this.add.Controls.Add(this.txt_gender);
            this.add.Controls.Add(this.txt_address);
            this.add.Controls.Add(this.txt_mobile);
            this.add.Controls.Add(this.txt_lname);
            this.add.Controls.Add(this.txt_email);
            this.add.Controls.Add(this.txt_fname);
            this.add.Controls.Add(this.LastName);
            this.add.Controls.Add(this.Email);
            this.add.Controls.Add(this.label5);
            this.add.Controls.Add(this.label4);
            this.add.Controls.Add(this.label3);
            this.add.Controls.Add(this.label2);
            this.add.Controls.Add(this.label1);
            this.add.Location = new System.Drawing.Point(4, 22);
            this.add.Name = "add";
            this.add.Padding = new System.Windows.Forms.Padding(3);
            this.add.Size = new System.Drawing.Size(709, 322);
            this.add.TabIndex = 0;
            this.add.Text = "Add Memeber";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // txt_fname
            // 
            this.txt_fname.Location = new System.Drawing.Point(72, 36);
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(117, 20);
            this.txt_fname.TabIndex = 3;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(72, 106);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(117, 20);
            this.txt_email.TabIndex = 4;
            // 
            // txt_lname
            // 
            this.txt_lname.Location = new System.Drawing.Point(72, 71);
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(117, 20);
            this.txt_lname.TabIndex = 5;
            // 
            // txt_mobile
            // 
            this.txt_mobile.Location = new System.Drawing.Point(72, 142);
            this.txt_mobile.Name = "txt_mobile";
            this.txt_mobile.Size = new System.Drawing.Size(117, 20);
            this.txt_mobile.TabIndex = 6;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(72, 182);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(117, 20);
            this.txt_address.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Register User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "FirstName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Mobile";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(8, 109);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(37, 13);
            this.Email.TabIndex = 13;
            this.Email.Text = "Email";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(8, 71);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(63, 13);
            this.LastName.TabIndex = 14;
            this.LastName.Text = "LastName";
            // 
            // txt_gender
            // 
            this.txt_gender.Location = new System.Drawing.Point(72, 225);
            this.txt_gender.Name = "txt_gender";
            this.txt_gender.Size = new System.Drawing.Size(117, 20);
            this.txt_gender.TabIndex = 15;
            // 
            // pnl_login
            // 
            this.pnl_login.Controls.Add(this.btn_signup);
            this.pnl_login.Controls.Add(this.label8);
            this.pnl_login.Controls.Add(this.label7);
            this.pnl_login.Controls.Add(this.label6);
            this.pnl_login.Controls.Add(this.txt_username);
            this.pnl_login.Controls.Add(this.txt_password);
            this.pnl_login.Controls.Add(this.txt_role);
            this.pnl_login.Location = new System.Drawing.Point(195, 36);
            this.pnl_login.Name = "pnl_login";
            this.pnl_login.Size = new System.Drawing.Size(283, 209);
            this.pnl_login.TabIndex = 16;
            // 
            // txt_role
            // 
            this.txt_role.Location = new System.Drawing.Point(86, 80);
            this.txt_role.Name = "txt_role";
            this.txt_role.Size = new System.Drawing.Size(174, 20);
            this.txt_role.TabIndex = 1;
            this.txt_role.Text = "User";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(86, 54);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(174, 20);
            this.txt_password.TabIndex = 2;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(86, 28);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(174, 20);
            this.txt_username.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "UserName";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Role";
            // 
            // btn_signup
            // 
            this.btn_signup.Location = new System.Drawing.Point(86, 139);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(75, 23);
            this.btn_signup.TabIndex = 20;
            this.btn_signup.Text = "Sign Up";
            this.btn_signup.UseVisualStyleBackColor = true;
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(164, 271);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(100, 23);
            this.btn_register.TabIndex = 17;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.add);
            this.tabControl1.Controls.Add(this.manage);
            this.tabControl1.Controls.Add(this.View);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(717, 348);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(709, 322);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Remove Members";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dataGridView_view
            // 
            this.dataGridView_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_view.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_view.Name = "dataGridView_view";
            this.dataGridView_view.Size = new System.Drawing.Size(724, 177);
            this.dataGridView_view.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(323, 238);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "Gender";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(588, 199);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Address";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(457, 199);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Mobile";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(323, 199);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Email";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(179, 199);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "LastName";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(43, 199);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "FirstName";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(286, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_gender
            // 
            this.comboBox_gender.FormattingEnabled = true;
            this.comboBox_gender.Items.AddRange(new object[] {
            "male",
            "female"});
            this.comboBox_gender.Location = new System.Drawing.Point(286, 255);
            this.comboBox_gender.Name = "comboBox_gender";
            this.comboBox_gender.Size = new System.Drawing.Size(118, 21);
            this.comboBox_gender.TabIndex = 25;
            // 
            // text_address
            // 
            this.text_address.Location = new System.Drawing.Point(554, 215);
            this.text_address.Name = "text_address";
            this.text_address.Size = new System.Drawing.Size(149, 20);
            this.text_address.TabIndex = 24;
            // 
            // text_mobile
            // 
            this.text_mobile.Location = new System.Drawing.Point(420, 215);
            this.text_mobile.Name = "text_mobile";
            this.text_mobile.Size = new System.Drawing.Size(118, 20);
            this.text_mobile.TabIndex = 23;
            // 
            // text_email
            // 
            this.text_email.Location = new System.Drawing.Point(275, 215);
            this.text_email.Name = "text_email";
            this.text_email.Size = new System.Drawing.Size(139, 20);
            this.text_email.TabIndex = 22;
            // 
            // text_lname
            // 
            this.text_lname.Location = new System.Drawing.Point(151, 215);
            this.text_lname.Name = "text_lname";
            this.text_lname.Size = new System.Drawing.Size(118, 20);
            this.text_lname.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(283, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "select a row to edit";
            // 
            // text_fname
            // 
            this.text_fname.Location = new System.Drawing.Point(19, 215);
            this.text_fname.Name = "text_fname";
            this.text_fname.Size = new System.Drawing.Size(118, 20);
            this.text_fname.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Filter Username";
            // 
            // txt_filter
            // 
            this.txt_filter.Location = new System.Drawing.Point(112, 162);
            this.txt_filter.Name = "txt_filter";
            this.txt_filter.Size = new System.Drawing.Size(157, 20);
            this.txt_filter.TabIndex = 17;
            this.txt_filter.TextChanged += new System.EventHandler(this.txt_filter_TextChanged);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 360);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.View.ResumeLayout(false);
            this.View.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_edit)).EndInit();
            this.manage.ResumeLayout(false);
            this.add.ResumeLayout(false);
            this.add.PerformLayout();
            this.pnl_login.ResumeLayout(false);
            this.pnl_login.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage View;
        private System.Windows.Forms.DataGridView dataGridView_edit;
        private System.Windows.Forms.TabPage manage;
        private System.Windows.Forms.TabPage add;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Panel pnl_login;
        private System.Windows.Forms.Button btn_signup;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_role;
        private System.Windows.Forms.TextBox txt_gender;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_mobile;
        private System.Windows.Forms.TextBox txt_lname;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_fname;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView_view;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox_gender;
        private System.Windows.Forms.TextBox text_address;
        private System.Windows.Forms.TextBox text_mobile;
        private System.Windows.Forms.TextBox text_email;
        private System.Windows.Forms.TextBox text_lname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox text_fname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_filter;
    }
}